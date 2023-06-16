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
    public partial class Chap30_Class_F_클래스_ : Form
    {
        //Chap29_Class 클래스를 Chap30_Class_F의 필드멤버로 등록.
        private Chap29_Class _CHAP29 = new Chap29_Class();
        public Chap30_Class_F_클래스_()
        {
            InitializeComponent();
            MessageBox.Show(_CHAP29.sValue); //실행하자말자 창이 뜸
        }

        private void btn_ClassCall_Click(object sender, EventArgs e)
        {
            //클래스의 객체화  (인스턴스화)
            // 클래스 => 객체로 생성되는 과정
            Chap29_Class CHAP29 = new Chap29_Class();
            CHAP29.sValue = "클래스의 전역변수";

            //CHAP 29 객체의 sValue 가 변경 되더라도, 
            //CHAP29_T 와는 별개의 클래스 객체 이므로
            //CHAP29_T.sValue 의 값은 영향을 받지 않는다.

            Chap29_Class CHAP29_T = new Chap29_Class();
            MessageBox.Show(CHAP29_T.sValue);
        }

        private void btn_classcall_two_Click(object sender, EventArgs e)
        {
            // OverLoading 된 생성자를 호출 하여 클래스 멤버 초기화.
            string sValues = "던져주는 값으로 초기화";
            Chap29_Class CHAP29 = new Chap29_Class(sValues);
            MessageBox.Show(CHAP29.sValue);
        }

        private void btnFieldCall_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_CHAP29.sValue);
            _CHAP29.sValue = "바꿔버렸어요";
            MessageBox.Show(_CHAP29.sValue);
        }

        private void btn_Class_Call_4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_CHAP29.sValue);
            _CHAP29.sValue = "언제 바꼈나요.ㅠㅠ";
            MessageBox.Show(_CHAP29.sValue);
        }

        private void btn_call_Method_Click(object sender, EventArgs e)
        {
            // 전역 변수 클래스 객체 에 등록되어 있는 메서드를 호출 가능.
            _CHAP29.MethodMember();
        }
    }
}
