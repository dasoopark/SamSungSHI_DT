using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;

/*
    실기 3 . 박다수
    0. (사과,참외,수박) 주문 버튼 클릭 시(1,2) : 모두 구현 완료

    1. 결제하기 버튼 클릭 시 (1,2,3,4) : 모두 구현 완료

    2. 총 결제 금액 보기 클릭 시 (1,2) : 모두 구현 완료

    3. 주문 취소하기 클릭시 (1,2) : 모두 구현 완료

    4. 발주 입고 클릭시 (1,2,3,4,5,6,7) : 모두 구현완료

    5. 전체 삭제 버튼 클릭 시 - 기입한 발주 내역을 모두 초기화 하는 이지만
       발주 텍스트 목록만 지우는것도 구현하였지만, 
       발주 초기화 시 발주했던 과일 갯수들, 관리자 가게 잔액을 이전 값으로 회복시켜 
       주어야 한다고 생각하여 발주 전체 삭제 시, 모든 발주 갯수만큼 과일과 관리자 금액이 돌아오게 구현 하였습니다.

    6. 개별 마진 보기 버튼 클릭시 : 모두 구현 완료

    7. 총 마진보기 버튼 클릭 시 : 모두 구현 완료
   


    * 메모용 - 난감했던 버그
    과일 수량이 0이 될 때 까지 장바구니에 담고  0이 된 후에도 계속 메세지창을 무시하고 버튼을 누른 후
    되돌리기를 하면  그 누른 횟수 만큼 증감되어 되돌리기 되는 현상이 발생 (초기 과일갯수랑 금액이랑 달라지게됨)
      - 클리어 차곡차곡 해서 해결 완료
    
 */
namespace MyFirstCSharp
{
    public partial class Chap99_Final_Exam03 : Form
    {
        private int iTotalPrice = 0; // 총 결제 금액  
        private int iCustCash = 100000; // 고객 잔액 금액
        private int ilManCash = 100000; // 관리자 초기 가게 잔액.
        int iTotalBaljooPrice = 0; // 총 발주 금액


        int appcnt = 0;
        int meloncnt = 0;
        int wmcnt = 0;


        private Dictionary<string, order_FruitInfo> purchase_list = new Dictionary<string, order_FruitInfo>(); //값에, 과일 정보(가격,개수)를 받는 딕셔너리
        private Dictionary<string, order_FruitInfo> orderHistory = new Dictionary<string, order_FruitInfo>(); //텍스트 박스에 구매한 것들을 누적시키기 위해 사용하는 딕셔너리
        private Dictionary<string, order_FruitInfo> baljoolist = new Dictionary<string, order_FruitInfo>(); // 발주 수량을 누적 저장하는 딕셔너리
        private Dictionary<string, order_FruitInfo> baljoolist_temp = new Dictionary<string, order_FruitInfo>(); // 현재 발주를 기준으로, 매니저 금액 계산 용





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

            if (iFruitCount > 0)
            {
                if (_sfruitname == "사과")
                {
                    ++appcnt;
                }
                else if (_sfruitname == "참외")
                {
                    ++meloncnt;
                }
                else if (_sfruitname == "수박")
                {
                    ++wmcnt;
                }
            }


            if (iFruitCount == 0)
            {
                MessageBox.Show($"{sFruitName}의 재고 수량이 0 입니다. 주문을 더 할 수 없습니다.");
                return;
            }

            // 던져주는 과일의 재고 개수 1 차감. 
            --iFruitCount;
            lblFruitCnt.Text = Convert.ToString(iFruitCount);


            // 총 누적 구매 금액
            iTotalPrice += iSalePrice;

            if (orderHistory.ContainsKey(sFruitName))
            {
                orderHistory[sFruitName].Quantity += 1;
                orderHistory[sFruitName].TotalPrice += iSalePrice;
            }
            else
            {
                orderHistory[sFruitName] = new order_FruitInfo { Quantity = 1, TotalPrice = iSalePrice };
            }
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

            int apptotal = 0;
            int melontotal = 0;
            int wmtotal = 0;
            int il_totaltemp = 0;



