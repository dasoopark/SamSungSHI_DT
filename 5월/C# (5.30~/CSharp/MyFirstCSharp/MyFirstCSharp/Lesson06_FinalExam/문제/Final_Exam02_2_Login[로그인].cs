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


// 실기 2
/*
     박다수 
     1. 사용자 정보 관리 사용자 데이터 관리 유형 생성 완료
     2. 사용자 등록 시 중복 ID 등록 되지 않도록 완료
     3. LOGIN 시 ID와 비밀번호 일치시 "?? 님 반갑습니다." 메세지 표현 완료
     4. LOGIN 시 ID 존재하지 않을 경우 "존재하지 않는 ID입니다" 메세지 표현
     5. LOGIN 시 ID는 일치하지만 PW가 일치하지 않는 경우  
        비밀번호를 잘못 입력하였습니다 남은횟수 ?회 메세지로 각각의 ID마다 구현완료
        5회 이상 오류시 비밀번호 5회 미일치 프로그램을 종료 후 메세지 표현 후 종료
 */
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
                MessageBox.Show("존재하지 않는 ID 입니다");
                return;
            }

            //입력한 id, 패스워드 받아오기
            string sUserId = txtUserId.Text;
            string sPassword = txtPassWord.Text;


            bool isUserIdFound = false; //등록된 ID 인지 확인하는 플래그

            for (int i = 0; i < _userinfos.Count; ++i) //Foreach 로는, 반복변수의 직접 수정이 안되므로 for문 사용
            {
                UserInfo_Exam userinfo = _userinfos[i]; 

                if (userinfo.Userid == sUserId)
                {
                    isUserIdFound = true;
                    if (userinfo.PassWord == sPassword)
                    {
                        MessageBox.Show($"{userinfo.UserName}님 반갑습니다."); //조건 3. 반갑습니다, 로그인 성공시 비밀번호 실패횟수 초기화
                        userinfo.PassCnt = 0; 
                        _userinfos[i] = userinfo; // 유저 정보를 최신 정보의 상태로 업데이트 
                    }
                    else
                    {
                       //조건 5.비밀번호 잘못 입력, 남은 횟수, 5회 미일치시 메세지 표현 후 종료.
                        userinfo.PassCnt += 1;
                        _userinfos[i] = userinfo; // 유저 정보를 최신 정보의 상태로 업데이트 
                        MessageBox.Show($"비밀번호를 잘못 입력 하였습니다. 남은 횟수:{5 - userinfo.PassCnt}");
                        if(userinfo.PassCnt==5) //비밀번호를 5번 틀렸을 때
                        {
                            MessageBox.Show("비밀번호가 5회 미일치 하여 프로그램을 종료합니다.");
                            Application.Exit(); //프로그램 종료
                        }
                    }
                    break;
                }
            }
 
            if (!isUserIdFound) //조건 4. 존재하지 않는 ID입니다.
            {
                MessageBox.Show("존재하지 않는 ID 입니다.");
            }

         
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
