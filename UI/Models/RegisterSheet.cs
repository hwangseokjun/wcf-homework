using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Models
{
    public class RegisterSheet
    {
        [DisplayName("프로젝트번호")]
        public string ProjectNo { get; set; }
        [DisplayName("강재번호")]
        public string MillSheetNo { get; set; }
        [DisplayName("발행일")]
        public DateTime IssuedDate { get; set; }
        [DisplayName("문서관리번호")]
        public string DocMngNo { get; set; }
    }
}
