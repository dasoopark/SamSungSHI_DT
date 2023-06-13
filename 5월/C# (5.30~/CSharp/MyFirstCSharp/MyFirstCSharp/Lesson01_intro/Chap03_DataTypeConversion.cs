using System; 
using System.Windows.Forms;

namespace MyFirstCSharp
{
    public partial class Chap03_DataTypeConversion : Form
    {
        // 데이터 타입의 형 변환( 숫자 -> 문자 )
        // 문자열로 데이터타입을 변경 : .ToString() , Convert.ToString()

        // 데이터 타입의 형 변환( 문자 -> 숫자 )
        // 숫자형으로 데이터타입을 변경 :  .Parse(),  Convert.ToInt32() 


        // 명시적 형변환
        // 변경할 데이터 타입을 지정후 변환
        // .ToString() , Convert.ToString();
        // .Parse(),     Convert.ToInt32() 

        public Chap03_DataTypeConversion()
        {
            InitializeComponent();
        }

        private void btnItoS_Click(object sender, EventArgs e)
        {
            // 디버깅 
            // 프로그램 개발 시 오류 내역을 검출 하거나. 프로그램의 로직 이 실행되는 각 단위 별로 
            // 결과 를 확인 할 수 있도록 하는 프로그래밍 방법.
            // 브레이크 포인트. : 로직이 실행 될때 멈춰서 디버깅이 시작 되는 시점 ( 왼쪽 음영색 라인 클릭, F9 )

            // 숫자 를 문자 로 변환하기 기능. 

            // 1. 변환될 대상 숫자를 담을 변수 생성 및 초기화.
            // 초기화 할때 또는 대입 할때 대입되는 대상 (리터럴)
            int iValue  = 10;
            int iValue2 = 20;

            double dValue  = 10.1;
            double dvalue2 = 20.5;

            // 2. 변형된 데이터 타입이 담길 문자 변수.
            string sValue1;
            string sValue2;

            // 3. iValue 의 데이터 타입 int 의 기능중 ToString()이라는 기능을 사용하여
            // 숫자 를 문자 로 변형 후 sValue(string) 에 대입한다.
            sValue1 = iValue.ToString();

            // 4. 메세지 박스로 변형된 문자형 숫자를 표현
            MessageBox.Show(sValue1);

            // sValue2 에 dvalue2 을 대입 해 보세요 (sValue2 를 dvalue2 문자열로 초기화).
            sValue2 = dvalue2.ToString();

            // 문자열로 변환하는 기능 2번째
            sValue2 = Convert.ToString(dvalue2);

            // Convert.ToString() 의 기능은 결과적으로는 .ToString() 가 같은 결과를 생성 하지만. 
            // Null 처리 의 오류 반환 때문에 .ToString() 보다는 Convert.ToString() 형식을 사용하는것을 
            // 추천.


            // 문자 열의 합 ( 연관되는 문자열을 이어서 표현 )
            // sValue1 : "10" , sValue2 : "20.5"
            string sValue3 = sValue1 + sValue2;

            MessageBox.Show(sValue3); // 1020.5

        }

        private void btnStoI_Click(object sender, EventArgs e)
        {
            // 문자를 숫자로 변경하는 로직. 

            // 1. 숫자로 바꿀 문자열 변수 생성.
            string sValue1 = "안녕하세요";
            string sValue2 = "10";
            string sValue3 = "10.1"; // 소수를 포함한 실수.


            // 2. .Parse() 기능을 통한 변환.
            int iResult = 0; // 변환 결과를 담을 int 변수.

            // 안녕하세요 문자를 숫자로 바꾸려 했으나 변환 실패를 통한 런타임 오류
            // iResult = int.Parse(sValue1);
            
            // 숫자로 변환 할 수 있는 문자일 경우 오류 없이 변환이 완료.
            iResult = int.Parse(sValue2);

            // 3. Convert.ToInt32() 
            // 문자 -> 숫자 
            // 숫자로 바꿀수 없는 문자일 경우 시스템 오류 발생.
            //iResult = Convert.ToInt32(sValue1); // "안녕하세요" 가 숫자로 바뀔수 없으므로 오류 반환.


            // 4. 숫자 로 변환 할 수 있는 문자인지 검증하는 기능 .TryParse()

            // 숫자형 데이터 형변환 실패. 
            // bResult : false 
            // iResult : 0 
            bool bResult =  int.TryParse(sValue1, out iResult);

            // 숫자형 데이터 형변환 실패 (실수형 데이터(소수포함) 를 정수로 변형하려 할때 실패)
            // sValue3 : 10.1 
            // bResult :  false
            // iResult :  0 
            bResult = int.TryParse(sValue3, out iResult);


            // 숫자형 데이터 형변환 (소수 데이터를 형변환)
            double dResult = 0; // 소수 형변환 결과를 받을 변수.

            // 소수 형 실수 문자열을 실수 데이터 타입으로 형변환 및 결과 검출.
            // sValue3 : "10.1"
            // dResult : 10.1
            // bResult : true
            bResult = double.TryParse(sValue3, out dResult);

            // 정수형 문자열을 실수 데이터 타입으로 형변환 하는경우.
            // sValue2 : "10";
            // dResult : 10
            // bResult : true
            bResult = double.TryParse(sValue2, out dResult);


            // 문자 를 숫자 로 형변환 할 경우. .Parse() 와 Convert.ToInt32() 를 사용 할 수 있지만. 
            // 변환 할수 없는 유형의 문자인 경우 런타임 오류가 발생 하므로 
            // 데이터타입.TryParse() 기능을 사용하여 형변환 하는것을 추천.
        }

        private void btnNull_Click(object sender, EventArgs e)
        {
            // 다중 주석 처리 문. /* */
            /* 
              Null 상태의 변환 처리. 
            - Convert.ToString() 구문을 사용 시 Null 처리된 값이 있을 경우 빈값을 반환.
            
            - Null ?
              . 데이터의 용량(메모리) 가 할당되지 않은 상태. 
              . "" 은 아무런 값이 없는 값이 할당된 상태

              . 숫자형 데이터 타입은 ? 키워드를 추가하여 null 상태로 만들수 있다. 

            */

            string sValue = null;
            //MessageBox.Show(sValue.ToString()); // sValue 가 null 처리 되었으므로 오류가 발생. (런타임 오류 )
            MessageBox.Show(Convert.ToString(sValue)); // sValue 가 null 처리 되었어도 아무것도 없는값으로 치환하여 반환
            string sValue2 = "";


            // 숫자 데이터를 null 처리 하는 방법.  ? 
            // Convert.ToString 과 .ToString() 형식으로 Null 을 변환 할 수있다.
            int? iValue = null;
            MessageBox.Show(iValue.ToString());
        }

        private void btnSUM_Click(object sender, EventArgs e)
        {
            // 문자열 의 합과 숫자의 합.
            string sValue1 = "ABC";
            string sValue2 = "DEF";

            string sValue3 = sValue1 + sValue2;
            MessageBox.Show(sValue3); // ABCDEF

            int iValue1 = 50;
            int iValue2 = 30;
            int iValue3 = iValue1 + iValue2;
            MessageBox.Show(Convert.ToString(iValue3)); // 80
        }
    }
}
