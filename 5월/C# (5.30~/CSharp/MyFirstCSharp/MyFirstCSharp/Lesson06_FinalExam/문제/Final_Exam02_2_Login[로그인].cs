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


            bool isUserIdFound = false; //등록된 ID 인지 확인하는 플래그coinpan.com/index.php?mid=free&document_srl=350950029&comment_srl=350950150#comment_350950150

            for (int i = 0; i < _userinfos.Count; ++i) //Foreach 로는, 반복변수의 직접 수정이 안되므로 for문 사용
            {
                UserInfo_Exam userinfo = _userinfos[i]; 

                if (userinfo.Userid == sUserId)
                {
                    isUserIdFound = true;
                    if (userinfo.PassWord == sPassword)
                    {
                        MessageBox.Show($"{userinfo.UserName}님 반갑습니다.");
                        userinfo.PassCnt = 0; 
                        _userinfos[i] = userinfo; // 유저 정보를 최신 정보의 상태로 업데이트 
                    }
                    else
                    {
                        MessageBox.Show("비밀번호가 일치하지 않습니다.");
                        userinfo.PassCnt += 1;
                        _userinfos[i] = userinfo; // 유저 정보를 최신 정보의 상태로 업데이트 
                        MessageBox.Show($"비밀번호 실패 횟수:{userinfo.PassCnt}");
                        if(userinfo.PassCnt==5) //비밀번호를 5번 틀렸을 때
                        {
                            MessageBox.Show("비밀번호가 5회 미일치 하여 프로그램을 종료합니다.");
                            Application.Exit(); //프로그램 종료
                        }
                    }
                    break;
                }
            }
 
            if (!isUserIdFound)
            {
                MessageBox.Show("존재하지 않는 ID 입니다.");
            }




            //foreach (UserInfo_Exam userinfo in _userinfos)
            //{
            //     UserInfo_Exam _passcnt_userinfo = userinfo;
            //    if (userinfo.Userid == sUserId)
            //    {
            //        if (userinfo.PassWord == sPassword)
            //        {
            //            MessageBox.Show($"{userinfo.UserName}님 반갑습니다.");

            //        }
            //        else
            //        {
            //            MessageBox.Show("비밀번호가 일치하지 않습니다.");
            //            _passcnt_userinfo.PassCnt += 1;
            //            MessageBox.Show($"비밀번호 실패 횟수:{userinfo.PassCnt}");

            //        }
            //        return;
            //    }
            //    MessageBox.Show("일치하는 사용자 ID가 없습니다.");
            //}


            //bool loginFlag = false;   //아이디와 올바른 비밀번호를 입력할 때 까지 무한 반복
            //while (!loginFlag)
            //{
            //    foreach (UserInfo_Exam userinfo in _userinfos)
            //    {
            //        UserInfo_Exam _passcnt_userinfo = userinfo;
            //        if (userinfo.Userid == sUserId)
            //        {
            //            if (userinfo.PassWord == sPassword)
            //            {
            //                MessageBox.Show($"{userinfo.UserName}님 반갑습니다.");
            //            }
            //            else
            //            {
            //                MessageBox.Show("비밀번호가 일치하지 않습니다.");
            //                _passcnt_userinfo.PassCnt += 1;
            //                MessageBox.Show($"비밀번호 실패 횟수:{_passcnt_userinfo.PassCnt}");
            //            }
            //            return;
            //        }
            //    }
            //    MessageBox.Show("일치하는 사용자 ID가 없습니다.");
            //}

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
