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
    public interface IMillCertificateSheetService
    {
        [OperationContract]
        string Add(RegisterRequestDTO registerRequestDto);
        [OperationContract]
        string Modify(ModifyRequestDTO modifyRequestDto);
        [OperationContract]
        string Remove(int id);
        [OperationContract]
        List<MillSheetResponseDTO> GetAll();
        [OperationContract]
        void GetBy(string category, string query);
        [OperationContract]
        List<MillSheetResponseDTO> GetByCreatedAt();
    }
}
