using COM.DataAccess;
using COM.Dtos;
using COM.Models;
using IF;
using SVC.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Transactions;

namespace SVC
{
    [GlobalErrorHandlerBehavior(typeof(GlobalErrorHandler))]
    [ServiceBehavior(TransactionIsolationLevel = IsolationLevel.Serializable, TransactionTimeout = "00:00:30")]
    public class MillCertificateSheetService : IMillCertificateSheetService
    {
        private readonly IMillCertificateSheetRepository _millCertificateSheetRepository;
        private readonly ITreePathRepository _treePathRepository;

        public MillCertificateSheetService()
        {
            _millCertificateSheetRepository = new MillCertificateSheetRepository();
            _treePathRepository = new TreePathRepository();
        }

        public MillCertificateSheetService(IMillCertificateSheetRepository millCertificateSheetRepository, ITreePathRepository treePathRepository)
        {
            _millCertificateSheetRepository = millCertificateSheetRepository;
            _treePathRepository = treePathRepository;
        }

        [OperationBehavior(TransactionScopeRequired = true)]
        public string Add(RegisterRequestDTO registerRequestDto)
        {
            using (var scope = new TransactionScope())
            {
                try
                {
                    // TODO: 예외처리 필요. 현재일보다 앞서거나 지나치게 멀 경우 등록 불가.
                    #region 예외처리
                    #endregion

                    var createdAt = DateTime.Today.ToString("yyyy-MM-dd");

                    var millCertificateSheet = new MillCertificateSheet
                    {
                        ProjectNo = registerRequestDto.ProjectNo,
                        MillSheetNo = registerRequestDto.MillSheetNo,
                        DocMngNo = registerRequestDto.DocMngNo,
                        IssuedDate = registerRequestDto.IssuedDate.ToString("yyyy-MM-dd"),
                        CreatedAt = createdAt,
                        ModifiedAt = null
                    };

                    _millCertificateSheetRepository.Save(millCertificateSheet);

                    scope.Complete();
                }
                catch (Exception ex) 
                {
                    throw new FaultException($"{ex.Message}");
                }
            }
            
            return "";
        }

        public List<MillSheetResponseDTO> GetAll()
        {
            return _millCertificateSheetRepository.FindAll();
        }

        public void GetBy(string category, string query)
        {
            throw new NotImplementedException();
        }

        public string Remove(int id)
        {
            throw new NotImplementedException();
        }

        public string Modify(ModifyRequestDTO modifyRequestDto)
        {
            throw new NotImplementedException();
        }

        public List<MillSheetResponseDTO> GetByCreatedAt()
        {
            return new List<MillSheetResponseDTO>();
        }
    }
}
