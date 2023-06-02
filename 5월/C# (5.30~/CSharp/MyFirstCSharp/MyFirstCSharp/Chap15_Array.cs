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

            //배열의 데이터를 모두 삭제, (방은 그대로 두고 데이터만 삭제)
            //첫번째 요소 :배열, 두번째 요소 : 인덱스(삭제 시작주소), 삭제할 데이터 갯수
            // Array.Clear(iExamArray,         0,      iExamArray.Length); //배열이 전체 삭제됨

            //배열의 복사
            //() : 캐스팅 - 강제로 형변환을 하는 기능
            // 변환되어야 되는 대상이 명확할 경우에 사용

            // =>클론형식의 복사 => 깊은 복사라고 함(메모리 참조 안하게 됨) 값바꿔도 기존 참조 배열 변경X
            //주소와 값의 정보를 그대로 복사하여 서로다른 데이터 형식으로 복사하는 방법
            object oValue = iExamArray.Clone();
            int[] iBackup = (int[])oValue; //Object 형식 -> 특정데이터 형식 형변환 UnBoxing


            //int[] iBackup = (int[])iExamArray.Clone(); 
        }

        private void btnArrayCopy_Click(object sender, EventArgs e)
        {
            //값 형식과 참조 형식의 복사 

            //region, 닫을때 endregion =>코드 줄이는 창 생겨서 줄일수 있음
            #region < 값형식의 복사 방법 >  
            int ivalue = 10;
            int ivalue2 = ivalue; // ivalue2에 ivalue를 대입

            // ivalue = 10, ivalue2 = 20;
            MessageBox.Show(ivalue.ToString()); //"10"
            ivalue2 = 20; //값을 바꿔도 원본 데이터는 그대로 유지됨(ivalue)
            MessageBox.Show(ivalue.ToString()); //"10"

            //int데이터 타입은 값 형식으로 복사를 할 경우 해당 값을 직접 전달하여 복사가 된다.
            #endregion

            #region < 참조 형식의 복사 방법 >
            //배열을 복사. => 주소만 전달됨. 얕은 복사.
            int[] ivalues1 = {10,20,30,40,50};
            int[] ivalues2 = ivalues1;

            MessageBox.Show(ivalues1[0].ToString()); //"10" 
            ivalues2[0] = 333;
            MessageBox.Show(ivalues1[0].ToString()); //"333" //ivalues1값이 직접적으로 바뀜.
            #endregion
        }
    }
}
