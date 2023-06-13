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
    public partial class Chap19_Foreach_Test : Form
    {
        public Chap19_Foreach_Test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //2차원 배열을 Foreach로 텍스트박스에 표현하기.

            //1. 배열의 생성
            int[,] ivalues = new int[3,4] { { 1,2,3,4},
                                             {5,6,7, 8 },
                                             {9,10,11,12 } };

            //2차원 배열의 열의 수를 구함 
            int iArrayColumnCNT = ivalues.GetLength(1); 
            int iColumnCnt = 0; //허리할 데이터추출의 개수가 열의 개수와 일치하는지 확인


            foreach (int i in ivalues)
              {
                ++iColumnCnt; //열의 cnt 증가
                txtMatrix.Text += i.ToString() + " "; //현재 추출한 데이터를 표현
                if(iColumnCnt == iArrayColumnCNT)
                {
                    txtMatrix.Text += "\r\n";
                    iColumnCnt = 0;
                }
              }
             
           
            
        }
    }
}
