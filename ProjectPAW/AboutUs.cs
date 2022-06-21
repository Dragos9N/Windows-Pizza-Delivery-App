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
    public partial class AboutUs : Form
    {
        Thread th;
        public AboutUs()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void buttonLeave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(deschideFormaNext);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void deschideFormaNext()
        {
            Application.Run(new Form1());
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(deschideFormaBack);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void deschideFormaBack()
        {
            Application.Run(new Home());
        }

        private void roundButtonsSetari_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Settings in work!","Welcome!!",MessageBoxButtons.OKCancel);
        }

        private void roundButtons_Click(object sender, EventArgs e)
        {
            MessageBox.Show("FREE WI-FI!", "Welcome!", MessageBoxButtons.OKCancel);
        }

        private void roundButtons3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DRIVE THRU!", "Welcome!", MessageBoxButtons.OKCancel);
        }

        private void roundButtons4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("COMMAND 3 AND GET 1 FOR FREE", "Welcome!", MessageBoxButtons.OKCancel);
        }

        private void roundButtons5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HARD WORKING STAFF", "Welcome!", MessageBoxButtons.OKCancel);
        }
    }
}
