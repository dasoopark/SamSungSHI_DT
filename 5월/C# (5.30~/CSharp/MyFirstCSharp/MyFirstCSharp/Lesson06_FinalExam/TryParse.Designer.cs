namespace MyFirstCSharp.Lesson06_FinalExam
{
    partial class TryParse
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
            this.btn_TryParse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_TryParse
            // 
            this.btn_TryParse.Location = new System.Drawing.Point(154, 79);
            this.btn_TryParse.Name = "btn_TryParse";
            this.btn_TryParse.Size = new System.Drawing.Size(209, 110);
            this.btn_TryParse.TabIndex = 0;
            this.btn_TryParse.Text = "TryParse";
            this.btn_TryParse.UseVisualStyleBackColor = true;
            this.btn_TryParse.Click += new System.EventHandler(this.btn_TryParse_Click);
            // 
            // TryParse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_TryParse);
            this.Name = "TryParse";
            this.Text = "TryParse";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_TryParse;
    }
}