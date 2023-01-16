using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Zatmenie
{
    class Kolyasa
    {
        Brush brush;
        Pen pen;
        int x1, x2, y, W, xf2, yf2;
        double h, w;
        int arg1, arg2, arg3;
        int[] del = new int[3];
        int xk;
        public Kolyasa(int x, int y, int w, int arg1, int arg2, int arg3, int X, int Y)
        {
            del[2] = y - Y;
            x1 = x;
            this.y = y;
            x2 = x1 + w * 3 / 4;
            this.w = w / 4;
            h = this.w;
            W = w;
            del[0] = x1 - X;
            del[1] = x2 - X;
            this.arg1 = arg1;
            this.arg2 = arg2;
            this.arg3 = arg3;
            brush = new SolidBrush(Color.FromArgb(255, arg1, arg2, arg3));
            pen = new Pen(Color.FromArgb(255, (arg1 + 180) % 255, (arg2 + 180) % 255, (arg3 + 180) % 255));
        }
        public int ComeBack(string nn)
        {
            if (nn == "x1")
                return x1;
            else if (nn == "y")
                return y;
            else if (nn == "h")
                return Convert.ToInt32(h);
            else if (nn == "w")
                return Convert.ToInt32(w);
            else if (nn == "x2")
                return x2;
            else
                return 0;
        }
        public void Draw(Graphics graph)
        {
            graph.FillEllipse(brush, x1, y, Convert.ToInt32(w), Convert.ToInt32(h));
            graph.FillEllipse(brush, x2, y, Convert.ToInt32(w), Convert.ToInt32(h));
        }
        public void Draw(int x, int y, Graphics graph)
        {
            xf2 = x;
            yf2 = y;
            xk = x + W * 3 / 4;
            graph.FillEllipse(brush, x, y, Convert.ToInt32(w), Convert.ToInt32(h));
            graph.FillEllipse(brush, xk, y, Convert.ToInt32(w), Convert.ToInt32(h));
        }
        public void Obvod(Graphics graph)
        {
            graph.DrawEllipse(pen, x1, y, Convert.ToInt32(w), Convert.ToInt32(h));
            graph.DrawEllipse(pen, x2, y, Convert.ToInt32(w), Convert.ToInt32(h));
        }
        public bool Click(int x, int y)
        {
            if (y > this.y && ((x > this.x1 && x < this.x1 + w) || (x > this.x2 && x < this.x2 + w)) && y < this.y + h)
            {
                return true;
            }
            return false;
        }
        public bool Click2(int x, int y)
        {
            if ((y > yf2 && y < yf2 + h)&&((x > xf2 && x < xf2 + w) || (x > xk && x < xk + w)))
            {
                return true;
            }
            return false;
        }
        public void ChBP1()
        {
            brush = new SolidBrush(Color.FromArgb(255, arg1, arg2, arg3));
            pen = new Pen(Color.FromArgb(255, (arg1 + 180) % 255, (arg2 + 180) % 255, (arg3 + 180) % 255));
        }
        public void ChBP2()
        {
            brush = new SolidBrush(Color.FromArgb(122, arg1, arg2, arg3));
            pen = new Pen(Color.FromArgb(122, (arg1 + 180) % 255, (arg2 + 180) % 255, (arg3 + 180) % 255));
        }
        public void Move(int x, int y, Graphics graph)
        {
            x1 = x + del[0];
            x2 = x + del[1];
            this.y = y + del[2];
        }
        public void st(int x, int y, int w, double h)
        {
            x1 = x;
            x2 = x + W * 3 / 4;
            this.y = y;
            this.w += h;
            this.h += h;
            W = w;
        }
        public void ChARGB(int arg1, int arg2, int arg3)
        {
            this.arg1 = arg1;
            this.arg2 = arg2;
            this.arg3 = arg3;
            ChBP1();
        }
        public void Wreee(StreamWriter sv)
        {
            sv.WriteLine(Convert.ToString(x1));
            sv.WriteLine(Convert.ToString(x2));
            sv.WriteLine(Convert.ToString(y));
            sv.WriteLine(Convert.ToString(w));
            sv.WriteLine(Convert.ToString(h));
            sv.WriteLine(Convert.ToString(arg1));
            sv.WriteLine(Convert.ToString(arg2));
            sv.WriteLine(Convert.ToString(arg3));
        }
        public void Muda(StreamReader sr)
        {
            x1 = Convert.ToInt32(sr.ReadLine());
            x2 = Convert.ToInt32(sr.ReadLine());
            y = Convert.ToInt32(sr.ReadLine());
            w = Convert.ToInt32(sr.ReadLine());
            h = Convert.ToInt32(sr.ReadLine());
            arg1 = Convert.ToInt32(sr.ReadLine());
            arg2 = Convert.ToInt32(sr.ReadLine());
            arg3 = Convert.ToInt32(sr.ReadLine());
        }
    }
}
