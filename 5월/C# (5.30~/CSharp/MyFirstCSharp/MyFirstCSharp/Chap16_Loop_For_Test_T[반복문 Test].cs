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
    public partial class Chap16_Loop_For_Test_T : Form
    {
        public Chap16_Loop_For_Test_T()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 홀수 짝수 구하기 버튼 클릭
        /// </summary>
        /// <param name="sender">버튼의 속성</param>
        /// <param name="e">클릭 이벤트에 대한 속성</param>

        private void btnResult_Click(object sender, EventArgs e)
        {
            // 입력 시작 값 부터 입력 종료 값 까지의 총 짝수의 합과 홀수의 합 구하기.
            int iOdd = 0; //홀수 값을 모두 더해 누적될 변수
            int iEven = 0; //짝수 값을 모두 더해 누적될 변수.

            int iStarValue = 0; //입력한 시작 값을 다룰 변수
            int iEndValue = 0; // 입력한 종료 값을 다룰 변수

            StringBuilder sProcessEven = new StringBuilder(); //범위안의 모든 짝 수
            StringBuilder sProcessOdd = new StringBuilder(); //범위안의 모든 홀 수

            //벨리데이션
            //시작 입력값을 숫자로 정확히 입력 하였는지 확인.

            string sErrorMessage = string.Empty; //=""

            if (int.TryParse(txtStart.Text, out iStarValue) == false)
            {
                sErrorMessage = "입력한 시작 문자가 숫자로 바뀔 수 없습니다.";
                //MessageBox.Show("입력한 문자가 숫자로 바뀔 수 없습니다.");
                //return;
            }
            else if (!int.TryParse(txtEnd.Text, out iEndValue))
            {
                sErrorMessage = "입력한 종료 문자가 숫자로 바뀔 수 없습니다.";
                //MessageBox.Show("입력한 종료 문자가 숫자로 바뀔 수 없습니다.");
                //return;
            }
            else if (iStarValue >= iEndValue)
            {
                sErrorMessage = "입력 숫자가 종료 숫자 보다 큽니다.";
                //MessageBox.Show("입력 숫자가 종료 숫자 보다 큽니다.");
                //return;
            }

            if (sErrorMessage != "")
            {
                // 벨리데이션 체크 예외 상황이 발생 되었을 경우. 
                MessageBox.Show(sErrorMessage);
                return;
            }

            sProcessEven.Append("짝수 : ");
            sProcessOdd.Append("홀수 : ");
            //짝수와 홀수 합, 과정 산출하기 로직.
            for (int i = iStarValue; i <= iEndValue; i++)
            {
                if(i % 2 == 0)
                {
                    iEven += i; //짝수 누적 합
                    sProcessEven.Append(i + " "); //짝수 리스트 문자열 
                }
                else
                {
                    iOdd += i; //홀수 누적 합 
                    sProcessOdd.Append(i + " "); //홀수 리스트 문자열
                } 
            }

            // 반복문 종료 시 결과 표현.
            MessageBox.Show($"짝수의 합 : {iEven}, 홀수의 합 : {iOdd}");
            txtEvenResult.Text = sProcessEven.ToString();
            txtOddResult.Text = sProcessOdd.ToString();
        }  
    }
}
