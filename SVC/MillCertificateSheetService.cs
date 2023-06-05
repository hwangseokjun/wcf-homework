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

namespace SVC
{
    [GlobalErrorHandlerBehavior(typeof(GlobalErrorHandler))]
    public class MillCertificateSheetService : IMillCertificateSheetService
    {
        private readonly IMillCertificateSheetRepository _millCertificateSheetRepository;

        public MillCertificateSheetService()
        {
            _millCertificateSheetRepository = new MillCertificateSheetRepository();
        }

        public MillCertificateSheetService(IMillCertificateSheetRepository millCertificateSheetRepository)
        {
            _millCertificateSheetRepository = millCertificateSheetRepository;
        }

        public string Add(RegisterRequestDTO registerRequestDto)
        {
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
