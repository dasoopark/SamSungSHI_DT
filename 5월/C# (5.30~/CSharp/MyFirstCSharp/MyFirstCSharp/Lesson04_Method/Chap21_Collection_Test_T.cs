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
            //중복 되지 않은 문자열 찾기 Dictionary와 Foreach
            string sTitle = lbltitle.Text;

            // 문자열 에서 한글자씩 가지고 와서 Key로 생성, Key의 데이터 타입은 char 형식으로. 
             Dictionary<char,int> dic = new Dictionary<char,int>();

            //타이틀 에서 한글자씩 추출 하고 
            //Dictionary에 Key의 값으로 등록 하는데,
            // key의 값으로 이미 등록되어 있으면 1 증가 
            // key의 값으로 등록 되어 있지 않은 상태라면 . 1

            foreach(char cWord in sTitle)
            {
                if(dic.ContainsKey(cWord))
                {
                    //딕셔너리에 추출한 글자 로 된 Key가 있을 경우
                    dic[cWord] = dic[cWord] + 1;
                }
                else
                {
                    dic[cWord] = 1;
                }
            }
            // DIctionary 의 key 를 추출하는 기능.
            // dic.Keys
            foreach (char iValue in dic.Keys)
            {
                if (dic[iValue] == 1)
                {
                    MessageBox.Show($"중복되지 않은 첫 글자 는 {iValue}입니다.");
                }
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
                cStandardWord = sTitle[i];
                //j : i 문자가 있는지 없는지 찾을 문자열의 index
                for (int j =0; j<sTitle.Length; j++)
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
                if (!bFindFlag) break; // j에서 break안맞고 나왔을 때 =>중복된 값이 없는놈 
                else // j에서 break 맞고 나왔을 때 => 중복된 값이 있는놈이라 continue 
                {
                    bFindFlag = false;
                    continue;
                }
                
                // j 반복문 에서 break 맞고 나온녀석은 (중복) => continue , break 안맞고 나온녀석은 (중복아닌 최초의 값) =>break
            }
            MessageBox.Show($"중복되지 않은 가장 첫 문자는:{cStandardWord}");
        }

        private void btnLastIndexOf_Click(object sender, EventArgs e)
        {
            // LastIndexOf 방식().
            string sTitle = lbltitle.Text;

            //기준 문자 담을 변수.
            char cStandardWord = default(char);

            //반복 문 시작 
            // i : 기존 문자가 위치하는 index 정보.

            bool bFindFlag = false; //중복되지 않은 문자를 찾은경우 True
            for(int i = 0; i<sTitle.Length;i++)
            {
                cStandardWord = sTitle[i];
                // 현재 기준 문자가 있는 i의 위치와
                //기준 문자를 마지막 부터 찾은 LastindexOf의 주소 값이 같을 경우
                // 같을 경우 = 자기자신. 중복되지 않은 문자를 찾은 경우.
                if (i == sTitle.LastIndexOf(sTitle[i]))
                {
                    // 중복 되지 않는 문자를 찾았을 경우.
                    bFindFlag = true;
                    break;
                }
            }
            if(bFindFlag)
            {
                MessageBox.Show($"중복 되지 않은 문자는 {cStandardWord}입니다.");
            }
            else
            {
                MessageBox.Show("중복 되지 않는 문자를 찾지 못했습니다.");
            }
        }
    }
}
