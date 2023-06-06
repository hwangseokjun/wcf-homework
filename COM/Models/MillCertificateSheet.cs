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
        public string ModifiedAt { get; set; }
        public int TimeStampId { get; set; } 
    }
}
