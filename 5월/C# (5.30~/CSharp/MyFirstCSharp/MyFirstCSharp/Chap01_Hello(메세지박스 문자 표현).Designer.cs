namespace MyFirstCSharp
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
            this.btnbanga = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "안녕하세용";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // btnbanga
            // 
            this.btnbanga.Location = new System.Drawing.Point(105, 162);
            this.btnbanga.Name = "btnbanga";
            this.btnbanga.Size = new System.Drawing.Size(75, 23);
            this.btnbanga.TabIndex = 1;
            this.btnbanga.Text = "반갑습니다";
            this.btnbanga.UseVisualStyleBackColor = true;
            this.btnbanga.Click += new System.EventHandler(this.btnbanga_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(549, 354);
            this.Controls.Add(this.btnbanga);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHello;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnbanga;
    }
}

