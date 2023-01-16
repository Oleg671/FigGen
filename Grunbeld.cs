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
    class Grunbeld : Dlan_Gospoda
    {
        public Grunbeld(int lx, int ly, int endx, int endy) : base(lx, ly, endx, endy) {}
        public void DrawGr(Graphics graph)
        {
            graph.FillRectangle(brush, x, y, w, h);
        }
        public void DrawGr2(int x, int y, Graphics graph)
        {
            graph.FillRectangle(brush, x - (w / 2), y - (h / 2), w, h);
        }
        public void GrObvod(Graphics graph)
        {
            graph.DrawRectangle(pen, x, y, w, h);
        }
        public void GrObvod2(int x, int y, Graphics graph)
        {
            graph.DrawRectangle(pen, x - (w / 2), y - (h / 2), w, h);
        }
        public bool GrClick(int x, int y, Graphics graph)
        {
            if (x>this.x && y>this.y && x<this.x+w && y < this.y+h)
            {
                GrObvod(graph);
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
                DrawGr(graph);
                GrObvod(graph);
            }
        }
    }
}
