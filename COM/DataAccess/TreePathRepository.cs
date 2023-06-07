using COM.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COM.DataAccess
{
    public class TreePathRepository : ITreePathRepository
    {
        private readonly SQLiteConnection _connection;
        private readonly SQLiteTransaction _transaction;

        public TreePathRepository(SQLiteConnection connection, SQLiteTransaction transaction)
        {
            _connection = connection;
            _transaction = transaction;
        }

        public void Delete(TreePath entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TreePath> FindAll()
        {
            throw new NotImplementedException();
        }

        public TreePath FindById(int id)
        {
            throw new NotImplementedException();
        }

        public int Save(TreePath entity)
        {
            throw new NotImplementedException();
        }

        public void Update(TreePath entity)
        {
            throw new NotImplementedException();
        }
    }
}
