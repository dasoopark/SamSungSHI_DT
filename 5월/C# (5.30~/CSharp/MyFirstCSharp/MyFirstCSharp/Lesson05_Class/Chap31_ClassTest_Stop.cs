using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstCSharp.Lesson05_Class
{
    public partial class Chap31_ClassTest_Stop : Form
    {
        private Form _TempForm; //Form 형식
        public Chap31_ClassTest_Stop()
        {
            InitializeComponent();
        }
        public Chap31_ClassTest_Stop(Form TempForm) //이번엔 Form형식으로 받기 , Form 은 도화지와 같다.
        {
            InitializeComponent();
            _TempForm = TempForm;
          
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            //1번째 방법
            //MessageBox.Show("전원을 끕니다.");
            //Chap31_ClassTest_Main.state = "전원 OFF";

            _TempForm.Tag = "비가동";
         
            MessageBox.Show("비가동 상태를 등록 하였습니다.");
            this.Close(); //현재 창 종료
        }
    }
}
