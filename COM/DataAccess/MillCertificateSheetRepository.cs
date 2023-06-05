using Dapper;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using COM.Properties;
using System.Data;
using System.Data.SQLite;
using COM.Models;
using COM.Dtos;

namespace COM.DataAccess
{
    public class MillCertificateSheetRepository : IMillCertificateSheetRepository
    {
        public void Save(MillCertificateSheet millCertificateSheet) 
        {
            // TODO: 트랜잭션 처리 추가 필요
            using (IDbConnection cnn = new SQLiteConnection(Settings.Default.CONNECTION_STRING))
            using (var transaction = cnn.BeginTransaction())
            {
                try
                {
                    var query = @"INSERT INTO MillCertificateSheet (
                                    ProjectNo, 
                                    MillSheetNo, 
                                    DocMngNo, 
                                    IssuedDate, 
                                    CreatedAt
                                ) 
                                VALUES (
                                    @ProjectNo, 
                                    @MillSheetNo, 
                                    @DocMngNo, 
                                    @IssuedDate, 
                                    @CreatedAt
                                )";
                    cnn.Execute(query, millCertificateSheet);
                    transaction.Commit();
                }
                catch 
                {
                    transaction.Rollback();
                    throw new SQLiteException("failed to transaction");
                }
            }
        }

        public void DeleteById(int Id) 
        {
            using (IDbConnection cnn = new SQLiteConnection(Settings.Default.CONNECTION_STRING))
            {
                cnn.Execute($"UPDATE MillCertificateSheet AS m SET IsDeleted = 'Y' WHERE m.Id = {Id}");
            }
        }

        public void FindBy(string category, string query) 
        {
            using (IDbConnection cnn = new SQLiteConnection(Settings.Default.CONNECTION_STRING))
            {
                var outputs = cnn.Query<List<MillCertificateSheet>>("SELECT * FROM MillCertificateSheet WHERE {}");
            }
        }

        // TODO: 실제로는 페이징 쿼리가 적용되어야 함
        public List<MillSheetResponseDTO> FindAll() 
        {
            using (IDbConnection cnn = new SQLiteConnection(Settings.Default.CONNECTION_STRING))
            {
                var outputs = cnn.Query<MillCertificateSheet>("SELECT * FROM MillCertificateSheet AS m WHERE m.IsDeleted = 'N'");
                var responseDtos = new List<MillSheetResponseDTO>(outputs.Count());

                foreach (var tmp in outputs) 
                {
                    var responseDto = new MillSheetResponseDTO
                    {
                        Id = tmp.Id,
                        DocMngNo = tmp.DocMngNo,
                        ProjectNo = tmp.ProjectNo,
                        MillSheetNo = tmp.MillSheetNo,
                        IssuedDate = DateTime.Parse(tmp.IssuedDate),
                        CreateAt = DateTime.Parse(tmp.CreatedAt),
                        ModifiedAt = tmp.ModifiedAt is null ? null : (DateTime?)DateTime.Parse(tmp.ModifiedAt)
                    };

                    responseDtos.Add(responseDto);
                }

                return responseDtos;
            }
        }
    }
}
