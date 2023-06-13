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
    public partial class Chap16_Loop_For_Test : Form
    {

        int oddCnt;
        int evenCnt;
        int oddidx = 0;
        int evenidx = 0;
        public Chap16_Loop_For_Test()
        {
            InitializeComponent();
        }

        private void btnOddResult_Click(object sender, EventArgs e)
        {
            //입력한 값을 받아오기 
            string svalue = txtStart.Text;
            string evalue = txtEnd.Text;
            int oddresult = 0;
            int evenresult = 0;

            //정수 데이터 변수 생성
            int iResult = 0;
            int eResult = 0;
            //입력 받은 값을 숫자로 변환할 수 있는지 체크 bool 변수 
            bool sFlag = false;
            bool eFlag = false;

            //입력 문자를 숫자로 변환 후 iResult에 담고 성공여부를 bFlag에 담기
            sFlag = int.TryParse(svalue, out iResult); // svalue를 iResult 형태의 데이터로 변환 할 수 있는지 true or false 반환
            eFlag = int.TryParse(evalue, out eResult);

            if (!sFlag || !eFlag)
            {
                MessageBox.Show("공배수 판단을 할 수 없습니다.");
                return;
            }

            if(iResult>=eResult)
            {
                MessageBox.Show("시작 숫자가 종료 숫자보다 크거나 같을 수 없습니다.");
                return;
            }


            for(int i = iResult; i<= eResult; i++)
            {
                if(i%2==0) //짝수일때
                {
                    evenCnt++;
                }
                if(i%2==1)
                {
                    oddCnt++;
                }
            }
            int[] evenarr = new int[evenCnt];
            int[] oddarr = new int[oddCnt];


            for (int i = iResult; i <= eResult; i++)
            {
                if (i % 2 == 0) //짝수일때
                {
                    evenarr[evenidx] = i;
                    evenresult += i;
                    evenidx++;
                }
                if (i % 2 == 1)
                {
                    oddarr[oddidx] = i;
                    oddresult += i;
                    oddidx++;
                }
            }

            string oddvalue = string.Empty;
            string evenvalue = string.Empty;

            oddvalue = string.Join(" , ", oddarr);
            evenvalue = string.Join(" , ", evenarr);

            txtOddResult.Text = oddvalue;
            txtEvenResult.Text = evenvalue;

            MessageBox.Show($"짝수들의 합:{evenresult}");
            MessageBox.Show($"홀수들의 합:{oddresult}");



        }
    }
}
