namespace MyFirstCSharp
{
    partial class Chap16_Loop_For
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
            this.btnforsum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnforsum
            // 
            this.btnforsum.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnforsum.Location = new System.Drawing.Point(0, 0);
            this.btnforsum.Name = "btnforsum";
            this.btnforsum.Size = new System.Drawing.Size(719, 118);
            this.btnforsum.TabIndex = 0;
            this.btnforsum.Text = "1부터 100까지 더하기";
            this.btnforsum.UseVisualStyleBackColor = true;
            this.btnforsum.Click += new System.EventHandler(this.btnforsum_Click);
            // 
            // Chap16_Loop_For
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 365);
            this.Controls.Add(this.btnforsum);
            this.Name = "Chap16_Loop_For";
            this.Text = "반복문 For";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnforsum;
    }
}