
namespace UI.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this._btnRegister = new System.Windows.Forms.ToolStripMenuItem();
            this._btnClose = new System.Windows.Forms.ToolStripMenuItem();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.treeUserControl = new UI.UserControls.TreeUserControl();
            this.millCertificateSheetUserControl = new UI.UserControls.MillCertificateSheetUserControl();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._btnRegister,
            this._btnClose});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(710, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // _btnRegister
            // 
            this._btnRegister.Name = "_btnRegister";
            this._btnRegister.Size = new System.Drawing.Size(58, 20);
            this._btnRegister.Text = "등록(R)";
            this._btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // _btnClose
            // 
            this._btnClose.Name = "_btnClose";
            this._btnClose.Size = new System.Drawing.Size(58, 20);
            this._btnClose.Text = "종료(X)";
            this._btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(485, 33);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 2;
            this.monthCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateSelected);
            // 
            // treeUserControl
            // 
            this.treeUserControl.Location = new System.Drawing.Point(485, 207);
            this.treeUserControl.Name = "treeUserControl";
            this.treeUserControl.Size = new System.Drawing.Size(220, 207);
            this.treeUserControl.TabIndex = 3;
            this.treeUserControl.TreePath = null;
            // 
            // millCertificateSheetUserControl
            // 
            this.millCertificateSheetUserControl.Location = new System.Drawing.Point(12, 33);
            this.millCertificateSheetUserControl.Name = "millCertificateSheetUserControl";
            this.millCertificateSheetUserControl.Size = new System.Drawing.Size(467, 381);
            this.millCertificateSheetUserControl.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 420);
            this.Controls.Add(this.treeUserControl);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.millCertificateSheetUserControl);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.MainForm_PreviewKeyDown);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem _btnRegister;
        private System.Windows.Forms.ToolStripMenuItem _btnClose;
        private UserControls.MillCertificateSheetUserControl millCertificateSheetUserControl;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private UserControls.TreeUserControl treeUserControl;
    }
}