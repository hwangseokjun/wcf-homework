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

namespace COM.DataAccess
{
    public class MillCertificateSheetRepository : IMillCertificateSheetRepository
    {
        public void Save(MillCertificateSheet millCertificateSheet) 
        {
            using (IDbConnection cnn = new SQLiteConnection(Settings.Default.CONNECTION_STRING))
            {
                cnn.Execute("INSERT INTO mill_cert_sheets (val1, val2, ...) VALUES ", millCertificateSheet);
            }
        }

        public void DeleteById(int Id) 
        {
            using (IDbConnection cnn = new SQLiteConnection(Settings.Default.CONNECTION_STRING))
            {
                cnn.Execute("INSERT INTO mill_cert_sheets (val1, val2, ...) VALUES ");
            }
        }

        public void FindBy(string category, string query) 
        {
            using (IDbConnection cnn = new SQLiteConnection(Settings.Default.CONNECTION_STRING))
            {
                var outputs = cnn.Query<List<MillCertificateSheet>>("SELECT FROM mill_cert_sheets WHERE {}");
            }
        }

        public void FindAll() 
        { 
            
        }
    }
}
