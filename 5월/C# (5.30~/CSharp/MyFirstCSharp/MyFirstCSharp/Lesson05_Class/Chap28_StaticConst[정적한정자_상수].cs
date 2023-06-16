using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstCSharp
{

    /*
     Static 한정자 ( 정직 한정자) ***
        - 프로그램 전체에서 유기적으로 관리해야 하는 값이 발생할 경우
     *    객체의 생성 없이 클래스 내의 필드값을 직접 호출 및 관리 할 수 있도록 하는 한정자.
     *    클래스에 머물러있는 필드나 메서드 라는 의미에서 정적 필드 (클래스필드, 클래스 전역 변수)
     *    정적 메서드 (클래스 메서드) 라고도 불림.
     *    최초 초기화(호출 되는 시점) 될때
     *    Data 영역(정적 변수), Code 영역 (정적 메서드)의 메모리에 등록되어  프로그램이 종료 될때 까지 소멸되지 않는다.
     *    불필요하게 사용할 경우 메모리 효율성을 떨어트릴 수 있다.
     */
    internal class Chap28_StaticConst
    {
    }
    class Static_Class
    {
        //모든 필드가 static으로 한정되는 클래스.
        public static string sValue = "정적 변수 생성 되었습니다.";
    }

    class StaticOrinstance_Class
    {
        //정적 필드와 인스턴스 필드가 혼합되어 구현된 클래스.
        public string sinstance = "인스턴스 변수입니다.";
        public static string sStaticValue = "정적 변수입니다."; //Data 메모리 영역에 등록.

        //클래스 내에 정적 필드와 인스턴스 필드를 동시에 생성 할 수 있다.

        public static void StaticMethod()
        {
            //외부에서 언제든지 접근 가능한 정적 메서드(고정되어있는 메서드)
            // 정적 메서드
            //메서드의 코드 영역에 저장, 프로그램 종료 시 까지 소멸 되지 않는다.
            sStaticValue = "정적 변수가 수정 되었습니다.";
            int iValue = 0;
        }

    }
    //클래스 자체를 static 클래스로 지정 할 경우.
    // 클래스 내의 모든 멤버는 Static 형식으로 지정 되어야 하고
    // 모든 멤버는 Code영역 및 Data 영역에 등록이 된다.
    static class StaticClass
    {
        private static string sPrivate;
        public static string sPublic;

        //정적 한정자, 접근제한자 표현
        static public string sPublic2;


        static void StaticMethod()
        {

        }

       // public string sValue = "Static이 아니므로 만들 수 없습니다.";
    }
  



}
