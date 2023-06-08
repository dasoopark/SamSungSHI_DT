namespace MyFirstCSharp
{
    partial class Chap21_Collection
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
            this.btnList = new System.Windows.Forms.Button();
            this.listll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(30, 29);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(193, 120);
            this.btnList.TabIndex = 0;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // listll
            // 
            this.listll.Location = new System.Drawing.Point(263, 29);
            this.listll.Name = "listll";
            this.listll.Size = new System.Drawing.Size(202, 120);
            this.listll.TabIndex = 1;
            this.listll.Text = "ListTwo";
            this.listll.UseVisualStyleBackColor = true;
            this.listll.Click += new System.EventHandler(this.listll_Click);
            // 
            // Chap21_Collection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listll);
            this.Controls.Add(this.btnList);
            this.Name = "Chap21_Collection";
            this.Text = "Chap21_Collection";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button listll;
    }
}