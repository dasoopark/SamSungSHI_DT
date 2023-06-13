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
    public partial class Chap20_MiddleTest_07_T : Form
    {
        public Chap20_MiddleTest_07_T()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            // 0부터 20까지의 수 표현, 없는수 합해서 메세지로 나타내기.

            Random random = new Random();

            // 임의 난수 20개 받을 배열 생성.
            int[] iValues = new int[20];
            for(int i=0; i<20;i++)
            {
                iValues[i] = random.Next(0,21); //20 미만이므로 21로 해야함
            }
            Array.Sort(iValues);

            //텍스트 박스에 오름차순으로 표현하기.
            txtResult.Text = "";
            foreach(int i in iValues)
            {
                //텍스트박스에 표현
                txtResult.Text += i.ToString() + ",";
            }

            // 0~20까지 누락된 값을 찾아봅시다.

            int iResult = 0; //누락된 값의 합이 할당 될 변수.
            StringBuilder sResult = new StringBuilder(); //누락된 값의 리스트.

            // i:누락된 수 (찾을 값)
            int j = 0;
            for(int i =0; i<21; i++)
            {
                //찾을 기준값으로 배열에 데이터가 있는지 확인. 
                for(j=0; j<iValues.Length;j++)
                {
                    if (iValues[j] == i)
                    {
                        // 배열에 i값이 할당 되어 있다.!
                        break;
                    }
                }
                if (j == 20)
                {
                    //누락된 값을 결과에 등록.
                    iResult += i;
                    sResult.Append(i+" "); //누적된 수 리스트

                }
            }

            MessageBox.Show($"난수 배열 중 {sResult}이 없으며 총 합은 {iResult}입니다.");
           
        }
    }
}
