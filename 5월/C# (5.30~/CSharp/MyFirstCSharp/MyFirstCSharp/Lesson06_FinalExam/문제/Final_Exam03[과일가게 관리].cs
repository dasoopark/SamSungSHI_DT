using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MyFirstCSharp
{
    public partial class Chap99_Final_Exam03 : Form
    {
        private int iTotalPrice = 0; // 총 결제 금액  
        private int iCustCash = 100000; // 고객 잔액 금액
        private int ilManCash = 100000; // 관리자 초기 가게 잔액.

        private Dictionary<string, order_FruitInfo> purchase_list = new Dictionary<string, order_FruitInfo>(); //값에, 과일 정보(가격,개수)를 받는 딕셔너리
        private Dictionary<string, order_FruitInfo> cancel_Temp = new Dictionary<string, order_FruitInfo>(); //취소를 하기 위해, 결제 완료 전 정보를 입력받는 딕셔너리
        private Dictionary<string, order_FruitInfo> orderHistory = new Dictionary<string, order_FruitInfo>(); //텍스트 박스에 구매한 것들을 누적시키기 위해 사용하는 딕셔너리
        private Dictionary<string, order_FruitInfo> baljoolist = new Dictionary<string, order_FruitInfo>(); // 발주 수량을 저장하는 딕셔너리

        public Chap99_Final_Exam03()
        {
            InitializeComponent();

        }


        private void btnFruit_Click(object sender, EventArgs e)
        {
            Button btnTemp = (Button)sender;
            string sFruitName = btnTemp.Tag.ToString();
            switch (sFruitName)
            {
                // 결제 시 주문 수량 별 처리를 위하여 주문 버튼 클릭 후 
                case "사과":
                    // 사과의 주문 처리
                    FruitInventoryAdj(lblAppCount, sFruitName, 2000);
                    break;
                case "참외":
                    // 참외의 주문 처리 
                    FruitInventoryAdj(lblMelonCount, sFruitName, 2500);
                    break;
                case "수박":
                    // 수박의 주문 처리
                    FruitInventoryAdj(lblW_MCount, sFruitName, 18000);
                    break;
            }
        }


        void FruitInventoryAdj(Label lblFruitCnt, string sFruitName, int iSalePrice)
        {
            int iFruitCount = 0;
            string _sfruitname = sFruitName;
            // 과일의 현재 재고 수량이 0 일 경우 리턴. 
            iFruitCount = int.Parse(lblFruitCnt.Text);
            if (iFruitCount == 0)
            {
                MessageBox.Show($"{sFruitName}의 재고 수량이 0 입니다. 주문을 할 수 없습니다.");
                return;
            }

            // 던져주는 과일의 재고 개수 1 차감. 
            --iFruitCount;

            lblFruitCnt.Text = Convert.ToString(iFruitCount);

            // 총 누적 구매 금액
            iTotalPrice += iSalePrice;

            // 1.결제하기 - 주문했던 과일의 거래 내역을 수량과 금액으로 과일별로 텍스트박스에 누적하여 표현하기 위해 
            if (orderHistory.ContainsKey(sFruitName))
            {
                orderHistory[sFruitName].Quantity += 1;
                orderHistory[sFruitName].TotalPrice += iSalePrice;
            }
            else
            {
                orderHistory[sFruitName] = new order_FruitInfo { Quantity = 1, TotalPrice = iSalePrice };
            }

            // 결제 취소용 purchase_list에 마지막 결제 완료 품목 저장용
            if (purchase_list.ContainsKey(sFruitName))
            {
                purchase_list[sFruitName].Quantity += 1;
                purchase_list[sFruitName].TotalPrice += iSalePrice;
            }
            else
            {
                purchase_list[sFruitName] = new order_FruitInfo { Quantity = 1, TotalPrice = iSalePrice };
            }

        }



        private void btnTotalPrice_Click(object sender, EventArgs e) //3. 총 결제 금액 보기 클릭
        {
            int totalOrdered = 0;
            foreach (var item in orderHistory)
            {
                totalOrdered += item.Value.TotalPrice; //선택한 과일들의 총 누적 금액
            }


            MessageBox.Show($"총 결재 금액은 {totalOrdered} 원 입니다.");
        }




        private void btnOrderCancle_Click(object sender, EventArgs e) //4. 주문 취소하기 버튼 클릭
        {
            int appcnt = Convert.ToInt32(lblAppCount.Text);
            int chamcnt = Convert.ToInt32(lblMelonCount.Text);
            int wmcnt = Convert.ToInt32(lblW_MCount.Text);

            if (cancel_Temp.Count == 0)
            {
                MessageBox.Show("취소할 내역이 없습니다.");
                return;
            }

            foreach (var fruit in cancel_Temp)
            {
                if (fruit.Key == "사과")
                {
                    appcnt += fruit.Value.Quantity;
                    orderHistory[fruit.Key].Quantity -= fruit.Value.Quantity;
                    orderHistory[fruit.Key].TotalPrice -= fruit.Value.TotalPrice;
                    txtOrderList.AppendText($"\r\n---- 사과 구매 {fruit.Value.Quantity}개 취소 -----\r\n");
                    MessageBox.Show($"사과 {fruit.Value.Quantity}");
                    iCustCash += fruit.Value.TotalPrice;
                    ilManCash -= fruit.Value.TotalPrice;
                }
                if (fruit.Key == "참외")
                {
                    chamcnt += fruit.Value.Quantity;
                    orderHistory[fruit.Key].Quantity -= fruit.Value.Quantity;
                    orderHistory[fruit.Key].TotalPrice -= fruit.Value.TotalPrice;
                    txtOrderList.AppendText($"\r\n---- 참외 구매 {fruit.Value.Quantity}개 취소 -----\r\n");
                    MessageBox.Show($"참외 {fruit.Value.Quantity}");
                    iCustCash += fruit.Value.TotalPrice;
                    ilManCash -= fruit.Value.TotalPrice;
                }
                if (fruit.Key == "수박")
                {
                    wmcnt += fruit.Value.Quantity;
                    orderHistory[fruit.Key].Quantity -= fruit.Value.Quantity;
                    orderHistory[fruit.Key].TotalPrice -= fruit.Value.TotalPrice;
                    txtOrderList.AppendText($"\r\n---- 수박 구매 {fruit.Value.Quantity}개 취소 -----\r\n");
                    MessageBox.Show($"수박 {fruit.Value.Quantity}");
                    iCustCash += fruit.Value.TotalPrice;
                    ilManCash -= fruit.Value.TotalPrice;
                }
            }

            // 취소된 과일 정보를 다시 orderHistory에 저장 
            txtOrderList.AppendText("\r\n---- 결제 취소!! 누적된 거래 내역 -----\r\n");
            foreach (var fruit in orderHistory)
            {
                txtOrderList.AppendText($"{fruit.Key} {fruit.Value.Quantity}개 구매 총 구매 가격: {fruit.Value.TotalPrice}원\r\n");
            }
            txtOrderList.SelectionStart = txtOrderList.Text.Length; //텍스트박스에 누적하여 표현하기 위한 설정 
            txtOrderList.ScrollToCaret();

            lblAppCount.Text = appcnt.ToString();
            lblMelonCount.Text = chamcnt.ToString();
            lblW_MCount.Text = wmcnt.ToString();

            lblCustCash.Text = iCustCash.ToString();
            lblManCash.Text = ilManCash.ToString();

            MessageBox.Show("결제 취소 되었습니다.");
            cancel_Temp.Clear(); // 중복 결제 취소를 막기위해 Clear => Count =0이 됨.

        }



        private void btnBuy_Click(object sender, EventArgs e) //결제 하기
        {
            if (iTotalPrice > iCustCash)
            {
                MessageBox.Show("잔액이 부족합니다. 결제를 할 수 없습니다.");
                return;
            }

            foreach (var fruit in purchase_list)
            {
                if (fruit.Key == "사과")
                {
                    txtOrderList.AppendText($"\r\n---- 사과 구매 : {fruit.Value.Quantity}개  -----\r\n");
                }
                if (fruit.Key == "참외")
                {
                    txtOrderList.AppendText($"\r\n---- 참외 구매 : {fruit.Value.Quantity}개  -----\r\n");
                }
                if (fruit.Key == "수박")
                {
                    txtOrderList.AppendText($"\r\n---- 수박 구매 : {fruit.Value.Quantity}개  -----\r\n");
                }
            }


            txtOrderList.AppendText("\r\n---- 누적된 거래 내역 -----\r\n");
            foreach (var fruit in orderHistory)
            {

                txtOrderList.AppendText($"{fruit.Key} {fruit.Value.Quantity}개 구입 총 구매 가격: {fruit.Value.TotalPrice}원\r\n");
            }
            txtOrderList.SelectionStart = txtOrderList.Text.Length; //텍스트박스에 누적하여 표현하기 위한 설정 
            txtOrderList.ScrollToCaret();


            /*
             foreach (var cancel_fruit in purchase_list) 
            {
                cancel_Temp[cancel_fruit.Key] = cancel_fruit.Value;
            }
            */
            // ★ 제일 시간 많이 끌었던 구문 - 참조 복사 신경 잘 쓰기
            cancel_Temp.Clear();
            foreach (var cancel_fruit in purchase_list)
            {
                var copiedInfo = new order_FruitInfo
                {
                    Quantity = cancel_fruit.Value.Quantity,
                    TotalPrice = cancel_fruit.Value.TotalPrice
                };
                cancel_Temp[cancel_fruit.Key] = copiedInfo;
            }



            iCustCash -= iTotalPrice;
            ilManCash += iTotalPrice;
            iTotalPrice = 0;

            lblCustCash.Text = iCustCash.ToString();
            lblManCash.Text = ilManCash.ToString();
            MessageBox.Show("결제가 완료되었습니다.");

            //결제 완료를 기준으로 새로 품목을 받아야 하므로 , Clear를 통해 비워준다
            purchase_list.Clear();

        }

        private void btnFruitInvoice_Click(object sender, EventArgs e)
        {
            // 발주 수량을 3칸 다 기입하지 않은 경우 종료
            if (!CheckBaljoo_Noblank())
            {
                return;
            }

            // 발주 수량칸 3군데 중 한군데로 문자가 들어 가 있는 경우 종료
            if (!CheckBaljoo_OlnyNum())
            {
                return;
            }

            // 위 모든 사항을 채우면 정상적인 데이터가 들어온것이므로, 발주 딕셔너리에 넣어준다



        

            //// 발주 금액 계산
            //int applePrice = 1500;
            //int melonPrice = 2000;
            //int wmelonPrice = 5000;

            //int invoiceAmount = (appleQty * applePrice) + (melonQty * melonPrice) + (wmelonQty * wmelonPrice);

            //// 관리자 가게 금액보다 발주 금액이 많은 경우
            //if (invoiceAmount > ilManCash)
            //{
            //    MessageBox.Show("가게 잔액보다 발주 금액이 많습니다. 발주를 할 수 없습니다.");
            //    return;
            //}

            //// 발주 금액을 가게 잔액에서 차감
            //ilManCash -= invoiceAmount;

            //// 텍스트 박스에 발주 수량과 금액을 누적하여 표시
            //if (appleQty > 0)
            //{
            //    txtOrderList.AppendText($"사과 발주 : {appleQty}개, 금액: {appleQty * applePrice}원\r\n");
            //}
            //if (melonQty > 0)
            //{
            //    txtOrderList.AppendText($"참외 발주 : {melonQty}개, 금액: {melonQty * melonPrice}원\r\n");
            //}
            //if (wmelonQty > 0)
            //{
            //    txtOrderList.AppendText($"수박 발주 : {wmelonQty}개, 금액: {wmelonQty * wmelonPrice}원\r\n");
            //}

            // 발주 수량을 딕셔너리에 저장
            //orderQuantities["사과"].Quantity = appleQty;
            //orderQuantities["참외"].Quantity = melonQty;
            //orderQuantities["수박"].Quantity = wmelonQty;

            //// 발주 내역 초기화
            //txtAppleInvoieCount.Text = "";
            //txtMelonInvoieCount.Text = "";
            //txtW_MInvoieCount.Text = "";

            MessageBox.Show("정상적으로 발주되었습니다.");
        }

        private void BONInvoiceClear_Click(object sender, EventArgs e)
        {

        }

        private void btnShowUnitMargin_Click(object sender, EventArgs e)
        {

        }

        private void btnShowTotalMargin_Click(object sender, EventArgs e)
        {
            // 사과 라디오 버튼이 체크 되어있으면
            if (rdoApple.Checked)
            {
                // 사과에 대한 
            }
        }

        // 4-2 발주 입력시, 모든 칸에는 문자로 입력한 내역이 있으면 안됨.
        private bool input_Onlynum(string inputText)
        {
            int quantity = 0;
            if (int.TryParse(inputText, out quantity))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // 4 발주입고 시 발주 과일명, 수량, 가격을 알기 위한 딕셔너리 생성
        private Dictionary<string, order_FruitInfo> Input_Baljoo_Fruit()
        {



            //txtAppleInvoieCount.Text = "";
            //txtMelonInvoieCount.Text = "";
            //txtW_MInvoieCount.Text = ""

            return baljoolist;
        }



        // 4-1발주입고 클릭시 // 3개 모두 발주 개수를 기입하지 않으면 발주 내역이 없습니다. 메세지를 표현 메소드
        public bool CheckBaljoo_Noblank()
        {
            if (txtAppleInvoieCount.Text == "" && txtMelonInvoieCount.Text == "" && txtW_MInvoieCount.Text == "")
            {
                MessageBox.Show("발주 내역이 없습니다. 3개의 칸들을 모두 비울수는 없습니다.");
                return false;
            }
            return true;
        }

        // 4-2 발주 입력시, 모든 칸에는 문자로 입력한 내역이 있으면 안됨.
        public bool CheckBaljoo_OlnyNum()
        {
            if ((!input_Onlynum(txtAppleInvoieCount.Text) && !string.IsNullOrEmpty(txtAppleInvoieCount.Text)) ||
       (!input_Onlynum(txtMelonInvoieCount.Text) && !string.IsNullOrEmpty(txtMelonInvoieCount.Text)) ||
       (!input_Onlynum(txtW_MInvoieCount.Text) && !string.IsNullOrEmpty(txtW_MInvoieCount.Text)))
            {
                MessageBox.Show("입력된 발주 칸에는 모두 숫자로 표시되어 있어야 합니다.");
                return false;
            }
            return true;
        }

        // 4-2 발주입고 클릭시 // 1개라도 발주 내역이 있으면, 나머지 기입하지 않은 발주는 0개인것으로 한다.(문자로입력 내역은 무시)
        void CheckBajlJoo_Onlyone()
        {

         }

           
        }

    }

    class order_FruitInfo //과일 구매 개수와, 가격을 누적시켜, 텍스트 박스에 출력하기 위해
                          //// 1.결제하기 - 주문했던 과일의 거래 내역을 수량과 금액으로 과일별로 텍스트박스에 누적하여 표현
    {
        public int Quantity { get; set; }
        public int TotalPrice { get; set; }
    }


