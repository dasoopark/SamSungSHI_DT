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
            // Chap22_Method
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPaAr);
            this.Controls.Add(this.btnMethodCall);
            this.Name = "Chap22_Method";
            this.Text = "Chap22_Method";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMethodCall;
        private System.Windows.Forms.Button btnPaAr;
    }
}