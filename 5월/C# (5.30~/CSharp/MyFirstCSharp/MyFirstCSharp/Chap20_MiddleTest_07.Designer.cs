namespace MyFirstCSharp
{
    partial class Chap20_MiddleTest_07
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
            this.btnResult = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "랜덤함수 0 부터 20 까지의 수를 20개 받아와서 \r\n\r\n배열에 담고, 오름차순으로 정렬하여 텍스트 박스에 표현 후\r\n\r\n배열에 나열된 수 중 " +
    "(0~200) 없는 수를 모두 합한 결과를 메세지 박스로 표현하세요\r\n";
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(68, 127);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(454, 70);
            this.btnResult.TabIndex = 1;
            this.btnResult.Text = "없는 수 합하기";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(68, 203);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(454, 235);
            this.textBox1.TabIndex = 2;
            // 
            // Chap20_MiddleTest_07
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.label1);
            this.Name = "Chap20_MiddleTest_07";
            this.Text = "누락된 숫자 구하기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.TextBox textBox1;
    }
}