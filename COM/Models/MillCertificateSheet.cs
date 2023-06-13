using COM.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COM.Models
{
    [Table("mill_cert_sheets")]
    public class MillCertificateSheet
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string ProjectNo { get; set; }

        [Required]
        [MaxLength(20)]
        public string MillSheetNo { get; set; }

        [Required]
        [MaxLength(20)]
        public string DocMngNo { get; set; }

        [Required]
        [MaxLength(20)]
        public string IssuedDate { get; set; }

        public string ModifiedAt { get; set; } = null;

        [Index]
        [Required]
        [MaxLength(20)]
        public string CreatedAt { get; set; } = DateTime.Today.ToString("yyyy-MM-dd");

        [Required]
        [RegularExpression("^[YN]$")]
        public string IsDeleted { get; set; } = "N";

        public MillCertificateSheet()
        {
        }

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
