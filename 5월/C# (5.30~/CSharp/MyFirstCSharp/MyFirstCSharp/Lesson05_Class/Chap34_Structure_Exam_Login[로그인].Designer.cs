namespace MyFirstCSharp
{
    partial class Chap34_Structure_Exam_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chap34_Structure_Exam_Login));
            this.label1 = new System.Windows.Forms.Label();
            this.textUserId = new System.Windows.Forms.TextBox();
            this.textUserPW = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_userReg = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "사용자 ID";
            // 
            // textUserId
            // 
            this.textUserId.Location = new System.Drawing.Point(118, 43);
            this.textUserId.Name = "textUserId";
            this.textUserId.Size = new System.Drawing.Size(216, 21);
            this.textUserId.TabIndex = 1;
            // 
            // textUserPW
            // 
            this.textUserPW.Location = new System.Drawing.Point(118, 80);
            this.textUserPW.Name = "textUserPW";
            this.textUserPW.Size = new System.Drawing.Size(216, 21);
            this.textUserPW.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "PW";
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(98, 122);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(97, 23);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "로그인";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_userReg
            // 
            this.btn_userReg.Location = new System.Drawing.Point(215, 122);
            this.btn_userReg.Name = "btn_userReg";
            this.btn_userReg.Size = new System.Drawing.Size(119, 23);
            this.btn_userReg.TabIndex = 5;
            this.btn_userReg.Text = "사용자 등록";
            this.btn_userReg.UseVisualStyleBackColor = true;
            this.btn_userReg.Click += new System.EventHandler(this.btn_userReg_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label3.Location = new System.Drawing.Point(12, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(621, 210);
            this.label3.TabIndex = 6;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // Chap34_Structure_Exam_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 412);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_userReg);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.textUserPW);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textUserId);
            this.Controls.Add(this.label1);
            this.Name = "Chap34_Structure_Exam_Login";
            this.Text = "사용자 로그인";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textUserId;
        private System.Windows.Forms.TextBox textUserPW;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_userReg;
        private System.Windows.Forms.Label label3;
    }
}