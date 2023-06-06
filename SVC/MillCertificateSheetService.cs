using COM.DataAccess;
using COM.Dtos;
using COM.Models;
using IF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Transactions;

namespace SVC
{
    [ServiceBehavior(TransactionIsolationLevel = IsolationLevel.Serializable, TransactionTimeout = "00:00:30")]
    public class MillCertificateSheetService : IMillCertificateSheetService
    {
        private readonly IMillCertificateSheetRepository _millCertificateSheetRepository;
        private readonly ITreePathRepository _treePathRepository;
        private readonly ITimeStampRepository _timeStampRepository;

        public MillCertificateSheetService()
        {
            _millCertificateSheetRepository = new MillCertificateSheetRepository();
            _treePathRepository = new TreePathRepository();
            _timeStampRepository = new TimeStampRepository();
        }

        public MillCertificateSheetService(
            IMillCertificateSheetRepository millCertificateSheetRepository, 
            ITreePathRepository treePathRepository, 
            ITimeStampRepository timeStampRepository)
        {
            _millCertificateSheetRepository = millCertificateSheetRepository;
            _treePathRepository = treePathRepository;
            _timeStampRepository = timeStampRepository;
        }

        [OperationBehavior(TransactionScopeRequired = true)]
        public int AddMillCertificateSheet(RegisterRequestDTO registerRequestDto)
        {
            try
            {
                var currentDate = DateTime.Today.ToString("yyyy-MM-dd");

                // TODO: 예외처리 필요. 현재일보다 앞서거나 지나치게 멀 경우 등록 불가.
                #region 예외처리
                #endregion

                var millCertificateSheet = new MillCertificateSheet
                {
                    ProjectNo = registerRequestDto.ProjectNo,
                    MillSheetNo = registerRequestDto.MillSheetNo,
                    DocMngNo = registerRequestDto.DocMngNo,
                    IssuedDate = registerRequestDto.IssuedDate.ToString("yyyy-MM-dd"),
                    ModifiedAt = null
                };

                return _millCertificateSheetRepository.Save(millCertificateSheet);
            }
            catch (Exception ex)
            {
                throw new FaultException($"{ex.Message}");
            }
        }

        public void UpdateMillCertificateSheet(ModifyRequestDTO modifyRequestDto)
        {
            
        }

        public void RemoveMillCertificateSheet(int id)
        {

        }

        public List<MillSheetResponseDTO> GetMillCertificateSheets()
        {
            List<MillCertificateSheet> millCertificateSheets = _millCertificateSheetRepository.FindAll();
            var responseDtos = new List<MillSheetResponseDTO>(millCertificateSheets.Count());

            foreach (var tmp in millCertificateSheets)
            {
                var responseDto = new MillSheetResponseDTO
                {
                    Id = tmp.Id,
                    DocMngNo = tmp.DocMngNo,
                    ProjectNo = tmp.ProjectNo,
                    MillSheetNo = tmp.MillSheetNo,
                    IssuedDate = DateTime.Parse(tmp.IssuedDate),
                    ModifiedAt = tmp.ModifiedAt is null ? null : (DateTime?)DateTime.Parse(tmp.ModifiedAt)
                };
                responseDtos.Add(responseDto);
            }

            return responseDtos;
        }

        public void GetMillCertificateSheetsBy(string category, string search)
        {
            
        }

        public int AddTimeStamp()
        {
            return _timeStampRepository.Save(DateTime.Today);
        }

        public void RemoveTimeStamp(int id)
        {
            _timeStampRepository.DeleteBy(id);
        }

        public int AddTreePath()
        {
            return 0;
        }

        public void RemoveTreePath(int id)
        {
            _timeStampRepository.DeleteBy(id);
        }
    }
}
