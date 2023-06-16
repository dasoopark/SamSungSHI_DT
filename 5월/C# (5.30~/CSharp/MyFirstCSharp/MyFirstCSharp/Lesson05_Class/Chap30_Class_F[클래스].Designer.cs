namespace MyFirstCSharp
{
    partial class Chap30_Class_F_클래스_
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
            this.btn_ClassCall = new System.Windows.Forms.Button();
            this.btn_classcall_two = new System.Windows.Forms.Button();
            this.btnFieldCall = new System.Windows.Forms.Button();
            this.btn_Class_Call_4 = new System.Windows.Forms.Button();
            this.btn_call_Method = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ClassCall
            // 
            this.btn_ClassCall.Location = new System.Drawing.Point(12, 12);
            this.btn_ClassCall.Name = "btn_ClassCall";
            this.btn_ClassCall.Size = new System.Drawing.Size(754, 53);
            this.btn_ClassCall.TabIndex = 0;
            this.btn_ClassCall.Text = "클래스 객체 생성 및 호출";
            this.btn_ClassCall.UseVisualStyleBackColor = true;
            this.btn_ClassCall.Click += new System.EventHandler(this.btn_ClassCall_Click);
            // 
            // btn_classcall_two
            // 
            this.btn_classcall_two.Location = new System.Drawing.Point(12, 71);
            this.btn_classcall_two.Name = "btn_classcall_two";
            this.btn_classcall_two.Size = new System.Drawing.Size(754, 53);
            this.btn_classcall_two.TabIndex = 1;
            this.btn_classcall_two.Text = "클래스 객체 생성 및 호출 2";
            this.btn_classcall_two.UseVisualStyleBackColor = true;
            this.btn_classcall_two.Click += new System.EventHandler(this.btn_classcall_two_Click);
            // 
            // btnFieldCall
            // 
            this.btnFieldCall.Location = new System.Drawing.Point(12, 130);
            this.btnFieldCall.Name = "btnFieldCall";
            this.btnFieldCall.Size = new System.Drawing.Size(754, 53);
            this.btnFieldCall.TabIndex = 2;
            this.btnFieldCall.Text = "클래스 객체 생성 및 호출 3";
            this.btnFieldCall.UseVisualStyleBackColor = true;
            this.btnFieldCall.Click += new System.EventHandler(this.btnFieldCall_Click);
            // 
            // btn_Class_Call_4
            // 
            this.btn_Class_Call_4.Location = new System.Drawing.Point(12, 189);
            this.btn_Class_Call_4.Name = "btn_Class_Call_4";
            this.btn_Class_Call_4.Size = new System.Drawing.Size(754, 53);
            this.btn_Class_Call_4.TabIndex = 3;
            this.btn_Class_Call_4.Text = "클래스 객체 생성 및 호출 4";
            this.btn_Class_Call_4.UseVisualStyleBackColor = true;
            this.btn_Class_Call_4.Click += new System.EventHandler(this.btn_Class_Call_4_Click);
            // 
            // btn_call_Method
            // 
            this.btn_call_Method.Location = new System.Drawing.Point(12, 248);
            this.btn_call_Method.Name = "btn_call_Method";
            this.btn_call_Method.Size = new System.Drawing.Size(754, 53);
            this.btn_call_Method.TabIndex = 4;
            this.btn_call_Method.Text = "다른 클래스의 메서드 호출하기";
            this.btn_call_Method.UseVisualStyleBackColor = true;
            this.btn_call_Method.Click += new System.EventHandler(this.btn_call_Method_Click);
            // 
            // Chap30_Class_F_클래스_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_call_Method);
            this.Controls.Add(this.btn_Class_Call_4);
            this.Controls.Add(this.btnFieldCall);
            this.Controls.Add(this.btn_classcall_two);
            this.Controls.Add(this.btn_ClassCall);
            this.Name = "Chap30_Class_F_클래스_";
            this.Text = "Chap30_Class_F_클래스_";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ClassCall;
        private System.Windows.Forms.Button btn_classcall_two;
        private System.Windows.Forms.Button btnFieldCall;
        private System.Windows.Forms.Button btn_Class_Call_4;
        private System.Windows.Forms.Button btn_call_Method;
    }
}