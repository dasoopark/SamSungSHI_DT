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
    public partial class Chap25_RecursiveFunction : Form
    {
        public Chap25_RecursiveFunction()
        {
            InitializeComponent();
        }

        #region <리스트로 피보나치>
        private void btnList_Click(object sender, EventArgs e)
        {
            //int fibocnt = Convert.ToInt32(fibotext.Text); //내가 만든 코드

            //StringBuilder sb = new StringBuilder();

            //List<int> fibolist = new List<int>()
            //{
            //    0 ,1
            // //[0] [1]
            //};
            //for(int i = 2; i< fibocnt; i++)
            //{
            //    fibolist.Insert(i,fibolist[i-2] + fibolist[i - 1]);
            //}

            //foreach(int ivalue in fibolist)
            //{
            //    sb.Append(ivalue + " ");
            //}
            // MessageBox.Show(sb.ToString());

            List<int> iList = new List<int>()
            {
                0 ,1
             //[0] [1]
            };
            int loopcount = 0;

            bool bCheck = int.TryParse(fibotext.Text, out int iTurn); //Out int iResult를 생성 하면서 out 값
            if (!bCheck) return;

            if(iTurn >2) //입력한 차수 가 3 이상일때.
            {
                for(int i=2; i<iTurn; i++)
                {
                    iList.Add(iList[i - 2] + iList[i - 1]);
                    ++loopcount;
                }
                ++loopcount;
            }
            MessageBox.Show($"피보나치 수열 {iTurn}번째의 값은 {iList[iTurn-1]}입니다.총 반복횟수:{loopcount}");

            #endregion

        }
        #region <외부변수로 피보나치>
        
        private void btn_outvar_Click(object sender, EventArgs e)
        {
            bool bCheck = int.TryParse(fibotext.Text, out int iTurn); //Out int iResult를 생성 하면서 out 값
            if (!bCheck) return;

            int iNow = 1; //현재 값
            int iBefore = 0; //이전 값.
            int iTemp = 0; //현재값을 이전값으로 할당하기 위한 임시 변수.
            int iLoopCount = 0;
            int iResult = 0;
            // 1번째 수열 을 구할 경우.
            if(iTurn ==1)
            {
                iResult = iBefore; // 1번째 수열은 0 기초값.
            }
            else if(iTurn == 2)
            {
                iResult = iNow;
            }
            else if(iTurn >2)
            {
                for(int i=3; i<= iTurn; i++)
                {
                    iTemp = iNow; //현재 값을 이전 값을 ㅗ등록 하기 위해 임시 데이터에 옮겨 놓기.
                    iResult = iNow + iBefore; //구하려는 차수의 값을 현재값 + 이전값
                    iBefore = iTemp; //현재 값을 이전 값으로 할당.
                    ++iLoopCount;

                }
                ++iLoopCount; // for반복문에서 false로 만들기 위해 i가 1이 증가 되기위해 처리되는 수행도 1반복으로 쳐 준다.

            }
            
           string message = $"피보나치 수열 {iTurn}번째의 값은 {iResult}입니다.총 반복횟수{iLoopCount}:";
            MessageBox.Show(message);


        }

        private void btnRecursive_Click(object sender, EventArgs e)
        {
            /*재귀 함수(Recursive Function)
               메서드 내부에서 자기 자신을 반복적으로 호출 하는 것을 말한다.
                * 자신을 호출하는 부분(메서드를 호출 하는 로직)을 만나지 않을때 까지 반복한다.
                
            - 장점.
                . 직관적인 코드를 구현 할 수 있으며 복잡한 문제를 쉽게 표현 할 수 있다.

            - 단점.
                . 호출이 완료 되기 전까지 Stack 메모리에 절차 과정이 누적되므로 StackOverFlower 오류가 발생 할 수 있다.
                . 종료 시점을 명확히 하지 않으면 무한 루프에 빠질 수 있다.
                . 반복할 노드(횟수)가 많아 질수록 효율성이 떨어진다.
                . 메모제이션 기법으로 보안이 가능.(메모리)
            */
            int iLoopCount = 0; //반복 횟수 0 할당.

            bool bCheck = int.TryParse(fibotext.Text, out int iTurn); //Out int iResult를 생성 하면서 out 값
            if (!bCheck) return;

            //반복 수행 할 메서드 재귀 메서드 호출.
            int iResult = GetFibonacciNum(iTurn);

        }
        #endregion

        #region <재귀함수>
        // 재귀 메서드
        int GetFibonacciNum(int _iTurn)
        {
            int iResult = 0;
            int iLoopCount = 0;

            if (_iTurn >= 1 && _iTurn <= 2) //첫번째 순번.
            {
                // 재귀 함수에서는 이 블록 구문이 핵심적인 부분이 된다.
                // 0, 1 값을 찾아내기 위해 이 블록 코드로 진입할때 까지 재귀 함수가 구동.
                //이곳이 호출되는 횟수가 재귀 함수의 총 반복 횟수가 된다.
                iResult = _iTurn - 1; //1번째 기초값 0
                                      //2번째 기초값 1
                ++iLoopCount;
            }
            else if (_iTurn > 2)
            {
                //결과 가 누적 될 int 값.
                //왼쪽 함수부터 실행한다.
                iResult = GetFibonacciNum(_iTurn - 2) + GetFibonacciNum(_iTurn - 1);
            }
           

            return iResult;
            // 입력한 수를 정수로 반환하는 메서드.

        }
        #endregion

        #region < 메모이제이션 >
        private void btnMemoization_Click(object sender, EventArgs e)
        {
            //메모이 제이션
            // 컴퓨터 프로그램이 동일한 연산을 반복해야 할 때.
            // 이전에 계산했던 결과를 메모리에 등록 해 두고, 동일한 계산을 위해 수행해야
            // 하는 반복 횟수를 제거하여
            //프로그램의 실행 속도를 향상 시키는 방법.
            //재귀 함수를 호출 하는 횟수를 줄일 수 있도록 등록되어있는 값을
            //추가하여 재귀함수 호출 수를 줄이는 방법.

            int iLoopCount = 0; //반복횟수 0
            bool bCheck = int.TryParse(fibotext.Text, out int iTurn); //Out int iResult를 생성 하면서 out 값
            if (!bCheck) return;

            // 이전 연산의 결과를 등록할 (메모화 할 ) Dictionary 생성.
            Dictionary<int, int> dic = new Dictionary<int, int>()
            {
                // Key의 내용 : 회차 순번.
                // Value의 내용 : 수열의 결과값
                [1] = 0,
                [2] = 1
            };
            int iResult = GetFibonaccNum(iTurn, dic); //재귀 함수의 결과 값을 담을 변수.
            MessageBox.Show($"피보나치 수열 {iTurn}번째의 값은 {iResult}입니다.");
        }

        int GetFibonaccNum(int _iTurn, Dictionary<int, int> _Dic)
        {
            int _iResult = 0;
            int iLoopCount = 0; //반복횟수 0
            if (_Dic.ContainsKey(_iTurn))
            {
                ++iLoopCount;
                return _Dic[_iTurn];
            }
            // Dic에 해당 순번의 Key 가 없을 경우(기존에 찾은 값이 없을 경우)
            // 재귀 함수를 통하여 값이 도출 될 때 까지 loop를 반복.
            if (_iTurn > 2)
            {
                _Dic[_iTurn] = GetFibonaccNum((_iTurn - 2), _Dic) + GetFibonaccNum((_iTurn - 1), _Dic);
            }
            return _Dic[_iTurn];
        }
        #endregion
    }
}
