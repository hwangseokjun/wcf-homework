using COM.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COM.Models
{
    public class MillCertificateSheet
    {
        public int Id { get; set; }
        public string ProjectNo { get; set; }
        public string MillSheetNo { get; set; }
        public string DocMngNo { get; set; }
        public string IssuedDate { get; set; }
        public string ModifiedAt { get; set; } = null;
        public string CreatedAt { get; set; } = DateTime.Today.ToString("yyyy-MM-dd");
        public string IsDeleted { get; set; } = "N";

        public MillCertificateSheet(RegisterRequestDTO registerRequestDto)
        {
            ProjectNo = registerRequestDto.ProjectNo;
            MillSheetNo = registerRequestDto.MillSheetNo;
            DocMngNo = registerRequestDto.DocMngNo;
            IssuedDate = registerRequestDto.IssuedDate.ToString("yyyy-MM-dd");
        }

        public void Update(ModifyRequestDTO modifyRequestDto) 
        {
            ProjectNo = modifyRequestDto.ProjectNo;
            MillSheetNo = modifyRequestDto.MillSheetNo;
            DocMngNo = modifyRequestDto.DocMngNo;
            IssuedDate = modifyRequestDto.IssuedDate.ToString("yyyy-MM-dd");
            ModifiedAt = DateTime.Today.ToString("yyyy-MM-dd");
        }
    }
}
