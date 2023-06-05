namespace MyFirstCSharp
{
    partial class Chap17_MatrixTest
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
            this.txtResult = new System.Windows.Forms.TextBox();
            this.change = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.label1.Location = new System.Drawing.Point(233, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 133);
            this.label1.TabIndex = 0;
            this.label1.Text = "아래의 2,4 배열을 만들고 \r\n1행과 2행을 바꾸어 새로운 배열에 담아\r\n배열의 결과를 텍스트 박스에 표현하세요.\r\n\r\n[ 1,2,3,4    " +
    "    ==>   [5,6,7,8\r\n5,6,7,8]                    1,2,3,4]\r\n\r\n";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(227, 240);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(238, 198);
            this.txtResult.TabIndex = 2;
            // 
            // change
            // 
            this.change.Location = new System.Drawing.Point(227, 183);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(238, 56);
            this.change.TabIndex = 3;
            this.change.Text = "변경 하기";
            this.change.UseVisualStyleBackColor = true;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // Chap17_MatrixTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.change);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label1);
            this.Name = "Chap17_MatrixTest";
            this.Text = "배열실습";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button change;
    }
}