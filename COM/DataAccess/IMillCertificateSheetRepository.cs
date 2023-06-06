using COM.Dtos;
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
        void DeleteById(int Id);
        List<MillCertificateSheet> FindBy(string category, string search);
        List<MillSheetResponseDTO> FindAll();
    }
}
