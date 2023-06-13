using COM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COM.Dtos
{
    public class MillSheetResponseDTO
    {
        public int Id { get; set; }
        public string DocMngNo { get; set; }
        public string ProjectNo { get; set; }
        public string MillSheetNo { get; set; }
        public DateTime IssuedDate { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime? ModifiedAt { get; set; }

        public MillSheetResponseDTO()
        {
        }

        public MillSheetResponseDTO(MillCertificateSheet millCertificateSheet)
        {
            Id = millCertificateSheet.Id;
            DocMngNo = millCertificateSheet.DocMngNo;
            ProjectNo = millCertificateSheet.ProjectNo;
            MillSheetNo = millCertificateSheet.MillSheetNo;
            IssuedDate = DateTime.Parse(millCertificateSheet.IssuedDate);
            CreateAt = DateTime.Parse(millCertificateSheet.CreatedAt);
            ModifiedAt = millCertificateSheet.ModifiedAt is null ? null : (DateTime?)DateTime.Parse(millCertificateSheet.ModifiedAt);
        }
    }
}
