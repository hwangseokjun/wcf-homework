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
        public int Save(MillCertificateSheet millCertificateSheet)
        {
            #region 쿼리
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
            #endregion

            using (var cnn = new SQLiteConnection(Settings.Default.CONNECTION_STRING)) 
            {
                cnn.Open();

                return cnn.Execute(query, millCertificateSheet);
            }
        }

        public void DeleteBy(int Id) 
        {
            #region 쿼리
            var query = $@"UPDATE MillCertificateSheet AS m 
                                SET IsDeleted = 'Y' 
                                    WHERE m.Id = {Id}";
            #endregion

            using (var cnn = new SQLiteConnection(Settings.Default.CONNECTION_STRING))
            {
                cnn.Open();
                cnn.Execute(query);
            }
        }

        // TODO: 실제로는 페이징 쿼리가 적용되어야 함
        public List<MillCertificateSheet> FindAll() 
        {
            #region 쿼리
            var query = "SELECT * FROM MillCertificateSheet AS m WHERE m.IsDeleted = 'N'";
            #endregion

            using (var cnn = new SQLiteConnection(Settings.Default.CONNECTION_STRING))
            {
                cnn.Open();
                var outputs = cnn.Query<MillCertificateSheet>(query);

                return outputs.ToList();
            }
        }

        public void Update(MillCertificateSheet millCertificateSheet)
        {
            throw new NotImplementedException();
        }

        public List<MillCertificateSheet> FindBy(string category, string search)
        {
            throw new NotImplementedException();
        }
    }
}
