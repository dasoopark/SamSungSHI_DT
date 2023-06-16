using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstCSharp
{

    // Partial Class(분할 클래스, 파생 클래스)
    // 클래스는 동일한 NameSpace에서 같은이름으로 작성될 수 없다.
    // 여러명이 같은 클래스를 동시에 개발 하거나.
    // 단위 모듈별로 코딩을 나누어 개발해야 하는 경우.
    // 같은 기능을 수행하는 클래스임을 표현하는 키워드

    partial class Chap27_AccessModifier_Partial
    {
        public string sPublic = "Public";
        private string sPrivate = "Private";
        protected string sPartial = "Partial";
    }   

    partial class Chap27_AccessModifier_Partial
    {
        // 같은 이름의 클래스는 두개 이상 만들 수 없다.
        // partial Class를 선언하면
        // 같은 이름으로 두개의 클래스를 생성할 수 있다.
        // 이때 * 클래스가 두개가 생성 된게 아니라.
        // 하나의 클래스임을 선언하는 키워드가 Partial
        void CheckValue()
        {
            sPublic = sPrivate = sPartial; //Partial 클래스 내에서는 모든 멤버들이 공유 가능
        }
    }

   class NewClass2
    {
        void FindValue()
        {
            // 클래스 인스턴스 화, 객체 화.
            Chap27_AccessModifier_Partial CHAP27_P = new Chap27_AccessModifier_Partial();
            CHAP27_P.sPublic = "접근이 가능 합니다.";
            //CHAP27_P.sPartial = "Protected 접근이 불가능 합니다.";
            //CHAP27_P.sPrivate = "Private 접근이 불가능 합니다.";
        }
    }


}
