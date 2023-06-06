﻿using COM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COM.DataAccess
{
    public interface ITimeStampRepository
    {
        int Save(DateTime today);
        void DeleteBy(int Id);
        bool ExistsBy(DateTime today);
    }
}