            int iapptotal = appcnt * 2000;
            int imelontotal = meloncnt * 2500;
            int iwmtotal = wmcnt * 18000;

            foreach (var item in orderHistory)
            {
                if (item.Key == "사과")
                {
                    apptotal += item.Value.TotalPrice - (appcnt * 2000);
                }
                if (item.Key == "참외")
                {
                    melontotal += item.Value.TotalPrice - (meloncnt * 2500);
                }
                if (item.Key == "수박")
                {
                    wmtotal += item.Value.TotalPrice - (wmcnt * 18000);
                }
            }



            if (appcnt == 0 && meloncnt == 0 && wmcnt == 0)
            {
                MessageBox.Show("취소할 내역이 없습니다.");
                return;
            }

            lblAppCount.Text = (Convert.ToInt32(lblAppCount.Text) + appcnt).ToString();
            lblMelonCount.Text = (Convert.ToInt32(lblMelonCount.Text) + meloncnt).ToString();
            lblW_MCount.Text = (Convert.ToInt32(lblW_MCount.Text) + wmcnt).ToString();

            foreach (var item in orderHistory)
            {
                if (item.Key == "사과")
                {
                    orderHistory["사과"].Quantity -= appcnt;
                    orderHistory["사과"].TotalPrice = apptotal;
                }
                if (item.Key == "참외")
                {
                    orderHistory["참외"].Quantity -= meloncnt;
                    orderHistory["참외"].TotalPrice = melontotal;
                }
                if (item.Key == "수박")
                {
                    orderHistory["수박"].Quantity -= wmcnt;
                    orderHistory["수박"].TotalPrice = wmtotal;
                }
            }

            foreach (var item in purchase_list)
            {
                if (item.Key == "사과")
                {
                    apptotal += item.Value.TotalPrice - (appcnt * 2000);
                }
                if (item.Key == "참외")
                {
                    melontotal += item.Value.TotalPrice - (meloncnt * 2500);
                }
                if (item.Key == "수박")
                {
                    wmtotal += item.Value.TotalPrice - (wmcnt * 18000);
                }
            }

            foreach (var item in purchase_list)
            {
                if (item.Key == "사과")
                {
                    purchase_list["사과"].Quantity -= appcnt;
                    purchase_list["사과"].TotalPrice = apptotal;
                }
                if (item.Key == "참외")
                {
                    purchase_list["참외"].Quantity -= meloncnt;
                    purchase_list["참외"].TotalPrice = melontotal;
                }
                if (item.Key == "수박")
                {
                    purchase_list["수박"].Quantity -= wmcnt;
                    purchase_list["수박"].TotalPrice = wmtotal;
                }
            }
            // MessageBox.Show($"iTotalPrice는 {iTotalPrice}");
            int i_iTotalPrice = iTotalPrice + iapptotal + imelontotal + iwmtotal;
            MessageBox.Show("결제 취소 되었습니다.");
            il_totaltemp = iTotalPrice - i_iTotalPrice;

            iTotalPrice += il_totaltemp;
            // MessageBox.Show($"iTotalPrice는 {iTotalPrice}"); 값체크용
            // MessageBox.Show($"il_totaltemp는 {il_totaltemp}");
            //  MessageBox.Show($"i_itotalprice {i_iTotalPrice}");



            appcnt = 0;
            meloncnt = 0;
            wmcnt = 0;

            iapptotal = 0;
            imelontotal = 0;
            iwmtotal = 0;

        }


