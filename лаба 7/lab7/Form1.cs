using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string strCases(string str)
        {
            string answer = "";
            char[] myCharArr = str.ToCharArray();
            for (int i = 0; i < myCharArr.Length; i++)
            {
                if (char.IsLower(myCharArr[i])) answer += char.ToUpper(myCharArr[i]);
                else answer += char.ToLower(myCharArr[i]);
            }
            return answer;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string str = textBox1.Text;
            string result = strCases(str);
            richTextBox1.Text += result + "\n";//richTextBox1
        }
    }
}
