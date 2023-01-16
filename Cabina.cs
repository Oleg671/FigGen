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
    class Cabin
    {
        Brush brush;
        Pen pen;
        int x, y, w;
        double h;
        int arg1, arg2, arg3;
        Random rnd = new Random();
        int[] del = new int[2];
        int xf2, yf2;
        public Cabin(int arg1, int arg2, int arg3, int x, int y)
        {
            this.x = x;
            this.y = y;
            del[0] = 10;
            del[1] = 0;
            h = rnd.Next(10, 25);
            w = rnd.Next(10, 25);
            this.arg1 = arg1;
            this.arg2 = arg2;
            this.arg3 = arg3;
            brush = new SolidBrush(Color.FromArgb(255, arg1, arg2, arg3));
            pen = new Pen(Color.FromArgb(255, (arg1 + 180) % 255, (arg2 + 180) % 255, (arg3 + 180) % 255));
        }
        public int ComeBack(string nn)
        {
            if (nn == "x")
                return x;
            else if (nn == "y")
                return y;
            else if (nn == "h")
                return Convert.ToInt32(h);
            else if (nn == "w")
                return w;
            else if (nn == "xf2")
                return xf2;
            else if (nn == "yf2")
                return yf2;
            else
                return 0;
        }
        public void Draw(Graphics graph)
        {
            graph.FillRectangle(brush, x, y, w, Convert.ToInt32(h));
        }
        public void Draw(int x, int y, Graphics graph)
        {
            graph.FillRectangle(brush, x, y, w, Convert.ToInt32(h));
            xf2 = x;
            yf2 = y;
        }
        public void Obvod(Graphics graph)
        {
            graph.DrawRectangle(pen, x, y, w, Convert.ToInt32(h));
        }
        public bool Click(int x, int y)
        {
            if (x > this.x && y > this.y && x < this.x + w && y < this.y + h)
            {
                return true;
            }
            return false;
        }
        public bool Click2(int x, int y)
        {
            if (x > xf2 && y > yf2 && x < xf2 + w && y < yf2 + h)
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
            this.x = x + del[0];
            this.y = y + del[1];
        }
        public void st(int x, int y, int w, double h)
        {
            this.x = x + 10;
            this.y = y;
            this.w += w;
            this.h += h;
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
            sv.WriteLine(Convert.ToString(x));
            sv.WriteLine(Convert.ToString(y));
            sv.WriteLine(Convert.ToString(w));
            sv.WriteLine(Convert.ToString(h));
            sv.WriteLine(Convert.ToString(arg1));
            sv.WriteLine(Convert.ToString(arg2));
            sv.WriteLine(Convert.ToString(arg3));
        }
        public void Muda(StreamReader sr)
        {
            x = Convert.ToInt32(sr.ReadLine());
            y = Convert.ToInt32(sr.ReadLine());
            w = Convert.ToInt32(sr.ReadLine());
            h = Convert.ToInt32(sr.ReadLine());
            arg1 = Convert.ToInt32(sr.ReadLine());
            arg2 = Convert.ToInt32(sr.ReadLine());
            arg3 = Convert.ToInt32(sr.ReadLine());
        }
    }
}
