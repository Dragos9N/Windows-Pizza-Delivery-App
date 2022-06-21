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
    public partial class FormPictures : Form
    {
        public FormPictures()
        {
            InitializeComponent();
        }

        private void FormPictures_Load(object sender, EventArgs e)
        {
            pictureBoxImagine.AllowDrop = true;

        }

        private void pictureBoxDiavola_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBoxExotica_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBoxSiciliana_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBoxMexicana_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBoxImagine_DragEnter(object sender, DragEventArgs e)
        {
            //evenimentul se va declansa atunci cand vom duce imaginea in picturebox-ul principal
            e.Effect = e.AllowedEffect;
        }

        private void pictureBoxImagine_DragDrop(object sender, DragEventArgs e)
        {
            //evenimentul se va declansa atunci cand vom da drop imaginii in picturebox-ul principal
            pictureBoxImagine.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            //va face fetch imaginii careia i-am dat drag in picturebox-ul principal
        }

        private void pictureBoxDiavola_MouseDown(object sender, MouseEventArgs e)
        {
            //eventul va avea loc atunci cand dam click pe imagine
            pictureBoxDiavola.DoDragDrop(pictureBoxDiavola.Image, DragDropEffects.Copy);
        }

        private void pictureBoxExotica_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxExotica.DoDragDrop(pictureBoxExotica.Image, DragDropEffects.Copy);
        }

        private void pictureBoxSiciliana_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxSiciliana.DoDragDrop(pictureBoxSiciliana.Image, DragDropEffects.Copy);
        }

        private void pictureBoxMexicana_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxMexicana.DoDragDrop(pictureBoxMexicana.Image, DragDropEffects.Copy);
        }

        private void pictureBoxImagine_Click(object sender, EventArgs e)
        {

        }

        private void buttonLeave_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
