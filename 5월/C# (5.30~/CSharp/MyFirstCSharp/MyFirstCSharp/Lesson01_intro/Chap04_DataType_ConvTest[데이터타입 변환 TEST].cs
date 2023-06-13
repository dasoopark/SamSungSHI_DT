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
    public partial class Cahp04_DataType_ConvTest : Form
    {
        public Cahp04_DataType_ConvTest()
        {
            InitializeComponent();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {   
            // 텍스트 박스 두 수의 합 구해서 메세지로 표현하기.

            // 1. 텍스트 박스에 입력 된 값 을 가져오기.

            // 왼쪽 텍스트 박스에 입력 한 값을 문자열 변수 에 담기.
            string sFirstValue;
            sFirstValue = txtFirtValue.Text;

            // 오른쪽 텍스트 박스에 입력 한 값을 문자열 변수 에 담기.
            string sSecValue;
            sSecValue = txtSecValue.Text;


           
            // 2. 입력 받은 값을 정수로 변환. 

            // 왼쪽 텍스트 박스의 값을 정수로 담은 int 변수 만들기.
            int iFirstValue = 0;
            int.TryParse(sFirstValue, out iFirstValue);

            // 오른쪽 텍스트 박스의 값을 정ㅅ로 담은 int 변수 만들기. 
            int iSecValue = 0;
            int.TryParse(sSecValue, out iSecValue); 

            // 3. 두 수 합치기
            int iResult = 0; // 합친 결과를 받아올 int 변수.
            iResult = iFirstValue + iSecValue;

            // 4. 합친 결과 표현하기.
            string sResult; // 합친결과 를 문자로 담을 변수.
            sResult = Convert.ToString(iResult);
            MessageBox.Show(sResult);

            // 4 의 내용은 아래의 한줄로 표현 할 수 있다.
            // MessageBox.Show(Convert.ToString(sResult));
        }
    }
}
