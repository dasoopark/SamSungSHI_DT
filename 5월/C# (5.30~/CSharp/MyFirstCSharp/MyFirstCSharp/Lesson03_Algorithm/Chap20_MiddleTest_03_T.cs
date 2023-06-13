using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstCSharp
{
    public partial class Chap20_MiddleTest_03_T : Form
    {
        //클래스의 전역변수, 필드멤버, 인스턴스 변수
        int iClikCount;
        public Chap20_MiddleTest_03_T()
        {
            InitializeComponent();
            
        }

        private void btnMakeRan_Click(object sender, EventArgs e)
        {
            // 난수 : 임의의 정수 . 
            //
            ++iClikCount;
            Random rNumber = new Random();
            int iRanNumber = rNumber.Next(0, 100);

            if(iClikCount == 1)
            {
                txtNum1.Text = iRanNumber.ToString();
            }
            else if(iClikCount == 2)
            {
                txtNum2.Text = iRanNumber.ToString();
            }
            else
            {
                txtNum3.Text = iRanNumber.ToString();
                iClikCount = 0;
            }
        
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            int[] iValues = new int[3];
            int.TryParse(txtNum1.Text, out iValues[0]);
            int.TryParse(txtNum2.Text, out iValues[1]);
            int.TryParse(txtNum3.Text, out iValues[2]);

            //배열에 있는 값을 모두 더하기.
            Array.Sort(iValues); //오름차순으로 정렬 0 최소값, 2:최대값

            int iSumValue = 0;
            foreach(int iValue in iValues)
            {
                iSumValue += iValue;
            }

            string sMessage = string.Empty;
            if(iSumValue < 100)
            {
                sMessage = $"3수의 합이 100미만 이며 최소값은:{iValues[0]}, 최대값은:{iValues[2]}입니다.";
            }
            else if(iSumValue >=100 && iSumValue<200)
            {
                sMessage = $"3수의 합이 100이상 이며, 200미만 최소값은:{iValues[0]}, 최대값은:{iValues[2]}입니다. 합은:{iValues[0] + iValues[2]}";
            }
            else
            {
                sMessage = $"3수의 합이 200이 넘습니다.";
            }
            MessageBox.Show(sMessage);

            //텍스트 박스 일괄 클리어.
            //this : 현재 로직이 구현되고 있는 클래스를 지칭합니다.
            //지금 화면에 있는 모든 컨트롤을 추출합니다.
            foreach(Control con in this.Controls)
            {
                if(con is TextBox)
                {
                    //현재 화면에 있는 모든 텍스트 박스를 초기화.
                    con.Text = "";
                }
            }
            iClikCount = 0;
        }
    }
}
