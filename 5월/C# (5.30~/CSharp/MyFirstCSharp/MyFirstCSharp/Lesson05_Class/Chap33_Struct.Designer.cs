namespace MyFirstCSharp.Lesson05_Class
{
    partial class Chap33_Struct
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
            this.btn_Struct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Struct
            // 
            this.btn_Struct.Location = new System.Drawing.Point(96, 50);
            this.btn_Struct.Name = "btn_Struct";
            this.btn_Struct.Size = new System.Drawing.Size(386, 170);
            this.btn_Struct.TabIndex = 0;
            this.btn_Struct.Text = "구조체";
            this.btn_Struct.UseVisualStyleBackColor = true;
            this.btn_Struct.Click += new System.EventHandler(this.btn_Struct_Click);
            // 
            // Chap33_Struct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 291);
            this.Controls.Add(this.btn_Struct);
            this.Name = "Chap33_Struct";
            this.Text = "구조체";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Struct;
    }
}