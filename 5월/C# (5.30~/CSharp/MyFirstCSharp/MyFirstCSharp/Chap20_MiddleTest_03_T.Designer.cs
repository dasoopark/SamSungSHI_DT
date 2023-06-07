namespace MyFirstCSharp
{
    partial class Chap20_MiddleTest_03_T
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chap20_MiddleTest_03_T));
            this.label1 = new System.Windows.Forms.Label();
            this.btnMakeRan = new System.Windows.Forms.Button();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtNum3 = new System.Windows.Forms.TextBox();
            this.btnResult = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(471, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // btnMakeRan
            // 
            this.btnMakeRan.Location = new System.Drawing.Point(15, 105);
            this.btnMakeRan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMakeRan.Name = "btnMakeRan";
            this.btnMakeRan.Size = new System.Drawing.Size(106, 45);
            this.btnMakeRan.TabIndex = 1;
            this.btnMakeRan.Text = "난수 생성";
            this.btnMakeRan.UseVisualStyleBackColor = true;
            this.btnMakeRan.Click += new System.EventHandler(this.btnMakeRan_Click);
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(125, 131);
            this.txtNum1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(107, 21);
            this.txtNum1.TabIndex = 2;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(234, 131);
            this.txtNum2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(107, 21);
            this.txtNum2.TabIndex = 3;
            // 
            // txtNum3
            // 
            this.txtNum3.Location = new System.Drawing.Point(344, 131);
            this.txtNum3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNum3.Name = "txtNum3";
            this.txtNum3.Size = new System.Drawing.Size(107, 21);
            this.txtNum3.TabIndex = 4;
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(454, 105);
            this.btnResult.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(106, 45);
            this.btnResult.TabIndex = 5;
            this.btnResult.Text = "결과 보기";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(499, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = " 3 수의 난수를 모두 받았을 경우 순차적으로 첫번째 텍스트 박스에서 부터 난수를 표현한다.";
            // 
            // Chap20_MiddleTest_03_T
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 199);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.txtNum3);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.btnMakeRan);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Chap20_MiddleTest_03_T";
            this.Text = "난수 생성";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMakeRan;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtNum3;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Label label2;
    }
}