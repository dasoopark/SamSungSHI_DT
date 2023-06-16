namespace MyFirstCSharp
{
    partial class Chap36_abstractPolymophism
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
            this.btnAbstract = new System.Windows.Forms.Button();
            this.btnUserSearch = new System.Windows.Forms.Button();
            this.btnCustSearch = new System.Windows.Forms.Button();
            this.btnItemSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAbstract
            // 
            this.btnAbstract.Location = new System.Drawing.Point(255, 36);
            this.btnAbstract.Name = "btnAbstract";
            this.btnAbstract.Size = new System.Drawing.Size(137, 85);
            this.btnAbstract.TabIndex = 0;
            this.btnAbstract.Text = "추상화(abstract)";
            this.btnAbstract.UseVisualStyleBackColor = true;
            this.btnAbstract.Click += new System.EventHandler(this.btnAbstract_Click);
            // 
            // btnUserSearch
            // 
            this.btnUserSearch.Location = new System.Drawing.Point(12, 189);
            this.btnUserSearch.Name = "btnUserSearch";
            this.btnUserSearch.Size = new System.Drawing.Size(197, 85);
            this.btnUserSearch.TabIndex = 1;
            this.btnUserSearch.Tag = "UserMaster";
            this.btnUserSearch.Text = "사용자 정보 조회";
            this.btnUserSearch.UseVisualStyleBackColor = true;
            this.btnUserSearch.Click += new System.EventHandler(this.MenuSearch);
            // 
            // btnCustSearch
            // 
            this.btnCustSearch.Location = new System.Drawing.Point(227, 189);
            this.btnCustSearch.Name = "btnCustSearch";
            this.btnCustSearch.Size = new System.Drawing.Size(197, 85);
            this.btnCustSearch.TabIndex = 2;
            this.btnCustSearch.Tag = "CustMaster";
            this.btnCustSearch.Text = "고객 정보 조회";
            this.btnCustSearch.UseVisualStyleBackColor = true;
            this.btnCustSearch.Click += new System.EventHandler(this.MenuSearch);
            // 
            // btnItemSearch
            // 
            this.btnItemSearch.Location = new System.Drawing.Point(441, 189);
            this.btnItemSearch.Name = "btnItemSearch";
            this.btnItemSearch.Size = new System.Drawing.Size(197, 85);
            this.btnItemSearch.TabIndex = 3;
            this.btnItemSearch.Tag = "ItemMaster";
            this.btnItemSearch.Text = "품목 정보 조회";
            this.btnItemSearch.UseVisualStyleBackColor = true;
            this.btnItemSearch.Click += new System.EventHandler(this.MenuSearch);
            // 
            // Chap36_abstractPolymophism
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 325);
            this.Controls.Add(this.btnItemSearch);
            this.Controls.Add(this.btnCustSearch);
            this.Controls.Add(this.btnUserSearch);
            this.Controls.Add(this.btnAbstract);
            this.Name = "Chap36_abstractPolymophism";
            this.Text = "추상화와 다형성";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAbstract;
        private System.Windows.Forms.Button btnUserSearch;
        private System.Windows.Forms.Button btnCustSearch;
        private System.Windows.Forms.Button btnItemSearch;
    }
}