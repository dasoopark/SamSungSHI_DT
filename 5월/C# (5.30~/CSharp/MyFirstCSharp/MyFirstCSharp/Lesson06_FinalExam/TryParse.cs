using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstCSharp.Lesson06_FinalExam
{
    public partial class TryParse : Form
    {
        public TryParse()
        {
            InitializeComponent();
            
        }

        private void btn_TryParse_Click(object sender, EventArgs e)
        {
            StringToIntParser parser = new StringToIntParser();
            string userInput = "555";
            int number;

            if (parser.TryParse(userInput, out number))
            {
               MessageBox.Show($"변환된 정수: {number}");
            }
            else
            {
               MessageBox.Show("입력한 문자열을 정수로 변환할 수 없습니다.");
            }
        }
    }

    public class StringToIntParser
    {
        public bool TryParse(string input, out int result)
        {
            result = 0;
            foreach (char c in input)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }

            result = Int32.Parse(input);
            return true;
        }
    }

}
