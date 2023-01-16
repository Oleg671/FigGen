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
    class Zodd
    {
        Cabin cab;
        Kuzov kuz;
        Kolyasa kol;
        int arg1, arg2, arg3;
        Random rnd = new Random();
        CheckBox ff;
        int X, Y, H, W;
        ColorDialog cl = new ColorDialog();
        public Zodd(int lx, int ly, int endx, int endy)
        {
            ff = new CheckBox();
            ff.Size = new Size(20, 20);
            ff.Location = new Point(lx, ly);
            ff.Checked = true;
            arg1 = rnd.Next(255);
            arg2 = rnd.Next(255);
            arg3 = rnd.Next(255);
            X = rnd.Next(20, endx);
            Y = rnd.Next(10, endy);
            cab = new Cabin(arg1, arg2, arg3, X + 10, Y);
            kuz = new Kuzov(cab.ComeBack("x"), cab.ComeBack("y") + cab.ComeBack("h"), arg1, arg2, arg3,Y);
            kol = new Kolyasa(kuz.ComeBack("x"), kuz.ComeBack("y")+ kuz.ComeBack("h"), kuz.ComeBack("w"), arg1, arg2, arg3,X,Y);
            H = kol.ComeBack("y") + kol.ComeBack("h") - Y;
            W = kuz.ComeBack("w");
            ff.Click += touchCh;
        }
        public CheckBox BB()
        {
            return ff;
        }
        public bool RetTch()
        {
            return ff.Checked;
        }
        public void Invisible()
        {
            ff.Visible = false;
        }
        public int ComeBack(string nn)
        {
            if (nn == "x")
                return X;
            else if (nn == "y")
                return Y;
            else if (nn == "w")
                return W;
            else if (nn == "h")
                return H;
            else
                return 0;
        }
        public void Draw(Graphics graph)
        {
            cab.Draw(graph);
            kuz.Draw(graph);
            kol.Draw(graph);
        }
        public void Draw2(int x, int y, Graphics graph)
        {
            cab.Draw(x - (W / 2), y - (H / 2), graph);
            kuz.Draw(cab.ComeBack("xf2")-10, cab.ComeBack("yf2") + cab.ComeBack("h"), graph);
            kol.Draw(kuz.ComeBack("xf2"), kuz.ComeBack("yf2") + kuz.ComeBack("h"), graph);
        }
        public void Obvod(Graphics graph)
        {
            cab.Obvod(graph);
            kuz.Obvod(graph);
            kol.Obvod(graph);
        }
        public bool Click(int x, int y, Graphics graph)
        {
            if (cab.Click(x, y) || kuz.Click(x, y) || kol.Click(x, y))
            {
                Obvod(graph);
                return true;
            }
            return false;
        }
        public void touchCh(object sender, EventArgs e)
        {
            if (ff.Checked)
            {
                cab.ChBP1();
                kuz.ChBP1();
                kol.ChBP1();
            }
            else
            {
                cab.ChBP2();
                kuz.ChBP2();
                kol.ChBP2();
            }
        }
        public void Move(int x, int y, Graphics graph)
        {
            if (ff.Checked)
            {
                cab.Move(x, y, graph);
                kuz.Move(x, y, graph);
                kol.Move(x, y, graph);
                Draw(graph);
                Obvod(graph);
            }
        }
        public void st(int x, int y, int w, int h)
        {
            X = x;
            Y = y;
            cab.st(x, y, w - W, Convert.ToDouble(h - H) / 3);
            kuz.st(x, cab.ComeBack("y") + cab.ComeBack("h"), w - W, Convert.ToDouble(h - H) / 3);
            kol.st(x, kuz.ComeBack("y") + kuz.ComeBack("h"), kuz.ComeBack("w"), Convert.ToDouble(h - H) / 3);
        }
        public void ChARGB(int arg1, int arg2, int arg3)
        {
            cab.ChARGB(arg1, arg2, arg3);
            kuz.ChARGB(arg1, arg2, arg3);
            kol.ChARGB(arg1, arg2, arg3);
        }
        public void ClickARGB(int x, int y)
        {
            if (cab.Click2(x, y))
            {
                DialogResult result = cl.ShowDialog();
                cab.ChARGB(cl.Color.R, cl.Color.G, cl.Color.B);
            }
            else if (kuz.Click2(x, y))
            {
                DialogResult result = cl.ShowDialog();
                kuz.ChARGB(cl.Color.R, cl.Color.G, cl.Color.B);
            }
            else if (kol.Click2(x, y))
            {
                DialogResult result = cl.ShowDialog();
                kol.ChARGB(cl.Color.R, cl.Color.G, cl.Color.B);
            }
        }
        public void Wreee(StreamWriter sv)
        {
            cab.Wreee(sv);
            kuz.Wreee(sv);
            kol.Wreee(sv);
            sv.WriteLine(Convert.ToString(ff.Checked));
        }
        public void Muda(StreamReader sr)
        {
            cab.Muda(sr);
            kuz.Muda(sr);
            kol.Muda(sr);
            ff.Checked = Convert.ToBoolean(sr.ReadLine());
            if (ff.Checked)
            {
                cab.ChBP1();
                kuz.ChBP1();
                kol.ChBP1();
            }
            else
            {
                cab.ChBP2();
                kuz.ChBP2();
                kol.ChBP2();
            }
        }
    }   
}