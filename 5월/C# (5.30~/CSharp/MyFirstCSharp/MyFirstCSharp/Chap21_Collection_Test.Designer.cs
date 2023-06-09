namespace MyFirstCSharp
{
    partial class Chap21_Collection_Test
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
            this.btndup = new System.Windows.Forms.Button();
            this.btnLastIndex = new System.Windows.Forms.Button();
            this.btn_DicForeach = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(493, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "아래 문자열 중 중복되지 않는 문자 중 왼쪽에서 가장 첫 문자를 메세지 박스로 나타내세요.\r\n";
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("맑은 고딕", 13F);
            this.lbltitle.Location = new System.Drawing.Point(180, 101);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(188, 25);
            this.lbltitle.TabIndex = 1;
            this.lbltitle.Text = "ABCLD/EML/BAMDC/";
            // 
            // btndup
            // 
            this.btndup.Location = new System.Drawing.Point(43, 144);
            this.btndup.Name = "btndup";
            this.btndup.Size = new System.Drawing.Size(491, 71);
            this.btndup.TabIndex = 2;
            this.btndup.Text = "자유코딩";
            this.btndup.UseVisualStyleBackColor = true;
            this.btndup.Click += new System.EventHandler(this.btndup_Click);
            // 
            // btnLastIndex
            // 
            this.btnLastIndex.Location = new System.Drawing.Point(43, 222);
            this.btnLastIndex.Name = "btnLastIndex";
            this.btnLastIndex.Size = new System.Drawing.Size(491, 69);
            this.btnLastIndex.TabIndex = 3;
            this.btnLastIndex.Text = "LastIndexOf()방식";
            this.btnLastIndex.UseVisualStyleBackColor = true;
            this.btnLastIndex.Click += new System.EventHandler(this.btnLastIndex_Click);
            // 
            // btn_DicForeach
            // 
            this.btn_DicForeach.Location = new System.Drawing.Point(43, 297);
            this.btn_DicForeach.Name = "btn_DicForeach";
            this.btn_DicForeach.Size = new System.Drawing.Size(491, 70);
            this.btn_DicForeach.TabIndex = 4;
            this.btn_DicForeach.Text = "Dictionary와 Foreach를 사용";
            this.btn_DicForeach.UseVisualStyleBackColor = true;
            this.btn_DicForeach.Click += new System.EventHandler(this.btn_DicForeach_Click);
            // 
            // Chap21_Collection_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_DicForeach);
            this.Controls.Add(this.btnLastIndex);
            this.Controls.Add(this.btndup);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.label1);
            this.Name = "Chap21_Collection_Test";
            this.Text = "Chap21_Collection_Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Button btndup;
        private System.Windows.Forms.Button btnLastIndex;
        private System.Windows.Forms.Button btn_DicForeach;
    }
}