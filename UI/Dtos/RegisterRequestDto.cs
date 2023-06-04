using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Dtos
{
    public class RegisterRequestDto
    {
        public string ProjectNo { get; set; }
        public string MillSheetNo { get; set; }
        public DateTime IssuedDate { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
