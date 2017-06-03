using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace gestionPatissons
{
    public partial class Form2 : Form
    {

        AnnonceDAO adao = new AnnonceDAO();

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {



            List<Annonce> allAnnonce = adao.readAll();

            foreach (Annonce uneAnnonce in allAnnonce)
            {
                this.dataGridView1.Rows.Add(uneAnnonce.getId(), uneAnnonce.getTitre(), uneAnnonce.getEditeur(), uneAnnonce.getDatePublication());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string currentValue = Convert.ToString(dataGridView1.CurrentCell.Value);
            Annonce a = adao.findById(currentValue);

            label1.Text = a.getTitre();
            textBox1.Text = a.getTxt();

            pictureBox1.Load("https://patissons.fr/AnnoncesPhotos/"+a.getPhoto1());
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string currentValue = Convert.ToString(dataGridView1.CurrentCell.Value);
            DataGridViewRow currentRow = dataGridView1.CurrentRow;
            adao.delete(currentValue);
            dataGridView1.Rows.Remove(currentRow);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string currentValue = Convert.ToString(dataGridView1.CurrentCell.Value);
            DataGridViewRow currentRow = dataGridView1.CurrentRow;
            adao.update(currentValue);
            dataGridView1.Rows.Remove(currentRow);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
