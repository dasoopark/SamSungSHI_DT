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
    //배열 (참조형식, 배열의 이름은 Stack에 값은 Heap에 저장)
    // - 같은 데이터 타입의 여러 데이터가 하나의 배열
    // 변수 이름으로 나열된 데이터 형식.
    // - C#에서 배열은 반드시 방의 개수를 지정 하여 생성하거나, (EX. new int[5])
    // 배열에 나열 될 값들의 개수가 명시 되어야 한다. (Ex. Split('/')
    public partial class Chap15_Array : Form
    {
        public Chap15_Array()
        {
            InitializeComponent();
        }

        private void btnArrayF_Click(object sender, EventArgs e)
        {
            //1. 여러가지 배열의 초기화 (배열을 생성하고 값을 대입)


            //배열을 초기화 하는 방법 - 배열의 개수 와 값을 바로 등록

            //배열의 방의 개수를 지정하여 생성.
            int[] ivalues = new int[6];

            //배열의 방의 개수 와 값을 바로 등록.
            int[] ivalues2 = new int[3] { 0, 1, 2 };

            // 배열의 개수 지정 없이 값을 바로 등록
            int[] ivalue3 = new int[] { 10, 30, 50 };

            // new int[] 키워드 없이 바로 값을 등록
            int[] ivalue4 = { 10, 20, 30, 40, 50 };

            //반환 형태가 배열인 기능(메서드)를 이용하여 배열을 등록,
            string[] svalues = "ABCDE-FGHI".Split('-');

            //기존에 생성되어 있는 배열 만큼 빈 배열 만들기
            int[] ivalue5 = new int[svalues.Length];
            
            //2. C#에서 배열을 관리할때 사용되는 주요 기능
            //샘플 배열        0    1   2   3   4
            int[] iExamArray = {10, 30, 60, 50, 20};
            //배열의 정렬 (오름차순)    0   1   2  3   4
            Array.Sort(iExamArray);  // 10, 20, 30, 50, 60

            //배열의 정렬(내림차순)     0    1   2   3   4
            Array.Reverse(iExamArray); //60, 50, 30, 20, 10

            //배열의 값을 하나의 문자열로 표현
            string sExamValue = string.Empty; //배열의 값을 하나로 담을 변수
            sExamValue = string.Join(" / ", iExamArray); // 기존에 들어있는 배열을 /을 기준으로 인덱스 별로 넣어줌
            MessageBox.Show(sExamValue);
            



        }
    }
}
