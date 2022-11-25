using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var arr = Enumerable.Range(-7, 15).ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                textBox1.Text += "[" + arr[i].ToString() + "]  ";
            }
            arr = arr.Select(x => x < 0 ? 2 * x : x * x).ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                textBox2.Text += "[" + arr[i].ToString() + "]  ";
            }

        }
    }
}
