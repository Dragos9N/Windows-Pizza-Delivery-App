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
    public partial class Login : Form
    {
        Thread th;
        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                MessageBox.Show("Introduceți parola!");
            }
            else if(textBoxPassword.Text=="student" && textBoxNickname.Text=="Dragos")
            {
                this.Close();
                th = new Thread(deschideForma);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();             
            }
            else
            {
                MessageBox.Show("Parola sau numele introdusă este greșit introdusă!","Eroare",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void deschideForma()
        {
            Application.Run(new Home());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
