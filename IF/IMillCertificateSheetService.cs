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
        List<MillSheetResponseDTO> AddRange(List<RegisterRequestDTO> registerRequestDtos);

        [OperationContract]
        void Modify(ModifyRequestDTO modifyRequestDto);

        [OperationContract]
        void DeleteById(int id);

        [OperationContract]
        List<MillSheetResponseDTO> GetAll();

        [OperationContract]
        List<MillSheetResponseDTO> GetByCreatedAt(DateTime createdAt);

        [OperationContract]
        List<MillSheetResponseDTO> GetByCategoryAndKeyword(string category, string keyword);
    }
}
