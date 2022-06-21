using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Threading;

namespace ProjectPAW
{
    public partial class Form1 : Form
    {
        Thread th;

        public float pretMinim = 99999, pretMaxim= 0, pretMediu = 0;
        public float pretmax1 = 0;
        public float pretmax2 = 0;
        public float pretmax3 = 0;
        public float pretmax4 = 0;
        public float pretmax5 = 0;
        public float pretmax6 = 0;
        public float pretmax7 = 0;
        public Form1()
        {

            InitializeComponent();

            List<Pizza> pizza3 = new List<Pizza>()
            {
              new Pizza("Diavola ",0,0),
              new Pizza("Exotica ",0,0)

            };

            List<Pizza> pizza2 = new List<Pizza>()
            {
              new Pizza("Diavola ",0,0),
              new Pizza("Exotica ",0,0),
              new Pizza("Mexicana ",0,0),
              new Pizza("Siciliana ",0,0)
            };
            Comanda comanda1 = new Comanda(new List<Pizza>(pizza2), new Client(102, "Ionescu", "Alex"), new Adresa("Bucuresti", "Dambovitei", 14), 60, 200,DateTime.Now);
            Comanda comanda2 = new Comanda(new List<Pizza>(pizza3), new Client(108, "Popescu", "Vlad"), new Adresa("Timisoara", "Morii", 27), 2, 47,DateTime.Now);

            ListViewItem lvi1 = new ListViewItem(comanda1.idComanda.ToString());
            lvi1.SubItems.Add(comanda1.pretComanda.ToString());
            string listaPizz = "";
            for (int i = 0; i < pizza2.Count; i++)
            {
                listaPizz = listaPizz + comanda1.pizza[i].denumire;
            }
            lvi1.SubItems.Add(listaPizz);
            lvi1.SubItems.Add(comanda1.client.idClient.ToString());
            lvi1.SubItems.Add(comanda1.adresa.oras);
            lvi1.SubItems.Add(comanda1.data.ToString());
            lvi1.Tag = comanda1;
            listViewInregistrare.Items.Add(lvi1);
           

            ListViewItem lvi2 = new ListViewItem(comanda2.idComanda.ToString());
            lvi2.SubItems.Add(comanda2.pretComanda.ToString());
            string listaPizza2 = "";
            for (int i = 0; i < pizza3.Count; i++)
            {
                listaPizza2 = listaPizza2 + comanda1.pizza[i].denumire;
            }
            lvi2.SubItems.Add(listaPizza2);
            lvi2.SubItems.Add(comanda2.client.idClient.ToString());
            lvi2.SubItems.Add(comanda2.adresa.oras);
            lvi2.SubItems.Add(comanda2.data.ToString());
            lvi2.Tag = comanda2;
            listViewInregistrare.Items.Add(lvi2);

            listViewInregistrare.Sort();
        }

        public void Updateaza()
        {
            foreach (ListViewItem item in listViewInregistrare.Items)
            {
                Comanda comanda = (Comanda)item.Tag;
                item.Text = comanda.idComanda.ToString();
                item.SubItems[1].Text = comanda.pretComanda.ToString();
                string list2 = "";
                for (int i = 0; i < comanda.pizza.Count; i++)
                {
                    list2 = list2 + comanda.pizza[i].denumire;
                }
                item.SubItems[2].Text = list2;
                item.SubItems[3].Text = comanda.client.idClient.ToString();
                item.SubItems[4].Text = comanda.adresa.oras;
                item.SubItems[5].Text = comanda.data.ToString();
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
        }

        public void modificaComandaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewInregistrare.SelectedItems.Count > 0)
            {
                FormComanda fc = new FormComanda();
                listViewInregistrare.SelectedIndexChanged += new EventHandler(fc.ActualizeazaControale);
                fc.Text = "Modificare Comanda";
                fc.ActualizeazaControale(listViewInregistrare, e);
                fc.forma1 = this;
                fc.buttonActualizare.Text = "Modifica";
                fc.ShowDialog();
            }
        }

