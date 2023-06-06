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
        #region MillCertificatSheet
        [OperationContract]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        int AddMillCertificateSheet(RegisterRequestDTO registerRequestDto);
        [OperationContract]
        void UpdateMillCertificateSheet(ModifyRequestDTO modifyRequestDto);
        [OperationContract]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        void RemoveMillCertificateSheet(int id);
        [OperationContract]
        List<MillSheetResponseDTO> GetMillCertificateSheets();
        [OperationContract]
        void GetMillCertificateSheetsBy(string category, string search);
        #endregion

        #region TimeStamp
        [OperationContract]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        int AddTimeStamp();
        [OperationContract]
        void RemoveTimeStamp(int id);
        #endregion

        #region TreePath
        [OperationContract]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        int AddTreePath();
        [OperationContract]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        void RemoveTreePath(int id);
        #endregion
    }
}
