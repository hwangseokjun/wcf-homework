
namespace UI.UserControls
{
    partial class MillCertificateSheetUserControl
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bsMillCertificateSheet = new System.Windows.Forms.BindingSource(this.components);
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvMillCertificateSheet = new System.Windows.Forms.DataGridView();
            this.createdAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issuedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.millSheetNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.txtPage = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bsMillCertificateSheet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMillCertificateSheet)).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bsMillCertificateSheet
            // 
            this.bsMillCertificateSheet.DataSource = typeof(UI.Models.MillCertificateSheet);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(143, 252);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(23, 23);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(3, 252);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(23, 23);
            this.btnPrevious.TabIndex = 7;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(143, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 20);
            this.comboBox1.TabIndex = 6;
            // 
            // textBox1
            // 
            this.tableLayoutPanel.SetColumnSpan(this.textBox1, 2);
            this.textBox1.Location = new System.Drawing.Point(241, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 21);
            this.textBox1.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(375, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 21);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(289, 283);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 22);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "수정";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(375, 283);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 22);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefresh
            // 
            this.tableLayoutPanel.SetColumnSpan(this.btnRefresh, 2);
            this.btnRefresh.Location = new System.Drawing.Point(3, 283);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 22);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "전체";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvMillCertificateSheet
            // 
            this.dgvMillCertificateSheet.AllowUserToAddRows = false;
            this.dgvMillCertificateSheet.AllowUserToDeleteRows = false;
            this.dgvMillCertificateSheet.AutoGenerateColumns = false;
            this.dgvMillCertificateSheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMillCertificateSheet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.projectNoDataGridViewTextBoxColumn,
            this.millSheetNoDataGridViewTextBoxColumn,
            this.issuedDateDataGridViewTextBoxColumn,
            this.createdAtDataGridViewTextBoxColumn});
            this.tableLayoutPanel.SetColumnSpan(this.dgvMillCertificateSheet, 6);
            this.dgvMillCertificateSheet.DataSource = this.bsMillCertificateSheet;
            this.dgvMillCertificateSheet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMillCertificateSheet.Location = new System.Drawing.Point(3, 34);
            this.dgvMillCertificateSheet.Name = "dgvMillCertificateSheet";
            this.dgvMillCertificateSheet.RowTemplate.Height = 23;
            this.dgvMillCertificateSheet.Size = new System.Drawing.Size(472, 212);
            this.dgvMillCertificateSheet.TabIndex = 4;
            // 
            // createdAtDataGridViewTextBoxColumn
            // 
            this.createdAtDataGridViewTextBoxColumn.DataPropertyName = "CreatedAt";
            this.createdAtDataGridViewTextBoxColumn.HeaderText = "최초작성일";
            this.createdAtDataGridViewTextBoxColumn.Name = "createdAtDataGridViewTextBoxColumn";
            // 
            // issuedDateDataGridViewTextBoxColumn
            // 
            this.issuedDateDataGridViewTextBoxColumn.DataPropertyName = "IssuedDate";
            this.issuedDateDataGridViewTextBoxColumn.HeaderText = "발행일";
            this.issuedDateDataGridViewTextBoxColumn.Name = "issuedDateDataGridViewTextBoxColumn";
            // 
            // millSheetNoDataGridViewTextBoxColumn
            // 
            this.millSheetNoDataGridViewTextBoxColumn.DataPropertyName = "MillSheetNo";
            this.millSheetNoDataGridViewTextBoxColumn.HeaderText = "강재번호";
            this.millSheetNoDataGridViewTextBoxColumn.Name = "millSheetNoDataGridViewTextBoxColumn";
            // 
            // projectNoDataGridViewTextBoxColumn
            // 
            this.projectNoDataGridViewTextBoxColumn.DataPropertyName = "ProjectNo";
            this.projectNoDataGridViewTextBoxColumn.HeaderText = "프로젝트번호";
            this.projectNoDataGridViewTextBoxColumn.Name = "projectNoDataGridViewTextBoxColumn";
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 6;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tableLayoutPanel.Controls.Add(this.dgvMillCertificateSheet, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.btnRefresh, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.btnDelete, 5, 3);
            this.tableLayoutPanel.Controls.Add(this.btnUpdate, 4, 3);
            this.tableLayoutPanel.Controls.Add(this.btnSearch, 5, 0);
            this.tableLayoutPanel.Controls.Add(this.textBox1, 3, 0);
            this.tableLayoutPanel.Controls.Add(this.comboBox1, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.btnPrevious, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.btnNext, 2, 2);
            this.tableLayoutPanel.Controls.Add(this.txtPage, 1, 2);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 4;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(452, 312);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // txtPage
            // 
            this.txtPage.Location = new System.Drawing.Point(32, 252);
            this.txtPage.Name = "txtPage";
            this.txtPage.Size = new System.Drawing.Size(105, 21);
            this.txtPage.TabIndex = 9;
            // 
            // MillCertificateSheetUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "MillCertificateSheetUserControl";
            this.Size = new System.Drawing.Size(452, 312);
            ((System.ComponentModel.ISupportInitialize)(this.bsMillCertificateSheet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMillCertificateSheet)).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bsMillCertificateSheet;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.DataGridView dgvMillCertificateSheet;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn millSheetNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn issuedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtPage;
    }
}
