namespace csApp
{
    partial class Form1
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.edtFir = new DevExpress.XtraEditors.TextEdit();
            this.edtSec = new DevExpress.XtraEditors.TextEdit();
            this.edtResult = new DevExpress.XtraEditors.TextEdit();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.edtFir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtSec.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtResult.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(224, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // edtFir
            // 
            this.edtFir.Location = new System.Drawing.Point(12, 12);
            this.edtFir.Name = "edtFir";
            this.edtFir.Size = new System.Drawing.Size(100, 20);
            this.edtFir.TabIndex = 1;
            // 
            // edtSec
            // 
            this.edtSec.Location = new System.Drawing.Point(118, 12);
            this.edtSec.Name = "edtSec";
            this.edtSec.Size = new System.Drawing.Size(100, 20);
            this.edtSec.TabIndex = 2;
            // 
            // edtResult
            // 
            this.edtResult.Location = new System.Drawing.Point(305, 12);
            this.edtResult.Name = "edtResult";
            this.edtResult.Size = new System.Drawing.Size(100, 20);
            this.edtResult.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(224, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.edtResult);
            this.Controls.Add(this.edtSec);
            this.Controls.Add(this.edtFir);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.edtFir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtSec.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtResult.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private DevExpress.XtraEditors.TextEdit edtFir;
        private DevExpress.XtraEditors.TextEdit edtSec;
        private DevExpress.XtraEditors.TextEdit edtResult;
        private System.Windows.Forms.Button button2;
    }
}

