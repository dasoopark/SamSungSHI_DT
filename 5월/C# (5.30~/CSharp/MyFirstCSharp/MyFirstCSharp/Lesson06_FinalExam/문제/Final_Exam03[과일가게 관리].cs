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
    public partial class Chap99_Final_Exam03 : Form
    { 
        private int iTotalPrice = 0; // 총 결제 금액  
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


        void FruitInventoryAdj(Label lblFruitCnt, string sFruitName , int iSalePrice)
        {
            int iFruitCount = 0;
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
        }



        private void btnTotalPrice_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"총 결재 금액은 {iTotalPrice} 입니다.");
        }

        private void btnShowTotalMargin_Click(object sender, EventArgs e)
        {
            // 사과 라디오 버튼이 체크 되어있으면
            if(rdoApple.Checked)
            {
                // 사과에 대한 
            }
        }
    }
}
