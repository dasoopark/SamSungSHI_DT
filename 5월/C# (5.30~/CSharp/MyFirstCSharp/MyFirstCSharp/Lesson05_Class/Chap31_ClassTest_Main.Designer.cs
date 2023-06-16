namespace MyFirstCSharp
{
    partial class Chap31_ClassTest_Main
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
            this.btnMonitering = new System.Windows.Forms.Button();
            this.btnRunCall = new System.Windows.Forms.Button();
            this.btnStopCall = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMonitering
            // 
            this.btnMonitering.Location = new System.Drawing.Point(44, 60);
            this.btnMonitering.Name = "btnMonitering";
            this.btnMonitering.Size = new System.Drawing.Size(170, 240);
            this.btnMonitering.TabIndex = 0;
            this.btnMonitering.Text = "설비 상태 확인";
            this.btnMonitering.UseVisualStyleBackColor = true;
            this.btnMonitering.Click += new System.EventHandler(this.btnMonitering_Click);
            // 
            // btnRunCall
            // 
            this.btnRunCall.Location = new System.Drawing.Point(244, 60);
            this.btnRunCall.Name = "btnRunCall";
            this.btnRunCall.Size = new System.Drawing.Size(163, 99);
            this.btnRunCall.TabIndex = 1;
            this.btnRunCall.Text = "가동 화면 호출";
            this.btnRunCall.UseVisualStyleBackColor = true;
            this.btnRunCall.Click += new System.EventHandler(this.btnRunCall_Click);
            // 
            // btnStopCall
            // 
            this.btnStopCall.Location = new System.Drawing.Point(244, 190);
            this.btnStopCall.Name = "btnStopCall";
            this.btnStopCall.Size = new System.Drawing.Size(163, 110);
            this.btnStopCall.TabIndex = 2;
            this.btnStopCall.Text = "정지 화면 호출";
            this.btnStopCall.UseVisualStyleBackColor = true;
            this.btnStopCall.Click += new System.EventHandler(this.btnStopCall_Click);
            // 
            // Chap31_ClassTest_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 381);
            this.Controls.Add(this.btnStopCall);
            this.Controls.Add(this.btnRunCall);
            this.Controls.Add(this.btnMonitering);
            this.Name = "Chap31_ClassTest_Main";
            this.Text = "메인 화면";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMonitering;
        private System.Windows.Forms.Button btnRunCall;
        private System.Windows.Forms.Button btnStopCall;
    }
}