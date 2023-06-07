using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COM.Models
{
    public class TimeStamp
    {
        public int Id { get; set; }
        public string CreatedAt { get; set; } = DateTime.Today.ToString("yyyy-MM-dd");
    }
}
