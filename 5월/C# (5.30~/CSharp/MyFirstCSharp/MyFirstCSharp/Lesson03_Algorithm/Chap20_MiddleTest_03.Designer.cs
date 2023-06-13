namespace MyFirstCSharp
{
    partial class Chap20_MiddleTest_03
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chap20_MiddleTest_03));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.input1 = new System.Windows.Forms.TextBox();
            this.input2 = new System.Windows.Forms.TextBox();
            this.input3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(42, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 144);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 116);
            this.button1.TabIndex = 1;
            this.button1.Text = "난수 생성";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(209, 265);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(100, 21);
            this.input1.TabIndex = 2;
            // 
            // input2
            // 
            this.input2.Location = new System.Drawing.Point(315, 266);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(100, 21);
            this.input2.TabIndex = 3;
            // 
            // input3
            // 
            this.input3.Location = new System.Drawing.Point(421, 266);
            this.input3.Name = "input3";
            this.input3.Size = new System.Drawing.Size(100, 21);
            this.input3.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(527, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 116);
            this.button2.TabIndex = 5;
            this.button2.Text = "결과 보기";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(495, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "3 수의 난수를 모두 받았을 경우 순차적으로 첫번째 텍스트 박스에서 부터 난수를 표현한다.\r\n";
            // 
            // Chap20_MiddleTest_03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.input3);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.input1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Chap20_MiddleTest_03";
            this.Text = "Chap20_MiddleTest_03";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox input1;
        private System.Windows.Forms.TextBox input2;
        private System.Windows.Forms.TextBox input3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
    }
}