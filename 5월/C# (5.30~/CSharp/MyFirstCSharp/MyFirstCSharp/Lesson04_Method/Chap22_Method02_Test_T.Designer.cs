namespace MyFirstCSharp
{
    partial class Chap22_Method02_Test_T
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chap22_Method02_Test_T));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAppleOrder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAppleCnt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMelonOrder = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMelonCnt = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnWMOrder = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblWMCnt = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnTotalPrice = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAppleOrder);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblAppleCnt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(192, 112);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "사과";
            // 
            // btnAppleOrder
            // 
            this.btnAppleOrder.Location = new System.Drawing.Point(12, 44);
            this.btnAppleOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAppleOrder.Name = "btnAppleOrder";
            this.btnAppleOrder.Size = new System.Drawing.Size(155, 54);
            this.btnAppleOrder.TabIndex = 4;
            this.btnAppleOrder.Tag = "사과";
            this.btnAppleOrder.Text = "사과 주문";
            this.btnAppleOrder.UseVisualStyleBackColor = true;
            this.btnAppleOrder.Click += new System.EventHandler(this.btnAppleOrder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "개";
            // 
            // lblAppleCnt
            // 
            this.lblAppleCnt.AutoSize = true;
            this.lblAppleCnt.Location = new System.Drawing.Point(134, 16);
            this.lblAppleCnt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAppleCnt.Name = "lblAppleCnt";
            this.lblAppleCnt.Size = new System.Drawing.Size(17, 12);
            this.lblAppleCnt.TabIndex = 2;
            this.lblAppleCnt.Text = "10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "남은 수량 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "2000 원";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMelonOrder);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblMelonCnt);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(218, 20);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(192, 112);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "참외";
            // 
            // btnMelonOrder
            // 
            this.btnMelonOrder.Location = new System.Drawing.Point(12, 44);
            this.btnMelonOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMelonOrder.Name = "btnMelonOrder";
            this.btnMelonOrder.Size = new System.Drawing.Size(155, 54);
            this.btnMelonOrder.TabIndex = 4;
            this.btnMelonOrder.Tag = "참외";
            this.btnMelonOrder.Text = "참외 주문";
            this.btnMelonOrder.UseVisualStyleBackColor = true;
            this.btnMelonOrder.Click += new System.EventHandler(this.btnAppleOrder_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "개";
            // 
            // lblMelonCnt
            // 
            this.lblMelonCnt.AutoSize = true;
            this.lblMelonCnt.Location = new System.Drawing.Point(134, 16);
            this.lblMelonCnt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMelonCnt.Name = "lblMelonCnt";
            this.lblMelonCnt.Size = new System.Drawing.Size(17, 12);
            this.lblMelonCnt.TabIndex = 2;
            this.lblMelonCnt.Text = "10";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 16);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "남은 수량 :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 16);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "2500 원";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnWMOrder);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.lblWMCnt);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(414, 20);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(192, 112);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "수박";
            // 
            // btnWMOrder
            // 
            this.btnWMOrder.Location = new System.Drawing.Point(12, 44);
            this.btnWMOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnWMOrder.Name = "btnWMOrder";
            this.btnWMOrder.Size = new System.Drawing.Size(155, 54);
            this.btnWMOrder.TabIndex = 4;
            this.btnWMOrder.Tag = "수박";
            this.btnWMOrder.Text = "수박 주문";
            this.btnWMOrder.UseVisualStyleBackColor = true;
            this.btnWMOrder.Click += new System.EventHandler(this.btnAppleOrder_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(158, 16);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "개";
            // 
            // lblWMCnt
            // 
            this.lblWMCnt.AutoSize = true;
            this.lblWMCnt.Location = new System.Drawing.Point(134, 16);
            this.lblWMCnt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWMCnt.Name = "lblWMCnt";
            this.lblWMCnt.Size = new System.Drawing.Size(17, 12);
            this.lblWMCnt.TabIndex = 2;
            this.lblWMCnt.Text = "10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(61, 16);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 1;
            this.label9.Text = "남은 수량 :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 16);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "18000 원";
            // 
            // btnTotalPrice
            // 
            this.btnTotalPrice.Location = new System.Drawing.Point(170, 153);
            this.btnTotalPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTotalPrice.Name = "btnTotalPrice";
            this.btnTotalPrice.Size = new System.Drawing.Size(269, 55);
            this.btnTotalPrice.TabIndex = 7;
            this.btnTotalPrice.Text = "총 결제 금액 보기";
            this.btnTotalPrice.UseVisualStyleBackColor = true;
            this.btnTotalPrice.Click += new System.EventHandler(this.btnTotalPrice_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 254);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(421, 96);
            this.label8.TabIndex = 8;
            this.label8.Text = resources.GetString("label8.Text");
            // 
            // Chap22_Method02_Test_T
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 394);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnTotalPrice);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Chap22_Method02_Test_T";
            this.Text = "Swtich 분기문 실습";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAppleOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAppleCnt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMelonOrder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMelonCnt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnWMOrder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblWMCnt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnTotalPrice;
        private System.Windows.Forms.Label label8;
    }
}