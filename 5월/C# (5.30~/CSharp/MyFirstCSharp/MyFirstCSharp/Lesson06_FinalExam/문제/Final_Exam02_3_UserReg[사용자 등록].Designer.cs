namespace MyFirstCSharp
{ 
    partial class Final_Exam02_3_UserReg

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
            this.btnUserReg = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMailAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUserReg
            // 
            this.btnUserReg.Location = new System.Drawing.Point(83, 109);
            this.btnUserReg.Name = "btnUserReg";
            this.btnUserReg.Size = new System.Drawing.Size(114, 29);
            this.btnUserReg.TabIndex = 0;
            this.btnUserReg.Text = "사용자 등록";
            this.btnUserReg.UseVisualStyleBackColor = true;
            this.btnUserReg.Click += new System.EventHandler(this.btnUserReg_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(203, 109);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(128, 29);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "닫기";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "사용자 ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "사용자 명";
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(83, 3);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(248, 21);
            this.txtUserId.TabIndex = 4;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(83, 30);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(248, 21);
            this.txtUserName.TabIndex = 5;
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(83, 55);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.PasswordChar = '*';
            this.txtPassWord.Size = new System.Drawing.Size(248, 21);
            this.txtPassWord.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "비밀 번호";
            // 
            // txtMailAddress
            // 
            this.txtMailAddress.Location = new System.Drawing.Point(83, 82);
            this.txtMailAddress.Name = "txtMailAddress";
            this.txtMailAddress.Size = new System.Drawing.Size(248, 21);
            this.txtMailAddress.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "메일주소";
            // 
            // Final_Exam02_3_UserReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 149);
            this.Controls.Add(this.txtMailAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUserReg);
            this.Name = "Final_Exam02_3_UserReg";
            this.Text = "사용자 등록";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUserReg;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMailAddress;
        private System.Windows.Forms.Label label4;
    }
}