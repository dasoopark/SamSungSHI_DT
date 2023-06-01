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
    public partial class Chap11_BranchingStatment : Form
    {
        //분기문 
        //프로그램 흐름의 조건에 따라 여러 갈래로 나누는 흐름제어 구문
        //비교연산자로 ==, !=, <=, >=, &&, || 을 사용합니다.

        public Chap11_BranchingStatment()
        {
            InitializeComponent();
        }

        private void btnIF_Click_Click(object sender, EventArgs e)
        {
            //텍스트 박스에 입력한 값이 없을 경우 
            //"아무 값도 없습니다." 라는 메세지를 표현하고
            // 아닐 경우(값이 있을경우) 해당 값을 메세지로 표현

            //텍스트 박스에 입력한 값을 변수에담기.

            string svalue = txtBS.Text;
            if(svalue == "")
            {
                //true 
                MessageBox.Show("아무 값도 없습니다.");
            }
            else
            {
                //false
                MessageBox.Show(svalue);
            }
            
            //if(svalue != "")
            //{
            //    MessageBox.Show(svalue);
            //}
        }

        private void btn_inif_Click(object sender, EventArgs e)
        {
            /*
              만약에 텍스트 박스에 입력한 값이 
              1 일때는 "분기문 1 실행" 메세지
              2 일때는 "분기문 2 실행" 메세지
              3 일때는 "분기문 3 실행" 메세지

              아무 값도 입력하지 않은 경우 "값을 입력하세요" 메세지
              그리고 1, 2, 3 이 아닐 경우 "적절한 분기문이 없습니다." 메세지
          
            */
            //1. 텍스트 박스에 입력한 값 받아오기.
            string sTextValue = txtBS.Text;

            if (sTextValue == "")
            {
                MessageBox.Show("값을 입력하세요");
            }
            else
            {
                if (sTextValue == "1")
                {
                    MessageBox.Show("분기문 1 실행");
                }
                if (sTextValue == "2")
                {
                    MessageBox.Show("분기문 2 실행");
                }
                if (sTextValue == "3")
                {
                    MessageBox.Show("분기문 3 실행");
                }
                else
                {
                    MessageBox.Show("적절한 분기문이 없습니다.");
                }
            }
            //마지막의 else는 3번 분기문의 예외 일 경우 결과 로직이다.
            //1,2 를 입력하였을 경우 
            //"1번, 2번 분기문 실행"이라는 메세지를 표현하고
            // 3이 아니기 때문에 적절한 분기문이 없습니다. 표현.
            // 예상한 시나리오 대로 동작하지 않는 로직.

            //1,2,3 else의 흐름을 하나로 만들어주는 if의 흐름이 필요.
            
            
             
        }

        private void btnElseif_Click(object sender, EventArgs e)
        {
            // else if
            // if문과 다음 if문을 하나의 흐름으로 만들어 준다.
            // if, else if 를 마족시키는 조건을 하나라도 수행하면 흐름을 종료.
            // 모두 거짓 상태일 경우 else로직을 수행

            /*
             만약에 텍스트 박스에 입력한 값이 
             1 일때는 "분기문 1 실행" 메세지
             2 일때는 "분기문 2 실행" 메세지
             3 일때는 "분기문 3 실행" 메세지

             아무 값도 입력하지 않은 경우 "값을 입력하세요" 메세지
             그리고 1, 2, 3 이 아닐 경우 "적절한 분기문이 없습니다." 메세지

           */

            //입력한 값.
            string svalue = txtBS.Text;
            
            //1. 값을 입력하지 않았을 경우.
            if(svalue =="")
            {
                MessageBox.Show("값을 입력 하세요");
            }
            else if(svalue == "1")
            {
                MessageBox.Show("1 분기문 실행");
            }
            else if(svalue =="2")
            {
                MessageBox.Show("2 분기문 실행");
            }
            else if(svalue =="3")
            {
                MessageBox.Show("3 분기문 실행");
            }
            else
            {
                MessageBox.Show("적절한 분기문이 없습니다.");
            }
        }

        private void btnAndif_Click_Click(object sender, EventArgs e)
        {
            // &&(And) 모든 조건을 만족시킬 경우에만 참

            //입력한 값 받아오기.
            string svalue = txtBS.Text;
            if(svalue =="1" && svalue =="2" && svalue =="3") //or을 써야 오류가 안남 || and는 전부다 트루가되야 참이되므로 분기문이 없다고 뜸
            {
                //true
                MessageBox.Show($"{svalue}번 분기문 실행");
            }
            else if(svalue =="")
            {
                MessageBox.Show("값을 입력 하세요");
            }
            else
            {
                MessageBox.Show("적절한 분기문이 없습니다.");
            }
        }

        private void btnORif_Click(object sender, EventArgs e)
        {
            // ||(or) 조건 하나라도 만족시킬 경우면 참, '이거나', 
            // || 버티컬 바 (shift+\)

            //입력한 값 받아오기.
            string svalue = txtBS.Text;
            if (svalue == "1" || svalue == "2" || svalue == "3") //or을 써야 오류가 안남 ||
            {
                //true
                MessageBox.Show($"{svalue}번 분기문 실행");
            }
            else if (svalue == "")
            {
                MessageBox.Show("값을 입력 하세요");
            }
            else
            {
                MessageBox.Show("적절한 분기문이 없습니다.");
            }
        }

        private void btnbool_if_Click(object sender, EventArgs e)
        {
            //분기문의 외부 변수를 이용하여 분기 흐름 제어하기.
            // bool 데이터 변수에 데이터가 담긴 결과 로 흐름을 판단하는 로직.

            //1. 입력한 값 받아오기.
            string svalue = txtBS.Text;

            //2. 분기 흐름 제어를 위한 외부 bool 변수 생성.
            bool bFlag = false; // 기본값:false

            // 3. 첫번째 분기 흐름 설정
            if(svalue =="1" || svalue=="2" || svalue =="3")
            {
                bFlag = true;
            }
            else if(svalue=="")
            {
                MessageBox.Show("값을 입력하세요.");
                return; //로직종료
               
            }
            
            //4. 두번째 분기 흐름 생성.
            // bFlag의 참 / 거짓에 따른 분기 흐름.

            //아래 두 경우는 같은 케이스
            //bFlag에 false값이 있다면 if 문 실행.
            //if(!bFlag)
            //{
            //    //true
             
            //}
            if(bFlag==false) //bFlag가 
            {
                //true일때만
                //1,2,3을 입력하지 않은 경우
                MessageBox.Show("적절한 분기문이 없습니다.");
            }

            else //1,2,3값을 입력한 경우
            {
                MessageBox.Show($"{svalue}번 분기문 실행");
            }

        }

        private void btnPM_Click(object sender, EventArgs e)
        {
            //r 입력한 값이 음수 인지 양수 인지 판단

            //입력한 값을 받아오기 
            string svalue = txtBS.Text;

            //정수 데이터 변수 생성
            int iResult = 0;

            //입력 받은 값을 숫자로 변환할 수 있는지 체크 bool 변수 
            bool bFlag = false;

            //입력 문자를 숫자로 변환 후 iResult에 담고 성공여부를 bFlag에 담기
            bFlag = int.TryParse(svalue, out iResult); // svalue를 iResult 형태의 데이터로 변환 할 수 있는지 true or false 반환
            
            //벨리데이션 체크
            // 개발자가 프로그램 개발 시 오류 사항이 발생할 수 있는 로직을 예상하고
            // 오류 상황이 발생할 수 있는 로직을 처리 하기 전에 
            // 에러 메세지를 사용자 에게 전달 해 줌으로서
            // 시스템 오류 를 발생 시키지 않으면서 프로그램에 대한 신뢰도를
            // 높이는 개발 방법.
            // 사용자에게 정확한 사용 방법을 알리면서 올바르게 프로그램을 사용 할 수 있도록 유도.

            if(!bFlag)
            {
                MessageBox.Show("음수 양수 판단을 할 수 없습니다.");
                return;
            }
            if(iResult > 0)
            {
                MessageBox.Show("양수입니다.");
            }
            else if (iResult < 0)
            {
                MessageBox.Show("음수입니다.");
            }
            else
            {
                MessageBox.Show("0입니다.");
            }
        }

        private void btnhol_jjack_Click(object sender, EventArgs e)
        {
            // 홀수 짝수 판단 

            //입력한 값을 받아오기 
            string svalue = txtBS.Text;

            //정수 데이터 변수 생성
            int iResult = 0;

            //입력 받은 값을 숫자로 변환할 수 있는지 체크 bool 변수 
            bool bFlag = false;

            //입력 문자를 숫자로 변환 후 iResult에 담고 성공여부를 bFlag에 담기
            bFlag = int.TryParse(svalue, out iResult); // svalue를 iResult 형태의 데이터로 변환 할 수 있는지 true or false 반환

            //벨리데이션 체크
            // 개발자가 프로그램 개발 시 오류 사항이 발생할 수 있는 로직을 예상하고
            // 오류 상황이 발생할 수 있는 로직을 처리 하기 전에 
            // 에러 메세지를 사용자 에게 전달 해 줌으로서
            // 시스템 오류 를 발생 시키지 않으면서 프로그램에 대한 신뢰도를
            // 높이는 개발 방법.
            // 사용자에게 정확한 사용 방법을 알리면서 올바르게 프로그램을 사용 할 수 있도록 유도.

            if (!bFlag)
            {
                MessageBox.Show("홀수,짝수 구분 불가");
                return;
            }
            if (iResult == 0)
            {
                MessageBox.Show("영");
            }
            if (iResult % 2 == 0)
            {
                MessageBox.Show("짝수입니다.");
            }
            else if(iResult %2 == 1)
            {
                MessageBox.Show("홀수입니다.");
            }
           

        }

        private void btnTernaryOperator_Click(object sender, EventArgs e)
        {
            //삼항 연산자 
            //피 연산자의 개수가 3개인 조건부 연산자.
            // if - else구문을 한줄로 간단하게 표현할 수 있기 때문에 사용 
            //IN-LINE IF문이라고도 한다.
            //입력한 값을 받아오기 
            string svalue = txtBS.Text;

            //정수 데이터 변수 생성
            int iResult = 0;

            //입력 받은 값을 숫자로 변환할 수 있는지 체크 bool 변수 
            bool bFlag = false;

            //입력 문자를 숫자로 변환 후 iResult에 담고 성공여부를 bFlag에 담기
            bFlag = int.TryParse(svalue, out iResult); // svalue를 iResult 형태의 데이터로 변환 할 수 있는지 true or false 반환

            //결과를 담을 STRING 변수
            string sResult = string.Empty; //""
            // string sResult = "";

            sResult = (iResult % 2 == 0) ? "짝수입니다." : "홀수입니다.";
            MessageBox.Show(sResult);
        }
    }
}
