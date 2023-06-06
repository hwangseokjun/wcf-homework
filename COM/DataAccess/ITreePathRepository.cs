﻿using COM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COM.DataAccess
{
    public interface ITreePathRepository
    {
        int Save(TreePath treePath);
        void DeleteBy(int id);
        List<MillCertificateSheet> FindBy(int id);
    }
}
