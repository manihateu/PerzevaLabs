using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab11
{
    public partial class Form1 : Form
    {
        SolidBrush more = new SolidBrush(Color.Blue);
        SolidBrush parys = new SolidBrush(Color.Red);
        SolidBrush korabl = new SolidBrush(Color.Brown);
        SolidBrush kauta = new SolidBrush(Color.Gold);
        SolidBrush element = new SolidBrush(Color.SaddleBrown);
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // небо
            Graphics g = e.Graphics;
            g.Clear(Color.AliceBlue);
            // море
            g.FillRectangle(more, 0, 250, 1000, 1000);
            // корабль
            // сама основа
            Point point1 = new Point(250, 195);
            Point point2 = new Point(550, 195);
            Point point4 = new Point(300, 265);
            Point point3 = new Point(495, 265);
            Point[] curvePoints =
            {
                point1,
                point2,
                point3,
                point4,
            };
            g.FillPolygon(korabl, curvePoints);
            // иллюминаторы корабля
            g.FillEllipse(kauta, 325, 215, 22, 22);
            g.FillEllipse(kauta, 395, 215, 22, 22);
            g.FillEllipse(kauta, 460, 215, 22, 22);
            // прямоугольники
            g.FillRectangle(element, 400, 170, 100, 25);
            g.FillRectangle(element, 410, 150, 80, 25);
            // Парусы
            // первый
            Point point5 = new Point(270, 150);
            Point point6 = new Point(350, 195);
            Point point7 = new Point(350, 14);
            Point[] Parys1 =
            {
                point5,
                point6,
                point7,
            };
            g.FillPolygon(parys, Parys1);
            // Второй
            Point point8 = new Point(450, 20);
            Point point9 = new Point(400, 100);
            Point point10 = new Point(450, 150);
            Point[] Parys2 =
            {
                point8,
                point9,
                point10,
            };
            g.FillPolygon(parys, Parys2);
        }
    }
}

