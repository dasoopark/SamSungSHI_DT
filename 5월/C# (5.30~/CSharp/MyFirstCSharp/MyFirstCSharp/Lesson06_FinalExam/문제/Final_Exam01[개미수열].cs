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
    public partial class Final_Exam01 : Form
    {
        public Final_Exam01()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            string output = GetAntSequenceResult(14);
            MessageBox.Show(output);
        }

        private string GetAntSequenceResult(int n)
        {
            int[] currentSequence = new int[900];
            int[] nextSequence = new int[900];
            int count = 1, currentIndex = 0, nextIndex = 0;

            currentSequence[0] = 1;

            StringBuilder output = new StringBuilder();
            output.AppendLine("1번째 수열: 1");

            for (int i = 0; i < n; i++)
            {
                while (currentSequence[currentIndex] != 0)
                {
                    if (currentSequence[currentIndex] == currentSequence[currentIndex + 1])
                        count++;
                    else
                    {
                        nextSequence[nextIndex] = currentSequence[currentIndex];
                        nextSequence[nextIndex + 1] = count;
                        nextIndex += 2;
                        count = 1;
                    }
                    currentIndex++;
                }

                Array.Copy(nextSequence, currentSequence, nextSequence.Length);
                currentIndex = 0;
                nextIndex = 0;

                output.AppendLine($"{i + 2}번째 수열: {GetSequenceAsString(currentSequence)}");
            }

            return output.ToString();
        }

        private string GetSequenceAsString(int[] sequence)
        {
            StringBuilder builder = new StringBuilder();
            foreach (var item in sequence)
            {
                if (item == 0) break;
                builder.Append(item);
            }
            return builder.ToString();
        }
    }
}
