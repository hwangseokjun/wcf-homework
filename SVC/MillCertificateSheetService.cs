using COM.DataAccess;
using COM.Dtos;
using COM.Models;
using SVC.Extensions;
using IF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Transactions;
using SVC.Properties;

namespace SVC
{
    public class MillCertificateSheetService : IMillCertificateSheetService
    {
        private readonly IUnitOfWork _unitOfWork;

        public MillCertificateSheetService()
        {
            _unitOfWork = new UnitOfWork(Settings.Default.CONNECTION_STRING);
        }

        public MillCertificateSheetService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public MillSheetResponseDTO Add(RegisterRequestDTO registerRequestDto) 
        {
            try
            {
                _unitOfWork.BeginTransaction();
                var millCertificateSheet = new MillCertificateSheet(registerRequestDto);
                int id = _unitOfWork.GetRepository<MillCertificateSheetRepository>().Save(millCertificateSheet);
                _unitOfWork.Commit();

                return new MillSheetResponseDTO
                {
                    Id = id,
                    DocMngNo = millCertificateSheet.DocMngNo,
                    ProjectNo = millCertificateSheet.ProjectNo,
                    MillSheetNo = millCertificateSheet.MillSheetNo,
                    IssuedDate = DateTime.Parse(millCertificateSheet.IssuedDate),
                    CreateAt = DateTime.Parse(millCertificateSheet.CreatedAt),
                    ModifiedAt = null
                };
            }
            catch (FaultException ex) 
            {
                _unitOfWork.Rollback();
                throw new FaultException($"{ex.Message}");
            }
        }

        public void Modify(ModifyRequestDTO modifyRequestDto) 
        {
            var millCertificateSheet = _unitOfWork.GetRepository<MillCertificateSheetRepository>().FindById(modifyRequestDto.Id);
            millCertificateSheet.Update(modifyRequestDto);
            _unitOfWork.GetRepository<MillCertificateSheetRepository>().Update(millCertificateSheet);
        }

        public void DeleteById(int id) 
        {
            var millCertificateSheet = _unitOfWork.GetRepository<MillCertificateSheetRepository>().FindById(id);
            millCertificateSheet.IsDeleted = "Y";
            _unitOfWork.GetRepository<MillCertificateSheetRepository>().Update(millCertificateSheet);
        }

        public List<MillSheetResponseDTO> GetAll() 
        {
            var millCertificateSheets = _unitOfWork.GetRepository<MillCertificateSheetRepository>().FindAll();
            
            return millCertificateSheets.CreateResponseDtos();
        }

        public MillSheetResponseDTO GetById(int id) 
        {
            MillCertificateSheet millCertificateSheet = _unitOfWork.GetRepository<MillCertificateSheetRepository>().FindById(id);

            return new MillSheetResponseDTO
            {
                Id = millCertificateSheet.Id,
                DocMngNo = millCertificateSheet.DocMngNo,
                ProjectNo = millCertificateSheet.ProjectNo,
                MillSheetNo = millCertificateSheet.MillSheetNo,
                IssuedDate = DateTime.Parse(millCertificateSheet.IssuedDate),
                CreateAt = DateTime.Parse(millCertificateSheet.CreatedAt),
                ModifiedAt = millCertificateSheet.ModifiedAt is null ? null : (DateTime?)DateTime.Parse(millCertificateSheet.ModifiedAt)
            };
        }

        public List<MillSheetResponseDTO> GetByCreatedAt(DateTime createdAt) 
        {
            var value = createdAt.ToString("yyyy-MM-dd");
            var millCertificateSheets = _unitOfWork.GetRepository<MillCertificateSheetRepository>().FindByCreatedAt(value);

            return millCertificateSheets.CreateResponseDtos();
        }

        public List<MillSheetResponseDTO> GeyByCategoryAndKeyword(string category, string keyword) 
        {
            var millCertificateSheets = _unitOfWork.GetRepository<MillCertificateSheetRepository>().FindByCategoryAndKeyword(category, keyword);

            return millCertificateSheets.CreateResponseDtos();
        }
    }
}
