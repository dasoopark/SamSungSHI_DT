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
    public partial class Chap21_Collection_Test_T : Form
    {
        public Chap21_Collection_Test_T()
        {
            InitializeComponent();
        }

        private void btnDictionary_Click(object sender, EventArgs e)
        {
             Dictionary<int,int> dic = new Dictionary<int,int>();

            // DIctionary 의 key 를 추출하는 기능.
            // dic.Keys
            foreach (int iValue in dic.Keys)  
            {

            }
        }

        private void btnResult1_Click(object sender, EventArgs e)
        {
            // 중복 되지 않는 문자 찾기 (For in For)

            //타이틀 담기.
            string sTitle = lbltitle.Text;

            // 중복 문자가 아닌 첫 문자를 찾았을 경우를 알리는 bool값
            bool bFindFlag = false;
            // 1. 기존 문자 담을 변수.
            char cStandardWord = default(char);
            // 캐릭터 변수에 기본값 설정. \0 : Null의 코드 값.

            // i : 문자열(타이틀) 에서 기준이 되는 문자를 가리키는 index
            for(int i = 0; i<sTitle.Length; i++)
            {
                //j : i 문자가 있는지 없는지 찾을 문자열의 index
                for(int j =0; j<sTitle.Length; j++)
                {
                    if(i==j)
                    {
                        continue; //i j가 같으면 자기 자신은 패스해야함
                    }
                    // 기준문자 i가 자기자신을 비교 할 경우 j는 넘겨야 함 (i==j이면 자기자신)
                    if (sTitle[i] == sTitle[j])
                    {

                        //중복 단어 를 찾은경우.
                        bFindFlag = true;
                        break;
                    }
                }
                if (!bFindFlag) break; // break안맞고 나왔을 때
                if (bFindFlag) continue;
                // j 반복문 에서 break 맞고 나온녀석은 (중복) => continue , break 안맞고 나온녀석은 (중복아닌 최초의 값) =>break
            }
        }
    }
}
