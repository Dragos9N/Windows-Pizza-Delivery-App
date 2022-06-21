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
    public partial class FormBazaDeDate : Form
    {
        public FormBazaDeDate()
        {
            InitializeComponent();
        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewBD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Sunteti sigur ca vreti sa stergeti aceasta inregistrare?","Mesaj", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    tabelaClientiBindingSource.RemoveCurrent();
            }
        }

        private void buttonBDnou_Click(object sender, EventArgs e)
        {
            try
            {
                panelBD.Enabled = true;
                textBoxBDoras.Focus();
                this.detalii_Clienti.Tabela_Clienti.AddTabela_ClientiRow(this.detalii_Clienti.Tabela_Clienti.NewTabela_ClientiRow());
                tabelaClientiBindingSource.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                tabelaClientiBindingSource.ResetBindings(false);
            }
        }

        private void buttonBDediteaza_Click(object sender, EventArgs e)
        {
            panelBD.Enabled = true;
            textBoxBDoras.Focus();
        }

        private void buttonBDinchide_Click(object sender, EventArgs e)
        {
            panelBD.Enabled = false;
            tabelaClientiBindingSource.ResetBindings(false);
        }

        private void buttonBDsalveaza_Click(object sender, EventArgs e)
        {
            try
            {
                tabelaClientiBindingSource.EndEdit();
                tabela_ClientiTableAdapter.Update(this.detalii_Clienti.Tabela_Clienti);
                panelBD.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                tabelaClientiBindingSource.ResetBindings(false);
            }

        }

        private void FormBazaDeDate_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'detalii_Clienti.Tabela_Clienti' table. You can move, or remove it, as needed.
            this.tabela_ClientiTableAdapter.Fill(this.detalii_Clienti.Tabela_Clienti);
            tabelaClientiBindingSource.DataSource = this.detalii_Clienti.Tabela_Clienti;
            this.BackColor = Color.Silver;
        }

        private void textBoxBDcauta_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
