using System.Windows.Forms;
namespace MyFirstCSharp
{
    partial class Chap99_Final_Exam03
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnApple = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAppCount = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMellon = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMelonCount = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnW_M = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblW_MCount = new System.Windows.Forms.Label();
            this.btnTotalPrice = new System.Windows.Forms.Button();
            this.btnOrderCancle = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.lblCustCash = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnShowTotalMargin = new System.Windows.Forms.Button();
            this.rdoW_M = new System.Windows.Forms.RadioButton();
            this.rdoMelon = new System.Windows.Forms.RadioButton();
            this.rdoApple = new System.Windows.Forms.RadioButton();
            this.btnShowUnitMargin = new System.Windows.Forms.Button();
            this.grpInvoice = new System.Windows.Forms.GroupBox();
            this.BONInvoiceClear = new System.Windows.Forms.Button();
            this.txtAppleInvoieCount = new System.Windows.Forms.TextBox();
            this.btnFruitInvoice = new System.Windows.Forms.Button();
            this.txtW_MInvoieCount = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtMelonInvoieCount = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtOrderList = new System.Windows.Forms.TextBox();
            this.lblManCash = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.grpInvoice.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnApple);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblAppCount);
            this.groupBox1.Location = new System.Drawing.Point(50, 24);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(213, 148);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "사과";
            // 
            // btnApple
            // 
            this.btnApple.Location = new System.Drawing.Point(21, 61);
            this.btnApple.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnApple.Name = "btnApple";
            this.btnApple.Size = new System.Drawing.Size(173, 65);
            this.btnApple.TabIndex = 3;
            this.btnApple.Tag = "사과";
            this.btnApple.Text = "사과 주문";
            this.btnApple.UseVisualStyleBackColor = true;
            this.btnApple.Click += new System.EventHandler(this.btnFruit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "개";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "2000 원 남은 수량 :";
            // 
            // lblAppCount
            // 
            this.lblAppCount.AutoSize = true;
            this.lblAppCount.Location = new System.Drawing.Point(141, 19);
            this.lblAppCount.Name = "lblAppCount";
            this.lblAppCount.Size = new System.Drawing.Size(23, 15);
            this.lblAppCount.TabIndex = 1;
            this.lblAppCount.Text = "10";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMellon);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblMelonCount);
            this.groupBox2.Location = new System.Drawing.Point(270, 24);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(213, 148);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "참외";
            // 
            // btnMellon
            // 
            this.btnMellon.Location = new System.Drawing.Point(21, 61);
            this.btnMellon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMellon.Name = "btnMellon";
            this.btnMellon.Size = new System.Drawing.Size(173, 65);
            this.btnMellon.TabIndex = 3;
            this.btnMellon.Tag = "참외";
            this.btnMellon.Text = "참외 주문";
            this.btnMellon.UseVisualStyleBackColor = true;
            this.btnMellon.Click += new System.EventHandler(this.btnFruit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "개";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "2500 원 남은 수량 :";
            // 
            // lblMelonCount
            // 
            this.lblMelonCount.AutoSize = true;
            this.lblMelonCount.Location = new System.Drawing.Point(141, 19);
            this.lblMelonCount.Name = "lblMelonCount";
            this.lblMelonCount.Size = new System.Drawing.Size(23, 15);
            this.lblMelonCount.TabIndex = 1;
            this.lblMelonCount.Text = "10";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnW_M);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.lblW_MCount);
            this.groupBox3.Location = new System.Drawing.Point(489, 24);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(213, 148);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "수박";
            // 
            // btnW_M
            // 
            this.btnW_M.Location = new System.Drawing.Point(21, 61);
            this.btnW_M.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnW_M.Name = "btnW_M";
            this.btnW_M.Size = new System.Drawing.Size(173, 65);
            this.btnW_M.TabIndex = 3;
            this.btnW_M.Tag = "수박";
            this.btnW_M.Text = "수박 주문";
            this.btnW_M.UseVisualStyleBackColor = true;
            this.btnW_M.Click += new System.EventHandler(this.btnFruit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "개";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "18000 원 남은 수량 :";
            // 
            // lblW_MCount
            // 
            this.lblW_MCount.AutoSize = true;
            this.lblW_MCount.Location = new System.Drawing.Point(141, 19);
            this.lblW_MCount.Name = "lblW_MCount";
            this.lblW_MCount.Size = new System.Drawing.Size(23, 15);
            this.lblW_MCount.TabIndex = 1;
            this.lblW_MCount.Text = "10";
            // 
            // btnTotalPrice
            // 
            this.btnTotalPrice.Location = new System.Drawing.Point(275, 176);
            this.btnTotalPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTotalPrice.Name = "btnTotalPrice";
            this.btnTotalPrice.Size = new System.Drawing.Size(141, 36);
            this.btnTotalPrice.TabIndex = 4;
            this.btnTotalPrice.Text = "총결제 금액 보기";
            this.btnTotalPrice.UseVisualStyleBackColor = true;
            this.btnTotalPrice.Click += new System.EventHandler(this.btnTotalPrice_Click);
            // 
            // btnOrderCancle
            // 
            this.btnOrderCancle.Location = new System.Drawing.Point(427, 178);
            this.btnOrderCancle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOrderCancle.Name = "btnOrderCancle";
            this.btnOrderCancle.Size = new System.Drawing.Size(125, 35);
            this.btnOrderCancle.TabIndex = 15;
            this.btnOrderCancle.Text = "주문 취소 하기";
            this.btnOrderCancle.UseVisualStyleBackColor = true;
            this.btnOrderCancle.Click += new System.EventHandler(this.btnOrderCancle_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(559, 178);
            this.btnBuy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(143, 35);
            this.btnBuy.TabIndex = 14;
            this.btnBuy.Text = "결제 하기";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.lblCustCash);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Controls.Add(this.btnOrderCancle);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.btnBuy);
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Controls.Add(this.btnTotalPrice);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(729, 240);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "고객 주문 현황";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(189, 198);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(22, 15);
            this.label17.TabIndex = 18;
            this.label17.Text = "원";
            // 
            // lblCustCash
            // 
            this.lblCustCash.AutoSize = true;
            this.lblCustCash.Location = new System.Drawing.Point(131, 198);
            this.lblCustCash.Name = "lblCustCash";
            this.lblCustCash.Size = new System.Drawing.Size(55, 15);
            this.lblCustCash.TabIndex = 17;
            this.lblCustCash.Text = "100000";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(54, 198);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 15);
            this.label18.TabIndex = 16;
            this.label18.Text = "고객 잔액";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.grpInvoice);
            this.groupBox5.Controls.Add(this.groupBox7);
            this.groupBox5.Controls.Add(this.lblManCash);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(0, 240);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(729, 361);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "관리자";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnShowTotalMargin);
            this.groupBox6.Controls.Add(this.rdoW_M);
            this.groupBox6.Controls.Add(this.rdoMelon);
            this.groupBox6.Controls.Add(this.rdoApple);
            this.groupBox6.Controls.Add(this.btnShowUnitMargin);
            this.groupBox6.Location = new System.Drawing.Point(362, 172);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Size = new System.Drawing.Size(325, 152);
            this.groupBox6.TabIndex = 24;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "마진 확인";
            // 
            // btnShowTotalMargin
            // 
            this.btnShowTotalMargin.Location = new System.Drawing.Point(15, 96);
            this.btnShowTotalMargin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShowTotalMargin.Name = "btnShowTotalMargin";
            this.btnShowTotalMargin.Size = new System.Drawing.Size(302, 32);
            this.btnShowTotalMargin.TabIndex = 23;
            this.btnShowTotalMargin.Text = "총 마진 보기";
            this.btnShowTotalMargin.UseVisualStyleBackColor = true;
            this.btnShowTotalMargin.Click += new System.EventHandler(this.btnShowTotalMargin_Click);
            // 
            // rdoW_M
            // 
            this.rdoW_M.AutoSize = true;
            this.rdoW_M.Location = new System.Drawing.Point(185, 20);
            this.rdoW_M.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoW_M.Name = "rdoW_M";
            this.rdoW_M.Size = new System.Drawing.Size(58, 19);
            this.rdoW_M.TabIndex = 22;
            this.rdoW_M.TabStop = true;
            this.rdoW_M.Text = "수박";
            this.rdoW_M.UseVisualStyleBackColor = true;
            // 
            // rdoMelon
            // 
            this.rdoMelon.AutoSize = true;
            this.rdoMelon.Location = new System.Drawing.Point(105, 20);
            this.rdoMelon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoMelon.Name = "rdoMelon";
            this.rdoMelon.Size = new System.Drawing.Size(58, 19);
            this.rdoMelon.TabIndex = 21;
            this.rdoMelon.TabStop = true;
            this.rdoMelon.Text = "참외";
            this.rdoMelon.UseVisualStyleBackColor = true;
            // 
            // rdoApple
            // 
            this.rdoApple.AutoSize = true;
            this.rdoApple.Checked = true;
            this.rdoApple.Location = new System.Drawing.Point(24, 20);
            this.rdoApple.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoApple.Name = "rdoApple";
            this.rdoApple.Size = new System.Drawing.Size(58, 19);
            this.rdoApple.TabIndex = 20;
            this.rdoApple.TabStop = true;
            this.rdoApple.Text = "사과";
            this.rdoApple.UseVisualStyleBackColor = true;
            // 
            // btnShowUnitMargin
            // 
            this.btnShowUnitMargin.Location = new System.Drawing.Point(15, 46);
            this.btnShowUnitMargin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShowUnitMargin.Name = "btnShowUnitMargin";
            this.btnShowUnitMargin.Size = new System.Drawing.Size(302, 32);
            this.btnShowUnitMargin.TabIndex = 19;
            this.btnShowUnitMargin.Text = "개별 마진 보기";
            this.btnShowUnitMargin.UseVisualStyleBackColor = true;
            this.btnShowUnitMargin.Click += new System.EventHandler(this.btnShowUnitMargin_Click);
            // 
            // grpInvoice
            // 
            this.grpInvoice.Controls.Add(this.BONInvoiceClear);
            this.grpInvoice.Controls.Add(this.txtAppleInvoieCount);
            this.grpInvoice.Controls.Add(this.btnFruitInvoice);
            this.grpInvoice.Controls.Add(this.txtW_MInvoieCount);
            this.grpInvoice.Controls.Add(this.label21);
            this.grpInvoice.Controls.Add(this.label23);
            this.grpInvoice.Controls.Add(this.label19);
            this.grpInvoice.Controls.Add(this.label24);
            this.grpInvoice.Controls.Add(this.label22);
            this.grpInvoice.Controls.Add(this.txtMelonInvoieCount);
            this.grpInvoice.Controls.Add(this.label20);
            this.grpInvoice.Location = new System.Drawing.Point(365, 31);
            this.grpInvoice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpInvoice.Name = "grpInvoice";
            this.grpInvoice.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpInvoice.Size = new System.Drawing.Size(302, 125);
            this.grpInvoice.TabIndex = 16;
            this.grpInvoice.TabStop = false;
            this.grpInvoice.Text = "발주";
            // 
            // BONInvoiceClear
            // 
            this.BONInvoiceClear.Location = new System.Drawing.Point(201, 72);
            this.BONInvoiceClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BONInvoiceClear.Name = "BONInvoiceClear";
            this.BONInvoiceClear.Size = new System.Drawing.Size(94, 39);
            this.BONInvoiceClear.TabIndex = 14;
            this.BONInvoiceClear.Text = "전체 삭제";
            this.BONInvoiceClear.UseVisualStyleBackColor = true;
            this.BONInvoiceClear.Click += new System.EventHandler(this.BONInvoiceClear_Click);
            // 
            // txtAppleInvoieCount
            // 
            this.txtAppleInvoieCount.Location = new System.Drawing.Point(62, 24);
            this.txtAppleInvoieCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAppleInvoieCount.Name = "txtAppleInvoieCount";
            this.txtAppleInvoieCount.Size = new System.Drawing.Size(100, 25);
            this.txtAppleInvoieCount.TabIndex = 7;
            this.txtAppleInvoieCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnFruitInvoice
            // 
            this.btnFruitInvoice.Location = new System.Drawing.Point(201, 24);
            this.btnFruitInvoice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFruitInvoice.Name = "btnFruitInvoice";
            this.btnFruitInvoice.Size = new System.Drawing.Size(94, 44);
            this.btnFruitInvoice.TabIndex = 3;
            this.btnFruitInvoice.Text = "발주 입고";
            this.btnFruitInvoice.UseVisualStyleBackColor = true;
            this.btnFruitInvoice.Click += new System.EventHandler(this.btnFruitInvoice_Click);
            // 
            // txtW_MInvoieCount
            // 
            this.txtW_MInvoieCount.Location = new System.Drawing.Point(62, 86);
            this.txtW_MInvoieCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtW_MInvoieCount.Name = "txtW_MInvoieCount";
            this.txtW_MInvoieCount.Size = new System.Drawing.Size(100, 25);
            this.txtW_MInvoieCount.TabIndex = 13;
            this.txtW_MInvoieCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 28);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(37, 15);
            this.label21.TabIndex = 4;
            this.label21.Text = "사과";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(168, 89);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(22, 15);
            this.label23.TabIndex = 12;
            this.label23.Text = "개";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(168, 28);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(22, 15);
            this.label19.TabIndex = 6;
            this.label19.Text = "개";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 89);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(37, 15);
            this.label24.TabIndex = 11;
            this.label24.Text = "수박";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 58);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(37, 15);
            this.label22.TabIndex = 8;
            this.label22.Text = "참외";
            // 
            // txtMelonInvoieCount
            // 
            this.txtMelonInvoieCount.Location = new System.Drawing.Point(62, 55);
            this.txtMelonInvoieCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMelonInvoieCount.Name = "txtMelonInvoieCount";
            this.txtMelonInvoieCount.Size = new System.Drawing.Size(100, 25);
            this.txtMelonInvoieCount.TabIndex = 10;
            this.txtMelonInvoieCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(168, 58);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(22, 15);
            this.label20.TabIndex = 9;
            this.label20.Text = "개";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtOrderList);
            this.groupBox7.Location = new System.Drawing.Point(17, 58);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox7.Size = new System.Drawing.Size(337, 272);
            this.groupBox7.TabIndex = 15;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "거래 내역";
            // 
            // txtOrderList
            // 
            this.txtOrderList.Location = new System.Drawing.Point(15, 24);
            this.txtOrderList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOrderList.Multiline = true;
            this.txtOrderList.Name = "txtOrderList";
            this.txtOrderList.Size = new System.Drawing.Size(302, 243);
            this.txtOrderList.TabIndex = 14;
            // 
            // lblManCash
            // 
            this.lblManCash.AutoSize = true;
            this.lblManCash.Location = new System.Drawing.Point(136, 31);
            this.lblManCash.Name = "lblManCash";
            this.lblManCash.Size = new System.Drawing.Size(55, 15);
            this.lblManCash.TabIndex = 2;
            this.lblManCash.Text = "100000";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(187, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(22, 15);
            this.label14.TabIndex = 1;
            this.label14.Text = "원";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(26, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 15);
            this.label13.TabIndex = 0;
            this.label13.Text = "가게 잔액";
            // 
            // Chap99_Final_Exam03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 601);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Chap99_Final_Exam03";
            this.Text = "과일가게 관리";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.grpInvoice.ResumeLayout(false);
            this.grpInvoice.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btnApple;
        private Label label3;
        private Label label1;
        private Label lblAppCount;
        private GroupBox groupBox2;
        private Button btnMellon;
        private Label label2;
        private Label label4;
        private Label lblMelonCount;
        private GroupBox groupBox3;
        private Button btnW_M;
        private Label label5;
        private Label label6;
        private Label lblW_MCount;
        private Button btnTotalPrice;
        private Button btnOrderCancle;
        private Button btnBuy;
        private GroupBox groupBox4;
        private Label label17;
        private Label lblCustCash;
        private Label label18;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
        private Button btnShowTotalMargin;
        private RadioButton rdoW_M;
        private RadioButton rdoMelon;
        private RadioButton rdoApple;
        private Button btnShowUnitMargin;
        private GroupBox grpInvoice;
        private Button BONInvoiceClear;
        private TextBox txtAppleInvoieCount;
        private Button btnFruitInvoice;
        private TextBox txtW_MInvoieCount;
        private Label label21;
        private Label label23;
        private Label label19;
        private Label label24;
        private Label label22;
        private TextBox txtMelonInvoieCount;
        private Label label20;
        private GroupBox groupBox7;
        private TextBox txtOrderList;
        private Label lblManCash;
        private Label label14;
        private Label label13;
    }
}