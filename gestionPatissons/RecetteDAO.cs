using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace gestionPatissons
{
    class RecetteDAO
    {

        private MySqlConnection c; //Permettra connexion a la BDD


        public RecetteDAO()
        {
            this.c = Connexion.getInstance(); //Connexion a la BDD
        }


        public void create(Recette r)//On ajoute une recette
        {
            MySqlCommand Commande = new MySqlCommand("INSERT INTO recette (idRecette, titreRecette, texteRecette, IngredientsRecette, photo1Recette, photo2Recette, photo3Recette, photo4Recette, dateRecette, couleurRecette, coutRecette, difficulteRecette, noteRecette) VALUES (NULL,'"+r.Titre+ "','" + r.Text + "','" + r.Ingredients + "','" + r.PhotoUrl1 + "','" + r.PhotoUrl2 + "','" + r.PhotoUrl3 + "','" + r.PhotoUrl4 + "','" + r.Date + "','" + r.Couleur + "','" + r.Cout + "','" + r.Difficulte + "','" + r.Note + "') ;", this.c);

            int reussite = Commande.ExecuteNonQuery();
        }

        
       /* public bool update(Recette r)
        {
            return true;
        }


        public bool deleteRecette(Recette r)
        {
            return true;
        }

        public List<Recette> readAll()
        {
            return ;
        }
        

        public int countAll()
        {
            return 0;
        }*/
    }
}
