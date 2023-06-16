namespace MyFirstCSharp
{
    partial class Chap35_Inheritance
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
            this.btnInheritance = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInheritance
            // 
            this.btnInheritance.Location = new System.Drawing.Point(38, 38);
            this.btnInheritance.Name = "btnInheritance";
            this.btnInheritance.Size = new System.Drawing.Size(273, 127);
            this.btnInheritance.TabIndex = 0;
            this.btnInheritance.Text = "상속";
            this.btnInheritance.UseVisualStyleBackColor = true;
            this.btnInheritance.Click += new System.EventHandler(this.btnInheritance_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(343, 38);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(264, 127);
            this.btnRandom.TabIndex = 1;
            this.btnRandom.Text = "기존 클래스를 상속받아 새로운 기능 추가하기";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // Chap35_Inheritance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnInheritance);
            this.Name = "Chap35_Inheritance";
            this.Text = "상속";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInheritance;
        private System.Windows.Forms.Button btnRandom;
    }
}