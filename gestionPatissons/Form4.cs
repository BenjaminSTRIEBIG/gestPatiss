using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestionPatissons
{
    public partial class Form4 : Form
    {
        RecetteDAO rdao = new RecetteDAO();

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            List<Recette> allRecettes = rdao.readAll();

            foreach (Recette uneRecette in allRecettes)
            {
                this.dataGridView1.Rows.Add(uneRecette.Id, uneRecette.Titre, uneRecette.Date);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string currentValue = Convert.ToString(dataGridView1.CurrentCell.Value);
            Recette r = rdao.findById(currentValue);

            try { 
                pictureBox1.Load("https://patissons.fr/RecettesPhotos/" + r.PhotoUrl1);
                pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            }
            catch(Exception)
            {
                pictureBox1.Load("https://patissons.fr/RecettesPhotos/blanc.png");
            }

            try { 
                pictureBox2.Load("https://patissons.fr/RecettesPhotos/" + r.PhotoUrl2);
                pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            }
            catch(Exception)
            {
                pictureBox2.Load("https://patissons.fr/RecettesPhotos/blanc.png");
            }

            try
            {
                pictureBox3.Load("https://patissons.fr/RecettesPhotos/" + r.PhotoUrl3);
                pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            }
            catch(Exception)
            {
                pictureBox3.Load("https://patissons.fr/RecettesPhotos/blanc.png");
            }

            try
            {
                pictureBox4.Load("https://patissons.fr/RecettesPhotos/" + r.PhotoUrl4);
                pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            }
            catch(Exception)
            {
                pictureBox4.Load("https://patissons.fr/RecettesPhotos/blanc.png");
            }

            txtBoxTitreRecette.Text = r.Titre;
            txtBoxTexteRecette.Text = r.Text;
            txtBoxIngredRecette.Text = r.Ingredients;
            txtBoxCoutRecette.Text = r.Cout;
            cmbDificultRecette.Text = r.Difficulte;
            cmbNoteRecette.Text = r.Note;
            datePublication.Text = r.Date;
            colorlbl.Text = r.Couleur;
            lblId.Text = r.Id;

            openFileDialog1.FileName = r.PhotoUrl1;
            openFileDialog2.FileName = r.PhotoUrl2;
            openFileDialog3.FileName = r.PhotoUrl3;
            openFileDialog4.FileName = r.PhotoUrl4;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            openFileDialog3.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            openFileDialog4.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            string titre = txtBoxTitreRecette.Text;
            string txt = txtBoxTexteRecette.Text;
            string ingred = txtBoxIngredRecette.Text;
            string photo1Recette = openFileDialog1.SafeFileName;
            string photo2Recette = openFileDialog2.SafeFileName;
            string photo3Recette = openFileDialog3.SafeFileName;
            string photo4Recette = openFileDialog4.SafeFileName;
            string couleur = colorlbl.Text;
            if ((colorDialog1.Color.ToArgb() & 0x00FFFFFF).ToString("X6")!="#FFFFFF" & (colorDialog1.Color.ToArgb() & 0x00FFFFFF).ToString("X6") != null)
            {
                couleur = "#" + (colorDialog1.Color.ToArgb() & 0x00FFFFFF).ToString("X6");
            }
            else
            {
                couleur = colorlbl.Text;
            }
            
            string coutRecette = txtBoxCoutRecette.Text;
            string difficult = cmbDificultRecette.Text;
            string note = cmbNoteRecette.Text;

            //MessageBox.Show(titre + txt +  ingred + photo1Recette +  photo2Recette + photo3Recette + photo4Recette + datePublication.Text + couleur + coutRecette + difficult + note);

            Recette updateRecette = new Recette(lblId.Text, titre, txt, ingred, photo1Recette, photo2Recette, photo3Recette, photo4Recette, datePublication.Text ,couleur, coutRecette, difficult, note);
            rdao.update(updateRecette);

            UpLoadImage(openFileDialog1.FileName, openFileDialog1.SafeFileName);
            UpLoadImage(openFileDialog2.FileName, openFileDialog1.SafeFileName);
            UpLoadImage(openFileDialog3.FileName, openFileDialog1.SafeFileName);
            UpLoadImage(openFileDialog4.FileName, openFileDialog1.SafeFileName);

            MessageBox.Show("Recette Modifiée !");
            this.Close();
        }


        public static void UpLoadImage(string image, string targeturl)
        {
            try
            {
                FtpWebRequest req = (FtpWebRequest)WebRequest.Create("ftp://ftp.cluster021.hosting.ovh.net/www/RecettesPhotos/" + targeturl);
                req.UseBinary = true;
                req.Method = WebRequestMethods.Ftp.UploadFile;
                req.Credentials = new NetworkCredential("patissonnl", "Datacube68500");
                byte[] fileData = File.ReadAllBytes(image);
                req.ContentLength = fileData.Length;
                Stream reqStream = req.GetRequestStream();
                reqStream.Write(fileData, 0, fileData.Length);
                reqStream.Close();
            }
            catch(Exception)
            {

            }
            
        }




    }
}
