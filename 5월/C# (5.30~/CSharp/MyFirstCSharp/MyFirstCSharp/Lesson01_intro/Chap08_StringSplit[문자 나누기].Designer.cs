namespace MyFirstCSharp
{
    partial class Chap08_StringSplit
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnInterpolation = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.btnLength = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSplit = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.btnSubstring = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(392, 36);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "ABCDEFG/HIJKLMN/OPQRSTU";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnInterpolation);
            this.groupBox4.Location = new System.Drawing.Point(27, 70);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(246, 80);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "문자열 보간";
            // 
            // btnInterpolation
            // 
            this.btnInterpolation.Location = new System.Drawing.Point(12, 27);
            this.btnInterpolation.Name = "btnInterpolation";
            this.btnInterpolation.Size = new System.Drawing.Size(228, 43);
            this.btnInterpolation.TabIndex = 2;
            this.btnInterpolation.Text = "$";
            this.btnInterpolation.UseVisualStyleBackColor = true;
            this.btnInterpolation.Click += new System.EventHandler(this.btnInterpolation_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLength);
            this.groupBox1.Controls.Add(this.txtLength);
            this.groupBox1.Location = new System.Drawing.Point(28, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 122);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Length";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(11, 24);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(206, 28);
            this.txtLength.TabIndex = 0;
            // 
            // btnLength
            // 
            this.btnLength.Location = new System.Drawing.Point(11, 58);
            this.btnLength.Name = "btnLength";
            this.btnLength.Size = new System.Drawing.Size(206, 48);
            this.btnLength.TabIndex = 1;
            this.btnLength.Text = "Length";
            this.btnLength.UseVisualStyleBackColor = true;
            this.btnLength.Click += new System.EventHandler(this.btnLength_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSplit);
            this.groupBox2.Location = new System.Drawing.Point(28, 295);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(239, 105);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Split";
            // 
            // btnSplit
            // 
            this.btnSplit.Location = new System.Drawing.Point(11, 37);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(206, 48);
            this.btnSplit.TabIndex = 2;
            this.btnSplit.Text = "Split";
            this.btnSplit.UseVisualStyleBackColor = true;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSubstring);
            this.groupBox3.Controls.Add(this.txtCount);
            this.groupBox3.Controls.Add(this.txtIndex);
            this.groupBox3.Location = new System.Drawing.Point(31, 415);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(242, 126);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Substring";
            // 
            // txtIndex
            // 
            this.txtIndex.Location = new System.Drawing.Point(2, 27);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(90, 28);
            this.txtIndex.TabIndex = 1;
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(98, 27);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(140, 28);
            this.txtCount.TabIndex = 2;
            // 
            // btnSubstring
            // 
            this.btnSubstring.Location = new System.Drawing.Point(2, 61);
            this.btnSubstring.Name = "btnSubstring";
            this.btnSubstring.Size = new System.Drawing.Size(236, 48);
            this.btnSubstring.TabIndex = 3;
            this.btnSubstring.Text = "Substring";
            this.btnSubstring.UseVisualStyleBackColor = true;
            this.btnSubstring.Click += new System.EventHandler(this.btnSubstring_Click);
            // 
            // Chap08_StringSplit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 553);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lblTitle);
            this.Name = "Chap08_StringSplit";
            this.Text = "문자 나누기";
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnInterpolation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLength;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSubstring;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.TextBox txtIndex;
    }
}