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
                    //누적합산의 결과 값이 1000초과 할 경우 
                    break;
                }
            }
            MessageBox.Show(iResult.ToString());
        }
    }
}
