namespace MyFirstCSharp
{
    partial class Chap20_MiddleTest_08
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.reversOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "아래의 수를 내림차순으로 정렬하여 텍스트 박스에 표현 하세요.\r\n*Array.Sort, Revers 기능 사용하지 말것.\r\n{1,11,6,20,1" +
    "1,8,12,6,16,13,22}\r\n";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 140);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(347, 21);
            this.textBox1.TabIndex = 1;
            // 
            // reversOrder
            // 
            this.reversOrder.Location = new System.Drawing.Point(14, 63);
            this.reversOrder.Name = "reversOrder";
            this.reversOrder.Size = new System.Drawing.Size(347, 71);
            this.reversOrder.TabIndex = 2;
            this.reversOrder.Text = "내림 차순";
            this.reversOrder.UseVisualStyleBackColor = true;
            this.reversOrder.Click += new System.EventHandler(this.reversOrder_Click);
            // 
            // Chap20_MiddleTest_08
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reversOrder);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Chap20_MiddleTest_08";
            this.Text = "버블정렬 내림차순";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button reversOrder;
    }
}