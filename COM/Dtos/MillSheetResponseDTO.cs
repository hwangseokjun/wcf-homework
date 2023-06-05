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
    }
}
