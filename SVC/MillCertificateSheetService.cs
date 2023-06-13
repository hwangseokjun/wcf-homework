using COM.Dtos;
using COM.Models;
using SVC.Extensions;
using IF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SVC.Properties;
using COM.BLL;

namespace SVC
{
    public class MillCertificateSheetService : IMillCertificateSheetService
    {
        private readonly MillCertificateService _millCertificateService = new MillCertificateService();

        public MillCertificateSheetService()
        {
        }

        public MillSheetResponseDTO Add(RegisterRequestDTO registerRequestDto) 
        {
            return _millCertificateService.Add(registerRequestDto);
        }

        public List<MillSheetResponseDTO> AddRange(List<RegisterRequestDTO> registerRequestDtos) 
        {
            return _millCertificateService.AddRange(registerRequestDtos);
        }

        public void Modify(ModifyRequestDTO modifyRequestDto) 
        {
            _millCertificateService.Modify(modifyRequestDto);
        }

        public void DeleteById(int id) 
        {
            _millCertificateService.DeleteById(id);
        }

        public List<MillSheetResponseDTO> GetAll() 
        {
            return _millCertificateService.GetAll();
        }

        public List<MillSheetResponseDTO> GetByCreatedAt(DateTime createdAt) 
        {
            return _millCertificateService.GetByCreatedAt(createdAt);
        }

        public List<MillSheetResponseDTO> GetByCategoryAndKeyword(string category, string keyword) 
        {
            return _millCertificateService.GetByCategoryAndKeyword(category, keyword);
        }
    }
}
