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
    public partial class Chap31_ClassTest_Stop : Form
    {
        public Chap31_ClassTest_Stop()
        {
            InitializeComponent();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            MessageBox.Show("전원을 끕니다.");
            Chap31_ClassTest_Main.state = "전원 OFF";
        }
    }
}
