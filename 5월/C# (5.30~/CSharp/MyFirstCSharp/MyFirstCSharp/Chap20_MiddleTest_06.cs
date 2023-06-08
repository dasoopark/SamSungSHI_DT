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
    public partial class Chap20_MiddleTest_06 : Form
    {
        public Chap20_MiddleTest_06()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
           
            //가진 금액
            Random rNumber = new Random();
            int money = rNumber.Next(10000, 500001);

            // 놀이기구 반복횟수
            int play = rNumber.Next(1, 21);

            //놀이기구 최초 가격
            int playmoney = rNumber.Next(100, 3001);

            // 총 가격 (반복횟수 * 최초가격)
            int total = play * playmoney;

            //잔돈
            int jandon;

            if (total <= money)
            {
                jandon = money - total;
                MessageBox.Show($"{money}원이 있을 때 이용 요금 {playmoney}원인 놀이기구를 {play} 번 타면 {jandon}원이 남습니다.");
            }
            else
            {
                MessageBox.Show($"{money} 원이 있을 때 이용 요금 {playmoney} 원인 놀이기구를 {play} 번 타면 {total - money}원이 모자랍니다.");
            }
        }
    }
}
