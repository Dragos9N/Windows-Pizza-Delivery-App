
namespace ProjectPAW
{
    partial class Diavola
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Diavola));
            this.pictureBoxInfDiavola = new System.Windows.Forms.PictureBox();
            this.richTextBoxInfDiavola = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfDiavola)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxInfDiavola
            // 
            this.pictureBoxInfDiavola.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxInfDiavola.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxInfDiavola.Image")));
            this.pictureBoxInfDiavola.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxInfDiavola.Name = "pictureBoxInfDiavola";
            this.pictureBoxInfDiavola.Size = new System.Drawing.Size(347, 322);
            this.pictureBoxInfDiavola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxInfDiavola.TabIndex = 0;
            this.pictureBoxInfDiavola.TabStop = false;
            // 
            // richTextBoxInfDiavola
            // 
            this.richTextBoxInfDiavola.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.richTextBoxInfDiavola.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxInfDiavola.Location = new System.Drawing.Point(24, 112);
            this.richTextBoxInfDiavola.Name = "richTextBoxInfDiavola";
            this.richTextBoxInfDiavola.Size = new System.Drawing.Size(303, 145);
            this.richTextBoxInfDiavola.TabIndex = 1;
            this.richTextBoxInfDiavola.Text = resources.GetString("richTextBoxInfDiavola.Text");
            // 
            // Diavola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.richTextBoxInfDiavola);
            this.Controls.Add(this.pictureBoxInfDiavola);
            this.Name = "Diavola";
            this.Size = new System.Drawing.Size(347, 322);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfDiavola)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxInfDiavola;
        private System.Windows.Forms.RichTextBox richTextBoxInfDiavola;
    }
}
