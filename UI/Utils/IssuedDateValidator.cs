using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Utils
{
    public class IssuedDateValidator : IValidator
    {
        public bool IsValid(object value)
        {
            var selectedDate = DateTime.Parse((string)value);
            var currentDate = DateTime.Today;

            if (1 <= DateTime.Compare(selectedDate, currentDate)) 
            {
                return false;
            }

            return true;
        }
    }
}
