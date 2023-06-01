namespace MyFirstCSharp
{
    partial class Chap09_StringManage_Test
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(4, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(851, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "안녕하세요 2023 제조혁신 인재양성 S/W 개발 교육과정을 이수하게 된 OOO  입니다. 즐겁고 보람찬 DIGITALTRANING 교육이 되었으" +
    "면 합니다.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 82);
            this.button1.TabIndex = 1;
            this.button1.Text = "OOO->본인 이름으로 변경";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(294, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(259, 84);
            this.button2.TabIndex = 2;
            this.button2.Text = "S/W의 위치 찾고 메세지박스, 구현은 IN LINE으로";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(559, 120);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(217, 82);
            this.button3.TabIndex = 3;
            this.button3.Text = "시작 단어와 마지막 단어 각각 1자씩 메세지로 표현";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(85, 221);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(203, 84);
            this.button4.TabIndex = 4;
            this.button4.Text = "타이틀 문자열 의 앞, 뒤 에 -DT-\"문자열 삽입하기";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(294, 221);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(259, 84);
            this.button5.TabIndex = 5;
            this.button5.Text = "DIGITAL_TRAINING만 소문자로 변경  DGITALTRAINING 문자는 고정";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(559, 221);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(217, 84);
            this.button6.TabIndex = 6;
            this.button6.Text = "타이틀의 문자열의 모든 공백 없애기, *라벨TEXT에 직접 표현";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // Chap09_StringManage_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Chap09_StringManage_Test";
            this.Text = "문자열 다루기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}