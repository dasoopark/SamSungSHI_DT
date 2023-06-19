namespace MyFirstCSharp
{
    partial class TestGeneric
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
            this.btn_Generic_one = new System.Windows.Forms.Button();
            this.btn_Generic_two = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Generic_one
            // 
            this.btn_Generic_one.Location = new System.Drawing.Point(110, 66);
            this.btn_Generic_one.Name = "btn_Generic_one";
            this.btn_Generic_one.Size = new System.Drawing.Size(319, 58);
            this.btn_Generic_one.TabIndex = 0;
            this.btn_Generic_one.Text = "제너릭 메서드1";
            this.btn_Generic_one.UseVisualStyleBackColor = true;
            this.btn_Generic_one.Click += new System.EventHandler(this.btn_Generic_one_Click);
            // 
            // btn_Generic_two
            // 
            this.btn_Generic_two.Location = new System.Drawing.Point(110, 146);
            this.btn_Generic_two.Name = "btn_Generic_two";
            this.btn_Generic_two.Size = new System.Drawing.Size(319, 58);
            this.btn_Generic_two.TabIndex = 1;
            this.btn_Generic_two.Text = "제너릭 메서드2";
            this.btn_Generic_two.UseVisualStyleBackColor = true;
            this.btn_Generic_two.Click += new System.EventHandler(this.btn_Generic_two_Click);
            // 
            // TestGeneric
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Generic_two);
            this.Controls.Add(this.btn_Generic_one);
            this.Name = "TestGeneric";
            this.Text = "TestGeneric";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Generic_one;
        private System.Windows.Forms.Button btn_Generic_two;
    }
}