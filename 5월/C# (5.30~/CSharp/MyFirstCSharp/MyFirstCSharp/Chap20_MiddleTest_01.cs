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
    public partial class Chap20_MiddleTest_01 : Form
    {
        public Chap20_MiddleTest_01()
        {
            InitializeComponent();
        }

        private void ssang_guhagi_Click(object sender, EventArgs e)
        {
            int[] arr = { 1, 4, 6, 9, 10, 12, 16 };

            foreach (int num1 in arr)
            {
                foreach (int num2 in arr)
                {
                    if (num1 + num2 == 16)
                    {
                        ssang.Text += $"({num1},{num2}) ";
                    }
                }
            }
        }
    }
}
