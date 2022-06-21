
namespace ProjectPAW
{
    partial class Siciliana
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Siciliana));
            this.pictureBoxinfSiciliana = new System.Windows.Forms.PictureBox();
            this.richTextBoxinfSiciliana = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxinfSiciliana)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxinfSiciliana
            // 
            this.pictureBoxinfSiciliana.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxinfSiciliana.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxinfSiciliana.Image")));
            this.pictureBoxinfSiciliana.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxinfSiciliana.Name = "pictureBoxinfSiciliana";
            this.pictureBoxinfSiciliana.Size = new System.Drawing.Size(327, 255);
            this.pictureBoxinfSiciliana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxinfSiciliana.TabIndex = 0;
            this.pictureBoxinfSiciliana.TabStop = false;
            // 
            // richTextBoxinfSiciliana
            // 
            this.richTextBoxinfSiciliana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.richTextBoxinfSiciliana.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxinfSiciliana.Location = new System.Drawing.Point(44, 110);
            this.richTextBoxinfSiciliana.Name = "richTextBoxinfSiciliana";
            this.richTextBoxinfSiciliana.Size = new System.Drawing.Size(241, 117);
            this.richTextBoxinfSiciliana.TabIndex = 1;
            this.richTextBoxinfSiciliana.Text = "Blat\n350 g de faina\nSare\nZahar\nDrojdie uscata\nUlei de masline\n250 ml de apa\nToppi" +
    "ng\nSos de rosii\nMozzarella\nPorumb dulce\nArdei\nOregano\nCiuperci\nMasline\nBacon";
            // 
            // Siciliana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.richTextBoxinfSiciliana);
            this.Controls.Add(this.pictureBoxinfSiciliana);
            this.Name = "Siciliana";
            this.Size = new System.Drawing.Size(327, 255);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxinfSiciliana)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxinfSiciliana;
        private System.Windows.Forms.RichTextBox richTextBoxinfSiciliana;
    }
}