        private void btnBuy_Click(object sender, EventArgs e) //결제 하기
        {
            appcnt = 0;
            meloncnt = 0;
            wmcnt = 0;

            if (iTotalPrice > iCustCash)
            {
                MessageBox.Show("잔액이 부족합니다. 결제를 할 수 없습니다.");
                foreach (var fruit in purchase_list)
                {
                    if (fruit.Key == "사과")
                    {
                        orderHistory["사과"].Quantity -= purchase_list["사과"].Quantity;
                        orderHistory["사과"].TotalPrice -= purchase_list["사과"].TotalPrice;
                        iTotalPrice -= purchase_list["사과"].TotalPrice;
                        lblAppCount.Text = (Convert.ToInt32(lblAppCount.Text) + purchase_list["사과"].Quantity).ToString();
                    }
                    if (fruit.Key == "참외")
                    {
                        orderHistory["참외"].Quantity -= purchase_list["참외"].Quantity;
                        orderHistory["참외"].TotalPrice -= purchase_list["참외"].TotalPrice;
                        iTotalPrice -= purchase_list["참외"].TotalPrice;
                        lblMelonCount.Text = (Convert.ToInt32(lblMelonCount.Text) + purchase_list["참외"].Quantity).ToString();
                    }
                    if (fruit.Key == "수박")
                    {
                        orderHistory["수박"].Quantity -= purchase_list["수박"].Quantity;
                        orderHistory["수박"].TotalPrice -= purchase_list["수박"].TotalPrice;
                        iTotalPrice -= purchase_list["수박"].TotalPrice;
                        lblW_MCount.Text = (Convert.ToInt32(lblW_MCount.Text) + purchase_list["수박"].Quantity).ToString();
                    }
                }
                purchase_list.Clear();
                return;
            }

            //출력용 구문 
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

            // 누적 출력용 구문 
            txtOrderList.AppendText("\r\n---- 누적된 거래 내역 -----\r\n");
            foreach (var fruit in orderHistory)
            {

                txtOrderList.AppendText($"{fruit.Key} {fruit.Value.Quantity}개 구입 총 구매 가격: {fruit.Value.TotalPrice}원\r\n");
            }
            txtOrderList.SelectionStart = txtOrderList.Text.Length; //텍스트박스에 누적하여 표현하기 위한 설정 
            txtOrderList.ScrollToCaret();


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
            iTotalBaljooPrice = 0;
            if (baljoo_temp())
            {
                Input_Baljoo_Fruit();
            }
            else
            {
                return;
            }

            printbaljoo(baljoolist);
            txtAppleInvoieCount.Text = "";
            txtMelonInvoieCount.Text = "";
            txtW_MInvoieCount.Text = "";



            MessageBox.Show("정상적으로 발주되었습니다.");
        }

        // 4-6 : 누르면 기입한 발주 내역을 모두 초기화.
        private void BONInvoiceClear_Click(object sender, EventArgs e)
        {
            int baljooappcnt = 0;
            int baljoomeloncnt = 0;
            int baljoowmcnt = 0;
            // 발주 목록 프린트 
            txtOrderList.AppendText("\r\n---- 발주내역을 모두 초기화 합니다. -----\r\n");
            foreach (var fruit in baljoolist)
            {

                ilManCash += fruit.Value.TotalPrice;
                if (fruit.Key == "사과")
                {
                    baljooappcnt = fruit.Value.Quantity;
                }
                if (fruit.Key == "참외")
                {
                    baljoomeloncnt = fruit.Value.Quantity;
                }
                if (fruit.Key == "수박")
                {
                    baljoowmcnt = fruit.Value.Quantity;
                }
            }
            txtOrderList.SelectionStart = txtOrderList.Text.Length; //텍스트박스에 누적하여 표현하기 위한 설정 
            txtOrderList.ScrollToCaret();

            lblManCash.Text = ilManCash.ToString();
            lblAppCount.Text = (Convert.ToInt32(lblAppCount.Text) - baljooappcnt).ToString();
            lblMelonCount.Text = (Convert.ToInt32(lblMelonCount.Text) - baljoomeloncnt).ToString();
            lblW_MCount.Text = (Convert.ToInt32(lblW_MCount.Text) - baljoowmcnt).ToString();

            foreach (var fruit in baljoolist) //초기화시, 수량과 갯수 0개로 초기화
            {
                fruit.Value.TotalPrice = 0;
                fruit.Value.Quantity = 0;
            }

        }

