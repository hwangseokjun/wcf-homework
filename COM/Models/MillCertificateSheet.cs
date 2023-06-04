using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
        public DateTime IssuedDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}
