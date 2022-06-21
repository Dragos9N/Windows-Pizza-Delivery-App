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
    public partial class LineDesign : Form
    {
        public LineDesign()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            this.ResizeRedraw = true;//redimensionare automata

            base.OnPaint(e);//trasare automat fundat cu alb pe background

            Graphics g = e.Graphics;//pastrare cotnext grafic

            Rectangle rc = this.ClientRectangle;

            Point pc = new Point(rc.Width / 2, rc.Height / 2);
            g.DrawString("Lucru grafic", this.Font, Brushes.ForestGreen, new Point(10, 10));

            g.DrawLine(new Pen(Brushes.DarkGreen, 10), new Point(10, 20), pc);
        }

        private void buttonDeseneaza_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            g.DrawString("LUCRU GRAFIC", this.Font, Brushes.ForestGreen, new Point(50, 60));

            g.DrawLine(new Pen(Brushes.Snow, 10), 10, 20, 300, 310);
        }

        private void LineDesign_Load(object sender, EventArgs e)
        {

        }

        private void buttonLeave_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
