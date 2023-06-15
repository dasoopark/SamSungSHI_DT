using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstCSharp.Lesson05_Class
{
    public partial class Chap34_Structure_Exam_Login : Form
    {
        // 사용자 등록 화면에서 사용자의 리스트를 받아올 리스트
        private List<UserInfo> _userinfos = new List<UserInfo>();
        public Chap34_Structure_Exam_Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            //로그인 가능 여부를 판단.
            if(_userinfos.Count == 0)
            {
                MessageBox.Show("등록된 사용자가 없습니다.");
                return;
            }
            //입력한 id, 패스워드 받아오기
            string sUserId = textUserId.Text;
            string sPassword = textUserPW.Text;

            
            foreach(UserInfo userinfo in _userinfos)
            {
                if (userinfo.Userid == sUserId)
                {
                    if(userinfo.PassWord == sPassword)
                    {
                        MessageBox.Show($"{userinfo.UserName}님 반갑습니다.");
                    }
                    else
                    {
                        MessageBox.Show("비밀번호가 일치하지 않습니다.");
                    }
                    return;
                }
            }
            MessageBox.Show("일치하는 사용자 ID가 없습니다.");
        }

        private void btn_userReg_Click(object sender, EventArgs e)
        {
            //사용자 등록 버튼을 클릭 시 
            //사용자에 대한 정보를 담을 수 있는 리스트를 전달. (참조 주소)
            //사용자 등록 클래스 전달 (참조 주소).

            Chap34_Struct_Apply_UserReg Chap34 = new Chap34_Struct_Apply_UserReg(_userinfos);
            Chap34.ShowDialog();
        }
    }
}
