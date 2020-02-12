/**
 * 
 * 
 * 
 * Sierpinski triangle reference : https://en.wikipedia.org/wiki/Sierpi%C5%84ski_triangle
 * Barnsley fern reference : https://en.wikipedia.org/wiki/Barnsley_fern
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fractal
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        Bitmap drawImage;

        float oldX, oldY;
        float newX = 0, newY = 0;
        int count = 0;

        public Form1()
        {
            InitializeComponent();

            drawImage = new Bitmap(picCanvas.Width, picCanvas.Height);
            Graphics.FromImage(drawImage).Clear(Color.White);
            picCanvas.CreateGraphics().DrawImageUnscaled(drawImage, 0, 0);
        }

        private void DrawPoint(float x, float y)
        {
            //range −2.1820 < x < 2.6558  (4.8378) and 0 ≤ y < 9.9983

            int width = picCanvas.Width;
            int height = picCanvas.Height;

            //Mapping Position

            int size_width = (int)(width / 4.8378);
            int size_height = (int)(height / 9.9983);

            int posX = (int)(width / 2 + size_width * x);
            int posY = height - (int)(size_height * y);

            Graphics.FromImage(drawImage).FillRectangle(Brushes.Black, posX, posY, 1, 1);

        }

        private void btnBarnsleyfern_Click(object sender, EventArgs ev)
        {
            if (tmrBarnsley.Enabled == false)
            {
                Graphics.FromImage(drawImage).Clear(Color.White);
                picCanvas.CreateGraphics().DrawImageUnscaled(drawImage, 0, 0);
            }

            count = 0;
            oldX = 0;
            oldY = 0;

            tmrBarnsley.Enabled = true;
        }

        private void tmrBarnsley_Tick(object sender, EventArgs ev)
        {
            float a, b, c, d;
            float e = 0, f;
            double p;

            for (int i = 0; i <= 100; i++)
            {
                p = rnd.NextDouble();
                //Barnsley's fern Formula (확률에 따른 4가지)
                if (p <= 0.01)
                {
                    // f(1)    1%       p <= 0.01
                    a = b = c = f = 0;
                    d = 0.16F;
                }
                else if (p <= 0.86)
                {
                    // f(2)   85%      p <= 0.86
                    a = 0.85F;
                    b = 0.04F;
                    c = -0.04F;
                    d = 0.85F;
                    f = 1.6F;
                }
                else if (p <= 0.93)
                {
                    // f(3)    7%      p <= 0.93
                    a = 0.2F;
                    b = -0.26F;
                    c = 0.23F;
                    d = 0.22F;
                    f = 1.6F;
                }
                else
                {
                    // f(4)    7%      p <= 1
                    a = -0.15F;
                    b = 0.28F;
                    c = 0.26F;
                    d = 0.24F;
                    f = 0.44F;
                }

                newX = (a * oldX) + (b * oldY) + e;
                newY = (c * oldX) + (d * oldY) + f;

                oldX = newX;
                oldY = newY;
                DrawPoint(newX, newY);
            }
            picCanvas.CreateGraphics().DrawImageUnscaled(drawImage, 0, 0);
        }

        private void DrawInnerTriangle(int x, int y, int hh, int len)
        {

            Graphics g = Graphics.FromImage(drawImage);

            if (len <= 6)
                return;

            //삼각형 빗변 , 높이
            int w = len / 2;
            int h = hh / 2;

            //꼭지점좌표
            Point a = new Point(x - (w / 2), y + h);
            Point b = new Point(x + (w / 2), y + h);
            Point c = new Point(x, y + (h * 2));

            g.FillPolygon(Brushes.White, new Point[] { a, b, c });
            picCanvas.CreateGraphics().DrawImageUnscaled(drawImage, 0, 0);

            //left
            DrawInnerTriangle(a.X, a.Y, h, w);
            //right
            DrawInnerTriangle(b.X, b.Y, h, w);
            //up
            DrawInnerTriangle(x, y, h, w);
        }
        private void btnSierpinskiTriangle_Click(object sender, EventArgs e)
        {
            btnSierpinski.Enabled = false;
            tmrBarnsley.Enabled = false;

            //Method
            Graphics g = Graphics.FromImage(drawImage);

            int len = picCanvas.Width - (picCanvas.Width % 10);
            int h = (int)(len * Math.Sin(Math.PI / 3));
            h = h - (h % 10);

            Point a = new Point(len / 2, 0);
            Point b = new Point(0, h);
            Point c = new Point(len, h);

            g.Clear(Color.White);

            g.FillPolygon(Brushes.Black, new Point[] { a, b, c });
            DrawInnerTriangle(a.X, a.Y, h, len);
            picCanvas.CreateGraphics().DrawImageUnscaled(drawImage, 0, 0);


            btnSierpinski.Enabled = true;
        }

        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            picCanvas.CreateGraphics().DrawImageUnscaled(drawImage, 0, 0);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tmrBarnsley.Enabled = false;
            Graphics.FromImage(drawImage).Clear(Color.White);
            picCanvas.CreateGraphics().DrawImageUnscaled(drawImage, 0, 0);
        }
    }
}
