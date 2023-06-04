using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace IF
{
    [ServiceContract]
    public interface ITreePathService
    {
        [OperationContract]
        void Add();
        [OperationContract]
        void GetBy();
    }
}