        private void stergeComandaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewInregistrare.SelectedItems.Count > 0)
            {
                Comanda c = (Comanda)listViewInregistrare.SelectedItems[0].Tag;
                DialogResult stergere = MessageBox.Show("Sigur doriti sa stergeti comanda cu id-ul " + c.idComanda + " ?",
                    "Da, realizati stergerea", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (stergere == DialogResult.Yes) listViewInregistrare.SelectedItems[0].Remove();
            }
        }

        private void adaugaComandaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(new string[] { "", "", "", "", "", "" });
            listViewInregistrare.Items.Add(item);
            Comanda c = new Comanda(new List<Pizza>(), new Client(0, "", ""), new Adresa("", "", 0), 0, 0,DateTime.Now);
            item.Tag = c;
            item.Selected = true;

            FormComanda fc = new FormComanda();
            fc.comanda = c;
            fc.forma1 = this;
            fc.Text = "Adaugare comanda";
            fc.buttonActualizare.Text = "Adauga";

            fc.ShowDialog();

            if (fc.DialogResult != DialogResult.OK) item.Remove();

        }

        private void salvareToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salveazaXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MemoryStream memStream = new MemoryStream();
            XmlTextWriter writer = new XmlTextWriter(memStream, Encoding.UTF8);
            writer.Formatting = Formatting.Indented;

            Comanda c = (Comanda)listViewInregistrare.SelectedItems[0].Tag;
            writer.WriteStartDocument();
            writer.WriteStartElement("Salvare-XML");


            writer.WriteStartElement("Comanda");

            writer.WriteElementString("IdComanda", c.idComanda.ToString());
            writer.WriteElementString("PretComanda", c.pretComanda.ToString());
            string list = "";
            for (int i = 0; i < c.pizza.Count; i++)
            {
                list = list + c.pizza[i].denumire;
            }
            writer.WriteElementString("Pizza", list);
            writer.WriteElementString("IdClient", c.client.idClient.ToString());
            writer.WriteElementString("Oras", c.adresa.oras);
            writer.WriteElementString("Data", c.data.ToString());
            writer.WriteEndElement();




            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();


            string xmlstring = Encoding.UTF8.GetString(memStream.ToArray());

            memStream.Close();
            memStream.Dispose();

            StreamWriter sw = new StreamWriter("c:\\temp\\fisierComanda.xml");
            sw.WriteLine(xmlstring);
            sw.Close();

            MessageBox.Show("Fișierul a fost generat cu succes!");
        }

        private void salveazaXMLToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MemoryStream memStream = new MemoryStream();
            XmlTextWriter writer = new XmlTextWriter(memStream, Encoding.UTF8);
            writer.Formatting = Formatting.Indented;

            List<Comanda> lista = listViewInregistrare.Items.Cast<ListViewItem>()
                .Select(item => (Comanda)item.Tag)
                .ToList();

            writer.WriteStartDocument();
            writer.WriteStartElement("Salvare-XML");



            foreach (Comanda c in lista)
            {
                writer.WriteStartElement("Comanda");

                writer.WriteElementString("IdComanda", c.idComanda.ToString());
                writer.WriteElementString("PretComanda", c.pretComanda.ToString());
                string list = "";
                for (int i = 0; i < c.pizza.Count; i++)
                {
                    list = list + c.pizza[i].denumire;
                }
                writer.WriteElementString("Pizza", list);
                writer.WriteElementString("IdClient", c.client.idClient.ToString());
                writer.WriteElementString("Oras", c.adresa.oras);
                writer.WriteElementString("Data", c.data.ToString());
                writer.WriteEndElement();

            }


            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();


            string xmlstring = Encoding.UTF8.GetString(memStream.ToArray());

            memStream.Close();
            memStream.Dispose();

            StreamWriter sw = new StreamWriter("c:\\temp\\fisierComenzi.xml");
            sw.WriteLine(xmlstring);
            sw.Close();

            MessageBox.Show("Fișierul a fost generat cu succes!");
        }

        private void restaureazaXMLToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StreamReader citire = new StreamReader("c:\\temp\\fisierComenzi.xml");
            string aux = citire.ReadToEnd();
            List<Comanda> lista = new List<Comanda>();
            XmlReader reader = XmlReader.Create(new StringReader(aux));
            while (reader.Read())
            {
                if (reader.Name == "Comanda" && reader.NodeType == XmlNodeType.Element)
                {
                    Comanda obj;

                    while (reader.Read() && reader.Name != "IdComanda") { }
                    reader.Read();
                    string idComandaXML = reader.Value;

                    while (reader.Read() && reader.Name != "PretComanda") { }
                    reader.Read();
                    string PretComandaXML = reader.Value;

                    while (reader.Read() && reader.Name != "Pizza") { }
                    reader.Read();
                    string pizzaXML = reader.Value;

                    while (reader.Read() && reader.Name != "IdClient") { }
                    reader.Read();
                    string idClientXML = reader.Value;

                    while (reader.Read() && reader.Name != "Oras") { }
                    reader.Read();
                    string orasXML = reader.Value;

                    while(reader.Read() && reader.Name != "Data") { }
                    reader.Read();
                    string dataXML = reader.Value;

                    List<Pizza> pizza2 = new List<Pizza>()
                    {
                        new Pizza(pizzaXML,0,0)
                    };


                    obj = new Comanda(pizza2, new Client(int.Parse(idClientXML), "", ""), new Adresa(orasXML, "", 0), int.Parse(idComandaXML), int.Parse(PretComandaXML),DateTime.Parse(dataXML));
                    lista.Add(obj);

                }
            }
            listViewInregistrare.Items.Clear();

            foreach (Comanda c in lista)
            {
                ListViewItem lvi = new ListViewItem(new string[] { "", "", "", "", "", "" });
                lvi.Tag = c;
                listViewInregistrare.Items.Add(lvi);
            }
            Updateaza();
            citire.Close();

        }



        private void restaureazaXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamReader citire = new StreamReader("c:\\temp\\fisierComanda.xml");
            string aux = citire.ReadToEnd();
            List<Comanda> lista = new List<Comanda>();
            XmlReader reader = XmlReader.Create(new StringReader(aux));
            while (reader.Read())
            {
                if (reader.Name == "Comanda" && reader.NodeType == XmlNodeType.Element)
                {
                    Comanda obj;

                    while (reader.Read() && reader.Name != "IdComanda") { }
                    reader.Read();
                    string idComandaXML = reader.Value;

                    while (reader.Read() && reader.Name != "PretComanda") { }
                    reader.Read();
                    string PretComandaXML = reader.Value;

                    while (reader.Read() && reader.Name != "Pizza") { }
                    reader.Read();
                    string pizzaXML = reader.Value;

                    while (reader.Read() && reader.Name != "IdClient") { }
                    reader.Read();
                    string idClientXML = reader.Value;

                    while (reader.Read() && reader.Name != "Oras") { }
                    reader.Read();
                    string orasXML = reader.Value;

                    while (reader.Read() && reader.Name != "Data") { }
                    reader.Read();
                    string dataXML = reader.Value;

                    List<Pizza> pizza2 = new List<Pizza>()
                    {
                        new Pizza(pizzaXML,0,0)
                    };


                    obj = new Comanda(pizza2, new Client(int.Parse(idClientXML), "", ""), new Adresa(orasXML, "", 0), int.Parse(idComandaXML), int.Parse(PretComandaXML),DateTime.Parse(dataXML));
                    lista.Add(obj);

                }
            }

            foreach (Comanda c in lista)
            {
                ListViewItem lvi = new ListViewItem(new string[] { "", "", "", "", "", "" });
                lvi.Tag = c;
                listViewInregistrare.Items.Add(lvi);
            }
            Updateaza();
            citire.Close();

        }

        private void toolStripMenuItemAdauga_Click(object sender, EventArgs e)
        {
            adaugaComandaToolStripMenuItem_Click(sender, e);
        }

        private void afișareGraficaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PreturiMaxime(ref pretmax1, ref pretmax2, ref pretmax3, ref pretmax4, ref pretmax5, ref pretmax6, ref pretmax7);
            FormGraficComenzi fg = new FormGraficComenzi();
            fg.parinte = this;
            fg.Show();
        }

        private void fundalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                listViewInregistrare.BackColor = dialog.Color;
            }
        }

        private void primPlanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                listViewInregistrare.ForeColor = dialog.Color;
            }

        }

        private void imaginiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPictures fp = new FormPictures();
            fp.ShowDialog();
        }

        private void listViewInregistrare_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public double pretFaraTransport(float pret)
        {
            double pretFaraTransport = pret - 7.99;
            return pretFaraTransport;
        }
        private void buttonGenerareFactura_Click(object sender, EventArgs e)
        {
            if (listViewInregistrare.SelectedItems.Count > 0)
            {
                Comanda c = (Comanda)listViewInregistrare.SelectedItems[0].Tag;
                richTextBoxFactura.Clear();
                richTextBoxFactura.Text += "******************************************\n";
                richTextBoxFactura.Text += "***      CHITANȚĂ COMANDĂ PIZZA        ***\n";
                richTextBoxFactura.Text += "******************************************\n";
                richTextBoxFactura.Text += "ID Comandă: "+c.idComanda+"\n\n";
                richTextBoxFactura.Text += "Preț Comanda:" + c.pretComanda + "$\n";
                richTextBoxFactura.Text += "Din care: \n";
                richTextBoxFactura.Text += "Preț comandă:" + pretFaraTransport(c.pretComanda) + "$\n";
                richTextBoxFactura.Text += "Preț transport: 7.99$\n\n";
                string salvarePizza = "";
                for (int i = 0; i < c.pizza.Count; i++)
                {
                    salvarePizza += salvarePizza + c.pizza[i].denumire;
                }
                richTextBoxFactura.Text += "Pizza și cantitățile:" + salvarePizza + "\n\n";
                richTextBoxFactura.Text += "ID Client:" + c.client.idClient + "\n\n";
                richTextBoxFactura.Text += "Oraș: " + c.adresa.oras + "\n\n";
                richTextBoxFactura.Text += "Data comenzii:" + c.data+"\n\n";
                richTextBoxFactura.Text += "VĂ MULȚUMIM PENTRU ACHIZIȚIE\n";
                richTextBoxFactura.Text += "O ZI FRUMOASĂ! ";
            }
        }

        private void buttonResetareFactura_Click(object sender, EventArgs e)
        {
            richTextBoxFactura.Clear();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBoxFactura.Text, new Font("Microsoft Sans Serif", 16, FontStyle.Bold), Brushes.Black, new Point(12, 12));

        }

        private void buttonPrintareFactura_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void richTextBoxFactura_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode.ToString() == "A")
            {
                adaugaComandaToolStripMenuItem_Click(sender, e);
            }

        }

        private void bazaDeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBazaDeDate bd = new FormBazaDeDate();
            bd.ShowDialog();
        }

        private void niveluriPreturiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalcPret(ref pretMinim, ref pretMediu, ref pretMaxim);
            Prețuri p = new Prețuri();
            p.parinte = this;
            p.Show();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (listViewInregistrare.SelectedItems.Count > 0)
            {
                toolStripMenuItemModifica.Enabled = true;
                toolStripMenuItemSterge.Enabled = true;
               
            }
            else
            {
                toolStripMenuItemModifica.Enabled = false;
                toolStripMenuItemSterge.Enabled= false;
                
            }
        }

        private void informațiiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Informatii inf = new Informatii();
            inf.ShowDialog();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(deschideForma);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void deschideForma()
        {
            Application.Run(new Home());
        }

        private void leaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lineDesignToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LineDesign ln = new LineDesign();
            ln.ShowDialog();
        }

        private void delegatiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delegati delegat = new Delegati();
            delegat.ShowDialog();
        }

        private void mDIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDIcontainer mdi = new MDIcontainer();
            mdi.ShowDialog();
        }

        private void salvareComenziCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Comanda comanda = (Comanda)listViewInregistrare.SelectedItems[0].Tag;
            salvareCSV(comanda.adresa.oras, comanda.adresa.strada, "c:\\temp\\comenzi.csv");
            MessageBox.Show("Fisier CSV generat cu succes");
        }
        public static void salvareCSV(string adresa,string oras,string cale)
        {
            try
            {
                using (StreamWriter file = new StreamWriter(@cale, true))
                {
                    file.WriteLine(adresa + "," + oras);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Programul nu a functionat!", ex);
            }
            
        }

        public void CalcPret(ref float pmin, ref float pmediu, ref float pmax)
        {
            pmin = 99999;
            pretMaxim = 0;
            pretMediu = 0;

            foreach (ListViewItem lvi in listViewInregistrare.Items)
            {
                Comanda c = (Comanda)lvi.Tag;
                if (c.pretComanda < pmin) pmin = c.pretComanda;
                if (c.pretComanda > pmax) pmax = c.pretComanda;
                pmediu += c.pretComanda;
            }
            pmediu = pmediu / listViewInregistrare.Items.Count;
        }
        public void PreturiMaxime(ref float pretmax1, ref float pretmax2, ref float pretmax3, ref float pretmax4, ref float pretmax5, ref float pretmax6, ref float pretmax7)
        {
            var d1 = DateTime.Now;
            d1 = d1.Date.AddDays(-1);
            var d2 = DateTime.Now.AddDays(-2);
            var d3 = DateTime.Now.AddDays(-3);
            var d4 = DateTime.Now.AddDays(-4);
            var d5 = DateTime.Now.AddDays(-5);
            var d6 = DateTime.Now.AddDays(-6);
            var d7 = DateTime.Now.AddDays(-7);
            pretmax1 = 0; pretmax2 = 0; pretmax3 = 0;
            pretmax4 = 0; pretmax5 = 0; pretmax6 = 0;
            pretmax7 = 0;
            foreach (ListViewItem lvi in listViewInregistrare.Items)
            {
                Comanda c = (Comanda)lvi.Tag;

                if (c.data.Day == d1.Day)
                {
                    if (c.pretComanda > pretmax1) pretmax1 = c.pretComanda;
                }
                else if (c.data.Day == d2.Day)
                {
                    if (c.pretComanda > pretmax2) pretmax2 = c.pretComanda;
                }
                else if (c.data.Day == d3.Day)
                {
                    if (c.pretComanda > pretmax3) pretmax3 = c.pretComanda;
                }
                else if (c.data.Day == d4.Day)
                {
                    if (c.pretComanda > pretmax4) pretmax4 = c.pretComanda;
                }
                else if (c.data.Day == d5.Day)
                {
                    if (c.pretComanda > pretmax5) pretmax5 = c.pretComanda;
                }
                else if (c.data.Day == d6.Day)
                {
                    if (c.pretComanda > pretmax6) pretmax6 = c.pretComanda;
                }
                else if (c.data.Day == d7.Day)
                {
                    if (c.pretComanda > pretmax7) pretmax7 = c.pretComanda;
                }
            }
        }
    }
}
