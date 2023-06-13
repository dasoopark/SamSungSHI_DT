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
            this.btnNameChange = new System.Windows.Forms.Button();
            this.btnfindswIndex = new System.Windows.Forms.Button();
            this.btnfirst_last = new System.Windows.Forms.Button();
            this.btn_insertDt = new System.Windows.Forms.Button();
            this.btn_changeSo = new System.Windows.Forms.Button();
            this.btn_delTrim = new System.Windows.Forms.Button();
            this.btn_rollback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1186, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "안녕하세요 2023 제조혁신 인재양성 S/W 개발 교육과정을 이수하게 된 OOO  입니다. 즐겁고 보람찬 DIGITALTRANING 교육이 되었으" +
    "면 합니다.";
            // 
            // btnNameChange
            // 
            this.btnNameChange.Location = new System.Drawing.Point(20, 63);
            this.btnNameChange.Margin = new System.Windows.Forms.Padding(2);
            this.btnNameChange.Name = "btnNameChange";
            this.btnNameChange.Size = new System.Drawing.Size(234, 43);
            this.btnNameChange.TabIndex = 1;
            this.btnNameChange.Text = "OOO -> 본인 이름으로 변경\r\n * 라벨 TEXT 에 직접 변경해서 표현";
            this.btnNameChange.UseVisualStyleBackColor = true;
            this.btnNameChange.Click += new System.EventHandler(this.btnNameChange_Click);
            // 
            // btnfindswIndex
            // 
            this.btnfindswIndex.Location = new System.Drawing.Point(295, 63);
            this.btnfindswIndex.Margin = new System.Windows.Forms.Padding(2);
            this.btnfindswIndex.Name = "btnfindswIndex";
            this.btnfindswIndex.Size = new System.Drawing.Size(232, 43);
            this.btnfindswIndex.TabIndex = 2;
            this.btnfindswIndex.Text = "\"S/W\" 의 위치 찾고 메세지박스\r\n * 구현은 In Line 으로 ";
            this.btnfindswIndex.UseVisualStyleBackColor = true;
            this.btnfindswIndex.Click += new System.EventHandler(this.btnfindswIndex_Click);
            // 
            // btnfirst_last
            // 
            this.btnfirst_last.Location = new System.Drawing.Point(20, 110);
            this.btnfirst_last.Margin = new System.Windows.Forms.Padding(2);
            this.btnfirst_last.Name = "btnfirst_last";
            this.btnfirst_last.Size = new System.Drawing.Size(234, 43);
            this.btnfirst_last.TabIndex = 3;
            this.btnfirst_last.Text = "시작 단어 와 마지막 단어 각각 1자씩\r\n메세지 로 표현";
            this.btnfirst_last.UseVisualStyleBackColor = true;
            this.btnfirst_last.Click += new System.EventHandler(this.btnfirst_last_Click);
            // 
            // btn_insertDt
            // 
            this.btn_insertDt.Location = new System.Drawing.Point(295, 110);
            this.btn_insertDt.Margin = new System.Windows.Forms.Padding(2);
            this.btn_insertDt.Name = "btn_insertDt";
            this.btn_insertDt.Size = new System.Drawing.Size(232, 43);
            this.btn_insertDt.TabIndex = 4;
            this.btn_insertDt.Text = "타이틀 문자열 의 앞, 뒤 에 \r\n\"-DT-\" 문자열 삽입\r\n * 라벨 TEXT 에 직접 표현";
            this.btn_insertDt.UseVisualStyleBackColor = true;
            this.btn_insertDt.Click += new System.EventHandler(this.btn_insertDt_Click);
            // 
            // btn_changeSo
            // 
            this.btn_changeSo.Location = new System.Drawing.Point(20, 157);
            this.btn_changeSo.Margin = new System.Windows.Forms.Padding(2);
            this.btn_changeSo.Name = "btn_changeSo";
            this.btn_changeSo.Size = new System.Drawing.Size(234, 43);
            this.btn_changeSo.TabIndex = 5;
            this.btn_changeSo.Text = "DIGITALTRANING 만 소문자로 변경\r\n * DIGITALTRANING 문자는 고정\r\n * 라벨 TEXT 에 직접 표현";
            this.btn_changeSo.UseVisualStyleBackColor = true;
            this.btn_changeSo.Click += new System.EventHandler(this.btn_changeSo_Click);
            // 
            // btn_delTrim
            // 
            this.btn_delTrim.Location = new System.Drawing.Point(295, 157);
            this.btn_delTrim.Margin = new System.Windows.Forms.Padding(2);
            this.btn_delTrim.Name = "btn_delTrim";
            this.btn_delTrim.Size = new System.Drawing.Size(232, 43);
            this.btn_delTrim.TabIndex = 6;
            this.btn_delTrim.Text = "타이틀의 문자열의 모든 공백 없애기\r\n * 라벨 TEXT 에 직접 표현";
            this.btn_delTrim.UseVisualStyleBackColor = true;
            this.btn_delTrim.Click += new System.EventHandler(this.btn_delTrim_Click);
            // 
            // btn_rollback
            // 
            this.btn_rollback.Location = new System.Drawing.Point(79, 205);
            this.btn_rollback.Name = "btn_rollback";
            this.btn_rollback.Size = new System.Drawing.Size(341, 62);
            this.btn_rollback.TabIndex = 7;
            this.btn_rollback.Text = "원본 문자열 되돌리기";
            this.btn_rollback.UseVisualStyleBackColor = true;
            this.btn_rollback.Click += new System.EventHandler(this.btn_rollback_Click);
            // 
            // Chap09_StringManage_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 300);
            this.Controls.Add(this.btn_rollback);
            this.Controls.Add(this.btn_delTrim);
            this.Controls.Add(this.btn_changeSo);
            this.Controls.Add(this.btn_insertDt);
            this.Controls.Add(this.btnfirst_last);
            this.Controls.Add(this.btnfindswIndex);
            this.Controls.Add(this.btnNameChange);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Chap09_StringManage_Test";
            this.Text = "문자열 다루기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNameChange;
        private System.Windows.Forms.Button btnfindswIndex;
        private System.Windows.Forms.Button btnfirst_last;
        private System.Windows.Forms.Button btn_insertDt;
        private System.Windows.Forms.Button btn_changeSo;
        private System.Windows.Forms.Button btn_delTrim;
        private System.Windows.Forms.Button btn_rollback;
    }
}