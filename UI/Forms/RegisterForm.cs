using IF;
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
using UI.Dtos;
using UI.Models;
using UI.Utils;

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

            if (count <= 0)
            {
                MessageBox.Show("선택된 열이 없습니다.");
                return;
            }

            for (int i = count - 1; 0 <= i; i--)
            {
                int idx = dgvRegister.SelectedRows[i].Index;
                bsRegisterSheet.RemoveAt(idx);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (bsRegisterSheet.Count <= 0) 
            {
                MessageBox.Show("등록할 데이터가 없습니다.");
                return;
            }

            var sources = bsRegisterSheet.List.Cast<RegisterRequestDto>();

            try
            {
                foreach (var tmp in sources)
                {
                    var requestDto = new RegisterRequestDto
                    {
                        ProjectNo = tmp.ProjectNo,
                        MillSheetNo = tmp.MillSheetNo,
                        IssuedDate = tmp.IssuedDate,
                        CreatedAt = DateTime.Today
                    };
                    // TODO: 개별 요소들 반복문으로 insert
                }
            }
            catch (FaultException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            { 
                
            }
        }

        private void dgvRegister_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dgvRegister.IsCurrentCellDirty) 
            {
                var cell = dgvRegister.Rows[e.RowIndex].Cells[e.ColumnIndex];
                IValidator validator = CreateValidatorFrom(cell.OwningColumn.DataPropertyName);

                if (validator.IsValid(e.FormattedValue)) 
                {
                    return;
                };

                cell.ErrorText = "유효하지 않은 값입니다.";
            }
        }

        private IValidator CreateValidatorFrom(string columnName) 
        {
            switch (columnName)
            {
                case nameof(RegisterSheet.ProjectNo):
                    return new ProjectNoValidator();
                case nameof(RegisterSheet.MillSheetNo):
                    return new MillSheetNoValidator();
                case nameof(RegisterSheet.IssuedDate):
                    return new IssuedDateValidator();
                default:
                    return new DefaultValidator();
            }
        }
    }
}
