using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstCSharp.Lesson05_Class
{
    public partial class Chap32_Property : Form
    {
        //6. 서점 관리 클래스를 객체화.
        private BookStore B_s = new BookStore();
        public int iBookCount;
        /*
         1. 프로퍼티
         프로퍼티 (Property)
            - 클래스 내부 변수(전역 변수)의 값을 읽거나 쓸 때 사용하는 문법
            - 유효성 검사를 위해 사용 됩니다. 
                . 데이터의 변질로 인한 오류 사항을 사전에 방지 할 수 있는 방법.
            
            - 캡슐화를 지킬 수 있음
                . 정보를 은닉하고 최소한의 멤버만 공개 하는 방식.

        */
        public Chap32_Property()
        {
            InitializeComponent();
        }

        // 2. 서점 이라는 클래스 가 있다고 할 때
        class BookStore
        {
            private int iBookCount; // 3. 서점 클래스에서만 관리 할 만화책에 대한 재고 수량.

            // 프로퍼티 BookCount 생성
            public int BookCount // 4. 외부에서 BookCount로 접근 하여 내부의 iBookCount를 관리.
            {
                get // 데이터를 확인 할 때
                {
                    return iBookCount;
                }
                set // 데이터를 할당 할 때
                {
                    //외부에서 접근 가능한 BookCount 변수에 데이터를 할당 할 때 
                    //클래스 전역 변수 iBookCount 에 데이터 할당을 해준다.

                    iBookCount = value;
                }
            }

            //10. 데이터의 변질을 막기 위한 공용 변수 BookCount2 
            public int BookCount2
            {
                get
                {
                    return iBookCount;
                }
                set
                {
                    //데이터 변질을 막기 위한 로직.
                    if (value < 0)
                    {
                        // 차감한 수량이 -인 경우.
                        MessageBox.Show("만화책 재고 수량은 0 이하가 될 수 없습니다.");
                    }
                    else
                    {
                        iBookCount = value;
                    }
                }
            }
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
           
            //7. 서점 에 만화책의 입고 내역을 생성.
            int.TryParse(textinqty.Text, out int iinQty);
            // B_s.BookCount += iinQty;
            // lblStockQty.Text = B_s.BookCount.ToString();
            B_s.BookCount2 += iinQty;
            lblStockQty.Text = B_s.BookCount2.ToString();
            textinqty.Text = ""; //입고 입력 수량 삭제

            MessageBox.Show($"{iinQty} 권의 만화책이 입고 되었습니다.");

            // 서점 클래스의 재고 수량에 입고 
        }

        private void btn_Sale_Click(object sender, EventArgs e)
        {
            #region < 1번 Case , BookCount, - 재고 밸리데이션을 개별로 적용 할 경우 >
            ////8. 만화책 판매 로직 ( 클릭시 1권씩 재고 차감 )
            //--B_s.BookCount;

            ////9. 책의 카운트는 -가 될 수 없으므로 벨리데이션 체크.
            //if(B_s.BookCount <0)
            //{
            //    B_s.BookCount = 0;
            //    MessageBox.Show("책의 수량은 0 보다 작을 수 없습니다.");
            //}
            //// 수량 표현
            //lblStockQty.Text = B_s.BookCount.ToString();
            #endregion

            #region < 2번 Case, BookCount2 프로퍼티로 0 재고 벨리데이션을 공통으로 적용 하여 사용하는 경우>
            // 벨리데이션 체크를 통하여 재고를 0 이하로 만들지 않는 로직은 구현 완료 하였으나.
            // 프로젝트를 통하여 여러 사람과 같은 로직을 사용 해야 하는 경우.
            // 내가 만든 프로그램 이외에 다른사람이 BookStore 클래스의 BookCount 의 재고를 관리 해야 하는 경우가 생겼을때.
            // 변수 자체에 조건을 걸어 주어 재고가 0이하로 떨어지는 것을 방지할 수 있따.

            //11. 새로 만든 프로퍼티에 재고 차감.
            // BookCount2 프로퍼티에 재고가 0이하가 될 수 없는 조건을 설정하였음으로
            --B_s.BookCount2;
            lblStockQty.Text = B_s.BookCount2.ToString();
            #endregion

        }
        // 5. 정보 은닉을 위해 실제 데이터를 관리하는 변수 iBookCount 는 Private 로 선언을 했지만
        // Public BookCount를 통하여 Get와 Set으로 접근가능하게 하니
        // iBookCount를 Public으로 하지 왜 굳이..?


        // 12. 일반적인 Get / Set 방법 외에도 프로퍼티를 생성 할 수 있는 방법.
        public int BookCount3 { get; set; }
        

        // 13. 읽기 전용 프로퍼티
        public int BookCount4 { get; } // ReadOnly

        // 14. 쓰기 전용 프로퍼티
        public int BookCount5
        {
            set
            {
                iBookCount = value;
            }
        }

    }
}
