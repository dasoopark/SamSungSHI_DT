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
    public partial class Chap16_Loop_For : Form
    {
        //반복문
        //특정한 조건을 만족 할 때 까지 반복하여 동일한 로직을 실행하는 문법
        public Chap16_Loop_For()
        {
            InitializeComponent();
        }

        private void btnforsum_Click(object sender, EventArgs e)
        {
            //1부터 100까지 합하는 로직.

            // 1. 누적 값이 저장되는 변수.
            int iSumValue = 0;

            // 1 부터 100까지 반복
            // i: 반복하면서 조건을 만족시킬 변수
            // 반복문을 종료 할 수 있는 변수
            // int i = 0; : int형 변수 i가 0이라는 값을 가지고 시작.
            // : i <= 100 = 참인 조건 인지 판단하는 구문
            // : i++ = 후위 증가 연산자.
            for (int i =0; i <=100; i++)
            {
                iSumValue += i;
            }
            MessageBox.Show(iSumValue.ToString());
        }

        private void btnArraySum_Click(object sender, EventArgs e)
        {
            // 배열 의 데이터 수 만큼 for 문으로 반복 후 배열의 값 더하기.
            // 배열에 포함된 데이터의 갯수 및 값을 모른다고 가정.
            int[] ivalues = { 10, 20, 30, 40, 50, 50, 20 };
                             //0  1   2   3   4   5   6
            int iSumValue = 0; //배열의 모든 값을 더해서 누적 시킬 변수.
            
            //for문을 통하여 ivalues 배열에 있는 모든 값을 더하기.
            //배열의 주소 값으로 사용될 i
            for(int i = 0; i<ivalues.Length; i++)
            {
                iSumValue += ivalues[i];
            }
            MessageBox.Show(iSumValue.ToString());

          
        }

        private void GuGu_Btn_Click(object sender, EventArgs e)
        {   
            for(int i = 2; i<=9; i++)
            {
                for(int j = 1; j<=9; j++)
                {
                    txtGuGu.Text += $"{i} * {j} = {i * j}\r\n";

                }
            }
        }

        private void btnimmutable_Click(object sender, EventArgs e)
        {
            //값형식의 타입.
            //immutable Type과 (string) 과 Mutable Type (int)
            //immutable 타입은 저장되는 번지수만 늘어나서 데이터가 증가하는 방식.
            //누적 되기 전의 데이터가 사라지지 않는 방식.
            //2 * 1 = 2   //2 * 1 = 2  //2 * 1 = 2
            //2 * 2 = 4  //2 * 2 = 4
            //2 * 3 = 6
            //데이터가 누적 될 때 불필요한 메모리 공간이 많이 소비되므로 비효율적인 코딩 이 될 수 있다.
            //StringBuilder를 사용할 것을 권장 (강추추추)

            StringBuilder sBuilder = new StringBuilder();
            // 12345678910 .... 100
            for (int i = 1; i <= 100; i++)
            {
                sBuilder.Append(i.ToString());
                // 12345678910..............100
            }
            MessageBox.Show(sBuilder.ToString());
            sBuilder.Clear(); // 내용 삭제
        }
    }
}
