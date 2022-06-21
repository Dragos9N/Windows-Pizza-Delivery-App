
namespace ProjectPAW
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listViewInregistrare = new System.Windows.Forms.ListView();
            this.columnIdComanda = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnIdPretComanda = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDenumirePizza = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnIdClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnOras = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.comandaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaComandaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeComandaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaComandaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salveazaXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaureazaXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salveazaXMLToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.restaureazaXMLToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareComenziCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afișareGraficaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.culoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fundalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.primPlanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imaginiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bazaDeDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.niveluriPreturiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informațiiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.othersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineDesignToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delegatiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mDIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemAdauga = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSterge = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemModifica = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonGenerareFactura = new System.Windows.Forms.Button();
            this.buttonResetareFactura = new System.Windows.Forms.Button();
            this.buttonPrintareFactura = new System.Windows.Forms.Button();
            this.richTextBoxFactura = new System.Windows.Forms.RichTextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewInregistrare
            // 
            this.listViewInregistrare.AllowColumnReorder = true;
            this.listViewInregistrare.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnIdComanda,
            this.columnIdPretComanda,
            this.columnDenumirePizza,
            this.columnIdClient,
            this.columnOras,
            this.columnData});
            this.listViewInregistrare.GridLines = true;
            this.listViewInregistrare.HideSelection = false;
            this.listViewInregistrare.Location = new System.Drawing.Point(0, 42);
            this.listViewInregistrare.Name = "listViewInregistrare";
            this.listViewInregistrare.Size = new System.Drawing.Size(567, 312);
            this.listViewInregistrare.TabIndex = 0;
            this.listViewInregistrare.UseCompatibleStateImageBehavior = false;
            this.listViewInregistrare.View = System.Windows.Forms.View.Details;
            this.listViewInregistrare.SelectedIndexChanged += new System.EventHandler(this.listViewInregistrare_SelectedIndexChanged);
            // 
            // columnIdComanda
            // 
            this.columnIdComanda.Text = "ID Comandă";
            this.columnIdComanda.Width = 95;
            // 
            // columnIdPretComanda
            // 
            this.columnIdPretComanda.Text = "Preț Comandă";
            this.columnIdPretComanda.Width = 101;
            // 
            // columnDenumirePizza
            // 
            this.columnDenumirePizza.Text = "Pizza";
            this.columnDenumirePizza.Width = 126;
            // 
            // columnIdClient
            // 
            this.columnIdClient.Text = "ID Client";
            this.columnIdClient.Width = 65;
            // 
            // columnOras
            // 
            this.columnOras.Text = "Oraș";
            // 
            // columnData
            // 
            this.columnData.Text = "Data Înregistrării";
            this.columnData.Width = 117;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comandaToolStripMenuItem,
            this.salvareToolStripMenuItem,
            this.afișareGraficaToolStripMenuItem,
            this.culoriToolStripMenuItem,
            this.imaginiToolStripMenuItem,
            this.bazaDeDateToolStripMenuItem,
            this.niveluriPreturiToolStripMenuItem,
            this.informațiiToolStripMenuItem,
            this.homeToolStripMenuItem,
            this.leaveToolStripMenuItem,
            this.othersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1032, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // comandaToolStripMenuItem
            // 
            this.comandaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaComandaToolStripMenuItem,
            this.stergeComandaToolStripMenuItem,
            this.modificaComandaToolStripMenuItem});
            this.comandaToolStripMenuItem.Name = "comandaToolStripMenuItem";
            this.comandaToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.comandaToolStripMenuItem.Text = "Comandă";
            // 
            // adaugaComandaToolStripMenuItem
            // 
            this.adaugaComandaToolStripMenuItem.Name = "adaugaComandaToolStripMenuItem";
            this.adaugaComandaToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.adaugaComandaToolStripMenuItem.Text = "Adauga comanda";
            this.adaugaComandaToolStripMenuItem.Click += new System.EventHandler(this.adaugaComandaToolStripMenuItem_Click);
            // 
            // stergeComandaToolStripMenuItem
            // 
            this.stergeComandaToolStripMenuItem.Name = "stergeComandaToolStripMenuItem";
            this.stergeComandaToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.stergeComandaToolStripMenuItem.Text = "Sterge comanda";
            this.stergeComandaToolStripMenuItem.Click += new System.EventHandler(this.stergeComandaToolStripMenuItem_Click);
            // 
            // modificaComandaToolStripMenuItem
            // 
            this.modificaComandaToolStripMenuItem.Name = "modificaComandaToolStripMenuItem";
            this.modificaComandaToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.modificaComandaToolStripMenuItem.Text = "Modifica comanda";
            this.modificaComandaToolStripMenuItem.Click += new System.EventHandler(this.modificaComandaToolStripMenuItem_Click);
            // 
            // salvareToolStripMenuItem
            // 
            this.salvareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salveazaXMLToolStripMenuItem,
            this.restaureazaXMLToolStripMenuItem,
            this.salveazaXMLToolStripMenuItem1,
            this.restaureazaXMLToolStripMenuItem1,
            this.salvareComenziCSVToolStripMenuItem});
            this.salvareToolStripMenuItem.Name = "salvareToolStripMenuItem";
            this.salvareToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.salvareToolStripMenuItem.Text = "Fișiere";
            this.salvareToolStripMenuItem.Click += new System.EventHandler(this.salvareToolStripMenuItem_Click);
            // 
            // salveazaXMLToolStripMenuItem
            // 
            this.salveazaXMLToolStripMenuItem.Name = "salveazaXMLToolStripMenuItem";
            this.salveazaXMLToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.salveazaXMLToolStripMenuItem.Text = "Salveaza Comanda XML";
            this.salveazaXMLToolStripMenuItem.Click += new System.EventHandler(this.salveazaXMLToolStripMenuItem_Click);
            // 
            // restaureazaXMLToolStripMenuItem
            // 
            this.restaureazaXMLToolStripMenuItem.Name = "restaureazaXMLToolStripMenuItem";
            this.restaureazaXMLToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.restaureazaXMLToolStripMenuItem.Text = "Restaureaza Comanda XML";
            this.restaureazaXMLToolStripMenuItem.Click += new System.EventHandler(this.restaureazaXMLToolStripMenuItem_Click);
            // 
            // salveazaXMLToolStripMenuItem1
            // 
            this.salveazaXMLToolStripMenuItem1.Name = "salveazaXMLToolStripMenuItem1";
            this.salveazaXMLToolStripMenuItem1.Size = new System.Drawing.Size(273, 26);
            this.salveazaXMLToolStripMenuItem1.Text = "Salveaza Comenzi XML";
            this.salveazaXMLToolStripMenuItem1.Click += new System.EventHandler(this.salveazaXMLToolStripMenuItem1_Click);
            // 
            // restaureazaXMLToolStripMenuItem1
            // 
            this.restaureazaXMLToolStripMenuItem1.Name = "restaureazaXMLToolStripMenuItem1";
            this.restaureazaXMLToolStripMenuItem1.Size = new System.Drawing.Size(273, 26);
            this.restaureazaXMLToolStripMenuItem1.Text = "Restaureaza Comenzi XML";
            this.restaureazaXMLToolStripMenuItem1.Click += new System.EventHandler(this.restaureazaXMLToolStripMenuItem1_Click);
            // 
            // salvareComenziCSVToolStripMenuItem
            // 
            this.salvareComenziCSVToolStripMenuItem.Name = "salvareComenziCSVToolStripMenuItem";
            this.salvareComenziCSVToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.salvareComenziCSVToolStripMenuItem.Text = "Salvare Comenzi CSV";
            this.salvareComenziCSVToolStripMenuItem.Click += new System.EventHandler(this.salvareComenziCSVToolStripMenuItem_Click);
            // 
            // afișareGraficaToolStripMenuItem
            // 
            this.afișareGraficaToolStripMenuItem.Name = "afișareGraficaToolStripMenuItem";
            this.afișareGraficaToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            this.afișareGraficaToolStripMenuItem.Text = "Afișare Grafica";
            this.afișareGraficaToolStripMenuItem.Click += new System.EventHandler(this.afișareGraficaToolStripMenuItem_Click);
            // 
            // culoriToolStripMenuItem
            // 
            this.culoriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fundalToolStripMenuItem,
            this.primPlanToolStripMenuItem});
            this.culoriToolStripMenuItem.Name = "culoriToolStripMenuItem";
            this.culoriToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.culoriToolStripMenuItem.Text = "Culori";
            // 
            // fundalToolStripMenuItem
            // 
            this.fundalToolStripMenuItem.Name = "fundalToolStripMenuItem";
            this.fundalToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.fundalToolStripMenuItem.Text = "Fundal";
            this.fundalToolStripMenuItem.Click += new System.EventHandler(this.fundalToolStripMenuItem_Click);
            // 
            // primPlanToolStripMenuItem
            // 
            this.primPlanToolStripMenuItem.Name = "primPlanToolStripMenuItem";
            this.primPlanToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.primPlanToolStripMenuItem.Text = "Prim Plan";
            this.primPlanToolStripMenuItem.Click += new System.EventHandler(this.primPlanToolStripMenuItem_Click);
            // 
            // imaginiToolStripMenuItem
            // 
            this.imaginiToolStripMenuItem.Name = "imaginiToolStripMenuItem";
            this.imaginiToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.imaginiToolStripMenuItem.Text = "Imagini ";
            this.imaginiToolStripMenuItem.Click += new System.EventHandler(this.imaginiToolStripMenuItem_Click);
            // 
            // bazaDeDateToolStripMenuItem
            // 
            this.bazaDeDateToolStripMenuItem.Name = "bazaDeDateToolStripMenuItem";
            this.bazaDeDateToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.bazaDeDateToolStripMenuItem.Text = "Baza de Date";
            this.bazaDeDateToolStripMenuItem.Click += new System.EventHandler(this.bazaDeDateToolStripMenuItem_Click);
            // 
            // niveluriPreturiToolStripMenuItem
            // 
            this.niveluriPreturiToolStripMenuItem.Name = "niveluriPreturiToolStripMenuItem";
            this.niveluriPreturiToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.niveluriPreturiToolStripMenuItem.Text = "Niveluri Preturi";
            this.niveluriPreturiToolStripMenuItem.Click += new System.EventHandler(this.niveluriPreturiToolStripMenuItem_Click);
            // 
            // informațiiToolStripMenuItem
            // 
            this.informațiiToolStripMenuItem.Name = "informațiiToolStripMenuItem";
            this.informațiiToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.informațiiToolStripMenuItem.Text = "Informații";
            this.informațiiToolStripMenuItem.Click += new System.EventHandler(this.informațiiToolStripMenuItem_Click);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // leaveToolStripMenuItem
            // 
            this.leaveToolStripMenuItem.Name = "leaveToolStripMenuItem";
            this.leaveToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.leaveToolStripMenuItem.Text = "Leave";
            this.leaveToolStripMenuItem.Click += new System.EventHandler(this.leaveToolStripMenuItem_Click);
            // 
            // othersToolStripMenuItem
            // 
            this.othersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lineDesignToolStripMenuItem,
            this.delegatiToolStripMenuItem,
            this.mDIToolStripMenuItem});
            this.othersToolStripMenuItem.Name = "othersToolStripMenuItem";
            this.othersToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.othersToolStripMenuItem.Text = "Others";
            // 
            // lineDesignToolStripMenuItem
            // 
            this.lineDesignToolStripMenuItem.Name = "lineDesignToolStripMenuItem";
            this.lineDesignToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.lineDesignToolStripMenuItem.Text = "Line Design";
            this.lineDesignToolStripMenuItem.Click += new System.EventHandler(this.lineDesignToolStripMenuItem_Click);
            // 
            // delegatiToolStripMenuItem
            // 
            this.delegatiToolStripMenuItem.Name = "delegatiToolStripMenuItem";
            this.delegatiToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.delegatiToolStripMenuItem.Text = "Delegati";
            this.delegatiToolStripMenuItem.Click += new System.EventHandler(this.delegatiToolStripMenuItem_Click);
            // 
            // mDIToolStripMenuItem
            // 
            this.mDIToolStripMenuItem.Name = "mDIToolStripMenuItem";
            this.mDIToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.mDIToolStripMenuItem.Text = "MDI";
            this.mDIToolStripMenuItem.Click += new System.EventHandler(this.mDIToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAdauga,
            this.toolStripMenuItemSterge,
            this.toolStripMenuItemModifica});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(138, 76);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // toolStripMenuItemAdauga
            // 
            this.toolStripMenuItemAdauga.Name = "toolStripMenuItemAdauga";
            this.toolStripMenuItemAdauga.Size = new System.Drawing.Size(137, 24);
            this.toolStripMenuItemAdauga.Text = "Adaugă";
            this.toolStripMenuItemAdauga.Click += new System.EventHandler(this.toolStripMenuItemAdauga_Click);
            // 
            // toolStripMenuItemSterge
            // 
            this.toolStripMenuItemSterge.Name = "toolStripMenuItemSterge";
            this.toolStripMenuItemSterge.Size = new System.Drawing.Size(137, 24);
            this.toolStripMenuItemSterge.Text = "Șterge";
            this.toolStripMenuItemSterge.Click += new System.EventHandler(this.stergeComandaToolStripMenuItem_Click);
            // 
            // toolStripMenuItemModifica
            // 
            this.toolStripMenuItemModifica.Name = "toolStripMenuItemModifica";
            this.toolStripMenuItemModifica.Size = new System.Drawing.Size(137, 24);
            this.toolStripMenuItemModifica.Text = "Modifică";
            this.toolStripMenuItemModifica.Click += new System.EventHandler(this.modificaComandaToolStripMenuItem_Click);
            // 
            // buttonGenerareFactura
            // 
            this.buttonGenerareFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.buttonGenerareFactura.FlatAppearance.BorderSize = 0;
            this.buttonGenerareFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGenerareFactura.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerareFactura.ForeColor = System.Drawing.Color.White;
            this.buttonGenerareFactura.Location = new System.Drawing.Point(12, 395);
            this.buttonGenerareFactura.Name = "buttonGenerareFactura";
            this.buttonGenerareFactura.Size = new System.Drawing.Size(135, 37);
            this.buttonGenerareFactura.TabIndex = 2;
            this.buttonGenerareFactura.Text = "Generare Factură";
            this.buttonGenerareFactura.UseVisualStyleBackColor = false;
            this.buttonGenerareFactura.Click += new System.EventHandler(this.buttonGenerareFactura_Click);
            // 
            // buttonResetareFactura
            // 
            this.buttonResetareFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.buttonResetareFactura.FlatAppearance.BorderSize = 0;
            this.buttonResetareFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResetareFactura.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResetareFactura.ForeColor = System.Drawing.Color.White;
            this.buttonResetareFactura.Location = new System.Drawing.Point(190, 395);
            this.buttonResetareFactura.Name = "buttonResetareFactura";
            this.buttonResetareFactura.Size = new System.Drawing.Size(135, 37);
            this.buttonResetareFactura.TabIndex = 3;
            this.buttonResetareFactura.Text = "Resetare Factură";
            this.buttonResetareFactura.UseVisualStyleBackColor = false;
            this.buttonResetareFactura.Click += new System.EventHandler(this.buttonResetareFactura_Click);
            // 
            // buttonPrintareFactura
            // 
            this.buttonPrintareFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.buttonPrintareFactura.FlatAppearance.BorderSize = 0;
            this.buttonPrintareFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrintareFactura.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrintareFactura.ForeColor = System.Drawing.Color.White;
            this.buttonPrintareFactura.Location = new System.Drawing.Point(368, 395);
            this.buttonPrintareFactura.Name = "buttonPrintareFactura";
            this.buttonPrintareFactura.Size = new System.Drawing.Size(135, 37);
            this.buttonPrintareFactura.TabIndex = 4;
            this.buttonPrintareFactura.Text = "Printare Factură";
            this.buttonPrintareFactura.UseVisualStyleBackColor = false;
            this.buttonPrintareFactura.Click += new System.EventHandler(this.buttonPrintareFactura_Click);
            // 
            // richTextBoxFactura
            // 
            this.richTextBoxFactura.Font = new System.Drawing.Font("Bodoni MT", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxFactura.Location = new System.Drawing.Point(603, 42);
            this.richTextBoxFactura.Name = "richTextBoxFactura";
            this.richTextBoxFactura.Size = new System.Drawing.Size(405, 446);
            this.richTextBoxFactura.TabIndex = 5;
            this.richTextBoxFactura.Text = "";
            this.richTextBoxFactura.TextChanged += new System.EventHandler(this.richTextBoxFactura_TextChanged);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1032, 536);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.richTextBoxFactura);
            this.Controls.Add(this.buttonPrintareFactura);
            this.Controls.Add(this.buttonResetareFactura);
            this.Controls.Add(this.buttonGenerareFactura);
            this.Controls.Add(this.listViewInregistrare);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comenzi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewInregistrare;
        private System.Windows.Forms.ColumnHeader columnIdComanda;
        private System.Windows.Forms.ColumnHeader columnIdPretComanda;
        private System.Windows.Forms.ColumnHeader columnDenumirePizza;
        private System.Windows.Forms.ColumnHeader columnIdClient;
        private System.Windows.Forms.ColumnHeader columnOras;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem comandaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaComandaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergeComandaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaComandaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salveazaXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaureazaXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salveazaXMLToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem restaureazaXMLToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAdauga;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSterge;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemModifica;
        private System.Windows.Forms.ToolStripMenuItem afișareGraficaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem culoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fundalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem primPlanToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnData;
        private System.Windows.Forms.ToolStripMenuItem imaginiToolStripMenuItem;
        private System.Windows.Forms.Button buttonGenerareFactura;
        private System.Windows.Forms.Button buttonResetareFactura;
        private System.Windows.Forms.Button buttonPrintareFactura;
        private System.Windows.Forms.RichTextBox richTextBoxFactura;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ToolStripMenuItem bazaDeDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem niveluriPreturiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informațiiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem othersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineDesignToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem delegatiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mDIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareComenziCSVToolStripMenuItem;
    }
}

