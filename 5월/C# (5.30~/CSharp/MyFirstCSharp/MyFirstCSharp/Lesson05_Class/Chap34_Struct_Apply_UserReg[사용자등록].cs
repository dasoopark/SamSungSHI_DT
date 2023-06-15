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
    public partial class Chap34_Struct_Apply_UserReg : Form
    {
        public Chap34_Struct_Apply_UserReg()
        {
            InitializeComponent();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            // 사용자 등록 을 하기 전 벨리데이션 체크.
            string sUserid = txtuserid.Text;
            string sPassword = textPassWord.Text;
            string sUserName = textusername.Text;
            string sMailAddress = textUserMail.Text;
        }
    }
}
