using COM.DataAccess;
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
using System.Transactions;
using SVC.Properties;

namespace SVC
{
    public class MillCertificateSheetService : IMillCertificateSheetService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMillCertificateSheetRepository _millCertificateSheetRepository;
        private readonly ITreePathRepository _treePathRepository;
        private readonly ITimeStampRepository _timeStampRepository;

        public MillCertificateSheetService()
        {
            _unitOfWork = new UnitOfWork(Settings.Default.CONNECTION_STRING);
            _treePathRepository = _unitOfWork.GetRepository<TreePathRepository>();
            _timeStampRepository = _unitOfWork.GetRepository<TimeStampRepository>();
            _millCertificateSheetRepository = _unitOfWork.GetRepository<MillCertificateSheetRepository>();
        }

        public MillCertificateSheetService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _treePathRepository = _unitOfWork.GetRepository<TreePathRepository>();
            _timeStampRepository = _unitOfWork.GetRepository<TimeStampRepository>();
            _millCertificateSheetRepository = _unitOfWork.GetRepository<MillCertificateSheetRepository>();
        }

        public MillSheetResponseDTO Add(RegisterRequestDTO registerRequestDto) 
        {
            try
            {
                _unitOfWork.BeginTransaction();
                var millCertificateSheet = new MillCertificateSheet(registerRequestDto);
                int id = _millCertificateSheetRepository.Save(millCertificateSheet);
                _unitOfWork.Commit();

                return new MillSheetResponseDTO
                {
                    Id = id,
                    DocMngNo = millCertificateSheet.DocMngNo,
                    ProjectNo = millCertificateSheet.ProjectNo,
                    MillSheetNo = millCertificateSheet.MillSheetNo,
                    IssuedDate = DateTime.Parse(millCertificateSheet.IssuedDate),
                    CreateAt = DateTime.Parse(millCertificateSheet.CreatedAt),
                    ModifiedAt = null
                };
            }
            catch (FaultException ex) 
            {
                _unitOfWork.Rollback();
                throw new FaultException($"{ex.Message}");
            }
        }

        public void Modify(ModifyRequestDTO modifyRequestDto) 
        {
            var millCertificateSheet = _millCertificateSheetRepository.FindById(modifyRequestDto.Id);
            millCertificateSheet.Update(modifyRequestDto);
            _millCertificateSheetRepository.Update(millCertificateSheet);
            _unitOfWork.Commit();
        }

        public void DeleteById(int id) 
        {
            var millCertificateSheet = _millCertificateSheetRepository.FindById(id);
            millCertificateSheet.IsDeleted = "Y";
            _millCertificateSheetRepository.Update(millCertificateSheet);
            _unitOfWork.Commit();
        }

        public List<MillSheetResponseDTO> GetAll() 
        {
            var millCertificateSheets = _millCertificateSheetRepository.FindAll();
            _unitOfWork.Commit();

            return millCertificateSheets.CreateResponseDtos();
        }

        public MillSheetResponseDTO GetById(int id) 
        {
            MillCertificateSheet millCertificateSheet = _millCertificateSheetRepository.FindById(id);
            _unitOfWork.Commit();

            return new MillSheetResponseDTO
            {
                Id = millCertificateSheet.Id,
                DocMngNo = millCertificateSheet.DocMngNo,
                ProjectNo = millCertificateSheet.ProjectNo,
                MillSheetNo = millCertificateSheet.MillSheetNo,
                IssuedDate = DateTime.Parse(millCertificateSheet.IssuedDate),
                CreateAt = DateTime.Parse(millCertificateSheet.CreatedAt),
                ModifiedAt = millCertificateSheet.ModifiedAt is null ? null : (DateTime?)DateTime.Parse(millCertificateSheet.ModifiedAt)
            };
        }

        public List<MillSheetResponseDTO> GetByCreatedAt(DateTime createdAt) 
        {
            var value = createdAt.ToString("yyyy-MM-dd");
            var millCertificateSheets = _millCertificateSheetRepository.FindByCreatedAt(value);
            _unitOfWork.Commit();

            return millCertificateSheets.CreateResponseDtos();
        }

        public List<MillSheetResponseDTO> GeyByCategoryAndKeyword(string category, string keyword) 
        {
            var millCertificateSheets = _millCertificateSheetRepository.FindByCategoryAndKeyword(category, keyword);
            _unitOfWork.Commit();

            return millCertificateSheets.CreateResponseDtos();
        }
    }
}
