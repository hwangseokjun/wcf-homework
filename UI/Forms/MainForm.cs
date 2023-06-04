using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.R) 
            {
                using (var register = new RegisterForm())
                {
                    register.ShowDialog();
                }
            }

            if (e.Control && e.KeyCode == Keys.X) 
            {
                Close();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            using (var register = new RegisterForm()) 
            {
                register.ShowDialog();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void monthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {

        }
    }
}
