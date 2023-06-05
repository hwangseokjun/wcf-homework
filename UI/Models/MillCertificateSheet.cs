using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Models
{
    public class MillCertificateSheet
    {
        [Browsable(false)]
        public int Id { get; set; }
        [DisplayName("프로젝트번호")]
        public string ProjectNo { get; set; }
        [DisplayName("강재번호")]
        public string MillSheetNo { get; set; }
        [DisplayName("발행일")]
        public DateTime IssuedDate { get; set; }
        [DisplayName("최초작성일")]
        public DateTime CreatedAt { get; set; }
        [DisplayName("마지막 수정일")]
        public DateTime? ModifiedAt { get; set; }
        [DisplayName("문서관리번호")]
        public string DocMngNo { get; set; }
    }
}
