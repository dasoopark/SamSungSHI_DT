namespace MyFirstCSharp
{
    partial class Chap05_Operator
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
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnSumEuqal = new System.Windows.Forms.Button();
            this.btnMinEqual = new System.Windows.Forms.Button();
            this.btnMulEqual = new System.Windows.Forms.Button();
            this.btnDivEqual = new System.Windows.Forms.Button();
            this.btnPerEqual = new System.Windows.Forms.Button();
            this.btnSS = new System.Windows.Forms.Button();
            this.btnMM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEqual
            // 
            this.btnEqual.Location = new System.Drawing.Point(30, 33);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(89, 61);
            this.btnEqual.TabIndex = 0;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnSumEuqal
            // 
            this.btnSumEuqal.Location = new System.Drawing.Point(138, 33);
            this.btnSumEuqal.Name = "btnSumEuqal";
            this.btnSumEuqal.Size = new System.Drawing.Size(89, 61);
            this.btnSumEuqal.TabIndex = 0;
            this.btnSumEuqal.Text = "+=";
            this.btnSumEuqal.UseVisualStyleBackColor = true;
            this.btnSumEuqal.Click += new System.EventHandler(this.btnSumEuqal_Click);
            // 
            // btnMinEqual
            // 
            this.btnMinEqual.Location = new System.Drawing.Point(30, 110);
            this.btnMinEqual.Name = "btnMinEqual";
            this.btnMinEqual.Size = new System.Drawing.Size(89, 61);
            this.btnMinEqual.TabIndex = 1;
            this.btnMinEqual.Text = "-=";
            this.btnMinEqual.UseVisualStyleBackColor = true;
            this.btnMinEqual.Click += new System.EventHandler(this.btnMinEqual_Click);
            // 
            // btnMulEqual
            // 
            this.btnMulEqual.Location = new System.Drawing.Point(138, 110);
            this.btnMulEqual.Name = "btnMulEqual";
            this.btnMulEqual.Size = new System.Drawing.Size(89, 61);
            this.btnMulEqual.TabIndex = 2;
            this.btnMulEqual.Text = "*=";
            this.btnMulEqual.UseVisualStyleBackColor = true;
            this.btnMulEqual.Click += new System.EventHandler(this.btnMulEqual_Click);
            // 
            // btnDivEqual
            // 
            this.btnDivEqual.Location = new System.Drawing.Point(30, 189);
            this.btnDivEqual.Name = "btnDivEqual";
            this.btnDivEqual.Size = new System.Drawing.Size(89, 61);
            this.btnDivEqual.TabIndex = 3;
            this.btnDivEqual.Text = "/=";
            this.btnDivEqual.UseVisualStyleBackColor = true;
            this.btnDivEqual.Click += new System.EventHandler(this.btnDivEqual_Click);
            // 
            // btnPerEqual
            // 
            this.btnPerEqual.Location = new System.Drawing.Point(138, 189);
            this.btnPerEqual.Name = "btnPerEqual";
            this.btnPerEqual.Size = new System.Drawing.Size(89, 61);
            this.btnPerEqual.TabIndex = 4;
            this.btnPerEqual.Text = "%=";
            this.btnPerEqual.UseVisualStyleBackColor = true;
            this.btnPerEqual.Click += new System.EventHandler(this.btnPerEqual_Click);
            // 
            // btnSS
            // 
            this.btnSS.Location = new System.Drawing.Point(30, 265);
            this.btnSS.Name = "btnSS";
            this.btnSS.Size = new System.Drawing.Size(89, 61);
            this.btnSS.TabIndex = 5;
            this.btnSS.Text = "++";
            this.btnSS.UseVisualStyleBackColor = true;
            this.btnSS.Click += new System.EventHandler(this.btnSS_Click);
            // 
            // btnMM
            // 
            this.btnMM.Location = new System.Drawing.Point(138, 265);
            this.btnMM.Name = "btnMM";
            this.btnMM.Size = new System.Drawing.Size(89, 61);
            this.btnMM.TabIndex = 6;
            this.btnMM.Text = "--";
            this.btnMM.UseVisualStyleBackColor = true;
            this.btnMM.Click += new System.EventHandler(this.btnMM_Click);
            // 
            // Chap05_Operator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 357);
            this.Controls.Add(this.btnMM);
            this.Controls.Add(this.btnSS);
            this.Controls.Add(this.btnPerEqual);
            this.Controls.Add(this.btnDivEqual);
            this.Controls.Add(this.btnMulEqual);
            this.Controls.Add(this.btnMinEqual);
            this.Controls.Add(this.btnSumEuqal);
            this.Controls.Add(this.btnEqual);
            this.Name = "Chap05_Operator";
            this.Text = "연산자 학습";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnSumEuqal;
        private System.Windows.Forms.Button btnMinEqual;
        private System.Windows.Forms.Button btnMulEqual;
        private System.Windows.Forms.Button btnDivEqual;
        private System.Windows.Forms.Button btnPerEqual;
        private System.Windows.Forms.Button btnSS;
        private System.Windows.Forms.Button btnMM;
    }
}