        //4-7 개별 마진보기 버튼 클릭 시
        private void btnShowUnitMargin_Click(object sender, EventArgs e)
        {
            //발주를 안하고 개별마진을 보면 0원으로 초기화해서 계산 해야함.
            if (!baljoolist.ContainsKey("사과"))
            {
                baljoolist["사과"] = new order_FruitInfo { Quantity = 0, TotalPrice = 0 };

            }
            if (!baljoolist.ContainsKey("참외"))
            {
                baljoolist["참외"] = new order_FruitInfo { Quantity = 0, TotalPrice = 0 };
            }
            if (!baljoolist.ContainsKey("수박"))
            {
                baljoolist["수박"] = new order_FruitInfo { Quantity = 0, TotalPrice = 0 };
            }

            //구매를 안하고 개별마진을 보면 0원으로 초기화해서 계산해야함.
            if (!orderHistory.ContainsKey("사과"))
            {
                orderHistory["사과"] = new order_FruitInfo { Quantity = 0, TotalPrice = 0 };

            }
            if (!orderHistory.ContainsKey("참외"))
            {
                orderHistory["참외"] = new order_FruitInfo { Quantity = 0, TotalPrice = 0 };
            }
            if (!orderHistory.ContainsKey("수박"))
            {
                orderHistory["수박"] = new order_FruitInfo { Quantity = 0, TotalPrice = 0 };
            }

            if (rdoApple.Checked)
            {
                MessageBox.Show($"사과의 개별 마진 금액:{orderHistory["사과"].TotalPrice - baljoolist["사과"].TotalPrice}원");
            }
            else if (rdoMelon.Checked)
            {
                MessageBox.Show($"참외의 개별 마진 금액:{orderHistory["참외"].TotalPrice - baljoolist["참외"].TotalPrice}원");
            }
            else if (rdoW_M.Checked)
            {
                MessageBox.Show($"수박의 개별 마진 금액:{orderHistory["수박"].TotalPrice - baljoolist["수박"].TotalPrice}원");
            }
        }

