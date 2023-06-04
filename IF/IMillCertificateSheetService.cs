using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace IF
{
    [ServiceContract]
    public interface IMillCertificateSheetService
    {
        [OperationContract]
        string Add();
        [OperationContract]
        string Modify();
        [OperationContract]
        string Remove();
        [OperationContract]
        string GetAll();
        [OperationContract]
        void GetBy(string category, string query);
    }
}
