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
    abstract class Dlan_Gospoda
    {
        protected int x, y;
        protected int w, h;
        protected int mx, my;
        protected int arg1, arg2, arg3;
        protected Brush brush;
        protected Pen pen;
        protected CheckBox ff;
        Random rnd = new Random();
        public Dlan_Gospoda(int lx, int ly, int endx, int endy)
        {
            ff = new CheckBox();
            ff.Size = new Size(20, 20);
            ff.Location = new Point(lx, ly);
            ff.Checked = true;
            ff.Click += touchCh;
            x = rnd.Next(10, endx);
            y = rnd.Next(10, endy);
            h = rnd.Next(25, 125);
            w = rnd.Next(25, 125);
            mx = x + (w / 2);
            my = y + (h / 2);
            arg1 = rnd.Next(255);
            arg2 = rnd.Next(255);
            arg3 = rnd.Next(255);
            brush = new SolidBrush(Color.FromArgb(255,arg1, arg2, arg3));
            pen = new Pen(Color.FromArgb(255, (arg1 + 180) % 255, (arg2 + 180) % 255, (arg3 + 180) % 255));
        }
        public int ComeBack(string nn)
        {
            if (nn == "x")
                return x;
            else if (nn == "y")
                return y;
            else if (nn == "w")
                return w;
            else if (nn == "h")
                return h;
            else
                return 0;
        }
        public void touchCh(object sender, EventArgs e)
        {
            if (ff.Checked)
            {
                brush = new SolidBrush(Color.FromArgb(255, arg1, arg2, arg3));
                pen = new Pen(Color.FromArgb(255, (arg1 + 180) % 255, (arg2 + 180) % 255, (arg3 + 180) % 255));
            }
            else
            {
                brush = new SolidBrush(Color.FromArgb(122, arg1, arg2, arg3));
                pen = new Pen(Color.FromArgb(122, (arg1 + 180) % 255, (arg2 + 180) % 255, (arg3 + 180) % 255));
            }
        }
        public virtual void Move(int x, int y, Graphics graph)
        {
            if (ff.Checked)
            {
                this.x = x;
                this.y = y;
            }
        }
        public CheckBox BB()
        {
            return ff;
        }
        public void Invisible()
        {
            ff.Visible = false;
        }
        public bool RetTch()
        {
            return ff.Checked;
        }
        public void st(int x, int y, int w, int h)
        {
            this.x = x;
            this.y = y;
            this.h = h;
            this.w = w;
            mx = x + (w / 2);
            my = y + (h / 2);
        }
        public void ChArgb(int arg1, int arg2, int arg3)
        {
            this.arg1 = arg1;
            this.arg2 = arg2;
            this.arg3 = arg3;
            brush = new SolidBrush(Color.FromArgb(255, arg1, arg2, arg3));
            pen = new Pen(Color.FromArgb(255, (arg1 + 180) % 255, (arg2 + 180) % 255, (arg3 + 180) % 255));
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
            sv.WriteLine(Convert.ToString(ff.Checked));
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
            ff.Checked = Convert.ToBoolean(sr.ReadLine());
            if (ff.Checked)
            {
                brush = new SolidBrush(Color.FromArgb(255, arg1, arg2, arg3));
                pen = new Pen(Color.FromArgb(255, (arg1 + 180) % 255, (arg2 + 180) % 255, (arg3 + 180) % 255));
            }
            else
            {
                brush = new SolidBrush(Color.FromArgb(122, arg1, arg2, arg3));
                pen = new Pen(Color.FromArgb(122, (arg1 + 180) % 255, (arg2 + 180) % 255, (arg3 + 180) % 255));
            }
        }
    }
}
