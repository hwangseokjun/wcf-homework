
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
            this.btnRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.ToolStripMenuItem();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.treeUserControl = new UI.UserControls.TreeUserControl();
            this.millCertificateSheetUserControl = new UI.UserControls.MillCertificateSheetUserControl();
            this.ucLoadingPanel = new UI.UserControls.LoadingPanelUserControl();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRegister,
            this.btnClose});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(794, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // btnRegister
            // 
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.btnRegister.Size = new System.Drawing.Size(58, 20);
            this.btnRegister.Text = "등록(R)";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnClose
            // 
            this.btnClose.Name = "btnClose";
            this.btnClose.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.btnClose.Size = new System.Drawing.Size(58, 20);
            this.btnClose.Text = "종료(X)";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // monthCalendar
            // 
            this.monthCalendar.BackColor = System.Drawing.SystemColors.Window;
            this.monthCalendar.Location = new System.Drawing.Point(560, 33);
            this.monthCalendar.MaxSelectionCount = 1;
            this.monthCalendar.MinDate = new System.DateTime(1998, 1, 1, 0, 0, 0, 0);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.ShowToday = false;
            this.monthCalendar.TabIndex = 2;
            this.monthCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateSelected);
            // 
            // treeUserControl
            // 
            this.treeUserControl.Location = new System.Drawing.Point(560, 207);
            this.treeUserControl.Name = "treeUserControl";
            this.treeUserControl.Size = new System.Drawing.Size(220, 207);
            this.treeUserControl.TabIndex = 3;
            // 
            // millCertificateSheetUserControl
            // 
            this.millCertificateSheetUserControl.Location = new System.Drawing.Point(12, 33);
            this.millCertificateSheetUserControl.Name = "millCertificateSheetUserControl";
            this.millCertificateSheetUserControl.Size = new System.Drawing.Size(542, 375);
            this.millCertificateSheetUserControl.TabIndex = 1;
            // 
            // ucLoadingPanel
            // 
            this.ucLoadingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucLoadingPanel.Location = new System.Drawing.Point(193, 172);
            this.ucLoadingPanel.Name = "ucLoadingPanel";
            this.ucLoadingPanel.Size = new System.Drawing.Size(170, 56);
            this.ucLoadingPanel.TabIndex = 4;
            this.ucLoadingPanel.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 420);
            this.Controls.Add(this.ucLoadingPanel);
            this.Controls.Add(this.treeUserControl);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.millCertificateSheetUserControl);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem btnRegister;
        private System.Windows.Forms.ToolStripMenuItem btnClose;
        private UserControls.MillCertificateSheetUserControl millCertificateSheetUserControl;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private UserControls.TreeUserControl treeUserControl;
        private UserControls.LoadingPanelUserControl ucLoadingPanel;
    }
}