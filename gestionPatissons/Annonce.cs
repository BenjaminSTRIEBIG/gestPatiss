using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionPatissons
{
    public class Annonce
    {
        private string id;
        private string titre;
        private string txt;
        private string qte;
        private string lot;
        private string prix;
        private string photo1;
        private string photo2;
        private string photo3;
        private string photo4;
        private string editeur;
        private string validite;
        private string datePublication;

        public Annonce(string idA, string titreA, string txtA, string qteA, string lotA, string prixA, string photo1A, string photo2A, string photo3A, string photo4A, string editeurA, string validiteA, string datePublicationA)
        {
            this.id = idA;
            this.titre = titreA;
            this.txt = txtA;
            this.qte = qteA;
            this.lot = lotA;
            this.prix = prixA;
            this.photo1 = photo1A;
            this.photo2 = photo2A;
            this.photo3 = photo3A;
            this.photo4 = photo4A;
            this.editeur = editeurA;
            this.validite = validiteA;
            this.datePublication = datePublicationA;
        }

        public String getId()
        {
            return this.id;
        }

        public String getTitre()
        {
            return this.titre;
        }

        public String getTxt()
        {
            return this.txt;
        }

        public String getQte()
        {
            return this.qte;
        }

        public String getLot()
        {
            return this.lot;
        }

        public String getPrix()
        {
            return this.prix;
        }

        public String getPhoto1()
        {
            return this.photo1;
        }

        public String getPhoto2()
        {
            return this.photo2;
        }

        public String getPhoto3()
        {
            return this.photo3;
        }

        public String getPhoto4()
        {
            return this.photo4;
        }

        public String getEditeur()
        {
            return this.editeur;
        }

        public String getValidite()
        {
            return this.validite;
        }

        public string getDatePublication()
        {
            return this.datePublication;
        }

    }
}
