using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstCSharp.Lesson05_Class
{
    public partial class Chap31_ClassTest_Main : Form
    {

        public static string state = "대기중";
        

        // 다른 방법으로 풀기
        // 1. 일반 인스턴스 변수
       // private string sNowsTate = "대기중"; //가동 / 비가동 클래스에서 전역변수로 전달 시 값형으로 변형 (X) 

        //2. 클래스(참조)를 전달.
        // int[], List<> 여기선 자기 자신.
        public Chap31_ClassTest_Main()
        {
            InitializeComponent();
         
        }

        private void btnMonitering_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"현재 설비의 상태는 {this.Tag} 입니다.");
        }

        private void btnRunCall_Click(object sender, EventArgs e)
        {
            // 가동 등록 화면 호출.
            // Chap31_ClassTest_Run Chap31 = new Chap31_ClassTest_Run(ref sNowsTate);
           
            Chap31_ClassTest_Run Chap31 = new Chap31_ClassTest_Run(this); //참조 전달 형식으로 자기 자신의 클래스를 전달.

            this.Visible = false; // 현재 화면을 숨김처리.
                                  //Show : 비동기 - 한창 띄우고 기존창은 사라짐
                                  //ShowDialog : 동기. 
         
            Chap31.ShowDialog();
    
            this.Visible = true;

        }

        private void btnStopCall_Click(object sender, EventArgs e)
        {
            // 정지 등록 화면 호출.
            Chap31_ClassTest_Stop Chap31 = new Chap31_ClassTest_Stop(this);

            this.Visible = false; // 현재 화면을 숨김처리.
                                  //Show : 비동기 - 한창 띄우고 기존창은 사라짐
                                  //ShowDialog : 동기. 

            Chap31.ShowDialog(); // 모달창 {동기식으로 호출}
          
            this.Visible = true;
        }
    }
}
