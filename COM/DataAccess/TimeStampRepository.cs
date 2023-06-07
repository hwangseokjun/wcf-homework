using COM.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COM.DataAccess
{
    public class TimeStampRepository : ITimeStampRepository
    {
        private readonly SQLiteConnection _connection;
        private readonly SQLiteTransaction _transaction;

        public TimeStampRepository(SQLiteConnection connection, SQLiteTransaction transaction)
        {
            _connection = connection;
            _transaction = transaction;
        }

        public void Delete(TimeStamp entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TimeStamp> FindAll()
        {
            throw new NotImplementedException();
        }

        public TimeStamp FindById(int id)
        {
            throw new NotImplementedException();
        }

        public int Save(TimeStamp entity)
        {
            throw new NotImplementedException();
        }

        public void Update(TimeStamp entity)
        {
            throw new NotImplementedException();
        }
    }
}
