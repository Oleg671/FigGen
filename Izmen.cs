using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zatmenie
{
    internal partial class Izmen : Form
    {
        ColorDialog cl = new ColorDialog();
        Grunbeld gr;
        Locus lc;
        Zodd zd;
        int x, y, w, h;
        int ind;
        Graphics graph;
        Form1 ff = new Form1();
        public Izmen(Grunbeld gr, int endx, int endy)
        {
            InitializeComponent();
            xn.Maximum = endx;
            yn.Maximum = endy;
            this.gr = gr;
            ind = 1;
            x = gr.ComeBack("x");
            y = gr.ComeBack("y");
            w = gr.ComeBack("w");
            h = gr.ComeBack("h");
            xn.Value = x;
            yn.Value = y;
            wn.Value = w;
            hn.Value = h;
            graph = panel1.CreateGraphics();
        }
        public Izmen(Locus lc, int endx, int endy)
        {
            InitializeComponent();
            xn.Maximum = endx;
            yn.Maximum = endy;
            this.lc = lc;
            ind = 2;
            x = lc.ComeBack("x");
            y = lc.ComeBack("y");
            w = lc.ComeBack("w");
            h = lc.ComeBack("h");
            xn.Value = x;
            yn.Value = y;
            wn.Value = w;
            hn.Value = h;
            graph = panel1.CreateGraphics();
        }
        public Izmen(Zodd zd, int endx, int endy)
        {
            InitializeComponent();
            xn.Maximum = endx;
            yn.Maximum = endy;
            this.zd = zd;
            ind = 3;
            x = zd.ComeBack("x");
            y = zd.ComeBack("y");
            w = zd.ComeBack("w");
            h = zd.ComeBack("h");
            xn.Value = x;
            yn.Value = y;
            wn.Value = w;
            hn.Value = h;
            graph = panel1.CreateGraphics();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (ind == 1)
            {
                gr.DrawGr2(panel1.Width / 2, panel1.Height / 2, e.Graphics);
            }
            else if (ind == 2)
            {
                lc.DrawLo2(panel1.Width / 2, panel1.Height / 2, e.Graphics);
            }
            else if (ind == 3)
            {
                zd.Draw2(panel1.Width / 2, panel1.Height / 2, e.Graphics);
            }
        }
        private void CB_Click(object sender, EventArgs e)
        {
            if (ind == 1)
            {
                DialogResult result = cl.ShowDialog();
                gr.ChArgb(cl.Color.R, cl.Color.G, cl.Color.B);
                panel1.Refresh();
            }
            else if (ind == 2)
            {
                DialogResult result = cl.ShowDialog();
                lc.ChArgb(cl.Color.R, cl.Color.G, cl.Color.B);
                panel1.Refresh();
            }
            else if (ind == 3)
            {
                DialogResult result = cl.ShowDialog();
                zd.ChARGB(cl.Color.R, cl.Color.G, cl.Color.B);
                panel1.Refresh();
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (ind == 1)
            {
                gr.GrObvod2(panel1.Width / 2, panel1.Height / 2, graph);
            }
            else if (ind == 2)
            {
                lc.LoObvod2(panel1.Width / 2, panel1.Height / 2, graph);
            }
            else if (ind == 3)
            {
                zd.ClickARGB(e.X, e.Y);
                panel1.Refresh();
            }
        }
        private void wn_ValueChanged(object sender, EventArgs e)
        {
            if (ind == 1)
            {
                gr.st(Convert.ToInt32(xn.Value), Convert.ToInt32(yn.Value), Convert.ToInt32(wn.Value), Convert.ToInt32(hn.Value));
                panel1.Refresh();
            }
            else if (ind == 2)
            {
                lc.st(Convert.ToInt32(xn.Value), Convert.ToInt32(yn.Value), Convert.ToInt32(wn.Value), Convert.ToInt32(hn.Value));
                panel1.Refresh();
            }
            else if (ind == 3)
            {
                ///zd.st(Convert.ToInt32(xn.Value), Convert.ToInt32(yn.Value), Convert.ToInt32(wn.Value), Convert.ToInt32(hn.Value));
                panel1.Refresh();
            }
        }

        private void Izmen_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void hn_ValueChanged(object sender, EventArgs e)
        {
            if (ind == 1)
            {
                gr.st(Convert.ToInt32(xn.Value), Convert.ToInt32(yn.Value), Convert.ToInt32(wn.Value), Convert.ToInt32(hn.Value));
                panel1.Refresh();
            }
            else if (ind == 2)
            {
                lc.st(Convert.ToInt32(xn.Value), Convert.ToInt32(yn.Value), Convert.ToInt32(wn.Value), Convert.ToInt32(hn.Value));
                panel1.Refresh();
            }
            else if (ind == 3)
            {
                ///zd.st(Convert.ToInt32(xn.Value), Convert.ToInt32(yn.Value), Convert.ToInt32(wn.Value), Convert.ToInt32(hn.Value));
                panel1.Refresh();
            }
        }
        private void xn_ValueChanged(object sender, EventArgs e)
        {
            if (ind == 1)
            {
                gr.st(Convert.ToInt32(xn.Value), Convert.ToInt32(yn.Value), Convert.ToInt32(wn.Value), Convert.ToInt32(hn.Value));
                panel1.Refresh();
            }
            else if (ind == 2)
            {
                lc.st(Convert.ToInt32(xn.Value), Convert.ToInt32(yn.Value), Convert.ToInt32(wn.Value), Convert.ToInt32(hn.Value));
                panel1.Refresh();
            }
            else if (ind == 3)
            {
                ///zd.st(Convert.ToInt32(xn.Value), Convert.ToInt32(yn.Value), Convert.ToInt32(wn.Value), Convert.ToInt32(hn.Value));
                panel1.Refresh();
            }
        }

        private void yn_ValueChanged(object sender, EventArgs e)
        {
            if (ind == 1)
            {
                gr.st(Convert.ToInt32(xn.Value), Convert.ToInt32(yn.Value), Convert.ToInt32(wn.Value), Convert.ToInt32(hn.Value));
                panel1.Refresh();
            }
            else if (ind == 2)
            {
                lc.st(Convert.ToInt32(xn.Value), Convert.ToInt32(yn.Value), Convert.ToInt32(wn.Value), Convert.ToInt32(hn.Value));
                panel1.Refresh();
            }
            else if (ind == 3)
            {
                ///zd.st(Convert.ToInt32(xn.Value), Convert.ToInt32(yn.Value), Convert.ToInt32(wn.Value), Convert.ToInt32(hn.Value));
                panel1.Refresh();
            }
        }
    }
}