using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Controls
{
    public class CalendarCell : DataGridViewTextBoxCell
    {
        public override Type EditType => typeof(CalendarEditingControl);
        public override Type ValueType => typeof(DateTime);
        public override object DefaultNewRowValue => DateTime.Today;

        public CalendarCell() : base()
        {
            Style.Format = "yyyy-MM-dd";
        }

        public override void InitializeEditingControl(int rowIndex, object initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
        {
            base.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle);

            var control = DataGridView.EditingControl as CalendarEditingControl;
            
            if (Value is null)
            {
                control.Value = (DateTime)DefaultNewRowValue;
                return;
            }
            
            control.Value = DateTime.Parse((string)Value);
        }
    }
}
