using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ProjectPAW
{
    public partial class Home : Form
    {
        Thread th;
        public Home()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            SidePanel.Height = button2.Height;
            informatiiHome1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            informatiiHome1.BringToFront();
        }

        private void buttonhomeImagine_Click(object sender, EventArgs e)
        {
            SidePanel.Height = buttonhomeImagine.Height;
            SidePanel.Top = buttonhomeImagine.Top;
            homeimagini1.BringToFront();
        }

        private void buttonLeave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonHomepreturi_Click(object sender, EventArgs e)
        {
            SidePanel.Height = buttonHomepreturi.Height;
            SidePanel.Top = buttonHomepreturi.Top;
            preturi1.BringToFront();
        }

        private void buttonHOME_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(deschideForma);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void deschideForma()
        {
            Application.Run(new AboutUs());
        }
    }
}
