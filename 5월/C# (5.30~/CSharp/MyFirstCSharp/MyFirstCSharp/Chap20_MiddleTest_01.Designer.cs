namespace MyFirstCSharp
{
    partial class Chap20_MiddleTest_01
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
            this.label1 = new System.Windows.Forms.Label();
            this.ssang_guhagi = new System.Windows.Forms.Button();
            this.ssang = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label1.Location = new System.Drawing.Point(64, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 147);
            this.label1.TabIndex = 0;
            this.label1.Text = "다음 1차원 배열에 나열된 정수 중\r\n2개의 데이터를 추출하여\r\n합한 값이 16이 되는 쌍을 모두 구하세요.\r\n(1,4,6,9,10,12,16)\r" +
    "\n\r\n중복되는 데이터 쌍을 허용한다고 가정.\r\n(4,12), (12,4)";
            // 
            // ssang_guhagi
            // 
            this.ssang_guhagi.Location = new System.Drawing.Point(68, 197);
            this.ssang_guhagi.Name = "ssang_guhagi";
            this.ssang_guhagi.Size = new System.Drawing.Size(244, 91);
            this.ssang_guhagi.TabIndex = 1;
            this.ssang_guhagi.Text = "16쌍 구하기";
            this.ssang_guhagi.UseVisualStyleBackColor = true;
            this.ssang_guhagi.Click += new System.EventHandler(this.ssang_guhagi_Click);
            // 
            // ssang
            // 
            this.ssang.Location = new System.Drawing.Point(361, 197);
            this.ssang.Multiline = true;
            this.ssang.Name = "ssang";
            this.ssang.Size = new System.Drawing.Size(231, 180);
            this.ssang.TabIndex = 2;
            // 
            // Chap20_MiddleTest_01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ssang);
            this.Controls.Add(this.ssang_guhagi);
            this.Controls.Add(this.label1);
            this.Name = "Chap20_MiddleTest_01";
            this.Text = "Chap20_MiddleTest_01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ssang_guhagi;
        private System.Windows.Forms.TextBox ssang;
    }
}