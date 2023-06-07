using COM.Dtos;
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
        bool ExistsChildrenById(int id);
        [OperationContract]
        List<TreePathResponseDTO> FindChildrenById(int id); 
    }
}
