using COM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COM.DataAccess
{
    public interface IMillCertificateSheetRepository : IRepository<MillCertificateSheet, int>
    {
        IEnumerable<MillCertificateSheet> FindByCreatedAt(string createdAt);
        IEnumerable<MillCertificateSheet> FindByCategoryAndKeyword(string category, string keyword);
    }
}
