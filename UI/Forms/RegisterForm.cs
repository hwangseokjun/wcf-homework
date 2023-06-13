using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.MillCertificateSheetService;
using UI.Models;

namespace UI.Forms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            lblCurrentDate.Text = $"등록일자 : {DateTime.Today:yyyy-MM-dd}";
            bsRegisterSheet.AddNew();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int idx = dgvRegister.SelectedCells[0].ColumnIndex;

            if (idx == -1 || dgvRegister.RowCount <= idx + 1) 
            {
                bsRegisterSheet.AddNew();
                return;
            }

            bsRegisterSheet.Insert(idx + 1, new RegisterSheet());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int count = dgvRegister.SelectedRows.Count;

            #region 예외처리
            if (count <= 0)
            {
                MessageBox.Show("선택된 열이 없습니다.");
                return;
            }
            #endregion

            for (int i = count - 1; 0 <= i; i--)
            {
                int idx = dgvRegister.SelectedRows[i].Index;
                bsRegisterSheet.RemoveAt(idx);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            #region 예외처리
            if (bsRegisterSheet.Count <= 0) 
            {
                MessageBox.Show("등록할 데이터가 없습니다.");
                return;
            }
            #endregion

            dynamic registerSheets = bsRegisterSheet.List;

            using (var client = new MillCertificateSheetServiceClient()) 
            {
                foreach (var sheet in registerSheets)
                {
                    client.Add(new RegisterRequestDTO() 
                    { 
                        ProjectNo = sheet.ProjectNo,
                        MillSheetNo = sheet.MillSheetNo,
                        IssuedDate = sheet.IssuedDate,
                        DocMngNo = sheet.DocMngNo
                    });
                }
            }
        }

        private void dgvRegister_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dgvRegister.IsCurrentCellDirty) 
            {

            }
        }
    }
}
