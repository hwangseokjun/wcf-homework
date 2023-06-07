using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COM.DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        private SQLiteConnection _connection;
        private SQLiteTransaction _transaction;
        private Dictionary<Type, object> _repositories;

        public UnitOfWork(string connectionString)
        {
            _connection = new SQLiteConnection(connectionString);
            _repositories = new Dictionary<Type, object>();
        }

        public void BeginTransaction()
        {
            _connection.Open();
            _transaction = _connection.BeginTransaction();
        }

        public void Commit()
        {
            _transaction.Commit();
            _connection.Close();
        }

        public void Rollback()
        {
            _transaction.Rollback();
            _connection.Close();
        }

        public TRepository GetRepository<TRepository>() where TRepository : class
        {
            if (!_repositories.ContainsKey(typeof(TRepository)))
            {
                var repository = CreateRepository<TRepository>();
                _repositories.Add(typeof(TRepository), repository);
            }

            return _repositories[typeof(TRepository)] as TRepository;
        }

        private TRepository CreateRepository<TRepository>() where TRepository : class
        {
            if (typeof(TRepository) == typeof(IMillCertificateSheetRepository))
            {
                return new MillCertificateSheetRepository(_connection, _transaction) as TRepository;
            }
            else if (typeof(TRepository) == typeof(ITimeStampRepository))
            {
                return new TimeStampRepository(_connection, _transaction) as TRepository;
            }
            else if (typeof(TRepository) == typeof(ITreePathRepository)) 
            {
                return new TreePathRepository(_connection, _transaction) as TRepository;
            }

            throw new ArgumentException($"Repository of type '{typeof(TRepository).Name}' is not supported.");
        }

        public void Dispose()
        {
            _transaction?.Dispose();
            _connection?.Dispose();
        }
    }
}
