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
    public partial class Chap20_MiddleTest_08 : Form
    {
        public Chap20_MiddleTest_08()
        {
            InitializeComponent();
        }

        private void reversOrder_Click(object sender, EventArgs e)
        {
            
            int[] arr = { 1, 11, 6, 20, 11, 8, 12, 6, 16, 13, 22 };
            int temp;

            for(int i =0; i<arr.Length-1;i++)
            {
                for(int j=0; j<arr.Length-i-1; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            MessageBox.Show(arr.Length.ToString());
            string sortarr = string.Join(",", arr);
            textBox1.Text = sortarr.ToString();
        }
    }
}
