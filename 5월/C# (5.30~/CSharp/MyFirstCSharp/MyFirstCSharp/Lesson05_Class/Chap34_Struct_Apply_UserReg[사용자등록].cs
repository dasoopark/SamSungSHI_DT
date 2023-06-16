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
    public partial class Chap34_Struct_Apply_UserReg : Form
    {
        //클래스의 전역 변수로 사용자 정보데이터 유형을 나열할 수 있는 List
        private List<UserInfo> userinfos = new List<UserInfo>();

        // 

        public Chap34_Struct_Apply_UserReg(List<UserInfo> TempList)
        {
            InitializeComponent();
            userinfos = TempList; //주소 전달 해서 서로의 데이터 공유
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            // 사용자 등록 을 하기 전 벨리데이션 체크.
            string sUserid = txtuserid.Text;
            string sPassword = textPassWord.Text;
            string sUserName = textusername.Text;
            string sMailAddress = textUserMail.Text;

            if (sUserid == "" || sPassword == "" || sUserName == "" || sMailAddress == "")
            {
                MessageBox.Show("필수 입력 항목이 누락 되었습니다.");
                return;
            }

            ////사용자 정보 를 담을 수 있는 데이터 자료형에 등록하는 사용자에 대한 데이터를 할당.
            //UserInfo userinfo =     new UserInfo();
            //userinfo.Userid      =  sUserid;      // 사용자 ID
            //userinfo.PassWord    =  sPassword;    // 비밀번호
            //userinfo.UserName    =  sUserName;    // 사용자명
            //userinfo.MailAddress =  sMailAddress; // 메일 주소
            //userinfo.UserFlag    =  true;         // 사용
            //userinfo.MakdeDate   =  DateTime.Now; //현재 일 시

            ////전역 변수 리스트에 사용자 정보를 Add1
            //userinfos.Add(userinfo);

            //위 로직은 다음과 같이 표현할 수 있다.
            userinfos.Add(new UserInfo
            {
                Userid = sUserid,      // 사용자 ID
                PassWord = sPassword,    // 비밀번호
                UserName = sUserName,    // 사용자명
                MailAddress = sMailAddress, // 메일 주소
                UserFlag = true,        // 사용
                MakdeDate = DateTime.Now
            }) ;

            MessageBox.Show("정상적으로 등록되었습니다.");
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Chap34_Structure_Exam_Login CHAP34_Login = new Chap34_Structure_Exam_Login();
            CHAP34_Login.Show();

            this.Visible = false;
        }
    }
}
