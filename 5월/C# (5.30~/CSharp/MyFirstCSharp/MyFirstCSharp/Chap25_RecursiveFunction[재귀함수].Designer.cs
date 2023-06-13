namespace MyFirstCSharp
{
    partial class Chap25_RecursiveFunction
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
            this.fibotext = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnList = new System.Windows.Forms.Button();
            this.btn_outvar = new System.Windows.Forms.Button();
            this.btnRecursive = new System.Windows.Forms.Button();
            this.btnMemoization = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(42, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(678, 120);
            this.label1.TabIndex = 0;
            this.label1.Text = "입력한 숫자 의 피보나치 수열의 값을 구하는 로직을 구현하세요.\r\n\r\n*피보나치 수열 : 0 과 1 로 시작 하는 n 번째 피보나치 수는 바로 직" +
    "전 두 수 의 합을 나타내는 수열\r\n\r\n0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144 .....\r\n";
            // 
            // fibotext
            // 
            this.fibotext.Location = new System.Drawing.Point(58, 199);
            this.fibotext.Name = "fibotext";
            this.fibotext.Size = new System.Drawing.Size(100, 21);
            this.fibotext.TabIndex = 1;
            this.fibotext.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "번째 피보나치 수열 값";
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(308, 202);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(230, 35);
            this.btnList.TabIndex = 3;
            this.btnList.Text = "List를 사용하여 확인하기";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btn_outvar
            // 
            this.btn_outvar.Location = new System.Drawing.Point(308, 243);
            this.btn_outvar.Name = "btn_outvar";
            this.btn_outvar.Size = new System.Drawing.Size(230, 29);
            this.btn_outvar.TabIndex = 4;
            this.btn_outvar.Text = "외부 변수를 이용하여 확인하기";
            this.btn_outvar.UseVisualStyleBackColor = true;
            this.btn_outvar.Click += new System.EventHandler(this.btn_outvar_Click);
            // 
            // btnRecursive
            // 
            this.btnRecursive.Location = new System.Drawing.Point(308, 278);
            this.btnRecursive.Name = "btnRecursive";
            this.btnRecursive.Size = new System.Drawing.Size(230, 34);
            this.btnRecursive.TabIndex = 5;
            this.btnRecursive.Text = "Recursive";
            this.btnRecursive.UseVisualStyleBackColor = true;
            this.btnRecursive.Click += new System.EventHandler(this.btnRecursive_Click);
            // 
            // btnMemoization
            // 
            this.btnMemoization.Location = new System.Drawing.Point(308, 319);
            this.btnMemoization.Name = "btnMemoization";
            this.btnMemoization.Size = new System.Drawing.Size(230, 30);
            this.btnMemoization.TabIndex = 6;
            this.btnMemoization.Text = "메모화 기법을 통한 재귀호출 보완하기";
            this.btnMemoization.UseVisualStyleBackColor = true;
            this.btnMemoization.Click += new System.EventHandler(this.btnMemoization_Click);
            // 
            // Chap25_RecursiveFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMemoization);
            this.Controls.Add(this.btnRecursive);
            this.Controls.Add(this.btn_outvar);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fibotext);
            this.Controls.Add(this.label1);
            this.Name = "Chap25_RecursiveFunction";
            this.Text = "피보나치";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fibotext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btn_outvar;
        private System.Windows.Forms.Button btnRecursive;
        private System.Windows.Forms.Button btnMemoization;
    }
}