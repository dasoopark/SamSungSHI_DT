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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            //버튼을 클릭 했을때 메세지창 띄우기~
            // MessageBox : 메세지를 관리 할 수 있는 명령의 집합.
            // 메세지 박스에 있는 Show 라는 기능(함수, 메서드) 를 이용해서
            //show(???) : Show 라는 기능을 이용해서 ???를 수행하라.
            // "HELLO WORLD"를 표현하라.
            MessageBox.Show("Hello World");
        }


        //반갑습니다 버튼
        private void btnbanga_Click(object sender, EventArgs e)
        {
            MessageBox.Show("반갑습니다");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
