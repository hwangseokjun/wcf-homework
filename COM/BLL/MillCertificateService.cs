using COM.DAL;
using COM.Dtos;
using COM.Extensions;
using COM.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace COM.BLL
{
    public class MillCertificateService
    {
        public MillCertificateService()
        {
            using (var context = new MillCertificateDbContext())
            {
                context.Database.CreateIfNotExists();
            }
        }

        public MillSheetResponseDTO Add(RegisterRequestDTO registerRequestDto)
        {
            using (var context = new MillCertificateDbContext())
            {
                var millCertificateSheet = new MillCertificateSheet(registerRequestDto);
                context.MillCertificateSheets.Add(millCertificateSheet);
                millCertificateSheet.Id = context.SaveChanges();

                return new MillSheetResponseDTO(millCertificateSheet);
            }
        }

        public List<MillSheetResponseDTO> AddRange(List<RegisterRequestDTO> registerRequestDtos)
        {
            using (var context = new MillCertificateDbContext())
            {
                var millCertificateSheets = registerRequestDtos.ToMillCertificateSheets();
                var millSheetResponseDtos = context.MillCertificateSheets
                    .AddRange(millCertificateSheets)
                    .ToMillSheetResponseDtos();
                context.SaveChanges();

                return millSheetResponseDtos.ToList();
            }
        }

        public MillSheetResponseDTO Modify(ModifyRequestDTO modifyRequestDto)
        {
            using (var context = new MillCertificateDbContext()) 
            {
                var millCertificateSheet = context.MillCertificateSheets.Find(modifyRequestDto.Id);

                if (millCertificateSheet is null)
                {
                    throw new InvalidOperationException("지정된 레코드를 찾을 수 없습니다.");
                }

                millCertificateSheet.Update(modifyRequestDto);
                context.Entry(millCertificateSheet).State = EntityState.Modified;
                context.SaveChanges();

                return new MillSheetResponseDTO(millCertificateSheet);
            }
        }

        public void DeleteById(int id)
        {
            using (var context = new MillCertificateDbContext())
            {
                var millCertificateSheet = context.MillCertificateSheets.Find(id);
                millCertificateSheet.IsDeleted = "Y";
                context.Entry(millCertificateSheet).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public List<MillSheetResponseDTO> GetAll()
        {
            using (var context = new MillCertificateDbContext())
            {
                var query = from m in context.MillCertificateSheets
                            orderby m.Id
                            where m.IsDeleted == "N"
                            select m;

                return query.ToMillSheetResponseDtos();
            }
        }

        public List<MillSheetResponseDTO> GetByCreatedAt(DateTime createdAt)
        {
            using (var context = new MillCertificateDbContext())
            {
                string date = createdAt.ToString("yyyy-MM-dd");

                var query = from m in context.MillCertificateSheets
                            orderby m.Id
                            where m.CreatedAt == date && m.IsDeleted == "N"
                            select m;

                return query.ToMillSheetResponseDtos();
            }
        }

        public List<MillSheetResponseDTO> GetByCategoryAndKeyword(string category, string keyword)
        {
            using (var context = new MillCertificateDbContext())
            {
                var parameter = Expression.Parameter(typeof(MillCertificateSheet), "m");
                var property = Expression.Property(parameter, category);
                var contains = Expression.Call(property, typeof(string).GetMethod("Contains"), Expression.Constant(keyword));
                var whereLambda = Expression.Lambda<Func<MillCertificateSheet, bool>>(Expression.AndAlso(Expression.Equal(Expression.Property(parameter, nameof(MillCertificateSheet.IsDeleted)), Expression.Constant("N")), contains), parameter);
                var query = context.MillCertificateSheets.Where(whereLambda).OrderBy(m => m.Id);

                return query.ToMillSheetResponseDtos();
            }
        }
    }
}
