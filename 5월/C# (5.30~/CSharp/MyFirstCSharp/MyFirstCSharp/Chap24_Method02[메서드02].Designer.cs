namespace MyFirstCSharp
{
    partial class Chap24_Method02_메서드02_
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
            this.btnRef = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.btn_in = new System.Windows.Forms.Button();
            this.btn_TryParse = new System.Windows.Forms.Button();
            this.btn_overloading = new System.Windows.Forms.Button();
            this.btnparams = new System.Windows.Forms.Button();
            this.btn_Generic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRef
            // 
            this.btnRef.Location = new System.Drawing.Point(12, 36);
            this.btnRef.Name = "btnRef";
            this.btnRef.Size = new System.Drawing.Size(99, 112);
            this.btnRef.TabIndex = 0;
            this.btnRef.Text = "ref";
            this.btnRef.UseVisualStyleBackColor = true;
            this.btnRef.Click += new System.EventHandler(this.btnRef_Click);
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(117, 36);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(109, 112);
            this.btnOut.TabIndex = 1;
            this.btnOut.Text = "Out";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // btn_in
            // 
            this.btn_in.Location = new System.Drawing.Point(232, 36);
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(95, 112);
            this.btn_in.TabIndex = 2;
            this.btn_in.Text = "in";
            this.btn_in.UseVisualStyleBackColor = true;
            this.btn_in.Click += new System.EventHandler(this.btn_in_Click);
            // 
            // btn_TryParse
            // 
            this.btn_TryParse.Location = new System.Drawing.Point(333, 36);
            this.btn_TryParse.Name = "btn_TryParse";
            this.btn_TryParse.Size = new System.Drawing.Size(97, 112);
            this.btn_TryParse.TabIndex = 3;
            this.btn_TryParse.Text = "TryParse";
            this.btn_TryParse.UseVisualStyleBackColor = true;
            this.btn_TryParse.Click += new System.EventHandler(this.btn_TryParse_Click);
            // 
            // btn_overloading
            // 
            this.btn_overloading.Location = new System.Drawing.Point(436, 36);
            this.btn_overloading.Name = "btn_overloading";
            this.btn_overloading.Size = new System.Drawing.Size(102, 112);
            this.btn_overloading.TabIndex = 4;
            this.btn_overloading.Text = "OverLoading";
            this.btn_overloading.UseVisualStyleBackColor = true;
            this.btn_overloading.Click += new System.EventHandler(this.btn_overloading_Click);
            // 
            // btnparams
            // 
            this.btnparams.Location = new System.Drawing.Point(13, 173);
            this.btnparams.Name = "btnparams";
            this.btnparams.Size = new System.Drawing.Size(98, 140);
            this.btnparams.TabIndex = 5;
            this.btnparams.Text = "Params";
            this.btnparams.UseVisualStyleBackColor = true;
            this.btnparams.Click += new System.EventHandler(this.btnparams_Click);
            // 
            // btn_Generic
            // 
            this.btn_Generic.Location = new System.Drawing.Point(118, 173);
            this.btn_Generic.Name = "btn_Generic";
            this.btn_Generic.Size = new System.Drawing.Size(108, 140);
            this.btn_Generic.TabIndex = 6;
            this.btn_Generic.Text = "Generic Method";
            this.btn_Generic.UseVisualStyleBackColor = true;
            this.btn_Generic.Click += new System.EventHandler(this.btn_Generic_Click);
            // 
            // Chap24_Method02_메서드02_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Generic);
            this.Controls.Add(this.btnparams);
            this.Controls.Add(this.btn_overloading);
            this.Controls.Add(this.btn_TryParse);
            this.Controls.Add(this.btn_in);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.btnRef);
            this.Name = "Chap24_Method02_메서드02_";
            this.Text = "메서드";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRef;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Button btn_in;
        private System.Windows.Forms.Button btn_TryParse;
        private System.Windows.Forms.Button btn_overloading;
        private System.Windows.Forms.Button btnparams;
        private System.Windows.Forms.Button btn_Generic;
    }
}