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
    class Locus : Dlan_Gospoda
    {
        public Locus(int lx, int ly, int endx, int endy) : base(lx, ly, endx, endy) { }
        public void DrawLo(Graphics graph)
        {
            graph.FillEllipse(brush, x, y, w, h);
        }
        public void DrawLo2(int x, int y, Graphics graph)
        {
            graph.FillEllipse(brush, x - (w / 2), y - (h / 2), w, h);
        }
        public void LoObvod(Graphics graph)
        {
            graph.DrawEllipse(pen, x, y, w, h);
        }
        public void LoObvod2(int x, int y, Graphics graph)
        {
            graph.DrawEllipse(pen, x - (w / 2), y - (h / 2), w, h);
        }
        public bool LoClick(int x, int y, Graphics graph)
        {
            ///double k = (double)((x-this.x) / (w / 2)) * (double)((x - this.x) / (w / 2)) + (double)(y-this.y / (h / 2)) * (double)(y - this.y / (h / 2));
            if (x > this.x && y > this.y && x < this.x + w && y < this.y + h )
            {
                LoObvod(graph);
                return true;
            }
            return false;
        }
        public override void Move(int x, int y, Graphics graph)
        {
            if (ff.Checked)
            {
                this.x = x;
                this.y = y;
                DrawLo(graph);
                LoObvod(graph);
            }
        }
    }
}
