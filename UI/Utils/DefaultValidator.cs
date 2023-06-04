using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Utils
{
    public class DefaultValidator : IValidator
    {
        public bool IsValid(object value)
        {
            return true;
        }
    }
}
