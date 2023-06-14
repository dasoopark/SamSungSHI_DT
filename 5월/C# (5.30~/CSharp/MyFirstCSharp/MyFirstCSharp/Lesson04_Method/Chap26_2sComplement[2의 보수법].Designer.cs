namespace MyFirstCSharp
{
    partial class Chap26_2sComplement_2의_보수법_
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
            this.btnint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnint
            // 
            this.btnint.Location = new System.Drawing.Point(259, 78);
            this.btnint.Name = "btnint";
            this.btnint.Size = new System.Drawing.Size(233, 106);
            this.btnint.TabIndex = 0;
            this.btnint.Text = "int값 확인.";
            this.btnint.UseVisualStyleBackColor = true;
            this.btnint.Click += new System.EventHandler(this.btnint_Click);
            // 
            // Chap26_2sComplement_2의_보수법_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnint);
            this.Name = "Chap26_2sComplement_2의_보수법_";
            this.Text = "Chap26_2sComplement_2의_보수법_";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnint;
    }
}