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
    public partial class Chap19_Foreach_Test : Form
    {
        public Chap19_Foreach_Test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int[,] ivalues = new int[3,4] { { 1,2,3,4},
                                             {5,6,7, 8 },
                                             {9,10,11,12 } };

            int columns = ivalues.GetLength(0);
            MessageBox.Show(columns.ToString());
            
             foreach (int i in ivalues)
              {
                  txtMatrix.Text += i.ToString() + " "; 
              }
              
           
            
        }
    }
}
