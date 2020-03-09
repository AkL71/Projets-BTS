using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitalFishing;
using MySql.Data.MySqlClient;

namespace digitalFishing2
{
    public static class bdd
    {
        private static MySqlConnection connection;
        private static string serveur;
        private static string database;
        private static string UID;
        private static string Pswrd;

        public static void Initialize()
        {
            serveur = "127.0.0.1";
            database = "digitalfishing";
            UID = "root";
            Pswrd = "root";
            string connectionString;
            connectionString = "SERVER=" + serveur + ";" + "DATABASE=" +
            database + ";" + "UID=" + UID + ";" + "PASSWORD=" + Pswrd + ";";
            //string connectionString = "SERVER=127.0.0.1; DATABASE=digitalfishing; UID=root; PASSWORD=root";

            connection = new MySqlConnection(connectionString);
        }
        private static bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                Console.WriteLine("Erreur connexion BDD");
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        Console.WriteLine("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private static bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        #region del
        public static void DeleteMagazine(int NumMagazine)
        {
            string query = "DELETE FROM magazine " +
                            "WHERE NumMagazine=" + NumMagazine;

            if (bdd.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();
                bdd.CloseConnection();
            }
        }
        public static void DeletePigiste(int NumPigiste)
        {
            string query = "DELETE FROM magazine " +
                            "WHERE NumMagazine=" + NumPigiste;

            if (bdd.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();
                bdd.CloseConnection();
            }
        }
        public static void DeleteContrat(int NumContrat)
        {
            string query = "DELETE FROM magazine " +
                            "WHERE NumMagazine=" + NumContrat;

            if (bdd.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();
                bdd.CloseConnection();
            }
        }

        #endregion

        #region update
        //magazine
        public static void UpdateMagazine(int NumMagazine, string DateParutionMagazine, string DateBouclageMagazine, string DatePaiementMagazine, double BudgetMagazine)
        {
            string query = "UPDATE magazine " +
                            "SET DateBouclageMagazine='" + DateBouclageMagazine + "', DateSortieMagazine='" + DateParutionMagazine + "', DatePaiementMagazine='" + DatePaiementMagazine + "', BudgetMagazine = " + BudgetMagazine + "" +
                            "WHERE NumMagazine=" + NumMagazine;

            if (bdd.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();
                bdd.CloseConnection();
            }
        }
        //pigiste
        public static void UpdatePigiste(int NumPigiste, string NomPigiste, string PrenomPigiste, string AdressePigiste, string CPPigiste, string VillePigiste, string MailPigiste, string NumSecuPigiste, string ContratCadrePigiste)
        {
            string query = "UPDATE pigiste " +
                            "SET NomPigiste='" + NomPigiste + "', PrenomPigiste='" + PrenomPigiste + "', AdressePigiste='" + AdressePigiste + "', CPPigiste = '" + CPPigiste + "', VillePigiste ='" + VillePigiste + "',MailPigiste ='" + MailPigiste + "',NumSecuPigiste ='" + NumSecuPigiste + "',ContratCadrePigiste ='" + ContratCadrePigiste + "" +
                            "WHERE NumMagazine=" + NumPigiste;

            if (bdd.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();
                bdd.CloseConnection();
            }
        }
        // contrat
        public static void UpdateContrat(int NumContrat, string LettreAccordContrat, double MontantBrutContrat, double MontantNetContrat, bool DeclarationAgessaContrat, bool FactureContrat, int EtatContrat, Pigiste PigisteContrat, Magazine MagazineContrat)
        {
            string query = "UPDATE contrat " +
                            "SET LettreAccordContrat='" + LettreAccordContrat + "', MontantBrutContrat='" + MontantBrutContrat + "', MontantNetContrat='" + MontantNetContrat + "', DeclarationAgessaContrat = '" + DeclarationAgessaContrat + "', FactureContrat ='" + FactureContrat + "',EtatContrat ='" + EtatContrat + "',PigisteContrat ='" + PigisteContrat + "',MagazineContrat ='" + MagazineContrat + "" +
                            "WHERE NumMagazine=" + NumContrat;

            if (bdd.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();
                bdd.CloseConnection();
            }
        }


        #endregion

        #region insert
        //Magazine
        public static void InsertMagazine(string DateParutionMagazine, string DateBouclageMagazine, string DatePaiementMagazine, double BudgetMagazine)
        {
            //Requête Insertion Magazine
            string query = "INSERT INTO Magazine (DateBouclageMagazine, DateSortieMagazine, DatePaiementMagazine, BudgetMagazine) VALUES('" + DateParutionMagazine + "','" + DateBouclageMagazine + "','" + DatePaiementMagazine + "'," + BudgetMagazine + ")";
            Console.WriteLine(query);

            //open connection
            if (bdd.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                bdd.CloseConnection();
            }
        }
        //pigiste
        public static void InsertPigiste(string NomPigiste, string PrenomPigiste, string AdressePigiste, string CPPigiste, string VillePigiste, string MailPigiste, string NumSecuPigiste, string ContratCadrePigiste)
        {
            //Requête Insertion Magazine
            string query = "INSERT INTO pigiste (DateBouclageMagazine, DateSortieMagazine, DatePaiementMagazine, BudgetMagazine) VALUES('" + NomPigiste + "','" + PrenomPigiste + "','" + AdressePigiste + "'," + CPPigiste + "','" + VillePigiste + "'," + MailPigiste + "'," + NumSecuPigiste + "'," + ContratCadrePigiste + ")";
            Console.WriteLine(query);

            //open connection
            if (bdd.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                bdd.CloseConnection();
            }
        }
        //contrat
        public static void InsertContrat(string LettreAccordContrat, double MontantBrutContrat, double MontantNetContrat, bool DeclarationAgessaContrat, bool FactureContrat, int EtatContrat, Pigiste PigisteContrat, Magazine MagazineContrat)
        {
            //Requête Insertion Magazine
            string query = "INSERT INTO contrat (DateBouclageMagazine, DateSortieMagazine, DatePaiementMagazine, BudgetMagazine) VALUES('" + LettreAccordContrat + "','" + MontantBrutContrat + "','" + MontantNetContrat + "','" + DeclarationAgessaContrat + "','" + FactureContrat + "','" + EtatContrat + "','" + PigisteContrat + "','" + MagazineContrat + ")";
            Console.WriteLine(query);

            //open connection
            if (bdd.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                bdd.CloseConnection();
            }
        }
        #endregion

        #region select
        public static List<Magazine> GetMagazines()
        {
            //Select statement
            string query = "SELECT * FROM Magazine";

            //Create a list to store the result
            List<Magazine> dbMagazine = new List<Magazine>();

            //Ouverture connection
            if (bdd.OpenConnection() == true)
            {
                //Creation Command MySQL
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Création d'un DataReader et execution de la commande
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Lecture des données et stockage dans la collection
                while (dataReader.Read())
                {
                    Magazine leMagazine = new Magazine(Convert.ToInt16(dataReader["NumMagazine"]), Convert.ToString(dataReader["DateBouclageMagazine"]), Convert.ToString(dataReader["DatesParutionMagazine"]), Convert.ToString(dataReader["DatesPaiementMagazine"]), Convert.ToInt16(dataReader["BudgetMagazine"]));
                    dbMagazine.Add(leMagazine);
                }

                //fermeture du Data Reader
                dataReader.Close();

                //fermeture Connection
                bdd.CloseConnection();

                //retour de la collection pour être affichée
                return dbMagazine;
            }
            else
            {
                return dbMagazine;
            }
        }

        public static List<Pigiste> GetPigiste()
        {
            //Select statement
            string query = "SELECT * FROM pigiste";

            //Create a list to store the result
            List<Pigiste> dbPigiste = new List<Pigiste>();

            //Ouverture connection
            if (bdd.OpenConnection() == true)
            {
                //Creation Command MySQL
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Création d'un DataReader et execution de la commande
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Lecture des données et stockage dans la collection
                while (dataReader.Read())
                {
                    Pigiste lePigiste = new Pigiste(Convert.ToInt16(dataReader["NumPigiste"]), Convert.ToString(dataReader["NomPigiste"]), Convert.ToString(dataReader["PrenomPigiste"]), Convert.ToString(dataReader["AdressePigiste"]), Convert.ToString(dataReader["CPPigiste"]), Convert.ToString(dataReader["VillePigiste"]), Convert.ToString(dataReader["MailPigiste"]), Convert.ToString(dataReader["NumSecuPigiste"]), Convert.ToString(dataReader["ContratCadrePigiste"]));
                    dbPigiste.Add(lePigiste);
                }

                //fermeture du Data Reader
                dataReader.Close();

                //fermeture Connection
                bdd.CloseConnection();

                //retour de la collection pour être affichée
                return dbPigiste;
            }
            else
            {
                return dbPigiste;
            }
        }

        public static List<Contrat> GetContrat()
        {
            //Select statement
            string query = "SELECT * FROM (contrat C INNER JOIN PIGISTE P ON C.NumPigiste = P.NumPigiste) INNER JOIN MAGAZINE M ON C.NumMagazine = M.NumMagazine";

            //Create a list to store the result
            List<Contrat> dbContrat = new List<Contrat>();

            //Ouverture connection
            if (bdd.OpenConnection() == true)
            {
                //Creation Command MySQL
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Création d'un DataReader et execution de la commande
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Lecture des données et stockage dans la collection
                while (dataReader.Read())
                {
                    Pigiste tempPi = new Pigiste(Convert.ToInt16(dataReader["NumPigiste"]), Convert.ToString(dataReader["NomPigiste"]), Convert.ToString(dataReader["PrenomPigiste"]), Convert.ToString(dataReader["AdressePigiste"]), Convert.ToString(dataReader["CPPigiste"]), Convert.ToString(dataReader["VillePigiste"]), Convert.ToString(dataReader["MailPigiste"]), Convert.ToString(dataReader["NumSecuPigiste"]), Convert.ToString(dataReader["ContratCadrePigiste"]));
                    Magazine tempMa = new Magazine(Convert.ToInt16(dataReader["NumMagazine"]), Convert.ToString(dataReader["DatesParutionMagazine"]), Convert.ToString(dataReader["DateBouclageMagazine"]), Convert.ToString(dataReader["DatesPaiementMagazine"]), Convert.ToInt16(dataReader["BudgetMagazine"]));

                    Contrat leContrat = new Contrat(Convert.ToInt16(dataReader["NumContrat"]), Convert.ToString(dataReader["LettreAccordContrat"]), Convert.ToDouble(dataReader["MontantBrutContrat"]), Convert.ToDouble(dataReader["MontantNetContrat"]), Convert.ToBoolean(dataReader["DeclarationAgessaContrat"]), Convert.ToBoolean(dataReader["FactureContrat"]), Convert.ToInt16(dataReader["EtatContrat"]), tempPi, tempMa);
                    dbContrat.Add(leContrat);
                }

                //fermeture du Data Reader
                dataReader.Close();

                //fermeture Connection
                bdd.CloseConnection();

                //retour de la collection pour être affichée
                return dbContrat;
            }
            else
            {
                return dbContrat;
            }
        }
        #endregion
    }
}