﻿using COM.Models;
using COM.Properties;
using Dapper;
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
        public int Save(TreePath treePath)
        {
            throw new NotImplementedException();
        }

        public void DeleteBy(int id) 
        {
            var query = "";

            using (var cnn = new SQLiteConnection(Settings.Default.CONNECTION_STRING))
            {
                cnn.Open();
                cnn.Execute(query);
            }
        }

        public List<MillCertificateSheet> FindBy(int id)
        {
            var query = "";

            using (var cnn = new SQLiteConnection(Settings.Default.CONNECTION_STRING))
            {
                cnn.Open();
                return cnn.Query<MillCertificateSheet>(query).ToList();
            }
        }
    }
}
