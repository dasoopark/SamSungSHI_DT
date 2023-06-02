namespace MyFirstCSharp
{
    partial class Chap16_Loop_For
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
            this.btnforsum = new System.Windows.Forms.Button();
            this.btnArraySum = new System.Windows.Forms.Button();
            this.txtGuGu = new System.Windows.Forms.TextBox();
            this.GuGu_Btn = new System.Windows.Forms.Button();
            this.btnimmutable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnforsum
            // 
            this.btnforsum.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnforsum.Location = new System.Drawing.Point(0, 0);
            this.btnforsum.Name = "btnforsum";
            this.btnforsum.Size = new System.Drawing.Size(719, 118);
            this.btnforsum.TabIndex = 0;
            this.btnforsum.Text = "1부터 100까지 더하기";
            this.btnforsum.UseVisualStyleBackColor = true;
            this.btnforsum.Click += new System.EventHandler(this.btnforsum_Click);
            // 
            // btnArraySum
            // 
            this.btnArraySum.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnArraySum.Location = new System.Drawing.Point(0, 118);
            this.btnArraySum.Name = "btnArraySum";
            this.btnArraySum.Size = new System.Drawing.Size(719, 80);
            this.btnArraySum.TabIndex = 1;
            this.btnArraySum.Text = "배열 값 더하기";
            this.btnArraySum.UseVisualStyleBackColor = true;
            this.btnArraySum.Click += new System.EventHandler(this.btnArraySum_Click);
            // 
            // txtGuGu
            // 
            this.txtGuGu.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtGuGu.Location = new System.Drawing.Point(0, 198);
            this.txtGuGu.Multiline = true;
            this.txtGuGu.Name = "txtGuGu";
            this.txtGuGu.Size = new System.Drawing.Size(719, 81);
            this.txtGuGu.TabIndex = 2;
            // 
            // GuGu_Btn
            // 
            this.GuGu_Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.GuGu_Btn.Location = new System.Drawing.Point(0, 279);
            this.GuGu_Btn.Name = "GuGu_Btn";
            this.GuGu_Btn.Size = new System.Drawing.Size(719, 23);
            this.GuGu_Btn.TabIndex = 3;
            this.GuGu_Btn.Text = "구구단 표현하기 2~9";
            this.GuGu_Btn.UseVisualStyleBackColor = true;
            this.GuGu_Btn.Click += new System.EventHandler(this.GuGu_Btn_Click);
            // 
            // btnimmutable
            // 
            this.btnimmutable.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnimmutable.Location = new System.Drawing.Point(0, 302);
            this.btnimmutable.Name = "btnimmutable";
            this.btnimmutable.Size = new System.Drawing.Size(719, 23);
            this.btnimmutable.TabIndex = 4;
            this.btnimmutable.Text = "immutable";
            this.btnimmutable.UseVisualStyleBackColor = true;
            this.btnimmutable.Click += new System.EventHandler(this.btnimmutable_Click);
            // 
            // Chap16_Loop_For
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 365);
            this.Controls.Add(this.btnimmutable);
            this.Controls.Add(this.GuGu_Btn);
            this.Controls.Add(this.txtGuGu);
            this.Controls.Add(this.btnArraySum);
            this.Controls.Add(this.btnforsum);
            this.Name = "Chap16_Loop_For";
            this.Text = "반복문 For";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnforsum;
        private System.Windows.Forms.Button btnArraySum;
        private System.Windows.Forms.TextBox txtGuGu;
        private System.Windows.Forms.Button GuGu_Btn;
        private System.Windows.Forms.Button btnimmutable;
    }
}