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
    public partial class Chap17_Array2 : Form
    {
        public Chap17_Array2()
        {
            InitializeComponent();
        }

        private void btnMatrix_Click(object sender, EventArgs e)
        {
            //2차원 배열의 표현 과 예제

            //1. 배열의 생성 과 데이터 입력.
            int[,] iValues = new int[2, 4]; //2행 4열 의 2차원 배열 방 생성.
            iValues[0, 0] = 100;
            iValues[0, 1] = 500;
            iValues[0, 2] = 300;
            iValues[0, 3] = 200;

            iValues[1, 0] = 10;
            iValues[1, 1] = 20;
            iValues[1, 2] = 800;
            iValues[1, 3] = 20;

            // 2.배열의 생성 과 데이터 입력.  0열 1열 2열 3열
            int[,] ivalues2 = new int[3, 4] { {1, 2, 3, 4},  //0행
                                              {5, 6, 7, 8 }, //1행
                                              {9, 10,11,12 } }; //2행

            // 3. 2차원 배열의 행의 수를 구하는 기능.
            int iMatrixRowCount = ivalues2.GetLength(0); //2차원 배열의 행의 수

            // 4. 2차원 배열의 열의 수를 구하는 기능.
            int imatrixColumnCount = ivalues2.GetLength(1); //2차원 배열의 열의 수

            // 행을 기준으로 열을 반복.
            for(int i=0; i<iMatrixRowCount; i++)
            {
                for(int j=0; j<imatrixColumnCount; j++)
                {
                    txtMatrix.Text += ivalues2[i,j]+" ";
                }
                txtMatrix.Text += "\r\n";
            }
        }
    }
}
