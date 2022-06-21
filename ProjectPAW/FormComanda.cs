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
    public partial class FormComanda : Form
    {
        public Comanda comanda;
        public Form1 forma1;
        public FormComanda()
        {
            InitializeComponent();
        }

        public void ActualizeazaControale(object sender, EventArgs e)
        {
            ListView lista = (ListView)sender;

            if (lista.SelectedItems.Count > 0)
                comanda = (Comanda)lista.SelectedItems[0].Tag;

            if (comanda != null)
            {
                textBoxIdComanda.Text = comanda.idComanda.ToString();
                textBoxPretComanda.Text = comanda.pretComanda.ToString();
                string listaPizza3 = "";
                for (int i = 0; i < comanda.pizza.Count; i++)
                {
                    listaPizza3 = listaPizza3 + comanda.pizza[i].denumire;
                }
                comboBoxDiavola.Text = listaPizza3;
                textBoxIdClient.Text = comanda.client.idClient.ToString();
                textBoxOras.Text = comanda.adresa.oras;
                dateTimePickerInregistrare.Value = comanda.data;
            }
        }
        private void buttonActualizare_Click(object sender, EventArgs e)
        {
            bool eroareComanda = false;
            if (textBoxIdComanda.Text.Length==0)
            {
                eroareComanda = true;
                errorProviderIdComanda.SetError(textBoxIdComanda, "Trebuie sa introduceti un ID");
            }
            else errorProviderIdComanda.SetError(textBoxIdComanda, "");
            bool eroareClient = false;
            if (textBoxIdClient.Text.Length == 0)
            {
                eroareClient = true;
                errorProviderIdClient.SetError(textBoxIdClient, "Trebuie sa introduceti un ID pentru client");
            }
            else errorProviderIdClient.SetError(textBoxIdClient, "");
            bool eroarePret = false;
            if (textBoxPretComanda.Text.Length == 0)
            {
                eroarePret = true;
                errorProviderPretComanda.SetError(textBoxPretComanda, "Trebuie sa introduceti un pret");
            }
            else errorProviderPretComanda.SetError(textBoxPretComanda, "");
            
            if (comanda != null&&!eroareComanda&&!eroareClient&&!eroarePret)
            {
                
                this.DialogResult = DialogResult.OK;
                comanda.idComanda = Convert.ToInt32(textBoxIdComanda.Text);
                comanda.pretComanda = Convert.ToInt32(textBoxPretComanda.Text);

                string pizza11 = comboBoxDiavola.Text + textBoxNrDiavola.Text + " ";
                string pizza12 = comboBoxExotica.Text + textBoxExotica.Text + " ";
                string pizza13 = comboBoxMexicana.Text + textBoxMexicana.Text + " ";
                string pizza14 = comboBoxSiciliana.Text + textBoxSiciliana.Text;
                List<Pizza> pizza2 = new List<Pizza>()
                {
                 new Pizza(pizza11,0,0),          
                 new Pizza(pizza12,0,0),
                 new Pizza(pizza13,0,0),
                 new Pizza(pizza14,0,0)
                };
                comanda.pizza = pizza2;
               
                comanda.client.idClient = Convert.ToInt32(textBoxIdClient.Text);
                comanda.adresa.oras = textBoxOras.Text;
                comanda.data = dateTimePickerInregistrare.Value;
                forma1.Updateaza();
            }
        }


        private void FormComanda_Load(object sender, EventArgs e)
        {
        }

        private void buttonImaginiPizza_Click(object sender, EventArgs e)
        {
            FormPictures fp = new FormPictures();
            fp.ShowDialog();
        }

        private void FormComanda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode.ToString() == "Q")
            {
                FormPictures picture = new FormPictures();
                picture.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
