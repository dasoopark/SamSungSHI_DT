//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace MyFirstCSharp
//{
   
//    {
//        private int iTotalPrice = 0; // 총 결제 금액
//    private int iCustCash = 100000; // 고객 잔액 금액
//    private int ilManCash = 100000; // 관리자 초기 가게 잔액

//    private Dictionary<string, int> orderHistory = new Dictionary<string, int>();
//    private Dictionary<string, int> purchaseHistory = new Dictionary<string, int>();

//    public Chap99_Final_Exam03()
//    {
//        InitializeComponent();
//    }

//    private void btnFruit_Click(object sender, EventArgs e)
//    {
//        Button btnTemp = (Button)sender;
//        string sFruitName = btnTemp.Tag.ToString();
//        switch (sFruitName)
//        {
//            case "사과":
//                FruitInventoryAdj(lblAppleCount, sFruitName, 2000);
//                break;
//            case "참외":
//                FruitInventoryAdj(lblMelonCount, sFruitName, 2500);
//                break;
//            case "수박":
//                FruitInventoryAdj(lblWatermelonCount, sFruitName, 18000);
//                break;
//        }
//    }

//    void FruitInventoryAdj(Label lblFruitCount, string sFruitName, int iSalePrice)
//    {
//        int iFruitCount = 0;
//        iFruitCount = int.Parse(lblFruitCount.Text);
//        if (iFruitCount == 0)
//        {
//            MessageBox.Show($"{sFruitName}의 재고 수량이 0 입니다. 주문을 할 수 없습니다.");
//            return;
//        }

//        --iFruitCount;

//        lblFruitCount.Text = Convert.ToString(iFruitCount);

//        iTotalPrice += iSalePrice;

//        if (orderHistory.ContainsKey(sFruitName))
//        {
//            orderHistory[sFruitName] += iSalePrice;
//        }
//        else
//        {
//            orderHistory[sFruitName] = iSalePrice;
//        }

//        txtOrder.Text = "";
//        foreach (var fruit in orderHistory)
//        {
//            txtOrder.AppendText($"{fruit.Key}: {fruit.Value}원\r\n");
//        }
//        txtOrder.SelectionStart = txtOrder.Text.Length;
//        txtOrder.ScrollToCaret();
//    }

//    private void btnTotalOrderPrice_Click(object sender, EventArgs e)
//    {
//        int totalOrdered = 0;
//        foreach (var item in orderHistory)
//        {
//            totalOrdered += item.Value;
//        }

//        MessageBox.Show($"총 결재 금액은 {totalOrdered} 입니다.");
//    }

//    private void btnCancelOrder_Click(object sender, EventArgs e)
//    {
//        // 취소 내역이 없을 때
//        if (orderHistory.Count == 0)
//        {
//            MessageBox.Show("취소할 내역이 없습니다.");
//            return;
//        }

//        // 주문 내역 초기화
//        orderHistory.Clear();

//        // 과일 수량 복원
//        lblAppleCount.Text = "10";
//        lblMelonCount.Text = "10";
//        lblWatermelonCount.Text = "10";
//    }

//    private void btnPlaceOrder_Click(object sender, EventArgs e)
//    {
//        if (iTotalPrice > iCustCash)
//        {
//            MessageBox.Show("잔액이 부족합니다. 결제를 할 수 없습니다.");
//            return;
//        }

//        iCustCash -= iTotalPrice;
//        ilManCash += iTotalPrice;
//        iTotalPrice = 0;

//        MessageBox.Show("결제가 완료되었습니다.");
//    }
//}
//}
