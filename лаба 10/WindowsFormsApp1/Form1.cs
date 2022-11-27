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

        private void button1_Click_1(object sender, EventArgs e)
        {
            double Xmin, Xmax, Step;
            try
            {
                Xmin = double.Parse(textBoxXmin.Text);
                Xmax = double.Parse(textBoxXmax.Text);
                Step = double.Parse(textBoxStep.Text);
            }
            catch
            {
                Xmin = 0; Xmax = 0; Step = 1;  
            }
            // Количество точек графика
            int count = (int)Math.Ceiling((Xmax - Xmin) / Step) + 1;
            double[] x = new double[count];
            double[] y1 = new double[count];
            for (int i = 0; i < count; i++)
            {
                x[i] = Xmin + Step * i;
                y1[i] = (Math.Pow(x[i], 5 / 2) - 0.8) * Math.Log(Math.Pow(x[i],2)+12.7);
            }
            chart1.ChartAreas[0].AxisX.Minimum = Xmin;
            chart1.ChartAreas[0].AxisX.Maximum = Xmax;
            chart1.ChartAreas[0].AxisX.MajorGrid.Interval = Step;
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            
            chart1.Series[0].Points.DataBindXY(x, y1);
        }
    }
}
