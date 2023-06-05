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
    public partial class Chap18_While : Form
    {
        public Chap18_While()
        {
            InitializeComponent();
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            //1부터 100까지의 합을 While문으로 표현.

            //결과 변수
            int iResult = 0;
            int iCount = 0;

            // 조건을 만족하는 동안 계속 반복 

            while(iCount<100)
            {
                iCount++;
                if(iCount >= 20 && iCount <= 30)
                {
                    // 20부터 30사이의 값은 누적 하지 않는다.(continue)
                    continue;
                }
                iResult += iCount;      

                if(iResult > 1000)
                { 
                    //누적합산의 결과 값이 1000초과 할 경우 반복문 종료
                    break;
                }
            }
            MessageBox.Show(iResult.ToString());
        }

        private void btnwhileNoExit_Click(object sender, EventArgs e)
        {
            //무한 루프
            //주식 매매 프로그램 또는 서버의 신호를 대기 하여 받아와야 하는 프로그램
            // 의 경우 불규칙적으로 들어오는 데이터를 항상 수신 대기 해야 하므로
            //무한루프를 구현해 두고 수신 을 대기 하는 프로그래밍을 할 수 있다.

            int iCnt = 1;
            int iResult = 0;

            while(true)
            {
                iCnt++;
                iResult += iCnt;
            }

            int iCount = 1000;
          

            do
            {
                //초치ㅗ 1회 실행 및 조건 만족 시 반복 실행
                iResult += iCount;
                iCount--;
            }
            while (iCount < 100);
        }
    }
}
