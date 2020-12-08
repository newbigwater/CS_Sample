namespace Reflection
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
            this.TOP = new Reflection.TEST();
            this.TOP_FRONT = new Reflection.TEST();
            this.TOP_FRONT_LEFT = new Reflection.TEST();
            this.SuspendLayout();
            // 
            // TOP
            // 
            this.TOP.Location = new System.Drawing.Point(13, 13);
            this.TOP.Name = "TOP";
            this.TOP.Size = new System.Drawing.Size(82, 30);
            this.TOP.TabIndex = 0;
            // 
            // TOP_FRONT
            // 
            this.TOP_FRONT.Location = new System.Drawing.Point(13, 50);
            this.TOP_FRONT.Name = "TOP_FRONT";
            this.TOP_FRONT.Size = new System.Drawing.Size(82, 30);
            this.TOP_FRONT.TabIndex = 1;
            // 
            // TOP_FRONT_LEFT
            // 
            this.TOP_FRONT_LEFT.Location = new System.Drawing.Point(13, 87);
            this.TOP_FRONT_LEFT.Name = "TOP_FRONT_LEFT";
            this.TOP_FRONT_LEFT.Size = new System.Drawing.Size(82, 30);
            this.TOP_FRONT_LEFT.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.TOP_FRONT_LEFT);
            this.Controls.Add(this.TOP_FRONT);
            this.Controls.Add(this.TOP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private TEST TOP;
        private TEST TOP_FRONT;
        private TEST TOP_FRONT_LEFT;
    }
}

