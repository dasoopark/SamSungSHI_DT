namespace MyFirstCSharp.Lesson05_Class
{
    partial class Chap34_Struct_Apply_UserReg
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
            this.txtuserid = new System.Windows.Forms.TextBox();
            this.textusername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textPassWord = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textUserMail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Register = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "사용자 ID";
            // 
            // txtuserid
            // 
            this.txtuserid.Location = new System.Drawing.Point(118, 56);
            this.txtuserid.Name = "txtuserid";
            this.txtuserid.Size = new System.Drawing.Size(313, 21);
            this.txtuserid.TabIndex = 1;
            // 
            // textusername
            // 
            this.textusername.Location = new System.Drawing.Point(118, 83);
            this.textusername.Name = "textusername";
            this.textusername.Size = new System.Drawing.Size(313, 21);
            this.textusername.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "사용자 명";
            // 
            // textPassWord
            // 
            this.textPassWord.Location = new System.Drawing.Point(118, 110);
            this.textPassWord.Name = "textPassWord";
            this.textPassWord.PasswordChar = '*';
            this.textPassWord.Size = new System.Drawing.Size(313, 21);
            this.textPassWord.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "사용자 비밀번호";
            // 
            // textUserMail
            // 
            this.textUserMail.Location = new System.Drawing.Point(118, 137);
            this.textUserMail.Name = "textUserMail";
            this.textUserMail.Size = new System.Drawing.Size(313, 21);
            this.textUserMail.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "메일주소";
            // 
            // btn_Register
            // 
            this.btn_Register.Location = new System.Drawing.Point(173, 164);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(122, 41);
            this.btn_Register.TabIndex = 8;
            this.btn_Register.Text = "사용자 등록";
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(301, 164);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(130, 41);
            this.btn_cancel.TabIndex = 9;
            this.btn_cancel.Text = "닫기";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // Chap34_Struct_Apply_UserReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 260);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.textUserMail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textPassWord);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textusername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtuserid);
            this.Controls.Add(this.label1);
            this.Name = "Chap34_Struct_Apply_UserReg";
            this.Text = "사용자 등록";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtuserid;
        private System.Windows.Forms.TextBox textusername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textPassWord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textUserMail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.Button btn_cancel;
    }
}