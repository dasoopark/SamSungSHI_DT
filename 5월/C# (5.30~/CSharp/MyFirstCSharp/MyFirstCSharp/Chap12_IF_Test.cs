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
    public partial class Chap12_IF_Test : Form
    {
        int cnt = 0;
        public Chap12_IF_Test()
        {
            InitializeComponent();
        }

        private void GongBaeSoo_Click(object sender, EventArgs e)
        {
            cnt++;
            //입력한 값을 받아오기 
            string svalue = inputtxt.Text;

            //정수 데이터 변수 생성
            int iResult = 0;

            //입력 받은 값을 숫자로 변환할 수 있는지 체크 bool 변수 
            bool bFlag = false;

            //입력 문자를 숫자로 변환 후 iResult에 담고 성공여부를 bFlag에 담기
            bFlag = int.TryParse(svalue, out iResult); // svalue를 iResult 형태의 데이터로 변환 할 수 있는지 true or false 반환

            if (!bFlag)
            {
                MessageBox.Show("공배수 판단을 할 수 없습니다.");
                return;
            }
           
            if(iResult %2 == 0 && iResult %5 ==0)
            {
                MessageBox.Show("2와 5의 공배수입니다.");
                   if(iResult % 8 ==0)
                    {
                        gob_eight.Text = ($"8의 배수입니다. 값과의 곱:{iResult *= 8}");
 
                    } 
            }
            else
            {
                MessageBox.Show("문제에서 원하는 조건의 수가 아닙니다.");
            }
            btncount_txt.Text = cnt.ToString();


        }
    }
}
