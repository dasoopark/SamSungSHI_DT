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
    public partial class Chap20_MiddleTest_02 : Form
    {
        public Chap20_MiddleTest_02()
        {

            InitializeComponent();
        }

        private void btn_ssang_Click(object sender, EventArgs e)
        {
            //int[,] arr = { { 1, 4, 5, 9, 10, 12, 16 }, 
            //               { 2, 7, 11, 13, 14, 15, 18 } };

            //int iMatrixRowCount = arr.
            //Length(0); //행
            //int iMatrixColumnCount = arr.GetLength(1); //열

            //for(int i=0; i<iMatrixRowCount; i++)
            //{
            //    for(int j =0; j<iMatrixColumnCount; j++)
            //    {
            //        int currentNum = arr[i, j];
            //        int targetSum = 20 - currentNum;

            //        // 같은 행에서 합이 20이 되는 다른 수를 찾음
            //        for (int k = j + 1; k < iMatrixColumnCount; k++)
            //        {
            //            if (arr[i, k] == targetSum)
            //                textBox1.Text += ($"({currentNum}, {arr[i, k]})");
            //        }

            //        // 다른 행에서 합이 20이 되는 수를 찾음
            //        for (int m = i + 1; m < iMatrixRowCount; m++)
            //        {
            //            for (int n = 0; n < iMatrixColumnCount; n++)
            //            {
            //                if (arr[m, n] == targetSum)
            //                 textBox1.Text += ($"({currentNum}, {arr[m, n]})");

            //            }
            //        }
            //    }
            //}

            //교수님 풀이 방법
            // 2차원 배열 만들기
            int[,] iValues = { { 1, 4, 5, 9, 10, 12, 16 }, 
                             { 2, 7, 11, 13, 14, 15, 18 } };

            //찾은 쌍을 등록 해서 누적시킬 문자열 변수.
            string sValues = string.Empty;

            // 배열의 행의 수 구하기
            int iRowCnt = iValues.GetLength(0);

            //배열의 열의 수 구하기
            int iColCnt = iValues.GetLength(1);

            // 찾을 수 (20 - 기준 값)
            int iFindValue = 0;

            //반복의 횟수를 찾기 위한 Foreach Count 
          

            // 찾은 값(배열에서 값을 찾았을 경우)를 누적 시킨 배열.
            int[] iResults = new int[iRowCnt * iColCnt];
            int iResultindex = 0; //찾은 값이 등록 될 주소.


            // 로직 수행 여부를 지정할 외부 변수 Bool
            bool bBreakFlag = false;

            //2차원 배열에서 기준 값을 뽑아올 forEach
            foreach(int iValue in iValues)
            {
           
                bBreakFlag = false;
                //메모화 기능을 이용한 벨리데이션 체크.
                //찾은 값이 등록되어 있는 배열에서 기준값이 등록 되어 있는지 확인.
                for (int i=0; i<iResults.Length;i++)
                {
                    if(iValue == iResults[i])
                    {
                        //기준에 찾은 쌍의 값을 기준값으로 하여 찾으려 할 경우.
                        //중복 쌍을 찾는 경우 이므로 등록 로직을 수행 할 필요가 없다.
                        bBreakFlag = true;
                        break;
                    }
                }
                
                if(bBreakFlag)
                {
                    continue;
                }
                iFindValue = 20 - iValue; //배열에서 찾을 수
                
                //iR_Value : 기준 값에서 20을 만들 수 있는 대상 정수.
                foreach(int iR_Value in iValues)
                {
               
                    //찾아야 되는 수 == 배열에서 하나씩 추출한 수 
                    if (iFindValue == iR_Value && iFindValue != iValue) //뺸값이 배열에 존재하는지 확인 , 존재하면 둘다 합이 20이됨.
                    {
                        //기준값 과 합이 20이 되는 수가 배열에 존재한다.
                        iResults[iResultindex] = iR_Value; //찾은 값을 메모화 배열에 등록.
                        ++iResultindex;
                        sValues += $"{iValue}.{iR_Value}\r\n"; //찾은 값의 쌍을 보여주기 위해 문자열에 등록.
                    }
                }
            }
            MessageBox.Show(sValues);
        }
    }
}
