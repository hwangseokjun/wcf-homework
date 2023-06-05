using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Controls
{
    public class CalendarColumn : DataGridViewColumn
    {
        public override DataGridViewCell CellTemplate
        {
            get => base.CellTemplate;
            set
            {
                if (value != null && !value.GetType().IsAssignableFrom(typeof(CalendarCell)))
                {
                    throw new InvalidCastException("CalendarCell 타입이어야 합니다.");
                }

                base.CellTemplate = value;
            }
        }

        public CalendarColumn() : base(new CalendarCell())
        {
        }
    }
}
