using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstCSharp.Lesson05_Class
{
    public struct UserInfo
    {
        //사용자 ID
        public string Userid { get; set; }

         //사용자 PW
         public string PassWord { get; set; }

        //사용자 명
        public string UserName { get; set; }

        //메일 주소
        public string MailAddress { get; set; }

        //사용 여부
        public bool UserFlag { get; set; }

        //등록일시
        public DateTime MakdeDate { get; set; }

    }
}
