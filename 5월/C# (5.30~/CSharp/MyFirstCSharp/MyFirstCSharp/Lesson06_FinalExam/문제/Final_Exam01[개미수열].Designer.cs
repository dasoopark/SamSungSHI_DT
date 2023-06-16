namespace MyFirstCSharp
{
    partial class Final_Exam01
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
            this.btnResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(49, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(678, 95);
            this.label1.TabIndex = 1;
            this.label1.Text = "개미수열은 연속으로 나온 숫자의 갯수를 해당숫자 바로 뒤에 붙여 나열하는 수열입니다. \r\n\r\n예를 들어 입력이 1121인 경우 1이 2개 (12)" +
    " 2가 1개 (21) 그리고 1이 1개 (11) 즉 122111 이 출력 됩니다.\r\n\r\n1부터 시작하여 15 번째의 수열을 메세지 박스로 나타내" +
    " 보세요.";
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(53, 143);
            this.btnResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(674, 41);
            this.btnResult.TabIndex = 2;
            this.btnResult.Text = "개미수열 구하기";
            this.btnResult.UseVisualStyleBackColor = true;
            // 
            // Final_Exam01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 204);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Final_Exam01";
            this.Text = "개미수열";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnResult;
    }
}