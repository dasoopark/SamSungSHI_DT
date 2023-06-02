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
    public partial class Chap14_Switch_Test : Form
    {
        int apple = 10;
        int melon = 10;
        int wm = 10;
        int sum = 0;

        public Chap14_Switch_Test()
        {
            InitializeComponent();
        }

        private void btnAppleOrder_Click(object sender, EventArgs e)
        {
            apple -= 1;
            if(apple<0)
            {
                MessageBox.Show("재고가 없습니다.");
                return;
            }
            lblAppleCnt.Text = $"{apple.ToString()}";
            sum += 2000;
            
          
        }

        private void btnMelonOrder_Click(object sender, EventArgs e)
        {
            melon -= 1;
            if (melon < 0)
            {
                MessageBox.Show("재고가 없습니다.");
                return;
            }
            lblMelonCnt.Text = $"{melon.ToString()}";
            sum += 2500;
        }

        private void btnWMOrder_Click(object sender, EventArgs e)
        {

            wm -= 1;
            if (wm < 0)
            {
                MessageBox.Show("재고가 없습니다.");
                return;
            }
            lblWMCnt.Text = $"{wm.ToString()}";
            sum += 18000;
        }

        private void btnTotalPrice_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"총 가격의 합:{sum}");
        }
    }
}
