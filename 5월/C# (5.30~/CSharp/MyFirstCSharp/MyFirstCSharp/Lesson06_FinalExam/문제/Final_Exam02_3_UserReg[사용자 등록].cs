using MyFirstCSharp.Lesson06_FinalExam.문제;
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
    public partial class Final_Exam02_3_UserReg : Form
    {
        //클래스의 전역 변수로 사용자 정보데이터 유형을 나열할 수 있는 List
        private List<UserInfo_Exam> userinfos = new List<UserInfo_Exam>();

        public Final_Exam02_3_UserReg(List<UserInfo_Exam> TempList)
        {
            InitializeComponent();
            userinfos = TempList; //주소 전달 해서 서로의 데이터 공유
        }

        private void btnUserReg_Click(object sender, EventArgs e) //등록
        {
            // 사용자 등록 을 하기 전 벨리데이션 체크.
            string sUserid = txtUserId.Text;
            string sPassword = txtPassWord.Text;
            string sUserName = txtUserName.Text;
            string sMailAddress = txtMailAddress.Text;
            

            if (sUserid == "" || sPassword == "" || sUserName == "" || sMailAddress == "")
            {
                MessageBox.Show("필수 입력 항목이 누락 되었습니다.");
                return;
            }

            foreach (UserInfo_Exam Check_UserInfo in userinfos)  //중복 ID 등록되지 않게 체크 조건문
            {
                if (Check_UserInfo.Userid == txtUserId.Text)
                {
                    MessageBox.Show("이미 등록되어 있는 ID입니다. 다른 ID를 사용하세요");
                    return;
                }
            }

            //사용자 등록 
            userinfos.Add(new UserInfo_Exam
            {
                Userid = sUserid,      // 사용자 ID
                PassWord = sPassword,    // 비밀번호
                UserName = sUserName,    // 사용자명
                MailAddress = sMailAddress, // 메일 주소
                UserFlag = true,        // 사용
                PassCnt = 0,            // 비밀번호 틀린 카운트 횟수
                MakdeDate = DateTime.Now
            }) ;

            MessageBox.Show("정상적으로 등록되었습니다.");
        }

        private void btnClose_Click(object sender, EventArgs e) //닫기
        {
            Final_Exam02_2_Login Final_login = new Final_Exam02_2_Login();
            this.Visible = false;
        }
    }
}
