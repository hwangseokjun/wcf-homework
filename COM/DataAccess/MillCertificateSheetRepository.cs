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
            using (var cnn = new SQLiteConnection(Settings.Default.CONNECTION_STRING))
            {
                // TODO: 트랜잭션 처리를 위한 쿼리 추가 작성 필요(상위에서 트랜잭션 처리는 진행됨)
                
                var insertQuery = @"INSERT INTO MillCertificateSheet (
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
                cnn.Execute(insertQuery, millCertificateSheet);
            }
        }

        public void DeleteById(int Id) 
        {
            using (var cnn = new SQLiteConnection(Settings.Default.CONNECTION_STRING))
            {
                var query = $"UPDATE MillCertificateSheet AS m SET IsDeleted = 'Y' WHERE m.Id = {Id}";
                cnn.Execute(query);
            }
        }

        public List<MillCertificateSheet> FindBy(string category, string search)
        {
            using (var cnn = new SQLiteConnection(Settings.Default.CONNECTION_STRING))
            {
                var query = "SELECT * FROM MillCertificateSheet AS m WHERE m.IsDeleted = 'N' AND ...";
                var outputs = cnn.Query<MillCertificateSheet>(query);

                return outputs.ToList();
            }
        }

        // TODO: 실제로는 페이징 쿼리가 적용되어야 함
        public List<MillSheetResponseDTO> FindAll() 
        {
            using (var cnn = new SQLiteConnection(Settings.Default.CONNECTION_STRING))
            {
                var query = "SELECT * FROM MillCertificateSheet AS m WHERE m.IsDeleted = 'N'";
                var outputs = cnn.Query<MillCertificateSheet>(query);
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
