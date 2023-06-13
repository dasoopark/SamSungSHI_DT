namespace MyFirstCSharp
{
    partial class Chap21_Collection_Test_T
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
            this.lbltitle = new System.Windows.Forms.Label();
            this.btnResult1 = new System.Windows.Forms.Button();
            this.btnLastIndexOf = new System.Windows.Forms.Button();
            this.btnDictionary = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(505, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "아래 문자열 에서 중복되지 않는 문자 중 왼쪽에서 가장 첫 문자를 메세지 박스로 나타 내세요";
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbltitle.Location = new System.Drawing.Point(153, 78);
            this.lbltitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(194, 25);
            this.lbltitle.TabIndex = 1;
            this.lbltitle.Text = "ABCLD/EML/BAMDC/";
            // 
            // btnResult1
            // 
            this.btnResult1.Location = new System.Drawing.Point(28, 111);
            this.btnResult1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnResult1.Name = "btnResult1";
            this.btnResult1.Size = new System.Drawing.Size(498, 46);
            this.btnResult1.TabIndex = 2;
            this.btnResult1.Text = "자유 코딩";
            this.btnResult1.UseVisualStyleBackColor = true;
            this.btnResult1.Click += new System.EventHandler(this.btnResult1_Click);
            // 
            // btnLastIndexOf
            // 
            this.btnLastIndexOf.Location = new System.Drawing.Point(28, 161);
            this.btnLastIndexOf.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLastIndexOf.Name = "btnLastIndexOf";
            this.btnLastIndexOf.Size = new System.Drawing.Size(498, 46);
            this.btnLastIndexOf.TabIndex = 3;
            this.btnLastIndexOf.Text = "LastindexOf() 방식";
            this.btnLastIndexOf.UseVisualStyleBackColor = true;
            this.btnLastIndexOf.Click += new System.EventHandler(this.btnLastIndexOf_Click);
            // 
            // btnDictionary
            // 
            this.btnDictionary.Location = new System.Drawing.Point(28, 211);
            this.btnDictionary.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDictionary.Name = "btnDictionary";
            this.btnDictionary.Size = new System.Drawing.Size(498, 53);
            this.btnDictionary.TabIndex = 4;
            this.btnDictionary.Text = "Dictionary 와 Foreach 를 사용";
            this.btnDictionary.UseVisualStyleBackColor = true;
            this.btnDictionary.Click += new System.EventHandler(this.btnDictionary_Click);
            // 
            // Chap21_Collection_Test_T
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 300);
            this.Controls.Add(this.btnDictionary);
            this.Controls.Add(this.btnLastIndexOf);
            this.Controls.Add(this.btnResult1);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Chap21_Collection_Test_T";
            this.Text = "Collection 을 이용한 중복 찾기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Button btnResult1;
        private System.Windows.Forms.Button btnLastIndexOf;
        private System.Windows.Forms.Button btnDictionary;
    }
}