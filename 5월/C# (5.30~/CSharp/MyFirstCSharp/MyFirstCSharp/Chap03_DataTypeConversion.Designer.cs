namespace MyFirstCSharp
{
    partial class Chap03_DataTypeConversion
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
            this.btnitos = new System.Windows.Forms.Button();
            this.btnStoI = new System.Windows.Forms.Button();
            this.btnNull = new System.Windows.Forms.Button();
            this.btnSUM_Click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnitos
            // 
            this.btnitos.Location = new System.Drawing.Point(322, 174);
            this.btnitos.Name = "btnitos";
            this.btnitos.Size = new System.Drawing.Size(113, 69);
            this.btnitos.TabIndex = 0;
            this.btnitos.Text = "숫자 -> 문자";
            this.btnitos.UseVisualStyleBackColor = true;
            this.btnitos.Click += new System.EventHandler(this.btnitos_Click);
            // 
            // btnStoI
            // 
            this.btnStoI.Location = new System.Drawing.Point(498, 139);
            this.btnStoI.Name = "btnStoI";
            this.btnStoI.Size = new System.Drawing.Size(75, 139);
            this.btnStoI.TabIndex = 1;
            this.btnStoI.Text = "문자->숫자";
            this.btnStoI.UseVisualStyleBackColor = true;
            this.btnStoI.Click += new System.EventHandler(this.btnStoI_Click);
            // 
            // btnNull
            // 
            this.btnNull.Location = new System.Drawing.Point(104, 161);
            this.btnNull.Name = "btnNull";
            this.btnNull.Size = new System.Drawing.Size(159, 117);
            this.btnNull.TabIndex = 2;
            this.btnNull.Text = "Null 변환 처리";
            this.btnNull.UseVisualStyleBackColor = true;
            this.btnNull.Click += new System.EventHandler(this.btnNull_Click);
            // 
            // btnSUM_Click
            // 
            this.btnSUM_Click.Location = new System.Drawing.Point(634, 139);
            this.btnSUM_Click.Name = "btnSUM_Click";
            this.btnSUM_Click.Size = new System.Drawing.Size(75, 95);
            this.btnSUM_Click.TabIndex = 3;
            this.btnSUM_Click.Text = "SUM";
            this.btnSUM_Click.UseVisualStyleBackColor = true;
            this.btnSUM_Click.Click += new System.EventHandler(this.btnSUM_Click_Click);
            // 
            // Chap03_DataTypeConversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSUM_Click);
            this.Controls.Add(this.btnNull);
            this.Controls.Add(this.btnStoI);
            this.Controls.Add(this.btnitos);
            this.Name = "Chap03_DataTypeConversion";
            this.Text = "Chap03_DataTypeConversion";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnitos;
        private System.Windows.Forms.Button btnStoI;
        private System.Windows.Forms.Button btnNull;
        private System.Windows.Forms.Button btnSUM_Click;
    }
}