using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestionPatissons
{
    public partial class Form5 : Form
    {

        RecetteDAO rdao = new RecetteDAO();

        string currentValue;

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            List<Recette> allRecettes = rdao.readAll();

            foreach (Recette uneRecette in allRecettes)
            {
                this.dataGridView1.Rows.Add(uneRecette.Id, uneRecette.Titre, uneRecette.Date);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rdao.deleteRecette(currentValue);

            MessageBox.Show("Recette N°"+currentValue+" Supprimée !");
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            currentValue = Convert.ToString(dataGridView1.CurrentCell.Value);
        }
    }
}
