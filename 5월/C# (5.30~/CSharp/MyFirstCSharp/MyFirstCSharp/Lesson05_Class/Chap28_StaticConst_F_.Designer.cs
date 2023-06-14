namespace MyFirstCSharp

{
    partial class Chap28_StaticConst_F_
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
            this.btn_step1 = new System.Windows.Forms.Button();
            this.btn_step2 = new System.Windows.Forms.Button();
            this.btn_step3 = new System.Windows.Forms.Button();
            this.btnStatic = new System.Windows.Forms.Button();
            this.btnstatic_call = new System.Windows.Forms.Button();
            this.btn_Static_method_call = new System.Windows.Forms.Button();
            this.btnConst = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_step1
            // 
            this.btn_step1.Location = new System.Drawing.Point(12, 12);
            this.btn_step1.Name = "btn_step1";
            this.btn_step1.Size = new System.Drawing.Size(176, 108);
            this.btn_step1.TabIndex = 0;
            this.btn_step1.Text = "안녕하세요";
            this.btn_step1.UseVisualStyleBackColor = true;
            this.btn_step1.Click += new System.EventHandler(this.btn_step1_Click);
            // 
            // btn_step2
            // 
            this.btn_step2.Location = new System.Drawing.Point(194, 12);
            this.btn_step2.Name = "btn_step2";
            this.btn_step2.Size = new System.Drawing.Size(176, 108);
            this.btn_step2.TabIndex = 1;
            this.btn_step2.Text = "반갑습니다";
            this.btn_step2.UseVisualStyleBackColor = true;
            this.btn_step2.Click += new System.EventHandler(this.btn_step2_Click);
            // 
            // btn_step3
            // 
            this.btn_step3.Location = new System.Drawing.Point(376, 12);
            this.btn_step3.Name = "btn_step3";
            this.btn_step3.Size = new System.Drawing.Size(176, 108);
            this.btn_step3.TabIndex = 2;
            this.btn_step3.Text = "C#프로그래밍";
            this.btn_step3.UseVisualStyleBackColor = true;
            this.btn_step3.Click += new System.EventHandler(this.btn_step3_Click);
            // 
            // btnStatic
            // 
            this.btnStatic.Location = new System.Drawing.Point(12, 148);
            this.btnStatic.Name = "btnStatic";
            this.btnStatic.Size = new System.Drawing.Size(176, 82);
            this.btnStatic.TabIndex = 3;
            this.btnStatic.Text = "정적/인스턴스 필드에 값 대입";
            this.btnStatic.UseVisualStyleBackColor = true;
            this.btnStatic.Click += new System.EventHandler(this.btnStatic_Click);
            // 
            // btnstatic_call
            // 
            this.btnstatic_call.Location = new System.Drawing.Point(194, 148);
            this.btnstatic_call.Name = "btnstatic_call";
            this.btnstatic_call.Size = new System.Drawing.Size(176, 82);
            this.btnstatic_call.TabIndex = 4;
            this.btnstatic_call.Text = "정적/인스턴스 필드 호출";
            this.btnstatic_call.UseVisualStyleBackColor = true;
            this.btnstatic_call.Click += new System.EventHandler(this.btnstatic_call_Click);
            // 
            // btn_Static_method_call
            // 
            this.btn_Static_method_call.Location = new System.Drawing.Point(12, 236);
            this.btn_Static_method_call.Name = "btn_Static_method_call";
            this.btn_Static_method_call.Size = new System.Drawing.Size(176, 96);
            this.btn_Static_method_call.TabIndex = 5;
            this.btn_Static_method_call.Text = "정적 메서드 호출";
            this.btn_Static_method_call.UseVisualStyleBackColor = true;
            this.btn_Static_method_call.Click += new System.EventHandler(this.btn_Static_method_call_Click);
            // 
            // btnConst
            // 
            this.btnConst.Location = new System.Drawing.Point(194, 236);
            this.btnConst.Name = "btnConst";
            this.btnConst.Size = new System.Drawing.Size(176, 96);
            this.btnConst.TabIndex = 6;
            this.btnConst.Text = "상수";
            this.btnConst.UseVisualStyleBackColor = true;
            this.btnConst.Click += new System.EventHandler(this.btnConst_Click);
            // 
            // Chap28_StaticConst_F_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConst);
            this.Controls.Add(this.btn_Static_method_call);
            this.Controls.Add(this.btnstatic_call);
            this.Controls.Add(this.btnStatic);
            this.Controls.Add(this.btn_step3);
            this.Controls.Add(this.btn_step2);
            this.Controls.Add(this.btn_step1);
            this.Name = "Chap28_StaticConst_F_";
            this.Text = "Chap28_StaticConst_F_";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_step1;
        private System.Windows.Forms.Button btn_step2;
        private System.Windows.Forms.Button btn_step3;
        private System.Windows.Forms.Button btnStatic;
        private System.Windows.Forms.Button btnstatic_call;
        private System.Windows.Forms.Button btn_Static_method_call;
        private System.Windows.Forms.Button btnConst;
    }
}