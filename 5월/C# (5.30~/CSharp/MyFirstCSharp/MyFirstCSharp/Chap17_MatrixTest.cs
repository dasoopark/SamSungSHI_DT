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
    public partial class Chap17_MatrixTest : Form
    {
        public Chap17_MatrixTest()
        {
            InitializeComponent();
        }

        private void change_Click(object sender, EventArgs e)
        {
            int[,] ivalues = new int[2, 4] {{ 1, 2, 3, 4},
                                            { 5, 6, 7, 8 }};
            

            int iMatrixRowCount = ivalues.GetLength(0); //행
            int iMatrixColumnCount = ivalues.GetLength(1); //열
            int[,] iResults = new int[iMatrixRowCount, iMatrixColumnCount];

            //원본 배열의 행을 역으로 거슬러 올라가는 행의 주소!
            int iResultRowindex = 0;
            for (int i = iMatrixRowCount-1; i >= 0; i--)
            {
                for (int j = 0; j < iMatrixColumnCount; j++)
                {
                    iResults[iResultRowindex, j] = ivalues[i, j];
                }
                iResultRowindex++;
            }
            
        }
    }
}
