using COM.Models;
using COM.Properties;
using System;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Infrastructure;
using System.Data.SQLite;
using System.Data.SQLite.EF6;
using System.Reflection;


namespace COM.DAL
{
    [DbConfigurationType(typeof(SqliteConfiguration))]
    public class MillCertificateDbContext : DbContext
    {
        public DbSet<MillCertificateSheet> MillCertificateSheets { get; set; }

        public MillCertificateDbContext() : base("name=ConnectionString")
        {
        }
    }

    public class SqliteConfiguration : DbConfiguration
    {
        public SqliteConfiguration()
        {
            SetProviderFactory("System.Data.SQLite", SQLiteFactory.Instance);
            SetProviderFactory("System.Data.SQLite.EF6", SQLiteProviderFactory.Instance);
            SetProviderServices("System.Data.SQLite", (DbProviderServices)SQLiteProviderFactory.Instance.GetService(typeof(DbProviderServices)));
        }
    }
}
