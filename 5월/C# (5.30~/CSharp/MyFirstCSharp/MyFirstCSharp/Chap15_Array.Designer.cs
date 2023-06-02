namespace MyFirstCSharp
{
    partial class Chap15_Array
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
            this.btnArrayF = new System.Windows.Forms.Button();
            this.btnArrayCopy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnArrayF
            // 
            this.btnArrayF.Location = new System.Drawing.Point(28, 23);
            this.btnArrayF.Name = "btnArrayF";
            this.btnArrayF.Size = new System.Drawing.Size(154, 80);
            this.btnArrayF.TabIndex = 0;
            this.btnArrayF.Text = "ArrayFunction";
            this.btnArrayF.UseVisualStyleBackColor = true;
            this.btnArrayF.Click += new System.EventHandler(this.btnArrayF_Click);
            // 
            // btnArrayCopy
            // 
            this.btnArrayCopy.Location = new System.Drawing.Point(206, 23);
            this.btnArrayCopy.Name = "btnArrayCopy";
            this.btnArrayCopy.Size = new System.Drawing.Size(154, 80);
            this.btnArrayCopy.TabIndex = 1;
            this.btnArrayCopy.Text = "ArrayCopy";
            this.btnArrayCopy.UseVisualStyleBackColor = true;
            this.btnArrayCopy.Click += new System.EventHandler(this.btnArrayCopy_Click);
            // 
            // Chap15_Array
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnArrayCopy);
            this.Controls.Add(this.btnArrayF);
            this.Name = "Chap15_Array";
            this.Text = "Chap15_Array";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnArrayF;
        private System.Windows.Forms.Button btnArrayCopy;
    }
}