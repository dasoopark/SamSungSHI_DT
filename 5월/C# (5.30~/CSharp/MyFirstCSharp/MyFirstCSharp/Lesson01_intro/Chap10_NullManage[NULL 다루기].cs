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
    public partial class Chap10_NullManage : Form
    {
        public Chap10_NullManage()
        {
            InitializeComponent();
        }

        private void btnHasValue_Click(object sender, EventArgs e)
        {
            //데이터의 값이 Null인지 판단하는 기능, HasValue
            // ?붙여야 null처리가능
            int? ivalue = null;

            //값이 있을경우 ture / null 일 경우 false반환
            bool bflag = ivalue.HasValue;
            MessageBox.Show(bflag.ToString());

            //문자열의 null 처리 여부 판단.
            string svalue = null;
            //bflag = svalue.hasvalue;
            // 문자 열의 경우 null 상태를 허용하는 데이터 타입이므로
            //굳이 null 상태인지 체크하는 기능이 필요없다.
        }

        private void btnNull_Click(object sender, EventArgs e)
        {
            //Null 병합 연산자 '??' - ? 엘비스 기호
            // 데이터 타입의 유형이 null처리 된 상태인지 판단하는 키워드

            int? ivalue = null;
            //A??B : 만약에 A가 null 상태이면 B를 표현하고, null상태가 아니면 A를 그대로 표현하라.
            // 만약에 ivalue가 null 상태면 -1(원하는 숫자 입력가능), 아니면 ivalue값을 iResult에 대입하라.
            int iResult = ivalue ?? -1;
            MessageBox.Show(iResult.ToString());


            //String 타입에 null값 여부 판단.
            // ?? - String null값이면 해당 문자 출력, null이 아니면 string 벨류값 출력
            string svalue = null;
            MessageBox.Show(svalue ?? "변수가 null 상태 입니다."); //변수가 null 상태 입니다.

            svalue = "안녕하세요";
            MessageBox.Show(svalue ?? "변수가 null 상태 입니다."); //안녕하세요가 나옴


        }
    }
}
