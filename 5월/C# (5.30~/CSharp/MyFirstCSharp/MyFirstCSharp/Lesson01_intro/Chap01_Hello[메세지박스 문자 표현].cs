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
    public partial class Chap01_Hello : Form
    {
        public Chap01_Hello()
        {
            InitializeComponent();
        }

        private void aaaaaaa(object sender, EventArgs e)
        {
            //  버튼을 클릭 했을때 메세지창 띄우기. 

            // MessageBox : 메세지를 관리 할수 있는 명령의 집합.
            // .Show(???) : Show 라는 기능을 이용해서 ??? 를 수행하라.

            // 메세지 박스에 있는 Show 라는 기능(함수,메서드) 을 이용해서 
            // "Hello World" 를 표현하라.
            MessageBox.Show("Hello World");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 반갑습니다 메세지를 표현.
            MessageBox.Show("반갑습니다.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 버튼을 클릭 했을 때 이름을 나타내기 
            MessageBox.Show("저는 동상현 입니다.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("저는 동상현 입니다.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int ivalue = 10;
            Chap03_DataTypeConversion cl1 = new Chap03_DataTypeConversion();
            cl1.Show();
        }
    }
}
