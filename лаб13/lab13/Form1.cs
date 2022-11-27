using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int iteration = 0;
        int iterationOfDihotomy = 0;
        void BubbleSort(ref int[] Array)
        {
            for (int i = 0; i < Array.Length - 1; i++) {
                for (int j = i + 1; j < Array.Length; j++)
                    if (Array[i] > Array[j])
                    {
                        int t = Array[i];
                        Array[i] = Array[j];
                        Array[j] = t;
                    }
                iteration += 1;
            }
        }

        void SelectionSort(ref int[] Array)
        {

            for (int i = 0; i < Array.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < Array.Length; j++)
                    if (Array[j] < Array[min])
                        min = j;
                        
                        if (min != i)
                        {
                            int t = Array[i];
                            Array[i] = Array[min];
                            Array[min] = t;
                            iteration += 1;
                        }
            }
        }

        void SortArray(ref int[] array, int leftIndex, int rightIndex)
        {
            var i = leftIndex;
            var j = rightIndex;
            var pivot = array[leftIndex];
            while (i <= j)
            {
                while (array[i] < pivot)
                {
                    i++;
                }

                while (array[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                    iteration += 1;
                }
            }

            if (leftIndex < j)
                SortArray(ref array, leftIndex, j);
            if (i < rightIndex)
                SortArray(ref array, i, rightIndex);
            
        }

        void ShellSort(ref int[] array, int size)
        {
            for (int interval = size / 2; interval > 0; interval /= 2)
            {
                for (int i = interval; i < size; i++)
                {
                    var currentKey = array[i];
                    var k = i;
                    while (k >= interval && array[k - interval] > currentKey)
                    {
                        iteration += 1;
                        array[k] = array[k - interval];
                        k -= interval;
                    }
                    array[k] = currentKey;
                }
            }
            
        }

        int IndexOf(ref int[] Array, int Value)
        {
            
            for (int i = 0; i < Array.Length; i++)
                // Нашли нужное значение? Возвращаем его индекс
                if (Array[i] == Value)
                    return i;
            
            return -1;
        }

        int IndexOfDihotomy(ref int[] Array, int Value, int Left, int Right)
        {
            iterationOfDihotomy += 1;
            int x = (Left + Right) / 2;
            if (Array[x] == Value)
                return x;
            if ((x == Left) || (x == Right))
                return -1;
            if (Array[x] < Value)
                return IndexOfDihotomy(ref Array, Value, x, Right);
            else
                return IndexOfDihotomy(ref Array, Value, Left, x);
        }




        int[] numbers = new int[100];
        int[] numberstosort = new int[100];
        int[] numberstodihotomy = new int[100];
        private void button1_Click(object sender, EventArgs e)
            {
            
                textBox5.Text = "";
                Array.Clear(numbers, 0, 100);
                Random rand = new Random();
                for (int y = 0; y < 100; y++)
                {
                    numbers[y] = rand.Next(1,100);
                    numberstosort[y] = numbers[y];
                    numberstodihotomy[y] = numbers[y];
                    textBox5.Text += "[" + numbers[y].ToString() + "]";
                }
                BubbleSort(ref numberstodihotomy);
            }

        private void button2_Click(object sender, EventArgs e)
        {
            iteration = 0;
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox10.Text = "";
            BubbleSort(ref numberstosort);
            for (int y = 0; y < 100; y++)
            {
                textBox6.Text += "[" + numberstosort[y].ToString() + "]";
                numberstosort[y] = numbers[y];
            }
            textBox2.Text = iteration.ToString();
            iteration = 0;
            SelectionSort(ref numberstosort);
            for (int y = 0; y < 100; y++)
            {
                textBox7.Text += "[" + numberstosort[y].ToString() + "]";
                numberstosort[y] = numbers[y];
            }
            textBox3.Text = iteration.ToString();
            iteration = 0;
            SortArray(ref numberstosort, 0, 99);
            for (int y = 0; y < 100; y++)
            {
                textBox8.Text += "[" + numberstosort[y].ToString() + "]";
                numberstosort[y] = numbers[y];
            }
            textBox4.Text = iteration.ToString();
            iteration = 0;
            ShellSort(ref numberstosort,100);
            for (int y = 0; y < 100; y++)
            {
                textBox10.Text += "[" + numberstosort[y].ToString() + "]";
                numberstosort[y] = numbers[y];
            }
            textBox11.Text = iteration.ToString();
            iteration = 0;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label6.Text = "";
            try
            {
                
                int value = int.Parse(textBox9.Text);
                int index = IndexOf(ref numbers, value);
                if (index != -1)
                {
                    label6.Text = "Элемент найден!";
                }
                else
                {
                    label6.Text = "Элемент не найден!";
                }
            }
            catch { }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            //label8
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label8.Text = "";
            try
            {
                int value = int.Parse(textBox12.Text);
                int index = IndexOfDihotomy(ref numberstodihotomy, value, 0, 99);
                if (index != -1)
                {
                    label8.Text = "Элемент найден!";
                }
                else
                {
                    label8.Text = "Элемент не найден!";
                }
                textBox13.Text = iterationOfDihotomy.ToString();
                iterationOfDihotomy = 0;
            }
            catch { }
        }
    }
}

