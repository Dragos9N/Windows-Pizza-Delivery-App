using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPAW
{
    public partial class FormGraficComenzi : Form
    {
        string[] x; 
        float[] y;
        int nrElemente;
        public Form1 parinte;

        private void panel1_Resize(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Rectangle zonaClient = e.ClipRectangle;
            Brush fundal = new SolidBrush(Color.Orange);

            g.FillRectangle(fundal, zonaClient);

            zonaClient.X += 40; zonaClient.Y += 40;
            zonaClient.Width -= 80; zonaClient.Height -= 80;

            Pen creionVerde = new Pen(Color.DarkGreen, 8);
            g.DrawRectangle(creionVerde, zonaClient);

            int vl = zonaClient.Left;
            int vb = zonaClient.Bottom;
            int vr = zonaClient.Right;
            int vt = zonaClient.Top;

            float rap_dist_lat = 0.8f;
            float max;
            int lat;
            int dist;
            string denx = "";

            SolidBrush[] pensule = new SolidBrush[]
                {
                    new SolidBrush (Color.DarkCyan),
                    new SolidBrush (Color.DarkKhaki),
                    new SolidBrush(Color.MediumAquamarine),
                    new SolidBrush(Color.ForestGreen),
                    new SolidBrush (Color.DeepSkyBlue),
                    new SolidBrush(Color.IndianRed)
                };

            SolidBrush pensulaCurenta;
            Pen creionCurent;

            max = y[0];
            int i;
            for (i = 1; i < nrElemente; i++)
                if (max < y[i]) max = y[i];

            lat = (vr - vl) / (int)((nrElemente + 1) * rap_dist_lat + nrElemente);
            dist = (int)(lat * rap_dist_lat);

            creionCurent = new Pen(Color.Olive);
            g.DrawLine(creionCurent, vl, vt, vl, vb);
            g.DrawLine(creionCurent, vl, vb, vr, vb);

            creionCurent = new Pen(Color.BlanchedAlmond);
            for (i = 0; i < nrElemente; i++)
            {
                pensulaCurenta = pensule[(i % 6)];
                PointF pnt = new PointF(vl + dist + i * (lat + dist), (vb - y[i] * (vb - vt) / max));
                SizeF sz = new SizeF(lat, y[i] * (vb - vt) / max);
                g.FillRectangle(pensulaCurenta, new RectangleF(pnt, sz));

                denx = x[i].ToString();
                g.DrawString(denx, Font, pensulaCurenta, vl + dist + i * (lat + dist) + lat / 3, vb + 5);
            }
        }

        private void FormGraficComenzi_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            this.ResizeRedraw = true;
            nrElemente = 7;
            var d1 = DateTime.Now;
            d1 = d1.Date.AddDays(-1);
            var data1 = d1.ToShortDateString();
            var d2 = DateTime.Now;
            d2 = d2.Date.AddDays(-2);
            var data2 = d2.ToShortDateString();
            DateTime d3 = DateTime.Now;
            d3 = d3.Date.AddDays(-3);
            var data3 = d3.ToShortDateString();
            DateTime d4 = DateTime.Now;
            d4 = d4.Date.AddDays(-4);
            var data4 = d4.ToShortDateString();
            DateTime d5 = DateTime.Now;
            d5 = d5.Date.AddDays(-5);
            var data5 = d5.ToShortDateString();
            DateTime d6 = DateTime.Now;
            d6 = d6.Date.AddDays(-6);
            var data6 = d6.ToShortDateString();
            DateTime d7 = DateTime.Now;
            d7 = d7.Date.AddDays(-7);
            var data7 = d7.ToShortDateString();
            x = new string[] { data1, data2, data3, data4, data5, data6, data7 };
            y = new float[] { parinte.pretmax1, parinte.pretmax2, parinte.pretmax3, parinte.pretmax4, parinte.pretmax5, parinte.pretmax6, parinte.pretmax7 };
        }

        public FormGraficComenzi()
        {
            InitializeComponent();
        }
    }
}
