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
    public partial class MDIcontainer : Form
    {
        public MDIcontainer()
        {
            InitializeComponent();
            increment = 1;
        }
        int increment;
        private void adaugaFormaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDI mdi = new MDI();
            mdi.Text = "Fereastra" + increment.ToString();
            increment++;
            mdi.MdiParent = this;
            mdi.Show();
        }

        private void orizontalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void cascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void inchideFerestreleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(Form f in this.MdiChildren)
            {
                f.Close();
                f.Dispose();
            }
        }

        private void afisareMesajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                MessageBox.Show(((MDI)ActiveMdiChild).textBoxMDI.Text, "Din fereastra" + ((MDI)ActiveMdiChild).Text);
            }
        }
    }
}
