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
    public partial class Chap20_MiddleTest_05 : Form
    {
        public Chap20_MiddleTest_05()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] arr = { label1.Text };

            Array.IndexOf(arr, "?");
            MessageBox.Show(arr[0]);
        }
    }
}
