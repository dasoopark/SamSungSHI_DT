namespace MyFirstCSharp
{
    partial class Chap12_IF_Test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chap12_IF_Test));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputtxt = new System.Windows.Forms.TextBox();
            this.GongBaeSoo = new System.Windows.Forms.Button();
            this.gob_eight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btncount_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "입력 받을값";
            // 
            // inputtxt
            // 
            this.inputtxt.Location = new System.Drawing.Point(164, 37);
            this.inputtxt.Name = "inputtxt";
            this.inputtxt.Size = new System.Drawing.Size(229, 21);
            this.inputtxt.TabIndex = 2;
            // 
            // GongBaeSoo
            // 
            this.GongBaeSoo.Location = new System.Drawing.Point(454, 37);
            this.GongBaeSoo.Name = "GongBaeSoo";
            this.GongBaeSoo.Size = new System.Drawing.Size(145, 23);
            this.GongBaeSoo.TabIndex = 3;
            this.GongBaeSoo.Text = "2,5의 공배수 인지 판단";
            this.GongBaeSoo.UseVisualStyleBackColor = true;
            this.GongBaeSoo.Click += new System.EventHandler(this.GongBaeSoo_Click);
            // 
            // gob_eight
            // 
            this.gob_eight.Location = new System.Drawing.Point(165, 79);
            this.gob_eight.Name = "gob_eight";
            this.gob_eight.Size = new System.Drawing.Size(228, 21);
            this.gob_eight.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "8의 배수일 경우 값과의 곱";
            // 
            // btncount_txt
            // 
            this.btncount_txt.Location = new System.Drawing.Point(165, 123);
            this.btncount_txt.Name = "btncount_txt";
            this.btncount_txt.Size = new System.Drawing.Size(228, 21);
            this.btncount_txt.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "버튼을 클릭한 총 횟수";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 12);
            this.label5.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(415, 144);
            this.label6.TabIndex = 11;
            this.label6.Text = resources.GetString("label6.Text");
            // 
            // Chap12_IF_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btncount_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gob_eight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GongBaeSoo);
            this.Controls.Add(this.inputtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Chap12_IF_Test";
            this.Text = "Chap12_IF_Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputtxt;
        private System.Windows.Forms.Button GongBaeSoo;
        private System.Windows.Forms.TextBox gob_eight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox btncount_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}