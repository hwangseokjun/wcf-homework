using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COM.Dtos
{
    public class RegisterRequestDTO
    {
        public string ProjectNo { get; set; }
        public string MillSheetNo { get; set; }
        public string DocMngNo { get; set; }
        public DateTime IssuedDate { get; set; }
    }
}
