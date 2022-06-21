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
    public partial class Delegati : Form
    {
        public Delegati()
        {
            InitializeComponent();
        }
        public delegate void comenzi();
        public void CosturiTotale()
        {
            int val1 = int.Parse(textBoxCostPizza.Text);
            int val2 = int.Parse(textBoxCostTaxa.Text);
            int val3 = int.Parse(textBoxCostTransport.Text);
            int rezultat = val1 + val2 + val3;
            textBoxTotalCosturi.Text = rezultat.ToString();
        }
        public void BaniRamasi()
        {
            int val1 = int.Parse(textBoxCostPizza.Text);
            int val2 = int.Parse(textBoxCostTaxa.Text);
            int val3 = int.Parse(textBoxCostTransport.Text);
            int val4 = int.Parse(textBoxBuget.Text);
            int rezultat = val4 - (val1 + val2 + val3);
            textBoxBaniRamasi.Text = rezultat.ToString();
        }

        private void buttonBaniRamasi_Click(object sender, EventArgs e)
        {
            comenzi baniRamasi = new comenzi(BaniRamasi);
            baniRamasi.Invoke();
        }

        private void buttonCosturi_Click(object sender, EventArgs e)
        {
            comenzi costuriTotale = new comenzi(CosturiTotale);
            costuriTotale.Invoke();
            toolStripStatusLabel2.Text = textBoxTotalCosturi.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
