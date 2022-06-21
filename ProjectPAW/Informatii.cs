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
    public partial class Informatii : Form
    {
        public Informatii()
        {
            InitializeComponent();
        }

        private void Informatii_Load(object sender, EventArgs e)
        {
            diavola1.Hide();
            mexicana1.Hide();
            siciliana1.Hide();
            exotica1.Hide();

        }

        private void buttoninfDiavola_Click(object sender, EventArgs e)
        {
            mexicana1.Hide();
            siciliana1.Hide();
            exotica1.Hide();
            diavola1.Show();
            diavola1.BringToFront();
        }

        private void buttoninfMexicana_Click(object sender, EventArgs e)
        {
            diavola1.Hide();
            siciliana1.Hide();
            exotica1.Hide();
            mexicana1.Show();
            mexicana1.BringToFront();
        }

        private void button3infSiciliana_Click(object sender, EventArgs e)
        {
            diavola1.Hide();
            mexicana1.Hide();
            exotica1.Hide();
            siciliana1.Show();
            mexicana1.BringToFront();
        }

        private void buttoninfExotica_Click(object sender, EventArgs e)
        {
            diavola1.Hide();
            mexicana1.Hide();
            siciliana1.Hide();
            exotica1.Show();
            exotica1.BringToFront();
        }

        private void buttonLeave_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
