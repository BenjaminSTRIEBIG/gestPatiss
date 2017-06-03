using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace gestionPatissons
{
    public class AnnonceDAO
    {

        private MySqlConnection c; //Permettra connexion a la BDD



        public AnnonceDAO()
        {
            this.c = Connexion.getInstance(); //Connexion a la BDD
        }


        public bool update(string id) //Met a jout une annonce
        {
            MySqlCommand Commande = new MySqlCommand("UPDATE annonce SET validiteAnnonce=1 WHERE idAnnonce='"+id+"';", this.c);

            int reussite = Commande.ExecuteNonQuery();

            return (reussite > 0); //Si reussite > 0 alors renvoi TRUE
        }

        public bool delete(string id) //Supprime une annonce
        {
            MySqlCommand Commande = new MySqlCommand("DELETE FROM annonce WHERE idAnnonce='"+id+"';", this.c);

            int reussite = Commande.ExecuteNonQuery();

            return (reussite > 0); //Si reussite > 0 alors renvoi TRUE
        }

        public Annonce findById(string id) //Recherche une annonce
        {
            MySqlCommand Commande = new MySqlCommand("SELECT * FROM annonce WHERE idAnnonce='"+id+"';", this.c);

            MySqlDataReader dr = Commande.ExecuteReader(); //Recupère le résultat

            if(dr.Read())
            {
                Annonce ann = new Annonce(  dr["idAnnonce"].ToString(), 
                                            dr["titreAnnonce"].ToString(), 
                                            dr["texteAnnonce"].ToString(), 
                                            dr["qteAnnonce"].ToString(), 
                                            dr["lotAnnonce"].ToString(), 
                                            dr["prixAnnonce"].ToString(), 
                                            dr["photo1Annonce"].ToString(), 
                                            dr["photo2Annonce"].ToString(), 
                                            dr["photo3Annonce"].ToString(), 
                                            dr["photo4Annonce"].ToString(), 
                                            dr["editeurAnnonce"].ToString(), 
                                            dr["validiteAnnonce"].ToString(), 
                                            dr["datePublicationAnnonce"].ToString()
                                          );

                dr.Close();
                return (ann);
            }
            else
            {
                dr.Close();
                return (null);
            }
        }


        public List<Annonce> readAll() //Liste toutes les annonces
        {
            Annonce ann;

            List<Annonce> lesAnnonces = new List<Annonce>();

            MySqlCommand Commande = new MySqlCommand("SELECT * FROM annonce WHERE validiteAnnonce=0 ;", this.c);

            MySqlDataReader dr = Commande.ExecuteReader();
            while(dr.Read())
            {
                         ann = new Annonce(
                                            dr["idAnnonce"].ToString(),
                                            dr["titreAnnonce"].ToString(),
                                            dr["texteAnnonce"].ToString(),
                                            dr["qteAnnonce"].ToString(),
                                            dr["lotAnnonce"].ToString(),
                                            dr["prixAnnonce"].ToString(),
                                            dr["photo1Annonce"].ToString(),
                                            dr["photo2Annonce"].ToString(),
                                            dr["photo3Annonce"].ToString(),
                                            dr["photo4Annonce"].ToString(),
                                            dr["editeurAnnonce"].ToString(),
                                            dr["validiteAnnonce"].ToString(),
                                            dr["datePublicationAnnonce"].ToString()
                                          );

                lesAnnonces.Add(ann);
            }//fin While

            dr.Close();
            return (lesAnnonces);
        }
        




    }//Fin class
}
