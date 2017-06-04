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


         public void update(Recette r)
         {
            MySqlCommand Commande = new MySqlCommand("UPDATE recette SET titreRecette = '" + r.Titre.ToString() + "', texteRecette = '" + r.Text + "', IngredientsRecette = '" + r.Ingredients + "', photo1Recette = '" + r.PhotoUrl1 + "', photo2Recette = '" + r.PhotoUrl2 + "', photo3Recette = '" + r.PhotoUrl3 + "', photo4Recette = '" + r.PhotoUrl4 + "', couleurRecette = '" + r.Couleur + "', coutRecette = '" + r.Cout + "', difficulteRecette = '" + r.Difficulte + "', noteRecette = '" + r.Note + "' WHERE idRecette = '" + r.Id + "';", this.c);

            int reussite = Commande.ExecuteNonQuery();
        }


         public bool deleteRecette(String id)
         {

            MySqlCommand Commande = new MySqlCommand("DELETE FROM recette WHERE idRecette = '"+id+"';", this.c);

            int reussite = Commande.ExecuteNonQuery();

            return true;
         }

        public string countRecettes() //Liste toutes les annonces
        {

            MySqlCommand Commande = new MySqlCommand("SELECT count(*) FROM recette ;", this.c);

            MySqlDataReader dr = Commande.ExecuteReader();

            if (dr.Read())
            {
                string totalAnnoncesAcitves = dr[0].ToString();
                dr.Close();
                return (totalAnnoncesAcitves);
            }
            else
            {
                dr.Close();
                return (null);
            }
        }


        public List<Recette> readAll() //Liste toutes les annonces
        {
            Recette rec;

            List<Recette> lesAnnonces = new List<Recette>();

            MySqlCommand Commande = new MySqlCommand("SELECT * FROM recette ;", this.c);

            MySqlDataReader dr = Commande.ExecuteReader();
            while (dr.Read())
            {
                rec = new Recette(
                                   dr["idRecette"].ToString(),
                                   dr["titreRecette"].ToString(),
                                   dr["texteRecette"].ToString(),
                                   dr["IngredientsRecette"].ToString(),
                                   dr["photo1Recette"].ToString(),
                                   dr["photo2Recette"].ToString(),
                                   dr["photo3Recette"].ToString(),
                                   dr["photo4Recette"].ToString(),
                                   dr["dateRecette"].ToString(),
                                   dr["couleurRecette"].ToString(),
                                   dr["coutRecette"].ToString(),
                                   dr["difficulteRecette"].ToString(),
                                   dr["noteRecette"].ToString()
                                 );

                lesAnnonces.Add(rec);
            }//fin While

            dr.Close();
            return (lesAnnonces);
        }


        public Recette findById(string id) //Recherche une Recette
        {
            MySqlCommand Commande = new MySqlCommand("SELECT * FROM recette WHERE idRecette ='" + id + "';", this.c);

            MySqlDataReader dr = Commande.ExecuteReader(); //Recupère le résultat

            if (dr.Read())
            {
                Recette rec = new Recette(dr["idRecette"].ToString(),
                                           dr["titreRecette"].ToString(),
                                           dr["texteRecette"].ToString(),
                                           dr["IngredientsRecette"].ToString(),
                                           dr["photo1Recette"].ToString(),
                                           dr["photo2Recette"].ToString(),
                                           dr["photo3Recette"].ToString(),
                                           dr["photo4Recette"].ToString(),
                                           dr["dateRecette"].ToString(),
                                           dr["couleurRecette"].ToString(),
                                           dr["coutRecette"].ToString(),
                                           dr["difficulteRecette"].ToString(),
                                           dr["noteRecette"].ToString()
                                          );

                dr.Close();
                return (rec);
            }
            else
            {
                dr.Close();
                return (null);
            }
        }


    }
}
