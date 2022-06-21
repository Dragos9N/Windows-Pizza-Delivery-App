
namespace ProjectPAW
{
    partial class FormBazaDeDate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBazaDeDate));
            this.labelBDidcomanda = new System.Windows.Forms.Label();
            this.dataGridViewBD = new System.Windows.Forms.DataGridView();
            this.iDComandăDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prețComandăDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orașDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabelaClientiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detalii_Clienti = new ProjectPAW.Detalii_Clienti();
            this.panelBD = new System.Windows.Forms.Panel();
            this.textBoxBDoras = new System.Windows.Forms.TextBox();
            this.labelBDpretcomanda = new System.Windows.Forms.Label();
            this.labelBDidclient = new System.Windows.Forms.Label();
            this.labelBDoras = new System.Windows.Forms.Label();
            this.textBoxBDidcomanda = new System.Windows.Forms.TextBox();
            this.textBoxBDpretcomanda = new System.Windows.Forms.TextBox();
            this.textBoxBDidclient = new System.Windows.Forms.TextBox();
            this.buttonBDnou = new System.Windows.Forms.Button();
            this.buttonBDediteaza = new System.Windows.Forms.Button();
            this.buttonBDinchide = new System.Windows.Forms.Button();
            this.buttonBDsalveaza = new System.Windows.Forms.Button();
            this.tabela_ClientiTableAdapter = new ProjectPAW.Detalii_ClientiTableAdapters.Tabela_ClientiTableAdapter();
            this.tabelaClientiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaClientiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalii_Clienti)).BeginInit();
            this.panelBD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaClientiBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelBDidcomanda
            // 
            this.labelBDidcomanda.AutoSize = true;
            this.labelBDidcomanda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.labelBDidcomanda.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBDidcomanda.ForeColor = System.Drawing.Color.White;
            this.labelBDidcomanda.Location = new System.Drawing.Point(19, 7);
            this.labelBDidcomanda.Name = "labelBDidcomanda";
            this.labelBDidcomanda.Size = new System.Drawing.Size(119, 21);
            this.labelBDidcomanda.TabIndex = 2;
            this.labelBDidcomanda.Text = "ID Comanda";
            // 
            // dataGridViewBD
            // 
            this.dataGridViewBD.AllowUserToAddRows = false;
            this.dataGridViewBD.AutoGenerateColumns = false;
            this.dataGridViewBD.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.dataGridViewBD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDComandăDataGridViewTextBoxColumn,
            this.prețComandăDataGridViewTextBoxColumn,
            this.iDClientDataGridViewTextBoxColumn,
            this.orașDataGridViewTextBoxColumn});
            this.dataGridViewBD.DataSource = this.tabelaClientiBindingSource;
            this.dataGridViewBD.Location = new System.Drawing.Point(12, 264);
            this.dataGridViewBD.Name = "dataGridViewBD";
            this.dataGridViewBD.RowHeadersWidth = 51;
            this.dataGridViewBD.RowTemplate.Height = 24;
            this.dataGridViewBD.Size = new System.Drawing.Size(528, 184);
            this.dataGridViewBD.TabIndex = 3;
            this.dataGridViewBD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridViewBD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewBD_KeyDown);
            // 
            // iDComandăDataGridViewTextBoxColumn
            // 
            this.iDComandăDataGridViewTextBoxColumn.DataPropertyName = "ID Comandă";
            this.iDComandăDataGridViewTextBoxColumn.HeaderText = "ID Comandă";
            this.iDComandăDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDComandăDataGridViewTextBoxColumn.Name = "iDComandăDataGridViewTextBoxColumn";
            this.iDComandăDataGridViewTextBoxColumn.Width = 125;
            // 
            // prețComandăDataGridViewTextBoxColumn
            // 
            this.prețComandăDataGridViewTextBoxColumn.DataPropertyName = "Preț Comandă";
            this.prețComandăDataGridViewTextBoxColumn.HeaderText = "Preț Comandă";
            this.prețComandăDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prețComandăDataGridViewTextBoxColumn.Name = "prețComandăDataGridViewTextBoxColumn";
            this.prețComandăDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDClientDataGridViewTextBoxColumn
            // 
            this.iDClientDataGridViewTextBoxColumn.DataPropertyName = "ID Client";
            this.iDClientDataGridViewTextBoxColumn.HeaderText = "ID Client";
            this.iDClientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDClientDataGridViewTextBoxColumn.Name = "iDClientDataGridViewTextBoxColumn";
            this.iDClientDataGridViewTextBoxColumn.Width = 125;
            // 
            // orașDataGridViewTextBoxColumn
            // 
            this.orașDataGridViewTextBoxColumn.DataPropertyName = "Oraș";
            this.orașDataGridViewTextBoxColumn.HeaderText = "Oraș";
            this.orașDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orașDataGridViewTextBoxColumn.Name = "orașDataGridViewTextBoxColumn";
            this.orașDataGridViewTextBoxColumn.Width = 125;
            // 
            // tabelaClientiBindingSource
            // 
            this.tabelaClientiBindingSource.DataMember = "Tabela Clienti";
            this.tabelaClientiBindingSource.DataSource = this.detalii_Clienti;
            // 
            // detalii_Clienti
            // 
            this.detalii_Clienti.DataSetName = "Detalii_Clienti";
            this.detalii_Clienti.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelBD
            // 
            this.panelBD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panelBD.Controls.Add(this.textBoxBDoras);
            this.panelBD.Controls.Add(this.labelBDpretcomanda);
            this.panelBD.Controls.Add(this.labelBDidclient);
            this.panelBD.Controls.Add(this.labelBDoras);
            this.panelBD.Controls.Add(this.textBoxBDidcomanda);
            this.panelBD.Controls.Add(this.textBoxBDpretcomanda);
            this.panelBD.Controls.Add(this.textBoxBDidclient);
            this.panelBD.Controls.Add(this.labelBDidcomanda);
            this.panelBD.Enabled = false;
            this.panelBD.Location = new System.Drawing.Point(12, 2);
            this.panelBD.Name = "panelBD";
            this.panelBD.Size = new System.Drawing.Size(528, 230);
            this.panelBD.TabIndex = 0;
            // 
            // textBoxBDoras
            // 
            this.textBoxBDoras.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabelaClientiBindingSource, "Oraș", true));
            this.textBoxBDoras.Location = new System.Drawing.Point(183, 162);
            this.textBoxBDoras.Multiline = true;
            this.textBoxBDoras.Name = "textBoxBDoras";
            this.textBoxBDoras.Size = new System.Drawing.Size(151, 51);
            this.textBoxBDoras.TabIndex = 3;
            // 
            // labelBDpretcomanda
            // 
            this.labelBDpretcomanda.AutoSize = true;
            this.labelBDpretcomanda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.labelBDpretcomanda.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBDpretcomanda.ForeColor = System.Drawing.Color.White;
            this.labelBDpretcomanda.Location = new System.Drawing.Point(20, 60);
            this.labelBDpretcomanda.Name = "labelBDpretcomanda";
            this.labelBDpretcomanda.Size = new System.Drawing.Size(134, 21);
            this.labelBDpretcomanda.TabIndex = 5;
            this.labelBDpretcomanda.Text = "Pret Comanda";
            // 
            // labelBDidclient
            // 
            this.labelBDidclient.AutoSize = true;
            this.labelBDidclient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.labelBDidclient.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBDidclient.ForeColor = System.Drawing.Color.White;
            this.labelBDidclient.Location = new System.Drawing.Point(20, 108);
            this.labelBDidclient.Name = "labelBDidclient";
            this.labelBDidclient.Size = new System.Drawing.Size(81, 21);
            this.labelBDidclient.TabIndex = 6;
            this.labelBDidclient.Text = "ID Client";
            // 
            // labelBDoras
            // 
            this.labelBDoras.AutoSize = true;
            this.labelBDoras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.labelBDoras.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBDoras.ForeColor = System.Drawing.Color.White;
            this.labelBDoras.Location = new System.Drawing.Point(20, 162);
            this.labelBDoras.Name = "labelBDoras";
            this.labelBDoras.Size = new System.Drawing.Size(49, 21);
            this.labelBDoras.TabIndex = 7;
            this.labelBDoras.Text = "Oras";
            // 
            // textBoxBDidcomanda
            // 
            this.textBoxBDidcomanda.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabelaClientiBindingSource, "ID Comandă", true));
            this.textBoxBDidcomanda.Location = new System.Drawing.Point(183, 9);
            this.textBoxBDidcomanda.Name = "textBoxBDidcomanda";
            this.textBoxBDidcomanda.Size = new System.Drawing.Size(151, 22);
            this.textBoxBDidcomanda.TabIndex = 0;
            // 
            // textBoxBDpretcomanda
            // 
            this.textBoxBDpretcomanda.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabelaClientiBindingSource, "Preț Comandă", true));
            this.textBoxBDpretcomanda.Location = new System.Drawing.Point(183, 60);
            this.textBoxBDpretcomanda.Name = "textBoxBDpretcomanda";
            this.textBoxBDpretcomanda.Size = new System.Drawing.Size(151, 22);
            this.textBoxBDpretcomanda.TabIndex = 1;
            // 
            // textBoxBDidclient
            // 
            this.textBoxBDidclient.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabelaClientiBindingSource, "ID Client", true));
            this.textBoxBDidclient.Location = new System.Drawing.Point(183, 108);
            this.textBoxBDidclient.Name = "textBoxBDidclient";
            this.textBoxBDidclient.Size = new System.Drawing.Size(151, 22);
            this.textBoxBDidclient.TabIndex = 2;
            // 
            // buttonBDnou
            // 
            this.buttonBDnou.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.buttonBDnou.FlatAppearance.BorderSize = 0;
            this.buttonBDnou.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBDnou.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBDnou.ForeColor = System.Drawing.Color.White;
            this.buttonBDnou.Location = new System.Drawing.Point(150, 454);
            this.buttonBDnou.Name = "buttonBDnou";
            this.buttonBDnou.Size = new System.Drawing.Size(90, 31);
            this.buttonBDnou.TabIndex = 2;
            this.buttonBDnou.Text = "Nou";
            this.buttonBDnou.UseVisualStyleBackColor = false;
            this.buttonBDnou.Click += new System.EventHandler(this.buttonBDnou_Click);
            // 
            // buttonBDediteaza
            // 
            this.buttonBDediteaza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.buttonBDediteaza.FlatAppearance.BorderSize = 0;
            this.buttonBDediteaza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBDediteaza.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBDediteaza.ForeColor = System.Drawing.Color.White;
            this.buttonBDediteaza.Location = new System.Drawing.Point(246, 454);
            this.buttonBDediteaza.Name = "buttonBDediteaza";
            this.buttonBDediteaza.Size = new System.Drawing.Size(87, 31);
            this.buttonBDediteaza.TabIndex = 3;
            this.buttonBDediteaza.Text = "Editeaza";
            this.buttonBDediteaza.UseVisualStyleBackColor = false;
            this.buttonBDediteaza.Click += new System.EventHandler(this.buttonBDediteaza_Click);
            // 
            // buttonBDinchide
            // 
            this.buttonBDinchide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.buttonBDinchide.FlatAppearance.BorderSize = 0;
            this.buttonBDinchide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBDinchide.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBDinchide.ForeColor = System.Drawing.Color.White;
            this.buttonBDinchide.Location = new System.Drawing.Point(339, 454);
            this.buttonBDinchide.Name = "buttonBDinchide";
            this.buttonBDinchide.Size = new System.Drawing.Size(92, 31);
            this.buttonBDinchide.TabIndex = 4;
            this.buttonBDinchide.Text = "Inchide";
            this.buttonBDinchide.UseVisualStyleBackColor = false;
            this.buttonBDinchide.Click += new System.EventHandler(this.buttonBDinchide_Click);
            // 
            // buttonBDsalveaza
            // 
            this.buttonBDsalveaza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.buttonBDsalveaza.FlatAppearance.BorderSize = 0;
            this.buttonBDsalveaza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBDsalveaza.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBDsalveaza.ForeColor = System.Drawing.Color.White;
            this.buttonBDsalveaza.Location = new System.Drawing.Point(437, 454);
            this.buttonBDsalveaza.Name = "buttonBDsalveaza";
            this.buttonBDsalveaza.Size = new System.Drawing.Size(103, 31);
            this.buttonBDsalveaza.TabIndex = 5;
            this.buttonBDsalveaza.Text = "Salveaza";
            this.buttonBDsalveaza.UseVisualStyleBackColor = false;
            this.buttonBDsalveaza.Click += new System.EventHandler(this.buttonBDsalveaza_Click);
            // 
            // tabela_ClientiTableAdapter
            // 
            this.tabela_ClientiTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(54, 454);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 31);
            this.button1.TabIndex = 6;
            this.button1.Text = "Leave";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormBazaDeDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(581, 512);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonBDsalveaza);
            this.Controls.Add(this.buttonBDinchide);
            this.Controls.Add(this.buttonBDediteaza);
            this.Controls.Add(this.buttonBDnou);
            this.Controls.Add(this.panelBD);
            this.Controls.Add(this.dataGridViewBD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBazaDeDate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bază de Date";
            this.Load += new System.EventHandler(this.FormBazaDeDate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaClientiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalii_Clienti)).EndInit();
            this.panelBD.ResumeLayout(false);
            this.panelBD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaClientiBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelBDidcomanda;
        private System.Windows.Forms.Label labelBDpretcomanda;
        private System.Windows.Forms.Label labelBDidclient;
        private System.Windows.Forms.Label labelBDoras;
        private Detalii_ClientiTableAdapters.Tabela_ClientiTableAdapter tabela_ClientiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDComandăDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prețComandăDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orașDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tabelaClientiBindingSource1;
        public System.Windows.Forms.Panel panelBD;
        public System.Windows.Forms.DataGridView dataGridViewBD;
        public System.Windows.Forms.TextBox textBoxBDoras;
        public System.Windows.Forms.TextBox textBoxBDidcomanda;
        public System.Windows.Forms.TextBox textBoxBDpretcomanda;
        public System.Windows.Forms.TextBox textBoxBDidclient;
        public System.Windows.Forms.Button buttonBDnou;
        public System.Windows.Forms.Button buttonBDediteaza;
        public System.Windows.Forms.Button buttonBDinchide;
        public System.Windows.Forms.Button buttonBDsalveaza;
        public Detalii_Clienti detalii_Clienti;
        public System.Windows.Forms.BindingSource tabelaClientiBindingSource;
        public System.Windows.Forms.Button button1;
    }
}