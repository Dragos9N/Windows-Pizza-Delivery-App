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
    public partial class Prețuri : Form
    {
        public Form1 parinte;
        public Prețuri()
        {
            InitializeComponent();
        }

        private void Prețuri_Load(object sender, EventArgs e)
        {
            textBox1.Text = parinte.pretMinim.ToString();
            textBox3.Text = parinte.pretMediu.ToString();
            textBox2.Text = parinte.pretMaxim.ToString();
        }
    }
}
