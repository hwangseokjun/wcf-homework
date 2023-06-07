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
        MillSheetResponseDTO Add(RegisterRequestDTO registerRequestDto);
        [OperationContract]
        void Modify(ModifyRequestDTO modifyRequestDto);
        [OperationContract]
        void DeleteById(int id);
        [OperationContract]
        List<MillSheetResponseDTO> GetAll();
        [OperationContract]
        MillSheetResponseDTO GetById(int id);
        [OperationContract]
        List<MillSheetResponseDTO> GetByCreatedAt(DateTime createdAt);
        [OperationContract]
        List<MillSheetResponseDTO> GeyByCategoryAndKeyword(string category, string keyword);
    }
}
