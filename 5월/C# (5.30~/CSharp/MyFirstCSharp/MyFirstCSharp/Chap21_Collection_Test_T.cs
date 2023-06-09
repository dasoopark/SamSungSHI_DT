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
    public partial class Chap21_Collection_Test_T : Form
    {
        public Chap21_Collection_Test_T()
        {
            InitializeComponent();
        }

        private void btnDictionary_Click(object sender, EventArgs e)
        {
             Dictionary<int,int> dic = new Dictionary<int,int>();

            // DIctionary 의 key 를 추출하는 기능.
            // dic.Keys
            foreach (int iValue in dic.Keys)  
            {

            }
        }

        private void btnResult1_Click(object sender, EventArgs e)
        {
            // 
        }
    }
}
