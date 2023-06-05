using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COM.Models
{
    public class TreePath
    {
        public int Ancestor { get; set; }
        public int Descendant { get; set; }
        public int Depth { get; set; }
    }
}
