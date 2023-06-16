using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstCSharp
{

    /*
       상속 
       클래스에 있는 기능을 물려주어 (부모 클래스)
       상속받은 클래스 (자식 클래스)는 부모의 기능을 모두 사용할 수 있으면서
       추가로 더 많은 기능을 구현하여 적용 할 수 있도록 하는 기능.


     */
    public partial class Chap35_Inheritance : Form //클래스의 기본유형 public
    {
        public Chap35_Inheritance()
        {
            InitializeComponent();
        }

        #region < 중첩 클래스 >
        private class MyClass
        {
            // 중첩 클래스 기본유형 private
            // 클래스 내에 또다른 클래스가 정의된 형태
            // 외부에 정의하는 것보다 자신만 사용할 수 있는 클래스를 작성하고 싶을 때
            // 클래스 내부에서만 사용될 수 있도록 작성하는 형태.
            // Public으로 설정 시 중첩 클래스의 의미가 없어진다.
            // public 으로 설정시 외부에 공개한다는 의미 이므로
            // 바깥쪽에 (namespace) 클래스를 작성 해 주는것이 좋다.
            public string sValue;
            private void DoSomthing()
            {

            }
        }
        #endregion

        #region < 상속 예제 >
        //기능을 물려 줄 부모 클래스
        class Parents
        {
            public string sParents = "부모전역 문자열 변수";
            public void ParentsMethod()
            {
                MessageBox.Show("부모 클래스의 메서드를 호출 합니다.");
            }
        }
       

        class Child : Parents // Parents 클래스를 상속 받는 Child 클래스
        {
            public string sChild = "자식 전역 문자열 변수";
            public void ChildMethod()
            {
                MessageBox.Show("자식 클래스의 메서드를 호출 하였습니다.");
            }
        }
        private void btnInheritance_Click(object sender, EventArgs e)
        {
            Child child = new Child();
            MessageBox.Show(child.sParents);
            child.sParents = "부모전역 변수 값의 변경이 가능합니다.";
            MessageBox.Show(child.sChild);
            MessageBox.Show(child.sParents);

            child.ParentsMethod(); //부모클래스의 메서드를 호출 가능.
        }
        #endregion
        #region < 랜덤 클래스의 상속>
        class MyRandom : Random
        {
            //random 클래스를 상속
            public int ReturnRandom()
            {
                //base (부모 클래스를 지칭) Random
                //this (자신의 클래스를 지칭) MyRandom
                return base.Next(0, 11);
            }
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            MyRandom myrandom = new MyRandom();
            myrandom.ReturnRandom(); //랜덤 클래스를 상속 받은 MyRandom에 있는 메서드 호출.
            myrandom.Next(0, 200); //부모 클래스에 있는 기능을 그대로 사용 가능.
        }
 

        //상속을 하지 못하도록 하는 키워드 seald
        sealed class Parents2
        {
            // 상속을 할 수 없게 만든 클래스.
        }

        #endregion
    }
}
