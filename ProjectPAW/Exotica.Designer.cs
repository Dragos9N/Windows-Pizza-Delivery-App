
namespace ProjectPAW
{
    partial class Exotica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exotica));
            this.pictureBoxinfExotica = new System.Windows.Forms.PictureBox();
            this.richTextBoxinfExotica = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxinfExotica)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxinfExotica
            // 
            this.pictureBoxinfExotica.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxinfExotica.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxinfExotica.Image")));
            this.pictureBoxinfExotica.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxinfExotica.Name = "pictureBoxinfExotica";
            this.pictureBoxinfExotica.Size = new System.Drawing.Size(351, 245);
            this.pictureBoxinfExotica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxinfExotica.TabIndex = 0;
            this.pictureBoxinfExotica.TabStop = false;
            // 
            // richTextBoxinfExotica
            // 
            this.richTextBoxinfExotica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.richTextBoxinfExotica.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxinfExotica.Location = new System.Drawing.Point(53, 88);
            this.richTextBoxinfExotica.Name = "richTextBoxinfExotica";
            this.richTextBoxinfExotica.Size = new System.Drawing.Size(236, 129);
            this.richTextBoxinfExotica.TabIndex = 1;
            this.richTextBoxinfExotica.Text = " blat de pizza\n sos de rosii\n 150 g mozzarella\n 150 g sunca\n 100 g ananas";
            // 
            // Exotica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.richTextBoxinfExotica);
            this.Controls.Add(this.pictureBoxinfExotica);
            this.Name = "Exotica";
            this.Size = new System.Drawing.Size(351, 245);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxinfExotica)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxinfExotica;
        private System.Windows.Forms.RichTextBox richTextBoxinfExotica;
    }
}
