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
    public partial class Chap20_MiddleTest_07 : Form
    {
        public Chap20_MiddleTest_07()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            Random rNumber = new Random();
            rNumber.Next(0, 21);
            int[] arr = new int[201];
            int[] randarr = new int[20];
            int sum = 0;

            for(int i=0; i<randarr.Length;i++)
            {
                randarr[i] = rNumber.Next(0, 21);
            }
            Array.Sort(randarr);

            for(int i=0; i<201; i++)
            {
                arr[i] = i;
                
            }
            
            for(int i=0; i<randarr.Length;i++)
            {
                for(int j =0; j<arr.Length; j++)
                {
                    if (randarr[i] == arr[j])
                    {
                        arr[j] = 0;

                        textBox1.Text += ($"랜덤 숫자 {randarr[i]}를 배열에서 제외합니다.\r\n");
                    }
                }
            }

            for(int j=0; j<arr.Length; j++)
            {
                sum += arr[j];
            }

           textBox1.Text += ($"겹친 랜덤값을 뺀 배열의합은 :{sum}\r\n");
        }
    }
}
