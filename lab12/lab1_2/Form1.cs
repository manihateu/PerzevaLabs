using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1_2
{
    public partial class Form1 : Form
    {
        private GraphicsPath path;

        public Form1()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.UserPaint, true);

            path = new GraphicsPath();
            BuildSerpinsy(path, 0, 0, 100, 5);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.TranslateTransform(Width / 2, Height / 2);
            e.Graphics.DrawPath(Pens.Red, path);
        }

        void BuildSerpinsy(GraphicsPath path, float x0, float y0, float r, int n)
        {
            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    if (i == 0 && j == 0) continue;
                    path.AddRectangle(new RectangleF(x0 + j * r / 3 - r / 6, y0 + i * r / 3 - r / 6, r / 3, r / 3));
                    if (n > 1)
                    {
                        BuildSerpinsy(path, x0 + j * r / 3, y0 + i * r / 3, r / 3, n - 1);
                    }
                }
            }
        }
    }
}
