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
    public partial class Chap23_TryCatchFinally : Form
    {
        //예외 처리 Exception
        // 프로그램 구동 시 발생 할 수 있는 시스템 오류 를 검출하고,
        // 예외 상황을 발생시키는 로직을 통하여
        //예외 처리를 할 수 있는 로직을 추가 및 실행 하게 함으로서
        // 개발자가 예상하지 못한 상황을 미리 막고
        //사용자에게 프로그램의 신뢰도를 발생시키기 위함. 

        //클래스 인스턴스 변수 배열 생성.
        int[] iValues =  { 1, 3, 5 };
        public Chap23_TryCatchFinally()
        {
            InitializeComponent();
        }

        #region <문제 발생>
        private void btnSysError_Click(object sender, EventArgs e)
        {
            //예외 상황 발생 시키기
            //iValues 배열에 데이터가 3개 존재 하지만 (index=2),
            //i가 3이 되는 순간, index를 벗어 나므로 시스템 오류가 발생한다.

            for(int i = 0; i<5; i++)
            {
                MessageBox.Show(iValues[i].ToString());
               
            }
        }
        #endregion

        #region < 예외 처리 문법>
        private void btnTryCatch_Click(object sender, EventArgs e)
        {
            //예외 처리
            // * try와 catch 구문은 반드시 쌍으로 구현 되어야 한다.

            try
            {
                //정상적인 로직을 처리 하는 부분.
                for(int i =0; i<5;i++)
                {
                    MessageBox.Show(iValues[i].ToString());
               
                }
            }
            catch
            {
                //예외 상황이 발생 하였을 경우 대체 할수 있는 로직이 등록이 되는 부분.
                //오류가 발생하는 순간 catch로 이동.
                // 예외 상황을 알리는 메세지를 사용자에게 제공 함으로서
                // 시스
                MessageBox.Show("구동 중 예외상황이 발생하였습니다. 사용자와 문의 하세요.");
            }
        }
        #endregion


        #region < 메서드 내에서의 예외상황 발생시 로직의 흐름 >
        private void btnMethodException_Click(object sender, EventArgs e)
        {
            //메서드를 감싸고 있는 try Catch의 경우 (메인 로직)
            //메서드 내에서 오류가 발생 시
            // 메서드 내부에서 예외 상황을 발생 시켰으면 메인 입장에서
            try
            {
                if(SetErrorMethod())
                {
                    MessageBox.Show("정상적으로 완료가 되었습니다.");
                }
                SeterrorMethod2();
            }
            catch
            {
                MessageBox.Show("메인 로직에서 오류가 발생하였습니다.");
            }
        }

        bool SetErrorMethod()
        {
            try
            {
                //반드시 오류를 발생 시키는 로직.
                for(int i =0; i<5;i++)
                {
                    MessageBox.Show(iValues[i].ToString());
                }
                return true; //정상적으로 처리 되었을 경우.
            }
            catch
            {

                MessageBox.Show("서브 메서드에서 구동중 오류가 발생하였습니다.");
                return false; //메서드 기능 동작 중 오류가 발생 하였을 경우.
            }
        }

        void SeterrorMethod2()
        {
            for(int i=0; i<5; i++)
            {
                MessageBox.Show(iValues[i].ToString());
            }
        }
        #endregion

        private void btnException_Click(object sender, EventArgs e)
        {
            // Exception ?
            // 발생할 수 있는 시스템 오류의 원인을 확인하여
            // 프로그램 개발자 또는 사용자에게 보고 할 수 있도록 전달하는 클래스
            // 오류가 검출되는 상황에 맞는 Exception 클래스를 별도로 사용할 수 있으나,
            //통상적으로 Exception 클래스 (모든 예외상황을 검출하는 클래스)를 사용하며
            //자세한 오류 내역을 검출 하고자 할때 별도의 Exception 클래스를 혼합하여 사용 가능.

            // 구현 하려고 하는 로직에서 오류가 발생 할 것 같은 Exception 클래스를 선택.
            try
            {
                for(int i=0; i<5;i++)
                {
                    MessageBox.Show(iValues[i].ToString());
                }    
                // 예상 오류 내역은 index over 오류
            }
           catch(Exception ex)
            {
                //Exception : 모든 종류의 오류를 검출 하는데 자세하지는 못하다.
            }
        }




        #region < --  Exception 의 종류 -- > 

        // Exception 모든 종류의 예외를 처리할 수 있다.
        //
        // ArgumentException 메서드에 전달 되는 null이 아닌 인수가 잘못되었다.
        //
        // ArgumentNullException 메서드에 전달 되는 인수가 null이다.
        // 
        // ArgumentOutOfRangeException 인수가 유효한 값 범위를 벗어났다.
        // 
        // DirectoryNotFoundException 디렉터리 경로 일부가 잘못되었다.
        // 
        // DivideByZeroException 0으로 나누었다.
        // 
        // DriveNotFoundException 드라이브가 없거나 사용할 수 없다. 

        // FileNotFoundException 파일이 없다.
        // 
        // FormatException 문자열에서 변환할 수 있는 적절 한 형식이 아니다.
        // 
        // IndexOutOfRangeException 인덱스가 배열 또는 컬렉션의 범위를 벗어났다.
        // 
        // InvalidOperationException 개체의 현재 상태에서 메서드 호출을 사용할 수 없다.
        // 
        // KeyNotFoundException 컬렉션의 멤버에 액세스 하는 데 지정 된 키를 찾을 수 없다.
        // 
        // NotImplementedException 메서드 또는 작업이 구현 되지 않았다.
        // 
        // NotSupportedException 메서드 또는 작업이 지원 되지 않는다.
        // 
        // ObjectDisposedException 삭제 된 개체에 대한 작업을 수행했다.
        // 
        // OverflowException 산술, 캐스팅 또는 변환 작업을 수행 하면 오버플로가 발생한다.
        // 
        // OverflowException 작업 결과가 대상 데이터 형식의 범위를 벗어났다.
        // 
        // PathTooLongException 경로 또는 파일 이름이 시스템에서 정의한 최대 길이를 초과한다.
        // 
        // PlatformNotSupportedException 현재 플랫폼에서 작업이 지원 되지 않는다.
        // 
        // RankException 차원 수가 잘못되었다.
        // 
        // TimeoutException 작업에 할당 된 시간 간격이 만료 되었다.
        // 
        // UriFormatException 잘못 된 URI(Uniform Resource Identifier)가 사용 되었다.
        #endregion

        #region <Finally>
        private void btnFinally_Click(object sender, EventArgs e)
        {
            //try와 catch는 반드시 한쌍으로 구현되어야 한다.
            try
            {
                string sMessage = "Try";

                for(int i = 0; i<5; i++)
                {
                    MessageBox.Show(iValues[i].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                //finally 구문은 try와 catch의 마지막에 구현 된다.
                //반드시 구현되어야 하는 구문은 아니다.
                // -Try(정상로직이 완료되는 경우)와 
                // Catch (예외 상황의 로직이 실행되는 경우)
                // 에 관계 없이 반드시 실행 되어야 하는 로직이 위치.

                // 보통 데이터 베이스의 작업 완료 이후 데이터베이스 세션을 종료 해주는 역할로 사용.
            }
        }
        #endregion

        #region <Throw 예외 상황을 강제로 발생 시키는 구문>
        private void btnThrow_Click(object sender, EventArgs e)
        {
            //예외 상황 강제 발생(Throw)
            // 예외상황을 강제로 발생 시켜 예외 처리 로직을 (Catch) 수행 하게 한다.

            //0 ~ 10 난수를 받아 서 5이하 일 경우는 예외 로직을 처리하는 시나리오.
            Random random = new Random();

            try
            {
                if(random.Next(0,11) <= 5) //0이상 11미만.
                {
                    //예외 상황에 있는 로직을 강제로 실행.
                    throw new Exception("10 이하의 값을 생성 하였습니다.");
                }
            }
            catch(Exception ex)
            {
                //예외 상황의로직을 구현
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                //데이터 베이스 종료
            }
        }
        #endregion
    }
}
