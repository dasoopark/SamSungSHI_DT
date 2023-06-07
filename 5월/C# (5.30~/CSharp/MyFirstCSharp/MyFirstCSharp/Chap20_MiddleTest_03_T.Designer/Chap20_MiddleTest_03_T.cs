using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstCSharp
{
    public partial class Chap20_MiddleTest_03_T : Form
    {
        public Chap20_MiddleTest_03_T()
        {
            InitializeComponent();
        }

        private void btnMakeRan_Click(object sender, EventArgs e)
        {
            // 난수 : 임의의 정수 . 
            //      
            Random rNumber = new Random();
            int iRanNumber = rNumber.Next(0, 100);

            MessageBox.Show(iRanNumber.ToString());

            int[] a = { 2 };
            a = a.Append(30).ToArray();
        }
    }
}
