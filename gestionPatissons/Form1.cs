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
    public partial class Form1 : Form
    {
        AnnonceDAO adao = new AnnonceDAO();
        RecetteDAO rdao = new RecetteDAO();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label7.Text = adao.countNoActive();
            label4.Text = adao.countActive();
            label5.Text = rdao.countRecettes();
            
        }

        private void btnVerifAnnonces_Click(object sender, EventArgs e)
        {
            bool ouvertOuNon = false;

            foreach(Form frm in Application.OpenForms)
            {
                if(frm is Form2)
                {
                    frm.BringToFront();
                    ouvertOuNon = true;
                }
            }

            if(ouvertOuNon == false)
            {
                Form2 frm = new Form2();
                frm.Show();
            }
        }

        private void btnAjouteRecette_Click(object sender, EventArgs e)
        {
            bool ouvertOuNon = false;

            foreach (Form frm in Application.OpenForms)
            {
                if (frm is Form3)
                {
                    frm.BringToFront();
                    ouvertOuNon = true;
                }
            }

            if (ouvertOuNon == false)
            {
                Form3 frm = new Form3();
                frm.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            bool ouvertOuNon = false;

            foreach (Form frm in Application.OpenForms)
            {
                if (frm is Form4)
                {
                    frm.BringToFront();
                    ouvertOuNon = true;
                }
            }

            if (ouvertOuNon == false)
            {
                Form4 frm = new Form4();
                frm.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool ouvertOuNon = false;

            foreach (Form frm in Application.OpenForms)
            {
                if (frm is Form5)
                {
                    frm.BringToFront();
                    ouvertOuNon = true;
                }
            }

            if (ouvertOuNon == false)
            {
                Form5 frm = new Form5();
                frm.Show();
            }
        }
    }
}
