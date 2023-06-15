namespace MyFirstCSharp.Lesson05_Class
{
    partial class Chap32_Property
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
            this.textinqty = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStockQty = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_in = new System.Windows.Forms.Button();
            this.btn_Sale = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textinqty
            // 
            this.textinqty.Location = new System.Drawing.Point(29, 44);
            this.textinqty.Name = "textinqty";
            this.textinqty.Size = new System.Drawing.Size(232, 21);
            this.textinqty.TabIndex = 0;
            this.textinqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "개";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "현재 재고량";
            // 
            // lblStockQty
            // 
            this.lblStockQty.AutoSize = true;
            this.lblStockQty.Location = new System.Drawing.Point(409, 47);
            this.lblStockQty.Name = "lblStockQty";
            this.lblStockQty.Size = new System.Drawing.Size(11, 12);
            this.lblStockQty.TabIndex = 3;
            this.lblStockQty.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(442, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "개";
            // 
            // btn_in
            // 
            this.btn_in.Location = new System.Drawing.Point(78, 134);
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(183, 53);
            this.btn_in.TabIndex = 5;
            this.btn_in.Text = "입고";
            this.btn_in.UseVisualStyleBackColor = true;
            this.btn_in.Click += new System.EventHandler(this.btn_in_Click);
            // 
            // btn_Sale
            // 
            this.btn_Sale.Location = new System.Drawing.Point(313, 134);
            this.btn_Sale.Name = "btn_Sale";
            this.btn_Sale.Size = new System.Drawing.Size(183, 53);
            this.btn_Sale.TabIndex = 6;
            this.btn_Sale.Text = "만화책 판매";
            this.btn_Sale.UseVisualStyleBackColor = true;
            this.btn_Sale.Click += new System.EventHandler(this.btn_Sale_Click);
            // 
            // Chap32_Property
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 223);
            this.Controls.Add(this.btn_Sale);
            this.Controls.Add(this.btn_in);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblStockQty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textinqty);
            this.Name = "Chap32_Property";
            this.Text = "Chap32_Property";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textinqty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStockQty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_in;
        private System.Windows.Forms.Button btn_Sale;
    }
}