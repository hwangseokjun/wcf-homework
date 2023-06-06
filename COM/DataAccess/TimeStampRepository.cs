using Dapper;

using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using COM.Models;
using COM.Properties;

namespace COM.DataAccess
{
    public class TimeStampRepository : ITimeStampRepository
    {
        public int Save(DateTime today)
        {
            var query = "";

            using (var cnn = new SQLiteConnection(Settings.Default.CONNECTION_STRING))
            {
                cnn.Open();

                return cnn.Execute(query);
            }
        }

        public void DeleteBy(int Id)
        {
            var query = "";

            using (var cnn = new SQLiteConnection(Settings.Default.CONNECTION_STRING))
            {
                cnn.Open();
                cnn.Execute(query);
            }
        }

        public bool ExistsBy(DateTime today)
        {
            throw new NotImplementedException();
        }
    }
}
