namespace MyFirstCSharp
{
    partial class Chap23_TryCatchFinally
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
            this.btnSysError = new System.Windows.Forms.Button();
            this.btnTryCatch = new System.Windows.Forms.Button();
            this.btnMethodException = new System.Windows.Forms.Button();
            this.btnException = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSysError
            // 
            this.btnSysError.Location = new System.Drawing.Point(30, 31);
            this.btnSysError.Name = "btnSysError";
            this.btnSysError.Size = new System.Drawing.Size(212, 92);
            this.btnSysError.TabIndex = 0;
            this.btnSysError.Text = "시스템 오류 발생";
            this.btnSysError.UseVisualStyleBackColor = true;
            this.btnSysError.Click += new System.EventHandler(this.btnSysError_Click);
            // 
            // btnTryCatch
            // 
            this.btnTryCatch.Location = new System.Drawing.Point(267, 31);
            this.btnTryCatch.Name = "btnTryCatch";
            this.btnTryCatch.Size = new System.Drawing.Size(212, 92);
            this.btnTryCatch.TabIndex = 1;
            this.btnTryCatch.Text = "예외 처리";
            this.btnTryCatch.UseVisualStyleBackColor = true;
            this.btnTryCatch.Click += new System.EventHandler(this.btnTryCatch_Click);
            // 
            // btnMethodException
            // 
            this.btnMethodException.Location = new System.Drawing.Point(503, 31);
            this.btnMethodException.Name = "btnMethodException";
            this.btnMethodException.Size = new System.Drawing.Size(188, 92);
            this.btnMethodException.TabIndex = 2;
            this.btnMethodException.Text = "메서드의 예외 처리";
            this.btnMethodException.UseVisualStyleBackColor = true;
            this.btnMethodException.Click += new System.EventHandler(this.btnMethodException_Click);
            // 
            // btnException
            // 
            this.btnException.Location = new System.Drawing.Point(30, 166);
            this.btnException.Name = "btnException";
            this.btnException.Size = new System.Drawing.Size(212, 114);
            this.btnException.TabIndex = 3;
            this.btnException.Text = "Exception";
            this.btnException.UseVisualStyleBackColor = true;
            this.btnException.Click += new System.EventHandler(this.btnException_Click);
            // 
            // Chap23_TryCatchFinally
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnException);
            this.Controls.Add(this.btnMethodException);
            this.Controls.Add(this.btnTryCatch);
            this.Controls.Add(this.btnSysError);
            this.Name = "Chap23_TryCatchFinally";
            this.Text = "예외처리";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSysError;
        private System.Windows.Forms.Button btnTryCatch;
        private System.Windows.Forms.Button btnMethodException;
        private System.Windows.Forms.Button btnException;
    }
}