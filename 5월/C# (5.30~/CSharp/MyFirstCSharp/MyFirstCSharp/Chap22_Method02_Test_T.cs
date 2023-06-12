using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstCSharp
{
    public partial class Chap22_Method02_Test_T : Form
    {
        // 총 구매 금액 관리 변수.
        int iTotalPrice = 0;

        public Chap22_Method02_Test_T()
        {
            InitializeComponent();
        }

        private void btnAppleOrder_Click(object sender, EventArgs e)
        {

            //object Sender 인자
            // 해당 메서드를 호출하는 컨트롤의 정보를 담고 있다.
            //이벤트 메서드가 호출 될 경우 사용자가 이벤트를 발생시킨 컨트롤의 정보를 
            // 인수로 전달하여 호출된 메서드 에서 인자로 컨트롤을 Object형태로 전달 받아 로직을 처리.

            // Tag
            // Winform 의 Control(도구)에 존재하는 Onject 형식의 인스턴스 변수.
            // 사용자가 해당 컨트롤에 추가적으로 어떠한 값을 등록하거나 코멘트 또는 데이터를 주고 받을때
            // 편의성을 제공하도록 일종의 옷 주머니 같은 역할을 하는 컨트롤 변수.

            // 사과 주문에 대한 기능. 
            Button btnTemp = (Button)sender;
            setSwitchFruitSale(btnTemp.Tag.ToString()); //사과의 과일 주문 로직. , 클릭한 버튼의 Tag 속성에 있는 과일 이름으로 분기.
        }

        private void btnMelonOrder_Click(object sender, EventArgs e)
        {
            setSwitchFruitSale("참외"); //참외의 과일 주문 로직.
        }

        private void btnWMOrder_Click(object sender, EventArgs e)
        {
             setSwitchFruitSale("수박"); //수박의 과일 주문 로직.
        }

        private void btnTotalPrice_Click(object sender, EventArgs e)
        {
            // 총 결제 금액 보기.
            MessageBox.Show($"총 결재 금액은 {iTotalPrice} 원 입니다.");
        }

        void SelFruitSaleCount(Label lblTemp, string sFruitName, int iFruitPrice) //과일 갯수 매개변수
        {
            //과일 별 주문 클릭 로직 메서드

            //과일의 재고 수량
            int iFruitCount = Convert.ToInt32(lblTemp.Text);

            if (iFruitCount == 0)
            {
                MessageBox.Show($"{sFruitName}의 재고가 0 입니다. 주문할 수없습니다.");
                return;
            }

            // 과일의 재고 차감.
            lblTemp.Text = (--iFruitCount).ToString();

            // 과일 주문 금액 누적
            iTotalPrice += iFruitPrice;
        }

        //Switch 형식으로 만들기
        void setSwitchFruitSale(string sFruitName)
        {
            switch(sFruitName)
            {
                case "사과":
                    SelFruitSaleCount(lblAppleCnt, sFruitName, 2000);
                    break;
                case "참외":
                    SelFruitSaleCount(lblMelonCnt, sFruitName, 2500);
                    break;
                case "수박":
                    SelFruitSaleCount(lblWMCnt, sFruitName, 18000);
                    break;
            }
        }


    }
}
