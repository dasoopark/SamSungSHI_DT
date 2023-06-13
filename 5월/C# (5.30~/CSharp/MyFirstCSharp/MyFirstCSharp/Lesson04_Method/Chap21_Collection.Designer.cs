namespace MyFirstCSharp
{
    partial class Chap21_Collection
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
            this.btnList = new System.Windows.Forms.Button();
            this.listll = new System.Windows.Forms.Button();
            this.btnArrayList = new System.Windows.Forms.Button();
            this.Queuebtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnDictionary = new System.Windows.Forms.Button();
            this.btnHash = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnList
            // 
            this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnList.Location = new System.Drawing.Point(30, 29);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(193, 120);
            this.btnList.TabIndex = 0;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // listll
            // 
            this.listll.Location = new System.Drawing.Point(263, 29);
            this.listll.Name = "listll";
            this.listll.Size = new System.Drawing.Size(202, 120);
            this.listll.TabIndex = 1;
            this.listll.Text = "ListTwo";
            this.listll.UseVisualStyleBackColor = true;
            this.listll.Click += new System.EventHandler(this.listll_Click);
            // 
            // btnArrayList
            // 
            this.btnArrayList.Location = new System.Drawing.Point(30, 155);
            this.btnArrayList.Name = "btnArrayList";
            this.btnArrayList.Size = new System.Drawing.Size(193, 120);
            this.btnArrayList.TabIndex = 2;
            this.btnArrayList.Text = "ArrayList";
            this.btnArrayList.UseVisualStyleBackColor = true;
            this.btnArrayList.Click += new System.EventHandler(this.btnArrayList_Click);
            // 
            // Queuebtn
            // 
            this.Queuebtn.Location = new System.Drawing.Point(30, 281);
            this.Queuebtn.Name = "Queuebtn";
            this.Queuebtn.Size = new System.Drawing.Size(193, 124);
            this.Queuebtn.TabIndex = 3;
            this.Queuebtn.Text = "Queue";
            this.Queuebtn.UseVisualStyleBackColor = true;
            this.Queuebtn.Click += new System.EventHandler(this.Queuebtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(254, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 124);
            this.button1.TabIndex = 4;
            this.button1.Text = "Stack";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnDictionary
            // 
            this.BtnDictionary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BtnDictionary.Location = new System.Drawing.Point(30, 429);
            this.BtnDictionary.Name = "BtnDictionary";
            this.BtnDictionary.Size = new System.Drawing.Size(193, 126);
            this.BtnDictionary.TabIndex = 5;
            this.BtnDictionary.Text = "Dictionary";
            this.BtnDictionary.UseVisualStyleBackColor = true;
            this.BtnDictionary.Click += new System.EventHandler(this.BtnDictionary_Click);
            // 
            // btnHash
            // 
            this.btnHash.Location = new System.Drawing.Point(254, 429);
            this.btnHash.Name = "btnHash";
            this.btnHash.Size = new System.Drawing.Size(211, 126);
            this.btnHash.TabIndex = 6;
            this.btnHash.Text = "HashTable";
            this.btnHash.UseVisualStyleBackColor = true;
            this.btnHash.Click += new System.EventHandler(this.btnHash_Click);
            // 
            // Chap21_Collection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnHash);
            this.Controls.Add(this.BtnDictionary);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Queuebtn);
            this.Controls.Add(this.btnArrayList);
            this.Controls.Add(this.listll);
            this.Controls.Add(this.btnList);
            this.Name = "Chap21_Collection";
            this.Text = "Chap21_Collection";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button listll;
        private System.Windows.Forms.Button btnArrayList;
        private System.Windows.Forms.Button Queuebtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnDictionary;
        private System.Windows.Forms.Button btnHash;
    }
}