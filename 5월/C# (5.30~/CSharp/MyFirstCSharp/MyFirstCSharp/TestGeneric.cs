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
    public partial class TestGeneric : Form
    {
        public TestGeneric()
        {
            InitializeComponent();
        }

        public static void TestGenericMethod<T,R>(T gen1, T gen2, R gen3)
        {
            string result = $"{gen1.ToString()}_{gen2.ToString()}_{gen3.ToString()}";
            MessageBox.Show(result);
        }

        private void btn_Generic_one_Click(object sender, EventArgs e)
        {
           TestGenericMethod<int, string>(300, 150, "합은 450");
        }

        private void btn_Generic_two_Click(object sender, EventArgs e)
        {
            TestGenericMethod<string, double>("일반화 메서드", "표현값은", 500);
        }
    }
}
