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
    // 구조체 생성.
    struct Color
    {
        public string Red { get; set; }
        public string Yellow { get; set; }
        public string Blue { get; set; }
        
        //1. 생성자를 만들 수있다. - 인자가 없으면 만들 수 없다 / 인자 필수
        //public Color()
        //{

        //}
        public Color(string red, string yellow, string blue)
        {
            //생성자를 만들면 반드시 필드 멤버에 있는 요소를 초기화 해주어야 한다.
            this.Red = red;
            this.Yellow = yellow;
            this.Blue = blue;
        }
        
        //메서드에 대한 오버로딩이 가능.
        public Color(string red, string yellow)
        {
            this.Red = red;
            this.Yellow = yellow;
            Blue = "블루";

            //인자와는 관계없이 생성자에서 모든 필드 멤버를 초기화 해야 한다.
        }
    }
    public partial class Chap33_Struct : Form
    {
        // -- 구조체 선언 (클래스와 함께 Heap)
        public Chap33_Struct()
        {
            InitializeComponent();
        }

        private void btn_Struct_Click(object sender, EventArgs e)
            
        {
            /*
              구조체
                1. 클래스와 유사한 구조를 가지고 있지만 속성과 구현 방법이 다르다.
                2. 데이터 처리 방식
                    Struct : Valuetype(값 형식)
                    Class : Reference (참조 전달 형식)
                . 메모리 비용이 클래스보다 상대적으로 작다.
                    . 참조 형식 : Heap , Stack, 참조 주소 저장 메모리 비용이 발생

                3. 지역변수 (메서드 내부에서) 선언되어 사용 될경우, 스택 영역에 할당.
                   전역변수(필드멤버) 선언 될 경우 클래스와 함께 Heap 영역에 할당.
                4. 사용자 정의 데이터 타입을 만들어 사용 할 수 있다.  ㅂ 
                5. 상속이 불가능.
                6. 단순한 데이터 관리에 용이
            */

            //3개의 생성자 인자를 가지고 있는 구조체를 Stack에 등록
            Color MyColor = new Color("빨강","노랑","블루");

            // 구조체 값 전달 깊은 복사( 클래스 같은경우는 얕은 복사)
            Color MyColor2 = MyColor;
            MyColor2.Red = "RED"; //복사를 받은 구조체의 red에 데이터 변경.

            //원본 구조체 의 Red의 값.
            MessageBox.Show(MyColor.Red);

            // 값 형식 이므로 데이터를 참조 전달 하는 방법
            SetColor(ref MyColor);
            MessageBox.Show(MyColor.Red);
        }
        private void SetColor(ref Color _Color)
        {
            _Color.Red = "RED";
        }
    }
}
