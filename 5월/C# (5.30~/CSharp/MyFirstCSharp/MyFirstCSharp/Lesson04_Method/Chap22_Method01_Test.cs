using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstCSharp
{
    public partial class Chap22_Method01_Test : Form
    {
        public Chap22_Method01_Test()
        {
            InitializeComponent();
        }

        private void btnTwo_M_Click(object sender, EventArgs e)
        {
            if(vaildation(textBox1.Text,textBox2.Text))
            {
                MessageBox.Show($"2의 배수의 합은:{two_num(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text))}");
            }
            
        }

        private void btnFive_M_Click(object sender, EventArgs e)
        {
            if (vaildation(textBox1.Text, textBox2.Text))
            {
                MessageBox.Show($"5의 배수의 합은:{five_num(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text))}");
            }
        }

        private void btnTen_M_Click(object sender, EventArgs e)
        {
            if (vaildation(textBox1.Text, textBox2.Text))
            {
                MessageBox.Show($"10의 배수의 합은:{ten_num(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text))}");
            }
        }

        //벨리데이션 체크 메서드
        bool vaildation(string text1, string text2)
        {
            int aResult = 0;
            int bResult = 0;

            bool aFlag = false;
            bool bFlag = false;

            aFlag = int.TryParse(text1, out aResult);
            bFlag = int.TryParse(text2, out bResult);

            if (!aFlag || !bFlag)
            {
                MessageBox.Show("문자는 숫자만 입력해야 합니다.");
                return false;
            }
            else if(aResult<0 || bResult < 0)
            {
                MessageBox.Show("음수는 입력 받을 수 없습니다.");
                return false;
            }
            return true;
        }

        //2의 배수 체크 메서드
        int two_num(int a, int b)
        {
            int result = 0;
            for(int i=a; i<=b; i++)
            {
                if(i%2 == 0)
                {
                    result += i;
                }
            }
            return result;
        }

        //5의 배수 체크 메서드
        int five_num(int a, int b)
        {
            int result = 0;
            for (int i = a; i <= b; i++)
            {
                if (i % 5 == 0)
                {
                    result += i;
                }
            }
            return result;
        }

        //10의 배수 체크 메서드
        int ten_num(int a, int b)
        {
            int result = 0;
            for (int i = a; i <= b; i++)
            {
                if (i % 10 == 0)
                {
                    result += i;
                }
            }
            return result;
        }
    }
}
