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
    public partial class Chap09_StringManage_Test : Form
    {
        string stitle;
        public Chap09_StringManage_Test()
        {
            //클래스가 최초 호출 될때 디자인을 셋팅 하는 장소이다
            InitializeComponent();

            //되돌리기를 위한 원본 문자열을 담을 변수를 지정.
            stitle = label1.Text;
        }

        private void btnNameChange_Click(object sender, EventArgs e)
        {
            //OOO -> 자기 이름으로 표현하기
            label1.Text = label1.Text.Replace("OOO", "박다수");
        }

        private void btnfindswIndex_Click(object sender, EventArgs e)
        {
            //SW의 INDEX 표시
            MessageBox.Show($"S/W의 글귀의 위치는{label1.Text.IndexOf("S/W")} 입니다.");
        }

        private void btnfirst_last_Click(object sender, EventArgs e)
        {
            //시작단어와 마지막 단어 각각 한글자씩
            string sTitle = label1.Text;
            MessageBox.Show($"시작 문자: {sTitle[0]}, 종료 문자: {sTitle[sTitle.Length-1]}");
        }

        private void btn_insertDt_Click(object sender, EventArgs e)
        {
            //타이틀의 문자열 앞 뒤에 -DT- 문자열 삽입

            label1.Text = $"-DT- {label1.Text} -DT-";
        }

        private void btn_changeSo_Click(object sender, EventArgs e)
        {
            //특정 문자 소문자로 변경 Digital Training 소문자로 변경
            string svalue = "DIGITALTRANING";
            label1.Text = label1.Text.Replace(svalue, svalue.ToLower());
        }

        private void btn_delTrim_Click(object sender, EventArgs e)
        {
            //라벨 타이틀 모든 공백 없애기.
            label1.Text = label1.Text.Replace(" ", "");
        }

        private void btn_rollback_Click(object sender, EventArgs e)
        {
            //원본 문자열 되돌리기.
            //stitle에 있는 원본 문자열을 다시 label1.Text에 대입.
            label1.Text = stitle;
        }
    }
}
