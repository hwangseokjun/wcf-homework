
namespace UI.UserControls
{
    partial class LoadingPanelUserControl
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
            this.loadingIndicator = new UI.Controls.LoadingIndicator();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loadingIndicator
            // 
            this.loadingIndicator.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loadingIndicator.Location = new System.Drawing.Point(8, 9);
            this.loadingIndicator.Name = "loadingIndicator";
            this.loadingIndicator.Size = new System.Drawing.Size(36, 36);
            this.loadingIndicator.TabIndex = 0;
            this.loadingIndicator.Text = "loadingIndicator";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(53, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(108, 19);
            this.label.TabIndex = 1;
            this.label.Text = "PLEASE WAIT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Loading ...";
            // 
            // LoadingPanelUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.loadingIndicator);
            this.Name = "LoadingPanelUserControl";
            this.Size = new System.Drawing.Size(170, 56);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.LoadingIndicator loadingIndicator;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
    }
}
