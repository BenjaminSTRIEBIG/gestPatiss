using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionPatissons
{
    class Recette
    {

        private string id;
        private string titre;
        private string texte;
        private string ingredients;
        private string photo1URL;
        private string photo2URL;
        private string photo3URL;
        private string photo4URL;
        private string date;
        private string editeur;
        private string couleur;
        private string cout;
        private string difficulte;
        private string note;
        private string v;
        private string txt;
        private string ingred;
        private string photo1Recette;
        private string photo2Recette;
        private string photo3Recette;
        private string photo4Recette;
        private string coutRecette;
        private string difficult;

        public Recette(String idR, String titreR, String texteR, String ingredientsR, String photo1URLR, String photo2URLR, String photo3URLR, String photo4URLR, String dateR, String couleurR, String coutR, String difficulteR, String noteR)
        {
            this.id = idR;
            this.titre = titreR;
            this.texte = texteR;
            this.ingredients = ingredientsR;
            this.photo1URL = photo1URLR;
            this.photo2URL = photo2URLR;
            this.photo3URL = photo3URLR;
            this.photo4URL = photo4URLR;
            this.date = dateR;
            this.couleur = couleurR;
            this.cout = coutR;
            this.difficulte = difficulteR;
            this.note = noteR;
        }

        public string Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        public string Titre
        {
            get
            {
                return this.titre;
            }
            set
            {
                this.titre = value;
            }
        }

        public string Text
        {
            get
            {
                return this.texte;
            }
            set
            {
                this.texte = value;
            }
        }

        public string Ingredients
        {
            get
            {
                return this.ingredients;
            }
            set
            {
                this.ingredients = value;
            }
        }

        public string PhotoUrl1
        {
            get
            {
                return this.photo1URL;
            }
            set
            {
                this.photo1URL = value;
            }
        }

        public string PhotoUrl2
        {
            get
            {
                return this.photo2URL;
            }
            set
            {
                this.photo2URL = value;
            }
        }

        public string PhotoUrl3
        {
            get
            {
                return this.photo3URL;
            }
            set
            {
                this.photo3URL = value;
            }
        }

        public string PhotoUrl4
        {
            get
            {
                return this.photo4URL;
            }
            set
            {
                this.photo4URL = value;
            }
        }

        public string Date
        {
            get
            {
                return this.date;
            }
            set
            {
                this.date = value;
            }
        }

        public string Editeur
        {
            get
            {
                return this.editeur;
            }
            set
            {
                this.editeur = value;
            }
        }

        public string Couleur
        {
            get
            {
                return this.couleur;
            }
            set
            {
                this.couleur = value;
            }
        }

        public string Cout
        {
            get
            {
                return this.cout;
            }
            set
            {
                this.cout = value;
            }
        }

        public string Difficulte
        {
            get
            {
                return this.difficulte;
            }
            set
            {
                this.difficulte = value;
            }
        }

        public string Note
        {
            get
            {
                return this.note;
            }
            set
            {
                this.note = value;
            }
        }

        public string toString()
        {
            return (id + " " + titre + " " + texte + " " + ingredients + " " + photo1URL + " " + photo2URL + " " + photo3URL + " " + photo4URL + " " + date + " " + editeur + " " + couleur + " " + cout + " " + difficulte + " " + note);
        }
    }
}
