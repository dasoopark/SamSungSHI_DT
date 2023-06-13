namespace MyFirstCSharp
{
    partial class Chap13_switch
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFruit = new System.Windows.Forms.TextBox();
            this.btnIF = new System.Windows.Forms.Button();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "과일이름";
            // 
            // txtFruit
            // 
            this.txtFruit.Location = new System.Drawing.Point(214, 94);
            this.txtFruit.Name = "txtFruit";
            this.txtFruit.Size = new System.Drawing.Size(174, 21);
            this.txtFruit.TabIndex = 1;
            // 
            // btnIF
            // 
            this.btnIF.Location = new System.Drawing.Point(188, 134);
            this.btnIF.Name = "btnIF";
            this.btnIF.Size = new System.Drawing.Size(75, 79);
            this.btnIF.TabIndex = 2;
            this.btnIF.Text = "가격찾기(IF)";
            this.btnIF.UseVisualStyleBackColor = true;
            this.btnIF.Click += new System.EventHandler(this.btnIF_Click);
            // 
            // btnSwitch
            // 
            this.btnSwitch.Location = new System.Drawing.Point(269, 134);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(75, 79);
            this.btnSwitch.TabIndex = 3;
            this.btnSwitch.Text = "가격찾기(Switch)";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // Chap13_switch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.btnIF);
            this.Controls.Add(this.txtFruit);
            this.Controls.Add(this.label1);
            this.Name = "Chap13_switch";
            this.Text = "분기문 switch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFruit;
        private System.Windows.Forms.Button btnIF;
        private System.Windows.Forms.Button btnSwitch;
    }
}