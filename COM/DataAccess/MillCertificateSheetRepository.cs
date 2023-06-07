using COM.Models;
using Dapper;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COM.DataAccess
{
    public class MillCertificateSheetRepository : IMillCertificateSheetRepository
    {
        private readonly SQLiteConnection _connection;
        private readonly SQLiteTransaction _transaction;

        public MillCertificateSheetRepository(SQLiteConnection connection, SQLiteTransaction transaction)
        {
            _connection = connection;
            _transaction = transaction;
        }

        public void Delete(MillCertificateSheet entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            var query = "";

            _connection.Execute(query, _transaction);
        }

        public IEnumerable<MillCertificateSheet> FindAll()
        {
            var query = "";

            return _connection.Query<MillCertificateSheet>(query, _transaction);
        }

        public IEnumerable<MillCertificateSheet> FindByCategoryAndKeyword(string category, string keyword)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MillCertificateSheet> FindByCreatedAt(string createdAt) 
        {
            var query = "";

            return _connection.Query<MillCertificateSheet>(query, _transaction);
        }

        public MillCertificateSheet FindById(int id)
        {
            var query = "";

            return _connection.QuerySingleOrDefault<MillCertificateSheet>(query, _transaction);
        }

        public int Save(MillCertificateSheet entity)
        {
            return (int)_connection.Insert(entity, _transaction);
        }

        public void Update(MillCertificateSheet entity)
        {
            _connection.Update<MillCertificateSheet>(entity, _transaction);
        }
    }
}
