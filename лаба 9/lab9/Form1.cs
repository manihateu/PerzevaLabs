using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
            label2.Text = "";
        }

        
        static void Exercise(int[,] arr)
        {
            int max = arr[0, 0];
            int indi = 0;
            int indj = 0;
            int temp;
            for (int i = 1; i < arr.GetLength(0); i++)
            {
                if (arr[i, i] > max)
                {
                    max = arr[i, i];
                    indi = i;
                    indj = i;
                }
            }
            for (int i = 0, j = arr.GetLength(1) - 1; i < arr.GetLength(0); i++, j--)
            {
                if (arr[i, j] > max)
                {
                    max = arr[i, j];
                    indi = i;
                    indj = j;
                }
            }
            string str = indi.ToString() + " " + indj.ToString();
            temp = arr[indi, indj];
            arr[indi, indj] = arr[3, 3];
            arr[3, 3] = temp;

        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            int max = 0;
            int indi = 0, indj = 0;
            int[,] arr = new int[7, 7];
            Random rnd = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rnd.Next(1, 100);
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                        indi = i;
                        indj = j;
                    }
                }
            

            //print
            int row = 0;
            
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (row < i) {
                        row = i;
                        label1.Text += "\n";
                    }
                    label1.Text += "[" + arr[i, j].ToString() + "]" + "   \t";
                    

                }
            }
            //-----
            Exercise(arr);
            //print
            int row2 = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {   
                    if (row2 < i)
                    {
                        row2 = i;
                        label2.Text += "\n";
                    }
                    label2.Text += "[" + arr[i, j].ToString() + "]  ";
                    

                }
            }
            //-----
            textBox1.Text = "[" + (indj+1).ToString() + "]" + " " + "[" + (indi+1).ToString() + "]";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
