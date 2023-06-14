using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace MyFirstCSharp.Lesson05_Class
{
    public partial class Chap31_ClassTest_Run : Form
    {
        public Chap31_ClassTest_Run()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {

            MessageBox.Show("전원을 킵니다.");
            Chap31_ClassTest_Main.state = "전원 ON";
        }
    }
}
