namespace MyFirstCSharp
{
    partial class Chap20_MiddleTest_02
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
            this.btn_ssang = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(43, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 144);
            this.label1.TabIndex = 0;
            this.label1.Text = "다음 2차원 배열에 나열된 정수중 \r\n합한 값이 20이 되는 쌍을 모두 구하세요.\r\n(1, 4, 5, 9, 10, 12, 16)\r\n(2, 7, 1" +
    "1, 13, 14, 15, 18)\r\n\r\n중복되는 데이터 쌍을 허용하지 않습니다. \r\n\r\n\r\n";
            // 
            // btn_ssang
            // 
            this.btn_ssang.Location = new System.Drawing.Point(33, 167);
            this.btn_ssang.Name = "btn_ssang";
            this.btn_ssang.Size = new System.Drawing.Size(263, 130);
            this.btn_ssang.TabIndex = 1;
            this.btn_ssang.Text = "중복 미허용 합 20 쌍 구하기";
            this.btn_ssang.UseVisualStyleBackColor = true;
            this.btn_ssang.Click += new System.EventHandler(this.btn_ssang_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(328, 167);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 130);
            this.textBox1.TabIndex = 2;
            // 
            // Chap20_MiddleTest_02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_ssang);
            this.Controls.Add(this.label1);
            this.Name = "Chap20_MiddleTest_02";
            this.Text = "Chap20_MiddleTest_02_T";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ssang;
        private System.Windows.Forms.TextBox textBox1;
    }
}