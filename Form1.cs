using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Zatmenie
{
    public partial class Form1 : Form
    {
        static Grunbeld[] ApostRect = new Grunbeld[10];
        static Locus[] ApostElli = new Locus[10];
        static Zodd[] ApostEmig = new Zodd[10];
        int[] coun = new int[3];
        Graphics graph;
        int move;
        int ind,dx,dy;
        bool trig = true;
        bool trigsv = true;
        Izmen izm;
        StreamWriter sv;
        StreamReader sr;
        public Form1()
        {
            InitializeComponent();
            graph = CreateGraphics();
        }

        private void Rectal_ValueChanged(object sender, EventArgs e)
        {
            if (trig)
            {
                trigsv = true;
                if (Rectal.Value >= coun[0] && coun[0] != 10)
                {
                    coun[0] += 1;
                    ApostRect[Convert.ToInt32(Rectal.Value - 1)] = new Grunbeld(Convert.ToInt32(Rectal.Value) * 20 + 75, 0, this.Width, this.Height);
                    ApostRect[Convert.ToInt32(Rectal.Value - 1)].DrawGr(graph);
                    Controls.Add(ApostRect[Convert.ToInt32(Rectal.Value - 1)].BB());
                    Refresh();
                }
                else
                {
                    ApostRect[Convert.ToInt32(Rectal.Value)].Invisible();
                    coun[0] -= 1;
                    Refresh();
                }
            }
        }
        private void Ellay_ValueChanged(object sender, EventArgs e)
        {
            if (trig)
            {
                trigsv = true;
                if (Ellay.Value >= coun[1] && coun[1] != 10)
                {
                    coun[1] += 1;
                    ApostElli[Convert.ToInt32(Ellay.Value - 1)] = new Locus(Convert.ToInt32(Ellay.Value) * 20 + 75, 25, this.Width, this.Height);
                    ApostElli[Convert.ToInt32(Ellay.Value - 1)].DrawLo(graph);
                    Controls.Add(ApostElli[Convert.ToInt32(Ellay.Value - 1)].BB());
                    Refresh();
                }
                else
                {
                    ApostElli[Convert.ToInt32(Ellay.Value)].Invisible();
                    coun[1] -= 1;
                    Refresh();
                }
            }
        }

        private void emigrant_ValueChanged(object sender, EventArgs e)
        {
            if (trig)
            {
                trigsv = true;
                if (emigrant.Value >= coun[2] && coun[2] != 10)
                {
                    coun[2] += 1;
                    ApostEmig[Convert.ToInt32(emigrant.Value - 1)] = new Zodd(Convert.ToInt32(emigrant.Value) * 20 + 75, 50, this.Width, this.Height);
                    ApostEmig[Convert.ToInt32(emigrant.Value - 1)].Draw(graph);
                    Controls.Add(ApostEmig[Convert.ToInt32(emigrant.Value - 1)].BB());
                    Refresh();
                }
                else
                {
                    ApostEmig[Convert.ToInt32(emigrant.Value)].Invisible();
                    coun[2] -= 1;
                    Refresh();
                }
            }
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Refresh();
            for (int i = 0; i < Rectal.Value; i++)
            {
                if (ApostRect[i].GrClick(e.X, e.Y, graph))
                {
                    trigsv = true;
                    if (e.Button == MouseButtons.Left)
                    {
                        ind = i;
                        dx = e.X - ApostRect[ind].ComeBack("x");
                        dy = e.Y - ApostRect[ind].ComeBack("y");
                        move = 1;
                    }
                    else if (e.Button == MouseButtons.Right && ApostRect[i].RetTch())
                    {
                        izm = new Izmen(ApostRect[i], this.Width, this.Height);
                        izm.Show();
                    }
                    break;
                }
            }
            for (int i = 0; i < Ellay.Value; i++)
            {
                if (ApostElli[i].LoClick(e.X, e.Y, graph))
                {
                    trigsv = true;
                    if (e.Button == MouseButtons.Left)
                    {
                        ind = i;
                        dx = e.X - ApostElli[ind].ComeBack("x");
                        dy = e.Y - ApostElli[ind].ComeBack("y");
                        move = 2;
                    }
                    else if (e.Button == MouseButtons.Right && ApostElli[i].RetTch())
                    {
                        izm = new Izmen(ApostElli[i], this.Width, this.Height);
                        izm.Show();
                    }
                    break;
                }
            }
            for (int i = 0; i < emigrant.Value; i++)
            {
                if (ApostEmig[i].Click(e.X, e.Y, graph))
                {
                    trigsv = true;
                    if (e.Button == MouseButtons.Left)
                    {
                        ind = i;
                        dx = e.X - ApostEmig[ind].ComeBack("x");
                        dy = e.Y - ApostEmig[ind].ComeBack("y");
                        move = 3;
                    }
                    else if (e.Button == MouseButtons.Right && ApostEmig[i].RetTch())
                    {
                        izm = new Izmen(ApostEmig[i], this.Width, this.Height);
                        izm.Show();
                    }
                    break;
                }
            }
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move==1)
            {
                trigsv = true;
                ApostRect[ind].Move(e.X-dx, e.Y-dy, graph);
                Refresh();
            }
            else if (move == 2)
            {
                trigsv = true;
                ApostElli[ind].Move(e.X-dx, e.Y-dy, graph);
                Refresh();
            }
            else if (move==3)
            {
                trigsv = true;
                ApostEmig[ind].Move(e.X-dx, e.Y-dy, graph);
                Refresh();
            }
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            graph = CreateGraphics();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            savv();
            trigsv = false;
        }
        private void savv()
        {
            sv = new StreamWriter(Path.Combine(Environment.CurrentDirectory, "IdetaZla.txt"));
            sv.WriteLine(Convert.ToString(coun[0]));
            sv.WriteLine(Convert.ToString(coun[1]));
            sv.WriteLine(Convert.ToString(coun[2]));
            for (int i = 0; i < coun[0]; i++)
            {
                ApostRect[i].Wreee(sv);
            }
            for (int i = 0; i < coun[1]; i++)
            {
                ApostElli[i].Wreee(sv);
            }
            for (int i = 0; i < coun[2]; i++)
            {
                ApostEmig[i].Wreee(sv);
            }
            sv.Close();
        }

        private void Load_Click(object sender, EventArgs e)
        {
            for (int i = 0; i< coun[0]; i++)
            {
                ApostRect[i].Invisible();
            }
            for (int i = 0; i < coun[1]; i++)
            {
                ApostElli[i].Invisible();
            }
            for (int i = 0; i < coun[2]; i++)
            {
                ApostEmig[i].Invisible();
            }
            sr = new StreamReader(Path.Combine(Environment.CurrentDirectory, "IdetaZla.txt"));
            coun[0] = Convert.ToInt32(sr.ReadLine());
            coun[1] = Convert.ToInt32(sr.ReadLine());
            coun[2] = Convert.ToInt32(sr.ReadLine());
            trig = false;
            for (int i = 0; i < coun[0]; i++)
            {
                ApostRect[i] = new Grunbeld((i+1) * 20 + 75, 0, this.Width, this.Height);
                ApostRect[i].Muda(sr);
                ApostRect[i].DrawGr(graph);
                Controls.Add(ApostRect[i].BB());
            }
            for (int i = 0; i < coun[1]; i++)
            {
                ApostElli[i] = new Locus((i+1) * 20 + 75, 25, this.Width, this.Height);
                ApostElli[i].Muda(sr);
                ApostElli[i].DrawLo(graph);
                Controls.Add(ApostElli[i].BB());
            }
            for (int i = 0; i < coun[2]; i++)
            {
                ApostEmig[i] = new Zodd((i+1) * 20 + 75, 50, this.Width, this.Height);
                ApostEmig[i].Muda(sr);
                ApostEmig[i].Draw(graph);
                Controls.Add(ApostEmig[i].BB());
            }
            Refresh();
            Rectal.Value = coun[0];
            Ellay.Value = coun[1];
            emigrant.Value = coun[2];
            trig = true;
            sr.Close();
            trigsv = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (trigsv)
            {
                DialogResult res = MessageBox.Show("Вы бежите от хаоса без сохранения?", "АХАХАХАХАХААХАХАХАХАХХАХАХАХАХАХАХАХАХАХ", MessageBoxButtons.YesNoCancel);
                if (res == DialogResult.No)
                {
                    savv();
                }
                else if (res == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void Info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("СнNзо0л0 вEлNк0е зAтmенNе N RвNлсR пRтЬlй 4лен рYкN 60гA, 4т0 прNнесет хA0с нA этY зеmлю. ВAшN фNгYры 6YдYт рAзбр0сAны N рAзрYшAны, A трAкт0ры преврAтRтьсR 8 пыль NлN стAнYт Aп0ст0лAмN. BAш выб0р нNчег0 не п0менRет 8 эт0м AдY. ЖелAю вAм выжNть.....", "Идея зла явилась вам", MessageBoxButtons.YesNo);

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < coun[0]; i++)
            {
                ApostRect[i].DrawGr(e.Graphics);
            }
            for (int i = 0; i < coun[1]; i++)
            {
                ApostElli[i].DrawLo(e.Graphics);
            }
            for (int i = 0; i < coun[2]; i++)
            {
                ApostEmig[i].Draw(e.Graphics);
            }
        }
    }
}
