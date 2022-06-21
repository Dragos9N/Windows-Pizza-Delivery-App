
namespace ProjectPAW
{
    partial class FormComanda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormComanda));
            this.labelPretComanda = new System.Windows.Forms.Label();
            this.labelNumePizza = new System.Windows.Forms.Label();
            this.labelIdClient = new System.Windows.Forms.Label();
            this.labelOras = new System.Windows.Forms.Label();
            this.textBoxIdComanda = new System.Windows.Forms.TextBox();
            this.textBoxPretComanda = new System.Windows.Forms.TextBox();
            this.textBoxIdClient = new System.Windows.Forms.TextBox();
            this.textBoxOras = new System.Windows.Forms.TextBox();
            this.comboBoxDiavola = new System.Windows.Forms.ComboBox();
            this.buttonActualizare = new System.Windows.Forms.Button();
            this.labelIdComanda = new System.Windows.Forms.Label();
            this.comboBoxSiciliana = new System.Windows.Forms.ComboBox();
            this.comboBoxMexicana = new System.Windows.Forms.ComboBox();
            this.comboBoxExotica = new System.Windows.Forms.ComboBox();
            this.textBoxSiciliana = new System.Windows.Forms.TextBox();
            this.textBoxMexicana = new System.Windows.Forms.TextBox();
            this.textBoxExotica = new System.Windows.Forms.TextBox();
            this.textBoxNrDiavola = new System.Windows.Forms.TextBox();
            this.labelNrPizza = new System.Windows.Forms.Label();
            this.errorProviderIdComanda = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPretComanda = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderIdClient = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelDataInregistrarii = new System.Windows.Forms.Label();
            this.dateTimePickerInregistrare = new System.Windows.Forms.DateTimePicker();
            this.buttonImaginiPizza = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderIdComanda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPretComanda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderIdClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPretComanda
            // 
            this.labelPretComanda.AutoSize = true;
            this.labelPretComanda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.labelPretComanda.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPretComanda.ForeColor = System.Drawing.Color.White;
            this.labelPretComanda.Location = new System.Drawing.Point(31, 106);
            this.labelPretComanda.Name = "labelPretComanda";
            this.labelPretComanda.Size = new System.Drawing.Size(154, 23);
            this.labelPretComanda.TabIndex = 1;
            this.labelPretComanda.Text = "Preț Comandă";
            // 
            // labelNumePizza
            // 
            this.labelNumePizza.AutoSize = true;
            this.labelNumePizza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.labelNumePizza.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumePizza.ForeColor = System.Drawing.Color.White;
            this.labelNumePizza.Location = new System.Drawing.Point(31, 175);
            this.labelNumePizza.Name = "labelNumePizza";
            this.labelNumePizza.Size = new System.Drawing.Size(57, 23);
            this.labelNumePizza.TabIndex = 2;
            this.labelNumePizza.Text = "Pizza";
            // 
            // labelIdClient
            // 
            this.labelIdClient.AutoSize = true;
            this.labelIdClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.labelIdClient.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdClient.ForeColor = System.Drawing.Color.White;
            this.labelIdClient.Location = new System.Drawing.Point(31, 244);
            this.labelIdClient.Name = "labelIdClient";
            this.labelIdClient.Size = new System.Drawing.Size(92, 23);
            this.labelIdClient.TabIndex = 3;
            this.labelIdClient.Text = "ID Client";
            // 
            // labelOras
            // 
            this.labelOras.AutoSize = true;
            this.labelOras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.labelOras.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOras.ForeColor = System.Drawing.Color.White;
            this.labelOras.Location = new System.Drawing.Point(31, 314);
            this.labelOras.Name = "labelOras";
            this.labelOras.Size = new System.Drawing.Size(56, 23);
            this.labelOras.TabIndex = 4;
            this.labelOras.Text = "Oraș";
            // 
            // textBoxIdComanda
            // 
            this.textBoxIdComanda.Location = new System.Drawing.Point(269, 37);
            this.textBoxIdComanda.Multiline = true;
            this.textBoxIdComanda.Name = "textBoxIdComanda";
            this.textBoxIdComanda.Size = new System.Drawing.Size(121, 22);
            this.textBoxIdComanda.TabIndex = 5;
            // 
            // textBoxPretComanda
            // 
            this.textBoxPretComanda.Location = new System.Drawing.Point(269, 105);
            this.textBoxPretComanda.Multiline = true;
            this.textBoxPretComanda.Name = "textBoxPretComanda";
            this.textBoxPretComanda.Size = new System.Drawing.Size(121, 22);
            this.textBoxPretComanda.TabIndex = 6;
            // 
            // textBoxIdClient
            // 
            this.textBoxIdClient.Location = new System.Drawing.Point(269, 243);
            this.textBoxIdClient.Multiline = true;
            this.textBoxIdClient.Name = "textBoxIdClient";
            this.textBoxIdClient.Size = new System.Drawing.Size(121, 22);
            this.textBoxIdClient.TabIndex = 8;
            // 
            // textBoxOras
            // 
            this.textBoxOras.Location = new System.Drawing.Point(269, 313);
            this.textBoxOras.Multiline = true;
            this.textBoxOras.Name = "textBoxOras";
            this.textBoxOras.Size = new System.Drawing.Size(121, 22);
            this.textBoxOras.TabIndex = 9;
            // 
            // comboBoxDiavola
            // 
            this.comboBoxDiavola.FormattingEnabled = true;
            this.comboBoxDiavola.Items.AddRange(new object[] {
            "Diavola= "});
            this.comboBoxDiavola.Location = new System.Drawing.Point(269, 172);
            this.comboBoxDiavola.Name = "comboBoxDiavola";
            this.comboBoxDiavola.Size = new System.Drawing.Size(121, 24);
            this.comboBoxDiavola.TabIndex = 10;
            // 
            // buttonActualizare
            // 
            this.buttonActualizare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.buttonActualizare.FlatAppearance.BorderSize = 0;
            this.buttonActualizare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonActualizare.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonActualizare.ForeColor = System.Drawing.Color.White;
            this.buttonActualizare.Location = new System.Drawing.Point(35, 431);
            this.buttonActualizare.Name = "buttonActualizare";
            this.buttonActualizare.Size = new System.Drawing.Size(140, 54);
            this.buttonActualizare.TabIndex = 11;
            this.buttonActualizare.Text = "Actualizare";
            this.buttonActualizare.UseVisualStyleBackColor = false;
            this.buttonActualizare.Click += new System.EventHandler(this.buttonActualizare_Click);
            // 
            // labelIdComanda
            // 
            this.labelIdComanda.AutoSize = true;
            this.labelIdComanda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.labelIdComanda.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdComanda.ForeColor = System.Drawing.Color.White;
            this.labelIdComanda.Location = new System.Drawing.Point(31, 37);
            this.labelIdComanda.Name = "labelIdComanda";
            this.labelIdComanda.Size = new System.Drawing.Size(138, 23);
            this.labelIdComanda.TabIndex = 12;
            this.labelIdComanda.Text = "ID Comandă";
            // 
            // comboBoxSiciliana
            // 
            this.comboBoxSiciliana.FormattingEnabled = true;
            this.comboBoxSiciliana.Items.AddRange(new object[] {
            "Siciliana= "});
            this.comboBoxSiciliana.Location = new System.Drawing.Point(814, 176);
            this.comboBoxSiciliana.Name = "comboBoxSiciliana";
            this.comboBoxSiciliana.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSiciliana.TabIndex = 13;
            // 
            // comboBoxMexicana
            // 
            this.comboBoxMexicana.FormattingEnabled = true;
            this.comboBoxMexicana.Items.AddRange(new object[] {
            "Mexicana= "});
            this.comboBoxMexicana.Location = new System.Drawing.Point(614, 175);
            this.comboBoxMexicana.Name = "comboBoxMexicana";
            this.comboBoxMexicana.Size = new System.Drawing.Size(121, 24);
            this.comboBoxMexicana.TabIndex = 14;
            // 
            // comboBoxExotica
            // 
            this.comboBoxExotica.FormattingEnabled = true;
            this.comboBoxExotica.Items.AddRange(new object[] {
            "Exotica= "});
            this.comboBoxExotica.Location = new System.Drawing.Point(436, 172);
            this.comboBoxExotica.Name = "comboBoxExotica";
            this.comboBoxExotica.Size = new System.Drawing.Size(121, 24);
            this.comboBoxExotica.TabIndex = 15;
            // 
            // textBoxSiciliana
            // 
            this.textBoxSiciliana.Location = new System.Drawing.Point(814, 206);
            this.textBoxSiciliana.Multiline = true;
            this.textBoxSiciliana.Name = "textBoxSiciliana";
            this.textBoxSiciliana.Size = new System.Drawing.Size(121, 22);
            this.textBoxSiciliana.TabIndex = 16;
            // 
            // textBoxMexicana
            // 
            this.textBoxMexicana.Location = new System.Drawing.Point(614, 205);
            this.textBoxMexicana.Multiline = true;
            this.textBoxMexicana.Name = "textBoxMexicana";
            this.textBoxMexicana.Size = new System.Drawing.Size(121, 22);
            this.textBoxMexicana.TabIndex = 17;
            // 
            // textBoxExotica
            // 
            this.textBoxExotica.Location = new System.Drawing.Point(436, 202);
            this.textBoxExotica.Multiline = true;
            this.textBoxExotica.Name = "textBoxExotica";
            this.textBoxExotica.Size = new System.Drawing.Size(121, 22);
            this.textBoxExotica.TabIndex = 18;
            // 
            // textBoxNrDiavola
            // 
            this.textBoxNrDiavola.Location = new System.Drawing.Point(269, 202);
            this.textBoxNrDiavola.Multiline = true;
            this.textBoxNrDiavola.Name = "textBoxNrDiavola";
            this.textBoxNrDiavola.Size = new System.Drawing.Size(121, 22);
            this.textBoxNrDiavola.TabIndex = 19;
            // 
            // labelNrPizza
            // 
            this.labelNrPizza.AutoSize = true;
            this.labelNrPizza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.labelNrPizza.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNrPizza.ForeColor = System.Drawing.Color.White;
            this.labelNrPizza.Location = new System.Drawing.Point(31, 205);
            this.labelNrPizza.Name = "labelNrPizza";
            this.labelNrPizza.Size = new System.Drawing.Size(129, 23);
            this.labelNrPizza.TabIndex = 20;
            this.labelNrPizza.Text = "Numar Pizza";
            // 
            // errorProviderIdComanda
            // 
            this.errorProviderIdComanda.ContainerControl = this;
            // 
            // errorProviderPretComanda
            // 
            this.errorProviderPretComanda.ContainerControl = this;
            // 
            // errorProviderIdClient
            // 
            this.errorProviderIdClient.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(432, 244);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(707, 322);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(436, 37);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(121, 90);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // labelDataInregistrarii
            // 
            this.labelDataInregistrarii.AutoSize = true;
            this.labelDataInregistrarii.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.labelDataInregistrarii.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataInregistrarii.ForeColor = System.Drawing.Color.White;
            this.labelDataInregistrarii.Location = new System.Drawing.Point(31, 366);
            this.labelDataInregistrarii.Name = "labelDataInregistrarii";
            this.labelDataInregistrarii.Size = new System.Drawing.Size(165, 23);
            this.labelDataInregistrarii.TabIndex = 23;
            this.labelDataInregistrarii.Text = "Data Înregistrării";
            // 
            // dateTimePickerInregistrare
            // 
            this.dateTimePickerInregistrare.Location = new System.Drawing.Point(226, 365);
            this.dateTimePickerInregistrare.Name = "dateTimePickerInregistrare";
            this.dateTimePickerInregistrare.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerInregistrare.TabIndex = 24;
            // 
            // buttonImaginiPizza
            // 
            this.buttonImaginiPizza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.buttonImaginiPizza.FlatAppearance.BorderSize = 0;
            this.buttonImaginiPizza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImaginiPizza.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImaginiPizza.ForeColor = System.Drawing.Color.White;
            this.buttonImaginiPizza.Location = new System.Drawing.Point(966, 175);
            this.buttonImaginiPizza.Name = "buttonImaginiPizza";
            this.buttonImaginiPizza.Size = new System.Drawing.Size(159, 53);
            this.buttonImaginiPizza.TabIndex = 25;
            this.buttonImaginiPizza.Text = "Imagini Pizza";
            this.buttonImaginiPizza.UseVisualStyleBackColor = false;
            this.buttonImaginiPizza.Click += new System.EventHandler(this.buttonImaginiPizza_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(226, 431);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 54);
            this.button1.TabIndex = 26;
            this.button1.Text = "Leave";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormComanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1137, 561);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonImaginiPizza);
            this.Controls.Add(this.dateTimePickerInregistrare);
            this.Controls.Add(this.labelDataInregistrarii);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelNrPizza);
            this.Controls.Add(this.textBoxNrDiavola);
            this.Controls.Add(this.textBoxExotica);
            this.Controls.Add(this.textBoxMexicana);
            this.Controls.Add(this.textBoxSiciliana);
            this.Controls.Add(this.comboBoxExotica);
            this.Controls.Add(this.comboBoxMexicana);
            this.Controls.Add(this.comboBoxSiciliana);
            this.Controls.Add(this.labelIdComanda);
            this.Controls.Add(this.buttonActualizare);
            this.Controls.Add(this.comboBoxDiavola);
            this.Controls.Add(this.textBoxOras);
            this.Controls.Add(this.textBoxIdClient);
            this.Controls.Add(this.textBoxPretComanda);
            this.Controls.Add(this.textBoxIdComanda);
            this.Controls.Add(this.labelOras);
            this.Controls.Add(this.labelIdClient);
            this.Controls.Add(this.labelNumePizza);
            this.Controls.Add(this.labelPretComanda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FormComanda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizza";
            this.Load += new System.EventHandler(this.FormComanda_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormComanda_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderIdComanda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPretComanda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderIdClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelPretComanda;
        private System.Windows.Forms.Label labelNumePizza;
        private System.Windows.Forms.Label labelIdClient;
        private System.Windows.Forms.Label labelOras;
        private System.Windows.Forms.TextBox textBoxIdComanda;
        private System.Windows.Forms.TextBox textBoxPretComanda;
        private System.Windows.Forms.TextBox textBoxIdClient;
        private System.Windows.Forms.TextBox textBoxOras;
        private System.Windows.Forms.ComboBox comboBoxDiavola;
        public System.Windows.Forms.Button buttonActualizare;
        private System.Windows.Forms.Label labelIdComanda;
        private System.Windows.Forms.ComboBox comboBoxSiciliana;
        private System.Windows.Forms.ComboBox comboBoxMexicana;
        private System.Windows.Forms.ComboBox comboBoxExotica;
        private System.Windows.Forms.TextBox textBoxSiciliana;
        private System.Windows.Forms.TextBox textBoxMexicana;
        private System.Windows.Forms.TextBox textBoxExotica;
        private System.Windows.Forms.TextBox textBoxNrDiavola;
        private System.Windows.Forms.Label labelNrPizza;
        private System.Windows.Forms.ErrorProvider errorProviderIdComanda;
        private System.Windows.Forms.ErrorProvider errorProviderPretComanda;
        private System.Windows.Forms.ErrorProvider errorProviderIdClient;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DateTimePicker dateTimePickerInregistrare;
        private System.Windows.Forms.Label labelDataInregistrarii;
        private System.Windows.Forms.Button buttonImaginiPizza;
        public System.Windows.Forms.Button button1;
    }
}