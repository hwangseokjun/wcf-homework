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
        int Save(MillCertificateSheet millCertificateSheet);
        void DeleteBy(int Id);
        void Update(MillCertificateSheet millCertificateSheet);
        List<MillCertificateSheet> FindBy(string category, string search);
        List<MillCertificateSheet> FindAll();
    }
}
