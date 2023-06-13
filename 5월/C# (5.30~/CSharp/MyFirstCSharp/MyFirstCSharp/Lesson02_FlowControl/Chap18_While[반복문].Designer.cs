namespace MyFirstCSharp
{
    partial class Chap18_While
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
            this.btnWhile = new System.Windows.Forms.Button();
            this.btnwhileNoExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWhile
            // 
            this.btnWhile.Location = new System.Drawing.Point(67, 90);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(190, 111);
            this.btnWhile.TabIndex = 0;
            this.btnWhile.Text = "button1";
            this.btnWhile.UseVisualStyleBackColor = true;
            this.btnWhile.Click += new System.EventHandler(this.btnWhile_Click);
            // 
            // btnwhileNoExit
            // 
            this.btnwhileNoExit.Location = new System.Drawing.Point(323, 90);
            this.btnwhileNoExit.Name = "btnwhileNoExit";
            this.btnwhileNoExit.Size = new System.Drawing.Size(194, 111);
            this.btnwhileNoExit.TabIndex = 1;
            this.btnwhileNoExit.Text = "무한루프";
            this.btnwhileNoExit.UseVisualStyleBackColor = true;
            this.btnwhileNoExit.Click += new System.EventHandler(this.btnwhileNoExit_Click);
            // 
            // Chap18_While
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnwhileNoExit);
            this.Controls.Add(this.btnWhile);
            this.Name = "Chap18_While";
            this.Text = "반복문";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWhile;
        private System.Windows.Forms.Button btnwhileNoExit;
    }
}