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
    public partial class Chap20_MiddleTest_03 : Form
    {
        public Chap20_MiddleTest_03()
        {
            InitializeComponent();
        }
      
       
        private void button1_Click(object sender, EventArgs e)
        {
            Random rNumber = new Random();
            int rannum1 = rNumber.Next(0, 100);
            int rannum2 = rNumber.Next(0, 100);
            int rannum3 = rNumber.Next(0, 100);
            input1.Text = rannum1.ToString();
            input2.Text = rannum2.ToString();
            input3.Text = rannum3.ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int temp = 0;
            int max = 0;
            int lowest = 0;

            int ftext = Int32.Parse(input1.Text);
            int mtext = Int32.Parse(input2.Text);
            int etext = Int32.Parse(input3.Text);
            int[] arr = { ftext, mtext, etext };
            max = arr[0];
            lowest = arr[0];

            if(ftext+mtext+etext <100) //문제 1번째 조건
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (max < arr[i])
                    {
                        max = arr[i];
                    }

                    if (lowest > arr[i])
                    {
                        lowest = arr[i];
                    }
                }
                MessageBox.Show($"최대값은{max}, 최소값은{lowest}");
            }
            else if(ftext+mtext+etext>=100 && ftext+mtext+etext<200) //문제 2번째 조건
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (max < arr[i])
                    {
                        max = arr[i];
                    }

                    if (lowest > arr[i])
                    {
                        lowest = arr[i];
                    }
                }
                MessageBox.Show($"최대값{max}, 최소값은{lowest} 더하기 ={max+lowest}"); //문제 3번째 조건
            }
            else if(ftext + mtext + etext >= 200)
            {
                MessageBox.Show($"3수의 합이 200이 넘습니다.");
            }
          
            
           

        }
    }
}
