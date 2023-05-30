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
    public partial class Chap03_DataTypeConversion : Form
    {
        //디버깅
        //프로그램 개발 시 오류 내역을 검출 하거나, 프로그램의 로직이 실행되는 각 단위 별로 결과를 확인
        //할 수 있도록 하는 프로그래밍 방법.
        //브레이크 포인트 : 로직이 실행 될 때 멈춰서 디버깅이 시작 되는 시점(왼쪽 음영색 라인 클릭, f9)

        //명시적 형 변환
             //변경할 데이터타입을 지정 후 변환하는 방법 
             //데이터 타입의 형 변환 ( 숫자 -> 문자 )
             //문자열로 데이터타입을 변경 : .ToString(), convert.ToString()

                // 데이터 타입의 형 변환 ( 문자 -> 숫자 )
             // 숫자형으로 데이터타입을 변경: .Parse(), Convert.ToInt32()
        public Chap03_DataTypeConversion()
        {
            InitializeComponent();
        }

        private void btnitos_Click(object sender, EventArgs e)
        {
            //숫자를 문자로 변환하기 기능~-~.
            // 1.변환 될 대상 숫자를 담을 변수 생성 및 초기화
            //초기화 할 때 또는 대입 할 때 대입되는 대상(리터럴)
            int ivalue = 10;
            int ivalue2 = 20;

            double dvalue = 10.1;
            double dvalue2 = 20.5;

            //2. 변형되는 데이터 타입이 담길 문자 변수
            string svalue1;
            string svalue2;

            //ivalue의 데이터타입 int의 기능중 ToString()이라는 기능을 사용하여, //숫자를 문자로 변형 후 svalue(String)에 대입한다.
            svalue1 = ivalue.ToString();

            //4. 메세지 박스로 출력
            //MessageBox.Show(svalue1);

            // svalue2 에 dvalue2을 대입 해 보세요.
            svalue2 = dvalue2.ToString();
            MessageBox.Show(svalue2);

            //문자열로 변환하는 기능 2번째 - 실무에서 많이 쓰는 방식 (convert)
            svalue2 = Convert.ToString(dvalue2);

            //Convert.ToString()의 기능은 결과적으로는 .ToString()과 같은 결과를 생성하지만,
            // Null처리의 오류 반환 때문에 .ToString()보다는 Convert.ToString() 형식을 사용하는것을 추천합니다.

            //문자 열의 합
            // svalue: "10", svalue2: "20.5"
            string svalue3 = svalue1 + svalue2; //숫자로 계산되는게 아니라 문자열만 더해짐 (연관되는 문자열을 이어서 표현) 1020.5
            
            MessageBox.Show(svalue3);



        }

        private void btnStoI_Click(object sender, EventArgs e)
        {
            //문자를 숫자로 변경하는 로직
            //1. 숫자로 바꿀 문자열 변수 생성
            string svalue1 = "안녕하세요";
            string svalue2 = "10";
            string svalue3 = "10.1";

            //2. .Parse()기능을 통한 변환.
            int iResult = 0; //변환 결과를 담을 int변수, 

            // iResult = int.Parse(svalue1); 안녕하세요라는 문자를 숫자로 바꾸려 했으나, 변환 실패를 통한 런타임 오류가 발생을 함
            // 숫자로 변환 할 수 있는 문자일 경유 오류 없이 변환이 완료.
            iResult = int.Parse(svalue2);

            //3. Conver.ToInt32()
            //문자 -> 숫자
            //숫자로 바꿀 수 없는 문자일 경우 시스템 오류 발생.
            // iResult = Convert.ToInt32(svalue1); //"안녕하세요"가 숫자로 바뀔 수 없으므로 오류를 반환

            // 4. 숫자 로 변환 할 수 있는 문자인지 검증하는 기능 .TryParse()

            // 숫자형 데이터 형변환 실패.
            // bResult : false
            // iResult : 0
            bool bResult = int.TryParse(svalue1, out iResult);

            //숫자형 데이터 형변환 실패 (실수형 데이터(소수포함) 를 정수로 변형하려 할때 실패)
            // svalue3 : 10.1
            // bresult : false
            // iresult : 0
            bResult = int.TryParse(svalue3, out iResult);

            //숫자형 데이터 형변환 (소수 데이터를 형변환)
            double dResult = 0;//소수 형변환 결과를 받을 변수. 

            //소수 형 실수 문자열을 실수 데이터 타입으로 형변환 및 결과 검출.
            //svalue3 : "10.1"
            // dResult : 10.1
            // bResult : true
            bResult = double.TryParse(svalue3, out dResult);

            //정수형 문자열을 실수 데이터 타입으로 형변환 하는경우.
            // svalue2 : "10";
            // dResult : 10이 들어감
            // bResult: true가 들어감
            bResult = double.TryParse(svalue2, out dResult);

            // 문자 를 숫자 로 형변환 할 경우,  .Parse()와 Convert.ToInt32()를 사용할 수 있지만,
            // 변환 할 수 없는 유형의 문자인 경우 런타임 오류가 발생 하므로
            // 데이터타입.TryParse() 기능을 사용하여 형변환 하는 것을 추천.
            

            

        }

        private void btnNull_Click(object sender, EventArgs e)
        {
            // 다중 주석 처리 문. /* */
            /*
               - Null 상태의 변환 처리.
               - Convert.ToString() 구문을 사용 시 Null 처리된 값이 있을 경우 빈값을 반환.
               
               - Null ?
                    - 데이터의 용량(메모리)가 할당되지 않은 상태.
                    - **은 아무런 값이 없는 값이 할당된 상태.
                숫자형 데이터 타입은 ? 키워드를 추가하여 null 상태로 만들 수 있다.
            */
            string svalue = null;
            //MessageBox.Show(svalue.ToString()); //sValue가 null 처리 되었으므로 오류가 발생(런타임 오류)
            MessageBox.Show(Convert.ToString(svalue)); //svalue가 null처리 되었어도 아무 것도 없는값으로 치환하여 반환
            string svalue2 = "";

            //숫자 데이터를 null 처리 하는 방법. ? => convert.toString()쓰면 됨.
            //Convert.ToString과 .ToString() 형식으로 Null을 변환 할 수 있다.
            int? ivalue = null; 
            MessageBox.Show(ivalue.ToString());

            
        }

        private void btnSUM_Click_Click(object sender, EventArgs e)
        {
            //문자열의 합과 숫자의 합.
            string svalue1 = "ABC";
            string svalue2 = "DEF";

            string svalue3 = svalue1 + svalue2;
            MessageBox.Show(svalue3); //ABCDEF

            int ivalue1 = 50;
            int ivalue2 = 30;
            int ivalue3 = ivalue1 + ivalue2;
            MessageBox.Show(Convert.ToString(ivalue3)); //80
        }
    }
}
