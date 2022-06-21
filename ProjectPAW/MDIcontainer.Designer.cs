
namespace ProjectPAW
{
    partial class MDIcontainer
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.formeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaFormaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afisareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orizontalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inchideFerestreleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operatiiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afisareMesajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formeToolStripMenuItem,
            this.operatiiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(570, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // formeToolStripMenuItem
            // 
            this.formeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaFormaToolStripMenuItem,
            this.afisareToolStripMenuItem,
            this.inchideFerestreleToolStripMenuItem});
            this.formeToolStripMenuItem.Name = "formeToolStripMenuItem";
            this.formeToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.formeToolStripMenuItem.Text = "Forme";
            // 
            // adaugaFormaToolStripMenuItem
            // 
            this.adaugaFormaToolStripMenuItem.Name = "adaugaFormaToolStripMenuItem";
            this.adaugaFormaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.adaugaFormaToolStripMenuItem.Text = "Adauga forma";
            this.adaugaFormaToolStripMenuItem.Click += new System.EventHandler(this.adaugaFormaToolStripMenuItem_Click);
            // 
            // afisareToolStripMenuItem
            // 
            this.afisareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orizontalaToolStripMenuItem,
            this.verticalaToolStripMenuItem,
            this.cascadaToolStripMenuItem});
            this.afisareToolStripMenuItem.Name = "afisareToolStripMenuItem";
            this.afisareToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.afisareToolStripMenuItem.Text = "Afisare";
            // 
            // orizontalaToolStripMenuItem
            // 
            this.orizontalaToolStripMenuItem.Name = "orizontalaToolStripMenuItem";
            this.orizontalaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.orizontalaToolStripMenuItem.Text = "Orizontala";
            this.orizontalaToolStripMenuItem.Click += new System.EventHandler(this.orizontalaToolStripMenuItem_Click);
            // 
            // verticalaToolStripMenuItem
            // 
            this.verticalaToolStripMenuItem.Name = "verticalaToolStripMenuItem";
            this.verticalaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.verticalaToolStripMenuItem.Text = "Verticala";
            this.verticalaToolStripMenuItem.Click += new System.EventHandler(this.verticalaToolStripMenuItem_Click);
            // 
            // cascadaToolStripMenuItem
            // 
            this.cascadaToolStripMenuItem.Name = "cascadaToolStripMenuItem";
            this.cascadaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cascadaToolStripMenuItem.Text = "Cascada";
            this.cascadaToolStripMenuItem.Click += new System.EventHandler(this.cascadaToolStripMenuItem_Click);
            // 
            // inchideFerestreleToolStripMenuItem
            // 
            this.inchideFerestreleToolStripMenuItem.Name = "inchideFerestreleToolStripMenuItem";
            this.inchideFerestreleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.inchideFerestreleToolStripMenuItem.Text = "Inchide ferestrele";
            this.inchideFerestreleToolStripMenuItem.Click += new System.EventHandler(this.inchideFerestreleToolStripMenuItem_Click);
            // 
            // operatiiToolStripMenuItem
            // 
            this.operatiiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afisareMesajToolStripMenuItem});
            this.operatiiToolStripMenuItem.Name = "operatiiToolStripMenuItem";
            this.operatiiToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.operatiiToolStripMenuItem.Text = "Operatii";
            // 
            // afisareMesajToolStripMenuItem
            // 
            this.afisareMesajToolStripMenuItem.Name = "afisareMesajToolStripMenuItem";
            this.afisareMesajToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.afisareMesajToolStripMenuItem.Text = "Afisare mesaj";
            this.afisareMesajToolStripMenuItem.Click += new System.EventHandler(this.afisareMesajToolStripMenuItem_Click);
            // 
            // MDIcontainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDIcontainer";
            this.Text = "MDIcontainer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaFormaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afisareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orizontalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inchideFerestreleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operatiiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afisareMesajToolStripMenuItem;
    }
}