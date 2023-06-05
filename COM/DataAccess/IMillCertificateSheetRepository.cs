﻿using COM.Dtos;
using COM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COM.DataAccess
{
    public interface IMillCertificateSheetRepository
    {
        void Save(MillCertificateSheet millCertificateSheet);

        List<MillSheetResponseDTO> FindAll();
    }
}