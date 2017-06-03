using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Odbc;
using System.Data.OleDb;
using MySql.Data.MySqlClient;

namespace gestionPatissons
{
    class Connexion
    {
        /******************************** 
        Permet de se connecter a la base 
        ********************************/
            private static MySqlConnection c;


            //Constructeur privé vide 
            private Connexion() { }


            public static MySqlConnection getInstance()
            {
                if (c == null)
                {
                    string chaineDeConnexion;
                    chaineDeConnexion =
                                        "server=mysql-datacube.alwaysdata.net;" + //Serveur
                                        "database=datacube_patissonsdb;" + //Nom de la BDD
                                        "uid=datacube;" + //Nom de compte
                                        "pwd=Datacube68;"; //Mot de passe
                    c = new MySqlConnection(chaineDeConnexion);
                    c.Open(); 
                }//fin Si 
                return Connexion.c;
            }//fin getInstance
        }//Fin classe 
    }