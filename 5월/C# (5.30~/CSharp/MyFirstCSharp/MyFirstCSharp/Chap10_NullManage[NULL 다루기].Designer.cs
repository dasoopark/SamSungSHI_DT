namespace MyFirstCSharp
{
    partial class Chap10_NullManage
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
            this.btnHasValue = new System.Windows.Forms.Button();
            this.btnNull = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHasValue
            // 
            this.btnHasValue.Location = new System.Drawing.Point(195, 123);
            this.btnHasValue.Name = "btnHasValue";
            this.btnHasValue.Size = new System.Drawing.Size(166, 93);
            this.btnHasValue.TabIndex = 0;
            this.btnHasValue.Text = "HasValue";
            this.btnHasValue.UseVisualStyleBackColor = true;
            this.btnHasValue.Click += new System.EventHandler(this.btnHasValue_Click);
            // 
            // btnNull
            // 
            this.btnNull.Location = new System.Drawing.Point(397, 123);
            this.btnNull.Name = "btnNull";
            this.btnNull.Size = new System.Drawing.Size(205, 93);
            this.btnNull.TabIndex = 1;
            this.btnNull.Text = "Null 병합 연산자 ??";
            this.btnNull.UseVisualStyleBackColor = true;
            this.btnNull.Click += new System.EventHandler(this.btnNull_Click);
            // 
            // Chap10_NullManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNull);
            this.Controls.Add(this.btnHasValue);
            this.Name = "Chap10_NullManage";
            this.Text = "Chap10_NullManage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHasValue;
        private System.Windows.Forms.Button btnNull;
    }
}