using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace MyFirstCSharp
{
  
    public partial class Chap31_ClassTest_Run : Form
    {
       
        Chap31_ClassTest_Main _TempClass;
        public Chap31_ClassTest_Run()
        {
            InitializeComponent();
            
        }
        public Chap31_ClassTest_Run(Chap31_ClassTest_Main TempClass)  //생성자.
        {
            InitializeComponent();
            _TempClass = TempClass;
        }
        
        private void btnRun_Click(object sender, EventArgs e)
        {
            // 가동 화면 클래스 에서 가동 버튼을 클릭 하였을 경우

            // 1. 벨리데이션을 통해 거를 내역은 먼저 길러놓고 (로직을 수행하면 안되는 경우)
            // 2. 정상 조건 일 경우의 로직을 안전하게 구현.
            // 3. 데이터 베이스의 세션을 종료.
            // 4. 메세지를 통해 상태 보고
            // MessageBox.Show("전원을 킵니다.");
            // Chap31_ClassTest_Main.state = "전원 ON";


            //2번째 방법
            _TempClass.Tag = "가동중";
            MessageBox.Show("전원을 킵니다.");
            this.Close(); //현재 클래스를 종료 (현재 클래스를 메모리 에서 소거 )
        }
    }
}
