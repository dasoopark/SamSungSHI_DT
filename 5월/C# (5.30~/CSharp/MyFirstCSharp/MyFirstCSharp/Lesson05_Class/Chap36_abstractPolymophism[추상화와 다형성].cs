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
    public partial class Chap36_abstractPolymophism : Form
    {
        #region < 0, 추상화의 정의 와 Abstract >
        /*
            추상화 
            구현해야 하는 기능을 정의만 해 둔다.
            추상적으로 기능에 대한 정의, 로직, 은 존재하지 않는 상태
            추상클래스를 상속받는 클래스는 추상클래스에서 정의한 기능을 구현해야 한다.
          
            * 추상 클래스의 상속을 구현 하는 이유?
              프로그램을 설계 하는 사람. 많은 클래스(화면)에서 반드시 구현해야 하는 기능이 있을 때.
             (조회, 추가, 저장, 삭제)
             여러 개발자들이 개발을 할 때 설계자의 의도를 파악하지 못하고
            1. 조회, 추가, 저장, 삭제 등에 대한 기능을 누락하여 구현할 경우가 발생할 수도 있다.
            2. 개발자들 마다 조회(search(), find()), 추가, 저장, 삭제, 기능의 명칭을 통일성 없이 사용할 가능성이 있음. 

            설계자가 생각한 필수 기능(조회, 저장 등)과 기능에 대한 명칭(Search(), inquire()) 상속 받아서
            각 클래스 별로 목적에 맞게 기능을 상세히 구현할 수 있도록 하여
            프로그램에 대한 일관성과 통일성을 지키고 필수 기능 누락 상황을 예방 할 수 있다.


            abstract : 추상 클래스를 만들어 주는 키워드
            1. 상속 받는 클래스에서 반드시 구현 해야하는 기능
            2. 클래스 멤버 중 하나라도 abstract 형식이면 클래스 자체는 abstract 키워드를 부여해야 한다.
            3. 메서드의 기능명칭 만 정의 하되 구현은 상속 받은 클래스에서 한다.
                - 메서드의 본문을 정의 할 수 없다. (일반 메서드를 작성 할 수 없다)
            4. Abstract 클래스는 일반 함수 및 필드 멤버를 가질 수 있다.
            5. abstract 클래스는 인스턴스 화(객체화) 할 수 없다. (기능 정의와 상속이 목적)

            **** 상속 받을 클래스에서 반드시 구현해야 하지만 누락 할 가능성이 있는 기능을
                 구현 할 수 있도록 강제 하는 기능
         */



        #endregion

        #region <2. 상속한 클래스의 기능 실행 . 및 업 캐스팅 >

        public Chap36_abstractPolymophism()
        {
            InitializeComponent();
        }

        private void btnAbstract_Click(object sender, EventArgs e)
        {
            // 추상 클래스는 인스턴스화 할 수 없다 (기능 정의 와 상속이 목적이기 때문)
            // ToolBar toolBar = new ToolBar();

            // itemMaster 클래스의 인스턴스화 및 기능 실행.
            ItemMaster iteM = new ItemMaster();
            iteM.DoSearch(); // 추상클래스(ToolBar)에서 상속 받아 구현을 강제 받은 메서드.
            iteM.DoSave();  // 추상클래스(ToolBar)에서 상속 받아 구현을 강제 받은 메서드.
            iteM.DoPrint(); // 품목 마스터(ItemMaster) 클래스에서 별도로 구현한 메서드.

            // 추상 클래스의 업캐스팅
            // 부모 클래스의 기능 중 자식 클래스가 오버라이드(구현 선언)
            // 한 기능을 부모 클래스의 객체로 형 변환 후 실행 할 수 있다.

            ToolBar toolBar = new ItemMaster(); // 업캐스팅 => 부모가 동작 가능.
                                                // toolBar.DoPrint(); 자식만 가지고 있는것은 쓸 수 없음.
                                                // ItemMaster() 생성자에 있는 기능을 실행하고 (초기화)
                                                // new : 그 결과를 Heap 메모리에 등록을 해라.
                                                // item : Stack 에 item이라는 이름으로 등록하고
                                                // = : new로 생성한 Heap에 있는 메모리 주소를 item에 전달하라.
        }
        #endregion

        #region <4. 업 캐스팅을 통한 추상 메서드 기능 호출. >


        // 리팩토링 : 프로그램 구현에 영향을 주지 않고 간결 하고 효율적인 코드로 꾸미는 작업.
        // 코드 리팩토링 시작 0단계 -------------------------------------------------------------------------------------------------
        //아래 3개의 메서드는 불필요한 로직이 반복 되어 메서드 하나로 줄인다.
        //private void btnUserSearch_Click(object sender, EventArgs e)
        //{

        //}

        //private void btnCustSearch_Click(object sender, EventArgs e)
        //{

        //}


        // 코드 리팩토링 1번째 단계 - -----------------------------------------------------------------------------------------------
        //private void MenuSearch(object sender, EventArgs e) //버튼 3개의 클릭에 대한 연결을 MenuSearch로 통합.
        //{
        //    //3개의 버튼 태그에 각 클래스 이름 태그명으로 넣어줌.

        //    Button button = (Button)sender;
        //    if (button.Name == "btnUserSearch")
        //    {
        //        // 사용자 정보 조회 기능을 구현
        //        UserMaster UM = new UserMaster();
        //        UM.DoSearch(); //사용자 정보 조회 기능.
        //    }
        //    if(button.Name == "btnCustSearch")
        //    {
        //        //고객 정보 조회 기능 실행.
        //        CustMaster CM = new CustMaster();
        //        CM.DoSearch();
        //    }
        //    if(button.Name == "btnItemSearch")
        //    {
        //        //품목 정보 조회 기능 실행
        //        ItemMaster IM = new ItemMaster();
        //        IM.DoSearch();
        //    }
        //}

        // 코드 리팩토링 2 번째 단계 -------------------------------------------------------------------------------------------------
        // 버튼에 Tag 를 두어 클래스를 가변적으로 생성.

        //private void MenuSearch(object sender, EventArgs e) //버튼 3개의 클릭에 대한 연결을 MenuSearch로 통합.
        //{
        //    // 1. 버튼의 객체를 생성.
        //    Button button = (Button)sender;

        //    // 2. 찾으려는 클래스의 네임스페이스와 이름.
        //    string sClassName = $"MyFirstCSharp.{button.Tag}";

        //    // 3. 문자열로 클래스를 찾기.
        //    Type type = Type.GetType(sClassName);

        //    // 4. 해당 클래스 를 인스턴스 화 하기.
        //    object instence = Activator.CreateInstance(type);

        //    // 품목, 사용자, 고객 클래스 3개중에 하나
        //    // is : if(instence is ItemMaster) instence 객체가 Itemmaster 객체로 변환될 수 있다면.

        //    // as : instence 객체 가 Itemmaster 클래스로 변환 될 수 있다면 변환하고(ItemMaster IM Stack 메모리에 주소 를 전달하라) 안된다면 Null을 반환하라.
        //    ItemMaster IM = instence as ItemMaster;     
        //    if( IM != null )
        //    {
        //        IM.DoSearch();
        //    }

        //    CustMaster CM = instence as CustMaster;
        //    if (CM != null)
        //    {
        //        CM.DoSearch(); //고객 마스터의 조회 기능을 실행
        //    }

        //    UserMaster UM = instence as UserMaster;
        //    if (UM != null)
        //    {
        //        UM.DoSearch(); // 사용자 마스터 클래스의 조회 기능을 실행.
        //    }

        //    // 해당 클래스에 있는 기능을 호출 하기 위해서는
        //    // 해당 클래스의 객체를 선언 해야 한다.
        //    // 만약 100 개의 화면이 있을경우 100개의 로직을 구현해 내야 한다.
        //    // 코드가 간결해 지지 못하고 확장성 과 유지보수성이 떨어진다.
        //}

        // 코드 리팩토링 3번째 단계 ---------------------------------------------------------------------------------------------------
        // 다형성 업캐스팅을 활용.
        private void MenuSearch(object sender, EventArgs e) //버튼 3개의 클릭에 대한 연결을 MenuSearch로 통합.
        {
            // 1. 버튼의 객체를 생성.
            Button button = (Button)sender;

            // 2. 찾으려는 클래스의 네임스페이스와 이름.
            string sClassName = $"MyFirstCSharp.{button.Tag}";

            // 3. 문자열로 클래스를 찾기.
            Type type = Type.GetType(sClassName);

            // 4. 해당 클래스 를 인스턴스 화 하기.
            object instence = Activator.CreateInstance(type);



            // 다형성 : 다형성 을 구현하기 위한 기능 : UPCasting
            //UPCasting을 통한 다형성 등장.
            //UPCasting : 부모 클래스로 부터 구현을 정의 받은 기능을
            //  자식 클래스에서 구현하고 자식 클래스가 부모 클래스로 형변환 되면서 
            //  자식클래스의 기능을 부모 클래스의 객체 가 구현 할 수 있도록 하는 기능.
            ToolBar TempMenu = instence as ToolBar; //ToolBar의 기능은, 모든 마스터가 다 가지고 있음 -> 부모한테 줄수있음

  
            if(TempMenu != null)
            {
                TempMenu.DoSearch();
            }
            
        }
    }


    #endregion


    #region < 1. 추상 클래스의 생성 및 상속 >
    // 모든 화면에서 구현해야 하는 기능
    public abstract class ToolBar // 멤버 중 하나라도 abstract가 부여(추상화) 되어 있을 경우 클래스도 abstract(추상화)를 설정 해야 한다.
    {
        public abstract void DoSearch();//반드시 구현해야 하는 기능 1

        public abstract void DoSave(); //반드시 구현해야 하는 기능 2

        public void DoSomething()
        {
            // 로직이 구현되는 일반 메서드를 작성 할 수 있다.
        }
        //public abstract void DoDelete()
        //{
        //    //abstract 멤버 에는 기능 구현을 할 수 없다( 일반 메서드를 만들 수 없다. )
        //    Messagebox.show("");
        //}

    }
    class ItemMaster : ToolBar
    {
        public override void DoSave()
        {
            MessageBox.Show("품목의 내용을 저장합니당.");
        }

        // 부모 추상 클래스에서 구현을 강제 하게 하는 기능을 구현 하겠다 선언하는 키워드
        // Override : 내가 부모 클래스(추상 클래스)에서 지시한 기능을 구현 하겠다.
        public override void DoSearch()
        {
            MessageBox.Show("조건에 맞는 품목을 검색합니다.");
        }

        public void DoPrint()
        {
            MessageBox.Show("품목 화면을 출력합니다.");
        }
    }
    #endregion

    #region < 3. 추상 클래스를 상속 받는 추가 (클래스) 화면 들 >
    class UserMaster : ToolBar
    {
        public override void DoSave()
        {
            MessageBox.Show("사용자 정보를 저장합니다.");
        }

        public override void DoSearch()
        {
            MessageBox.Show("사용자 정보를 조회합니다.");
        }
    }

    class CustMaster : ToolBar
    {
        public override void DoSave()
        {
            MessageBox.Show("고객 정보를 저장합니다.");
        }

        public override void DoSearch()
        {
            MessageBox.Show("고객 정보를 조회합니다.");
        }
    }


    #endregion
}
