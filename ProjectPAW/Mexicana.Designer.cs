
namespace ProjectPAW
{
    partial class Mexicana
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mexicana));
            this.pictureBoxinfMexicana = new System.Windows.Forms.PictureBox();
            this.richTextBoxinfMexicana = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxinfMexicana)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxinfMexicana
            // 
            this.pictureBoxinfMexicana.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxinfMexicana.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxinfMexicana.Image")));
            this.pictureBoxinfMexicana.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxinfMexicana.Name = "pictureBoxinfMexicana";
            this.pictureBoxinfMexicana.Size = new System.Drawing.Size(332, 297);
            this.pictureBoxinfMexicana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxinfMexicana.TabIndex = 0;
            this.pictureBoxinfMexicana.TabStop = false;
            // 
            // richTextBoxinfMexicana
            // 
            this.richTextBoxinfMexicana.BackColor = System.Drawing.Color.Silver;
            this.richTextBoxinfMexicana.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxinfMexicana.Location = new System.Drawing.Point(25, 98);
            this.richTextBoxinfMexicana.Name = "richTextBoxinfMexicana";
            this.richTextBoxinfMexicana.Size = new System.Drawing.Size(276, 147);
            this.richTextBoxinfMexicana.TabIndex = 1;
            this.richTextBoxinfMexicana.Text = resources.GetString("richTextBoxinfMexicana.Text");
            // 
            // Mexicana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.richTextBoxinfMexicana);
            this.Controls.Add(this.pictureBoxinfMexicana);
            this.Name = "Mexicana";
            this.Size = new System.Drawing.Size(332, 297);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxinfMexicana)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxinfMexicana;
        private System.Windows.Forms.RichTextBox richTextBoxinfMexicana;
    }
}
