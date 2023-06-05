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
using UI.Models;
using UI.ServiceReference1;
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

            var sources = bsRegisterSheet.List.Cast<RegisterRequestDTO>();

            try
            {
                foreach (var tmp in sources)
                {
                    // TODO: 계약시에 정확히 DTO 생성 필요, 또한 클로저 테이블을 활용하므로 트랜잭션 처리가 필요하다.
                    var requestDto = new RegisterRequestDTO
                    {
                        
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
                // TODO: 완료된 요소들과 실패한 요소들에 대한 처리 필요
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
                    cell.ErrorText = string.Empty;
                    return;
                };

                // TODO: 컬럼의 이름에 따라 유효한 값을 띄워주는 에러메시지 표현하기
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
