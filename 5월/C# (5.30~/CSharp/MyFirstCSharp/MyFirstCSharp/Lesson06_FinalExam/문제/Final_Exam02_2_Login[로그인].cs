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
    public partial class Final_Exam02_2_Login : Form
    {
        // 사용자 등록 화면에서 사용자의 리스트를 받아올 리스트
        private List<UserInfo_Exam> _userinfos = new List<UserInfo_Exam>();
        private List<UserInfo_Exam> _passcnt_userinfo = new List<UserInfo_Exam>();

        public Final_Exam02_2_Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e) //로그인
        {
            //로그인 가능 여부를 판단.
            if (_userinfos.Count == 0)
            {
                MessageBox.Show("등록된 사용자가 없습니다.");
                return;
            }
            //입력한 id, 패스워드 받아오기
            string sUserId = txtUserId.Text;
            string sPassword = txtPassWord.Text;

            bool PassFlag = false; //비밀번호가 올바르게 들어올때까지 반복시키기 위한 flag (패스워드 카운트 용)
            foreach (UserInfo_Exam userinfo in _userinfos)
            {
                UserInfo_Exam _passcnt_userinfo = userinfo;
                if (userinfo.Userid == sUserId)
                {
                    if (userinfo.PassWord == sPassword)
                    {
                        MessageBox.Show($"{userinfo.UserName}님 반갑습니다.");
                    }
                    else
                    {
                        while (!PassFlag)
                        {
                            MessageBox.Show("비밀번호가 일치하지 않습니다.");
                            _passcnt_userinfo.PassCnt += 1;
                            MessageBox.Show($"비밀번호 실패 횟수:{_passcnt_userinfo.PassCnt}");
                        }
                    }
                    return;
                }
            }
            MessageBox.Show("일치하는 사용자 ID가 없습니다.");
        }

        private void btnUserReg_Click(object sender, EventArgs e) //사용자 등록
        {
            //사용자 등록 버튼을 클릭 시 
            //사용자에 대한 정보를 담을 수 있는 리스트를 전달. (참조 주소)
            //사용자 등록 클래스 전달 (참조 주소).

            Final_Exam02_3_UserReg Final_UserReg = new Final_Exam02_3_UserReg(_userinfos);
            Final_UserReg.ShowDialog();
        }
    }
}
