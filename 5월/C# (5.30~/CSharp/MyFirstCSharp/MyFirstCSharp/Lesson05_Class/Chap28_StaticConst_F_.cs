using MyFirstCSharp;
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
    public partial class Chap28_StaticConst_F_ : Form
    {
        //Const 상수 (변하지 않는 값)
            // - 최초 값 대입 후 (초기화 후) 추가로 값을 할당 할 수 없다.
            // 데이터의 변질을 막기 위해 사용.
            // 시스템의 경우 특정 하드웨어 또는 인프라 등에 접속하기 위한 경로, 주소등이 할당 된다.
        public Chap28_StaticConst_F_()
        {
            InitializeComponent();
        }

        private void btn_step1_Click(object sender, EventArgs e)
        {
            //특정한 클래스의 인스턴스 필드, 메서드 (멤버) 를 호출하기 위해서는
            // 클래스를 객체화 해야 한다. (인스턴스화)
            Chap27_AccessModifier CHAP27 = new Chap27_AccessModifier();
            CHAP27.sPublic = "";

            // Static 정적 한정자를 호출
            string sMessage = "123";

            //Static 정적 한정자를 호출
            // 정적 멤버 자체를 Data, Code 영역에 등록 하므로
            // 별도의 클래스를 객체화 할 필요가 없다.
            Static_Class.sValue = "값을 초기화 해서 Data 영역에 등록 합니다.";

            Static_Class.sValue = "안녕하세요";
        }

        private void btn_step2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Static_Class.sValue);
            Static_Class.sValue = "반갑습니다.";

        }

        private void btn_step3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Static_Class.sValue);
            Static_Class.sValue = "C# 프로그래밍";
            MessageBox.Show(Static_Class.sValue);
        }

        private void btnStatic_Click(object sender, EventArgs e)
        {
            //정적 필드와 인스턴스 필드를 모두 가지고 있는 클래스를 활용.

            //1. Static 형이 아닌 일반 필드(인스턴스 필드)
            // 클래스를 객체화 하여 호출 한후 Heap 영역

            StaticOrinstance_Class STO = new StaticOrinstance_Class();
            STO.sinstance = "반갑습니다";
            //  STO.sStaticValue = "어라 호출이 안되네"; 정적 필드에는 인스턴스 객체로 접근할 수 없다.

            //Data 영역에 클래스 필드 가 값이 할당되어 (초기화) 등록
            StaticOrinstance_Class.sStaticValue = "인스턴스 필드를 가지고 있는 클래스의 정적 필드를 호출할 수 있다.";
        }

        private void btnstatic_call_Click(object sender, EventArgs e)
        {
            // StaticOrinsatnce_Class 에 있는 필드 값을 호출 표현.
            StaticOrinstance_Class SOIC = new StaticOrinstance_Class();
            MessageBox.Show(SOIC.sinstance);

            // 정적 필드의 값 표현
            MessageBox.Show(StaticOrinstance_Class.sStaticValue);
        }

        private void btn_Static_method_call_Click(object sender, EventArgs e)
        {
            //정적 메서드 호출
            //메서드가 호출 됨과 동시에
            StaticOrinstance_Class.StaticMethod();
        }

        private void btnConst_Click(object sender, EventArgs e)
        {
            // 상수 : 바뀌지 않는 값.

            // 1. 상수가 있는 클래스 객체 생성
            Const_Class constclass = new Const_Class(); //상수 필드가 있는 클래스를 인스턴스 화(객체화)
      //   MessageBox.Show(constclass.sConst); 상수는 Static 속성을 가지고 있으므로, 객체화 해서 사용할 수 없다.

            //3. 상수에 데이터를 할당 하려 할 경우 오류가 발생한다.
            //   Const_Class.sConst = "상수에 값을 대입 해보자.. 안되네";

            //4. 확인
            MessageBox.Show(Const_Class.sConst);// 상수(정적 한정자)

        }
    }

    class Const_Class
    {
        //상수
        public const string sConst = "상수값";
    }
}
