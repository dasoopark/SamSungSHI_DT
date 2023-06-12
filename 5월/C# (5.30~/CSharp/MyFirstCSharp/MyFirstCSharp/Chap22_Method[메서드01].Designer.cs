namespace MyFirstCSharp
{
    partial class Chap22_Method
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
            this.btnMethodCall = new System.Windows.Forms.Button();
            this.btnPaAr = new System.Windows.Forms.Button();
            this.method_rtn = new System.Windows.Forms.Button();
            this.lbltitle = new System.Windows.Forms.Label();
            this.texttitle = new System.Windows.Forms.TextBox();
            this.btnStringReturn = new System.Windows.Forms.Button();
            this.btnint_rtn = new System.Windows.Forms.Button();
            this.DefaultBtnParameter = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCatch1 = new System.Windows.Forms.Button();
            this.btnCatch2 = new System.Windows.Forms.Button();
            this.btnArrayArgument = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMethodCall
            // 
            this.btnMethodCall.Location = new System.Drawing.Point(24, 36);
            this.btnMethodCall.Name = "btnMethodCall";
            this.btnMethodCall.Size = new System.Drawing.Size(163, 102);
            this.btnMethodCall.TabIndex = 0;
            this.btnMethodCall.Text = "메서드 호출";
            this.btnMethodCall.UseVisualStyleBackColor = true;
            this.btnMethodCall.Click += new System.EventHandler(this.btnMethodCall_Click);
            // 
            // btnPaAr
            // 
            this.btnPaAr.Location = new System.Drawing.Point(225, 36);
            this.btnPaAr.Name = "btnPaAr";
            this.btnPaAr.Size = new System.Drawing.Size(182, 102);
            this.btnPaAr.TabIndex = 1;
            this.btnPaAr.Text = "인수 인자";
            this.btnPaAr.UseVisualStyleBackColor = true;
            this.btnPaAr.Click += new System.EventHandler(this.btnPaAr_Click);
            // 
            // method_rtn
            // 
            this.method_rtn.Location = new System.Drawing.Point(24, 158);
            this.method_rtn.Name = "method_rtn";
            this.method_rtn.Size = new System.Drawing.Size(163, 102);
            this.method_rtn.TabIndex = 2;
            this.method_rtn.Text = "void Return";
            this.method_rtn.UseVisualStyleBackColor = true;
            this.method_rtn.Click += new System.EventHandler(this.method_rtn_Click);
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Location = new System.Drawing.Point(22, 9);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(38, 12);
            this.lbltitle.TabIndex = 3;
            this.lbltitle.Text = "label1";
            // 
            // texttitle
            // 
            this.texttitle.Location = new System.Drawing.Point(66, 9);
            this.texttitle.Name = "texttitle";
            this.texttitle.Size = new System.Drawing.Size(267, 21);
            this.texttitle.TabIndex = 4;
            // 
            // btnStringReturn
            // 
            this.btnStringReturn.Location = new System.Drawing.Point(234, 158);
            this.btnStringReturn.Name = "btnStringReturn";
            this.btnStringReturn.Size = new System.Drawing.Size(173, 102);
            this.btnStringReturn.TabIndex = 5;
            this.btnStringReturn.Text = "String return";
            this.btnStringReturn.UseVisualStyleBackColor = true;
            this.btnStringReturn.Click += new System.EventHandler(this.btnStringReturn_Click);
            // 
            // btnint_rtn
            // 
            this.btnint_rtn.Location = new System.Drawing.Point(434, 158);
            this.btnint_rtn.Name = "btnint_rtn";
            this.btnint_rtn.Size = new System.Drawing.Size(164, 102);
            this.btnint_rtn.TabIndex = 6;
            this.btnint_rtn.Text = "int return";
            this.btnint_rtn.UseVisualStyleBackColor = true;
            this.btnint_rtn.Click += new System.EventHandler(this.btnint_rtn_Click);
            // 
            // DefaultBtnParameter
            // 
            this.DefaultBtnParameter.Location = new System.Drawing.Point(622, 158);
            this.DefaultBtnParameter.Name = "DefaultBtnParameter";
            this.DefaultBtnParameter.Size = new System.Drawing.Size(145, 102);
            this.DefaultBtnParameter.TabIndex = 7;
            this.DefaultBtnParameter.Text = "Default Return";
            this.DefaultBtnParameter.UseVisualStyleBackColor = true;
            this.DefaultBtnParameter.Click += new System.EventHandler(this.DefaultBtnParameter_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCatch2);
            this.groupBox1.Controls.Add(this.btnCatch1);
            this.groupBox1.Location = new System.Drawing.Point(24, 280);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 127);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "클래스를 인수 로 전달하는 경우";
            // 
            // btnCatch1
            // 
            this.btnCatch1.Location = new System.Drawing.Point(25, 41);
            this.btnCatch1.Name = "btnCatch1";
            this.btnCatch1.Size = new System.Drawing.Size(106, 39);
            this.btnCatch1.TabIndex = 0;
            this.btnCatch1.Text = "나잡아 봐라~";
            this.btnCatch1.UseVisualStyleBackColor = true;
            this.btnCatch1.Click += new System.EventHandler(this.btnCatch1_Click);
            // 
            // btnCatch2
            // 
            this.btnCatch2.Location = new System.Drawing.Point(161, 41);
            this.btnCatch2.Name = "btnCatch2";
            this.btnCatch2.Size = new System.Drawing.Size(130, 39);
            this.btnCatch2.TabIndex = 1;
            this.btnCatch2.UseVisualStyleBackColor = true;
            this.btnCatch2.Click += new System.EventHandler(this.btnCatch2_Click);
            // 
            // btnArrayArgument
            // 
            this.btnArrayArgument.Location = new System.Drawing.Point(24, 436);
            this.btnArrayArgument.Name = "btnArrayArgument";
            this.btnArrayArgument.Size = new System.Drawing.Size(150, 99);
            this.btnArrayArgument.TabIndex = 9;
            this.btnArrayArgument.Text = "Array_Argument";
            this.btnArrayArgument.UseVisualStyleBackColor = true;
            this.btnArrayArgument.Click += new System.EventHandler(this.btnArrayArgument_Click);
            // 
            // Chap22_Method
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 619);
            this.Controls.Add(this.btnArrayArgument);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DefaultBtnParameter);
            this.Controls.Add(this.btnint_rtn);
            this.Controls.Add(this.btnStringReturn);
            this.Controls.Add(this.texttitle);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.method_rtn);
            this.Controls.Add(this.btnPaAr);
            this.Controls.Add(this.btnMethodCall);
            this.Name = "Chap22_Method";
            this.Text = "Chap22_Method";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMethodCall;
        private System.Windows.Forms.Button btnPaAr;
        private System.Windows.Forms.Button method_rtn;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.TextBox texttitle;
        private System.Windows.Forms.Button btnStringReturn;
        private System.Windows.Forms.Button btnint_rtn;
        private System.Windows.Forms.Button DefaultBtnParameter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCatch1;
        private System.Windows.Forms.Button btnCatch2;
        private System.Windows.Forms.Button btnArrayArgument;
    }
}