namespace MyFirstCSharp
{
    partial class Chap11_BranchingStatment
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
            this.btnIF_Click = new System.Windows.Forms.Button();
            this.txtBS = new System.Windows.Forms.TextBox();
            this.btn_inif = new System.Windows.Forms.Button();
            this.btnElseif = new System.Windows.Forms.Button();
            this.btnAndif_Click = new System.Windows.Forms.Button();
            this.btnORif = new System.Windows.Forms.Button();
            this.btnbool_if = new System.Windows.Forms.Button();
            this.btnPM = new System.Windows.Forms.Button();
            this.btnhol_jjack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIF_Click
            // 
            this.btnIF_Click.Location = new System.Drawing.Point(45, 34);
            this.btnIF_Click.Name = "btnIF_Click";
            this.btnIF_Click.Size = new System.Drawing.Size(127, 89);
            this.btnIF_Click.TabIndex = 0;
            this.btnIF_Click.Text = "IF";
            this.btnIF_Click.UseVisualStyleBackColor = true;
            this.btnIF_Click.Click += new System.EventHandler(this.btnIF_Click_Click);
            // 
            // txtBS
            // 
            this.txtBS.Location = new System.Drawing.Point(45, 7);
            this.txtBS.Name = "txtBS";
            this.txtBS.Size = new System.Drawing.Size(127, 21);
            this.txtBS.TabIndex = 1;
            // 
            // btn_inif
            // 
            this.btn_inif.Location = new System.Drawing.Point(188, 34);
            this.btn_inif.Name = "btn_inif";
            this.btn_inif.Size = new System.Drawing.Size(148, 89);
            this.btn_inif.TabIndex = 2;
            this.btn_inif.Text = "IN IF";
            this.btn_inif.UseVisualStyleBackColor = true;
            this.btn_inif.Click += new System.EventHandler(this.btn_inif_Click);
            // 
            // btnElseif
            // 
            this.btnElseif.Location = new System.Drawing.Point(357, 34);
            this.btnElseif.Name = "btnElseif";
            this.btnElseif.Size = new System.Drawing.Size(148, 89);
            this.btnElseif.TabIndex = 3;
            this.btnElseif.Text = "else if";
            this.btnElseif.UseVisualStyleBackColor = true;
            this.btnElseif.Click += new System.EventHandler(this.btnElseif_Click);
            // 
            // btnAndif_Click
            // 
            this.btnAndif_Click.Location = new System.Drawing.Point(45, 186);
            this.btnAndif_Click.Name = "btnAndif_Click";
            this.btnAndif_Click.Size = new System.Drawing.Size(127, 97);
            this.btnAndif_Click.TabIndex = 4;
            this.btnAndif_Click.Text = "and if";
            this.btnAndif_Click.UseVisualStyleBackColor = true;
            this.btnAndif_Click.Click += new System.EventHandler(this.btnAndif_Click_Click);
            // 
            // btnORif
            // 
            this.btnORif.Location = new System.Drawing.Point(202, 186);
            this.btnORif.Name = "btnORif";
            this.btnORif.Size = new System.Drawing.Size(134, 97);
            this.btnORif.TabIndex = 5;
            this.btnORif.Text = "OR IF";
            this.btnORif.UseVisualStyleBackColor = true;
            this.btnORif.Click += new System.EventHandler(this.btnORif_Click);
            // 
            // btnbool_if
            // 
            this.btnbool_if.Location = new System.Drawing.Point(357, 186);
            this.btnbool_if.Name = "btnbool_if";
            this.btnbool_if.Size = new System.Drawing.Size(148, 97);
            this.btnbool_if.TabIndex = 6;
            this.btnbool_if.Text = "BOOL IF";
            this.btnbool_if.UseVisualStyleBackColor = true;
            this.btnbool_if.Click += new System.EventHandler(this.btnbool_if_Click);
            // 
            // btnPM
            // 
            this.btnPM.Location = new System.Drawing.Point(45, 302);
            this.btnPM.Name = "btnPM";
            this.btnPM.Size = new System.Drawing.Size(127, 70);
            this.btnPM.TabIndex = 7;
            this.btnPM.Text = "음수/양수 판단";
            this.btnPM.UseVisualStyleBackColor = true;
            this.btnPM.Click += new System.EventHandler(this.btnPM_Click);
            // 
            // btnhol_jjack
            // 
            this.btnhol_jjack.Location = new System.Drawing.Point(202, 302);
            this.btnhol_jjack.Name = "btnhol_jjack";
            this.btnhol_jjack.Size = new System.Drawing.Size(127, 70);
            this.btnhol_jjack.TabIndex = 8;
            this.btnhol_jjack.Text = "홀수 / 짝수 판단";
            this.btnhol_jjack.UseVisualStyleBackColor = true;
            this.btnhol_jjack.Click += new System.EventHandler(this.btnhol_jjack_Click);
            // 
            // Chap11_BranchingStatment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnhol_jjack);
            this.Controls.Add(this.btnPM);
            this.Controls.Add(this.btnbool_if);
            this.Controls.Add(this.btnORif);
            this.Controls.Add(this.btnAndif_Click);
            this.Controls.Add(this.btnElseif);
            this.Controls.Add(this.btn_inif);
            this.Controls.Add(this.txtBS);
            this.Controls.Add(this.btnIF_Click);
            this.Name = "Chap11_BranchingStatment";
            this.Text = "분기문 학습하기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIF_Click;
        private System.Windows.Forms.TextBox txtBS;
        private System.Windows.Forms.Button btn_inif;
        private System.Windows.Forms.Button btnElseif;
        private System.Windows.Forms.Button btnAndif_Click;
        private System.Windows.Forms.Button btnORif;
        private System.Windows.Forms.Button btnbool_if;
        private System.Windows.Forms.Button btnPM;
        private System.Windows.Forms.Button btnhol_jjack;
    }
}