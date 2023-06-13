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
    public partial class Chap21_Collection_Test : Form
    {
        public Chap21_Collection_Test()
        {
            InitializeComponent();
        }

        private void btn_DicForeach_Click(object sender, EventArgs e)
        {
            string text = lbltitle.Text;
            char firstUniqueChar = '\0';

            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (char c in text)
            {
                if (c != '/' && !charCount.ContainsKey(c))
                    charCount[c] = 1;
                else if (c != '/')
                    charCount[c]++;
            }

            foreach (char key in charCount.Keys)
            {
                if (charCount[key] == 1)
                {
                    firstUniqueChar = key;
                    break;
                }
            }

            MessageBox.Show(firstUniqueChar.ToString());
        }

        private void btnLastIndex_Click(object sender, EventArgs e)
        {
            string text = lbltitle.Text;
            char firstUniqueChar = '\0';

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != '/' && text.IndexOf(text[i]) == text.LastIndexOf(text[i]))
                {
                    firstUniqueChar = text[i];
                    break;
                }
            }

            MessageBox.Show(firstUniqueChar.ToString());

        }

        private void btndup_Click(object sender, EventArgs e)
        {
            //자유코딩
            string lbltitle = "ABCLD/EML/BAMDC/";
            char firstUniqueChar = '\0';

            int[] charCount = new int[128]; // ASCII 문자 범위로 가정

            for (int i = 0; i < lbltitle.Length; i++)
            {
                char c = lbltitle[i];
                if (c != '/')
                {
                    charCount[c]++;
                }
            }

            for (int i = 0; i < lbltitle.Length; i++)
            {
                char c = lbltitle[i];
                if (c != '/' && charCount[c] == 1)
                {
                    firstUniqueChar = c;
                    break;
                }
            }

            MessageBox.Show(firstUniqueChar.ToString());
        }
    }
}