        //4-8 전체 마진보기 버튼 클릭 시 / 사과, 참외, 수박의 총 마진금액을 합산
        private void btnShowTotalMargin_Click(object sender, EventArgs e)
        {

            //발주를 안하고 전체마진을 보면 0원으로 초기화해서 계산 해야함.
            if (!baljoolist.ContainsKey("사과"))
            {
                baljoolist["사과"] = new order_FruitInfo { Quantity = 0, TotalPrice = 0 };

            }
            if (!baljoolist.ContainsKey("참외"))
            {
                baljoolist["참외"] = new order_FruitInfo { Quantity = 0, TotalPrice = 0 };
            }
            if (!baljoolist.ContainsKey("수박"))
            {
                baljoolist["수박"] = new order_FruitInfo { Quantity = 0, TotalPrice = 0 };
            }

            //구매를 안하고 전체마진을 보면 0원으로 초기화해서 계산해야함.
            if (!orderHistory.ContainsKey("사과"))
            {
                orderHistory["사과"] = new order_FruitInfo { Quantity = 0, TotalPrice = 0 };

            }
            if (!orderHistory.ContainsKey("참외"))
            {
                orderHistory["참외"] = new order_FruitInfo { Quantity = 0, TotalPrice = 0 };
            }
            if (!orderHistory.ContainsKey("수박"))
            {
                orderHistory["수박"] = new order_FruitInfo { Quantity = 0, TotalPrice = 0 };
            }


            int total = 0;
            total += orderHistory["사과"].TotalPrice - baljoolist["사과"].TotalPrice;
            total += orderHistory["참외"].TotalPrice - baljoolist["참외"].TotalPrice;
            total += orderHistory["수박"].TotalPrice - baljoolist["수박"].TotalPrice;

            MessageBox.Show($"총 마진 금액은 : {total}원 입니다.");
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

        // 4 발주입고 시 발주 과일명, 수량, 가격을 알기 위한 누적 딕셔너리 생성
        private Dictionary<string, order_FruitInfo> Input_Baljoo_Fruit()
        {
            if (!string.IsNullOrEmpty(txtAppleInvoieCount.Text) && int.TryParse(txtAppleInvoieCount.Text, out int appleCount) && appleCount > 0)
            {
                if (baljoolist.ContainsKey("사과"))
                {
                    baljoolist["사과"].Quantity += appleCount;
                    baljoolist["사과"].TotalPrice += (int)(2000 * 0.6) * Convert.ToInt32(txtAppleInvoieCount.Text);
                }
                else
                {
                    baljoolist["사과"] = new order_FruitInfo { Quantity = appleCount, TotalPrice = (int)(2000 * 0.6) * Convert.ToInt32(txtAppleInvoieCount.Text) };
                }
            }

            if (!string.IsNullOrEmpty(txtMelonInvoieCount.Text) && int.TryParse(txtMelonInvoieCount.Text, out int melonCount) && melonCount > 0)
            {
                if (baljoolist.ContainsKey("참외"))
                {
                    baljoolist["참외"].Quantity += melonCount;
                    baljoolist["참외"].TotalPrice += (int)(2500 * 0.6) * Convert.ToInt32(txtMelonInvoieCount.Text);
                }
                else
                {
                    baljoolist["참외"] = new order_FruitInfo { Quantity = melonCount, TotalPrice = (int)(2500 * 0.6) * Convert.ToInt32(txtMelonInvoieCount.Text) };
                }
            }

            if (!string.IsNullOrEmpty(txtW_MInvoieCount.Text) && int.TryParse(txtW_MInvoieCount.Text, out int wmCount) && wmCount > 0)
            {
                if (baljoolist.ContainsKey("수박"))
                {
                    baljoolist["수박"].Quantity += wmCount;
                    baljoolist["수박"].TotalPrice += (int)(18000 * 0.6) * Convert.ToInt32(txtW_MInvoieCount.Text);
                }
                else
                {
                    baljoolist["수박"] = new order_FruitInfo { Quantity = wmCount, TotalPrice = (int)(18000 * 0.6) * Convert.ToInt32(txtW_MInvoieCount.Text) };
                }
            }


            return baljoolist;
        }


        // 4 발주시 매니저 금액에서 현재 발주된 과일들 금액을 빼기 위한 임시 메서드
        private bool baljoo_temp()
        {

            if (!string.IsNullOrEmpty(txtAppleInvoieCount.Text) && int.TryParse(txtAppleInvoieCount.Text, out int appleCount) && appleCount > 0)
            {
                if (baljoolist_temp.ContainsKey("사과"))
                {
                    baljoolist_temp["사과"].Quantity += appleCount;
                    baljoolist_temp["사과"].TotalPrice += (int)(2000 * 0.6) * Convert.ToInt32(txtAppleInvoieCount.Text);
                    iTotalBaljooPrice += baljoolist_temp["사과"].TotalPrice;
                }
                else
                {
                    baljoolist_temp["사과"] = new order_FruitInfo { Quantity = appleCount, TotalPrice = (int)(2000 * 0.6) * Convert.ToInt32(txtAppleInvoieCount.Text) };
                    iTotalBaljooPrice += baljoolist_temp["사과"].TotalPrice;
                }
            }

            if (!string.IsNullOrEmpty(txtMelonInvoieCount.Text) && int.TryParse(txtMelonInvoieCount.Text, out int melonCount) && melonCount > 0)
            {
                if (baljoolist_temp.ContainsKey("참외"))
                {
                    baljoolist_temp["참외"].Quantity += melonCount;
                    baljoolist_temp["참외"].TotalPrice += (int)(2500 * 0.6) * Convert.ToInt32(txtMelonInvoieCount.Text);
                    iTotalBaljooPrice += baljoolist_temp["참외"].TotalPrice;
                }
                else
                {
                    baljoolist_temp["참외"] = new order_FruitInfo { Quantity = melonCount, TotalPrice = (int)(2500 * 0.6) * Convert.ToInt32(txtMelonInvoieCount.Text) };
                    iTotalBaljooPrice += baljoolist_temp["참외"].TotalPrice;
                }
            }

            if (!string.IsNullOrEmpty(txtW_MInvoieCount.Text) && int.TryParse(txtW_MInvoieCount.Text, out int wmCount) && wmCount > 0)
            {
                if (baljoolist_temp.ContainsKey("수박"))
                {
                    baljoolist_temp["수박"].Quantity += wmCount;
                    baljoolist_temp["수박"].TotalPrice += (int)(18000 * 0.6) * Convert.ToInt32(txtW_MInvoieCount.Text);
                    iTotalBaljooPrice += baljoolist_temp["수박"].TotalPrice;
                }
                else
                {
                    baljoolist_temp["수박"] = new order_FruitInfo { Quantity = wmCount, TotalPrice = (int)(18000 * 0.6) * Convert.ToInt32(txtW_MInvoieCount.Text) };
                    iTotalBaljooPrice += baljoolist_temp["수박"].TotalPrice;
                }
            }

            // 발주시에 3개중 키가 없는것이 이씅면 오류가 뜨므로, 대입
            if (!baljoolist_temp.ContainsKey("사과"))
            {
                baljoolist_temp["사과"] = new order_FruitInfo { Quantity = 0, TotalPrice = 0 };
            }
            if (!baljoolist_temp.ContainsKey("참외"))
            {
                baljoolist_temp["참외"] = new order_FruitInfo { Quantity = 0, TotalPrice = 0 };
            }
            if (!baljoolist_temp.ContainsKey("수박"))
            {
                baljoolist_temp["수박"] = new order_FruitInfo { Quantity = 0, TotalPrice = 0 };
            }

            if (!baljooCashCheck())
            {
                iTotalBaljooPrice = 0;
                foreach (var item in baljoolist_temp)
                {
                    baljoolist_temp[item.Key].Quantity = 0;
                    baljoolist_temp[item.Key].TotalPrice = 0;
                }
                return false;
            }
            else
            {
                ilManCash -= iTotalBaljooPrice;
                lblManCash.Text = ilManCash.ToString();

                //발주한 만큼 구매가능 갯수를 증가 해준다.
                int il_AppCount = Convert.ToInt32(lblAppCount.Text) + Convert.ToInt32(baljoolist_temp["사과"].Quantity);
                int il_mellonCount = Convert.ToInt32(lblMelonCount.Text) + Convert.ToInt32(baljoolist_temp["참외"].Quantity);
                int il_watermellonCount = Convert.ToInt32(lblW_MCount.Text) + Convert.ToInt32(baljoolist_temp["수박"].Quantity);
                lblAppCount.Text = il_AppCount.ToString();
                lblMelonCount.Text = il_mellonCount.ToString();
                lblW_MCount.Text = il_watermellonCount.ToString();
                iTotalBaljooPrice = 0;
                baljoolist_temp.Clear();
                return true;
            }

        }


        // 발주 금액이 관리자의 가게금액 보다 많은지 체크하는 메서드. 이후 차감
        public bool baljooCashCheck()
        {

            // 총 발주 금액이 관리자의 가게금액 보다 많을 경우 발주 할 수 없다는 메세지를 표현한다.
            if (iTotalBaljooPrice > ilManCash)
            {
                MessageBox.Show("총 발주 금액이 관리자의 가게금액 보다 많습니다. 발주 할 수 없습니다.");
                return false;
            }

            return true;
        }

        // 4-5 발주입고 클릭시 // 텍스트 박스에 발주 수량과 금액을 과일 별로 누적하여 표시 한다.
        void printbaljoo(Dictionary<string, order_FruitInfo> BaljooItem)
        {

            // 발주 목록 프린트 
            txtOrderList.AppendText("\r\n---- 누적된 발주목록 -----\r\n");
            foreach (var fruit in BaljooItem)
            {
                txtOrderList.AppendText($"{fruit.Key} {fruit.Value.Quantity}개 발주 총 발주 금액 : {fruit.Value.TotalPrice}원\r\n");
            }
            txtOrderList.SelectionStart = txtOrderList.Text.Length; //텍스트박스에 누적하여 표현하기 위한 설정 
            txtOrderList.ScrollToCaret();

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

      
    


    }

}

class order_FruitInfo //과일 구매 개수와, 가격을 누적시켜, 텍스트 박스에 출력하기 위해
                      //// 1.결제하기 - 주문했던 과일의 거래 내역을 수량과 금액으로 과일별로 텍스트박스에 누적하여 표현
{
    public int Quantity { get; set; }
    public int TotalPrice { get; set; }
}
