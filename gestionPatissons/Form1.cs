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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
    }
}
