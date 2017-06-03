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
    public partial class Form3 : Form
    {

        RecetteDAO rdao = new RecetteDAO();

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            cmbDificultRecette.Items.Add("Très Facile");
            cmbDificultRecette.Items.Add("Facile");
            cmbDificultRecette.Items.Add("Moyenne");
            cmbDificultRecette.Items.Add("Difficile");
            cmbDificultRecette.Items.Add("Expert");

            cmbNoteRecette.Items.Add("1");
            cmbNoteRecette.Items.Add("2");
            cmbNoteRecette.Items.Add("3");
            cmbNoteRecette.Items.Add("4");
            cmbNoteRecette.Items.Add("5");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog3.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog4.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string titre = txtBoxTitreRecette.Text ;
            string txt = txtBoxTexteRecette.Text;
            string ingred = txtBoxIngredRecette.Text;
            string photo1Recette = openFileDialog1.SafeFileName;
            string photo2Recette = openFileDialog2.SafeFileName;
            string photo3Recette = openFileDialog3.SafeFileName;
            string photo4Recette = openFileDialog4.SafeFileName;
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            string couleur = "#"+(colorDialog1.Color.ToArgb() & 0x00FFFFFF).ToString("X6");
            string coutRecette = txtBoxCoutRecette.Text;
            string difficult = cmbDificultRecette.Text;
            string note = cmbNoteRecette.Text;

            Recette creatRecette = new Recette("",titre,txt,ingred,photo1Recette,photo2Recette,photo3Recette,photo4Recette,date,couleur,coutRecette,difficult,note);
            rdao.create(creatRecette);

            UpLoadImage(openFileDialog1.FileName,openFileDialog1.SafeFileName);
            UpLoadImage(openFileDialog2.FileName, openFileDialog1.SafeFileName);
            UpLoadImage(openFileDialog3.FileName, openFileDialog1.SafeFileName);
            UpLoadImage(openFileDialog4.FileName, openFileDialog1.SafeFileName);

            MessageBox.Show("Recette Ajoutée !");
            this.Close();
        }

        private void txtBoxTitreRecette_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxTexteRecette_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxIngredRecette_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxCoutRecette_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbDificultRecette_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbNoteRecette_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        public static void UpLoadImage(string image, string targeturl)
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



    }
}
