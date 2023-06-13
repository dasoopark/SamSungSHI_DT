namespace MyFirstCSharp
{
    partial class Chap22_Method01_Test
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnTwo_M = new System.Windows.Forms.Button();
            this.btnFive_M = new System.Windows.Forms.Button();
            this.btnTen_M = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(29, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(546, 88);
            this.label1.TabIndex = 0;
            this.label1.Text = "반복문을 (For, While) 한번만 코딩하여 (소스내에서 반복문이 한번만 보이도록)\r\n범위 안의 수 중 2, 5, 10의 배수의 합을 버튼을 " +
    "클릭하였을 때 메세지 박스로 표현하세요\r\n  * 텍스트 박스의 문자는 숫자만 입력\r\n  * 음수는 입력 받을수 없다.\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "입력 받을 범위";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "~";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(148, 149);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 21);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(365, 149);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(161, 21);
            this.textBox2.TabIndex = 4;
            // 
            // btnTwo_M
            // 
            this.btnTwo_M.Location = new System.Drawing.Point(33, 201);
            this.btnTwo_M.Name = "btnTwo_M";
            this.btnTwo_M.Size = new System.Drawing.Size(172, 30);
            this.btnTwo_M.TabIndex = 5;
            this.btnTwo_M.Text = "2의 배수 표현";
            this.btnTwo_M.UseVisualStyleBackColor = true;
            this.btnTwo_M.Click += new System.EventHandler(this.btnTwo_M_Click);
            // 
            // btnFive_M
            // 
            this.btnFive_M.Location = new System.Drawing.Point(227, 201);
            this.btnFive_M.Name = "btnFive_M";
            this.btnFive_M.Size = new System.Drawing.Size(172, 30);
            this.btnFive_M.TabIndex = 6;
            this.btnFive_M.Text = "5의 배수 표현";
            this.btnFive_M.UseVisualStyleBackColor = true;
            this.btnFive_M.Click += new System.EventHandler(this.btnFive_M_Click);
            // 
            // btnTen_M
            // 
            this.btnTen_M.Location = new System.Drawing.Point(424, 201);
            this.btnTen_M.Name = "btnTen_M";
            this.btnTen_M.Size = new System.Drawing.Size(172, 30);
            this.btnTen_M.TabIndex = 7;
            this.btnTen_M.Text = "10의 배수 표현";
            this.btnTen_M.UseVisualStyleBackColor = true;
            this.btnTen_M.Click += new System.EventHandler(this.btnTen_M_Click);
            // 
            // Chap22_Method01_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTen_M);
            this.Controls.Add(this.btnFive_M);
            this.Controls.Add(this.btnTwo_M);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Chap22_Method01_Test";
            this.Text = "메서드 응용하기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnTwo_M;
        private System.Windows.Forms.Button btnFive_M;
        private System.Windows.Forms.Button btnTen_M;
    }
}