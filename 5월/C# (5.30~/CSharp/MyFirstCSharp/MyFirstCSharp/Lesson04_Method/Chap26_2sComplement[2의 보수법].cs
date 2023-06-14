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
    public partial class Chap26_2sComplement_2의_보수법_ : Form
    {
        public Chap26_2sComplement_2의_보수법_()
        {
            InitializeComponent();
        }

        private void btnint_Click(object sender, EventArgs e)
        {
            /*
                - 앞의 Fibonacci 수열에서 49를 입력 시
                  int 자료형 리스트의 값 1134903170 + 183611903 = -132375223인 이유
                 
                  int 자료형 은 4Byte의 메모리 공간이 할당. 4Byte = 8bit * 4
                  1Byte = 8Bit.

                 Bit 0, 1의 상태를 담을 수 있는 메모리의 가장 작은 단위. 
             */
            int iValue1 = 1134903170;
            int iValue2 = 1836311903;
            int iResult = iValue1 + iValue2; // 2971215073 이 나와야 하는데 -132375223이 나옴
            MessageBox.Show(iResult.ToString());

            // int는 4바이트를 담을 수 있는 자료형 (32Bit)
            // [1111 1111] [1111 1111] [1111 1111] [1111 1111] = 4294967295
            // 32Bit로 표현 할수 있는 최대 정수 (0 ~ 4294967295). 음수를 포함하지 않는 최대 정수

            //양수만 담을수있는 32Bit 정수 자료형
            uint ulvalue = 4294967295;
            ulvalue = uint.MaxValue; //32bit 양수 자료 최대 값. 4294967295
            ulvalue = uint.MinValue; //32Bit 양수 자료 최소 값. 0

            //하지만 int는 양과 음의 수로 표현 하므로 최대 최소값의 범위가 이동.
            iResult = int.MinValue; //32bit 음수 포함 자료 최소값 : -2147483648
            iResult = int.MaxValue; //32Bit 음수 포함 자료 최대값 : 214783647 (왜 -와 +의 크기가 다를까 ? 0 을 양수)

            ulvalue = 214783647 + 214783648; // 4294967295

            //int 자료형 구조는 똑같이 4294967295의 범위를 담을 수 있는데,
            // 다만 - 부터 시작하여 절반을 나눠 가지므로 -2147483648 ~ 2147483647 가 4294967295 의 범위가 된다.

            //uint에서 (양수만 관리하는 자료형)
            // 0을 2진수로 표현. (uint의 최소값)
            // 0000 0000 0000 0000 0000 0000 0000 0000 : 0*32 있는 2진수가 0의 값이 된다.

            //int의 경우 가장 앞자리 bit 0, 1을 음수와 양수로 사용.
            //int의 경우 최소값 -214783648
            //2진수로 표현.
            // 1000 0000 0000 0000 0000 0000 : -2147483648

            // 1134903170  + 1836311903 = 2971215073
            //이진법으로 변환
            // 1011 0001 0001 1001 0010 0100 1110 0001 
         }
    }
}
