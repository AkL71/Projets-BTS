using DigitalFishing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace digitalFishing2
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<Contrat> cContrat = new List<Contrat>();
        List<Magazine> cMagazine = new List<Magazine>();
        List<Pigiste> cPigiste = new List<Pigiste>();
        public MainWindow()
        {
            InitializeComponent();
            

            // Ajout d'objets temporaires pour tester l'application
          //  Pigiste P1 = new Pigiste(1, "Duff", "John", "Rue des alouettes", "75000", "Alfortville", "johnd@mail.com", "010969000000", "1m2p-cc-01");
           // Pigiste P2 = new Pigiste(2, "Ligili", "Guy", "Rue des alouettes", "75000", "Alfortville", "guyl@mail.com", "011069000000", "1m2p-cc-02");
            //Pigiste P3 = new Pigiste(3, "Terieur", "Alex", "Rue des alouettes", "75000", "Alfortville", "alext@mail.com", "011169000000", "1m2p-cc-03");

            //Magazine M1 = new Magazine(1, "01/05/2019", "01/06/2019", "01/07/2019", 3300);
            //Magazine M2 = new Magazine(2, "01/07/2019", "01/08/2019", "01/09/2019", 3300);
            //Magazine M3 = new Magazine(3, "01/09/2019", "01/10/2019", "01/11/2019", 3300);


            // Exemple d'appel du deuxième constructeur pour génération automatique de la lettre accord pour C0, autre constructeur pour les autres
            //Contrat C0 = new Contrat(0, "1m2p-la-0-0", 160, 144, false, false, 0, P1, M1);
            //Contrat C1 = new Contrat(1, 160, 144, false, false, 0, P1, M2);
            //Contrat C2 = new Contrat(2, 160, 144, false, false, 0, P1, M3);
            //Contrat C3 = new Contrat(3, 160, 144, false, false, 0, P2, M1);
            //Contrat C4 = new Contrat(4, 160, 144, false, false, 0, P2, M2);
            //Contrat C5 = new Contrat(5, 160, 144, false, false, 0, P3, M2);
            //Contrat C6 = new Contrat(6, 160, 144, false, false, 0, P3, M3);


            // Création de 3 collections pour stocker les objets
            

            /* Remplissage des collections avec les objets
            cContrat.Add(C0);
            cContrat.Add(C1);
            cContrat.Add(C2);
            cContrat.Add(C3);
            cContrat.Add(C4);
            cContrat.Add(C5);
            cContrat.Add(C6);

            cMagazine.Add(M1);
            cMagazine.Add(M2);
            cMagazine.Add(M3);

            cPigiste.Add(P1);
            cPigiste.Add(P2);
            cPigiste.Add(P3);
            */


                bdd.Initialize();
            bdd.Initialize();
            cPigiste = bdd.GetPigiste();
            cMagazine = bdd.GetMagazines();
            cContrat = bdd.GetContrat();
            dtgContrat.ItemsSource = cContrat;
                dtgMagazine.ItemsSource = cMagazine;    
                dtgPigiste.ItemsSource = cMagazine;
                cboPigiste.ItemsSource = cPigiste;
                cboMagazine.ItemsSource = cMagazine;
    



        }

        private void dtgContrat_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
                Contrat C1 = (Contrat)dtgContrat.SelectedItem;
            txtNumContrat.Text = (Convert.ToString(C1.NumContrat));
            txtLettreAccordContrat.Text = (Convert.ToString(C1.LettreAccordContrat));
            txtMontantBrutContrat.Text = (Convert.ToString(C1.MontantBrutContrat));
            txtMontantNetContrat.Text = (Convert.ToString(C1.MontantNetContrat));
            cboEtatContrat.SelectedIndex = C1.EtatContrat;
            cboPigiste.SelectedItem = C1.PigisteContrat;
            cboMagazine.SelectedItem = C1.MagazineContrat;
            chkAgessa.SetCurrentValue(CheckBox.IsCheckedProperty, C1.DeclarationAgessaContrat);
            chkFacture.SetCurrentValue(CheckBox.IsCheckedProperty, C1.FactureContrat);

        }
        private void dtgMagazine_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            Magazine M1 = (Magazine)dtgMagazine.SelectedItem;
            txtNumMagazine.Text = (Convert.ToString(M1.NumMagazine));
            txtBudgetMagazine.Text = (Convert.ToString(M1.BudgetMagazine));
        


        }
        private void dtgPigiste_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            Pigiste P1 = (Pigiste)dtgPigiste.SelectedItem;
            txtNumPigiste.Text = (Convert.ToString(P1.NumPigiste));
            txtNomPigiste.Text = (Convert.ToString(P1.NomPigiste));
            txtPrenomPigiste.Text = (Convert.ToString(P1.PrenomPigiste));
            txtNumSecuPigiste.Text = (Convert.ToString(P1.NumSecuPigiste));
            txtContratCadrePigiste.Text = (Convert.ToString(P1.ContratCadrePigiste));
            txtAdressePigiste.Text = (Convert.ToString(P1.AdressePigiste));
            txtCPPigiste.Text = (Convert.ToString(P1.CPPigiste));
            txtVillePigiste.Text = (Convert.ToString(P1.VillePigiste));
            txtMailPigiste.Text = (Convert.ToString(P1.MailPigiste));

        }
        #region bouton
        private void btnAjouterContrat_Click(object sender, RoutedEventArgs e)
        {
            Contrat ajtcontrat = new Contrat(Int32.Parse(txtNumContrat.Text), Int32.Parse(txtMontantBrutContrat.Text), Int32.Parse(txtMontantNetContrat.Text), chkAgessa.IsChecked.Value, chkFacture.IsChecked.Value, cboEtatContrat.SelectedIndex, (Pigiste)cboPigiste.SelectedItem, (Magazine)cboMagazine.SelectedItem);
            cContrat.Add(ajtcontrat);
            dtgContrat.Items.Refresh();
        }

        private void btnModifierContrat_Click(object sender, RoutedEventArgs e)
        {
            int indice = cContrat.IndexOf((Contrat)dtgContrat.SelectedItem);
            cContrat.ElementAt(indice).LettreAccordContrat = txtLettreAccordContrat.Text;
            cContrat.ElementAt(indice).MontantBrutContrat = Int32.Parse(txtMontantBrutContrat.Text);
            cContrat.ElementAt(indice).MontantNetContrat = Int32.Parse(txtMontantNetContrat.Text);
            cContrat.ElementAt(indice).DeclarationAgessaContrat = chkAgessa.IsChecked.Value;
            cContrat.ElementAt(indice).FactureContrat = chkFacture.IsChecked.Value;
            cContrat.ElementAt(indice).EtatContrat = cboEtatContrat.SelectedIndex;
            cContrat.ElementAt(indice).PigisteContrat = (Pigiste)cboPigiste.SelectedItem;
            cContrat.ElementAt(indice).MagazineContrat = (Magazine)cboMagazine.SelectedItem;
            dtgContrat.Items.Refresh();
        }

        private void btnSupprimerContrat_Click(object sender, RoutedEventArgs e)
        {
            cContrat.Remove((Contrat)dtgContrat.SelectedItem);
            dtgContrat.SelectedIndex = 0;
            dtgContrat.Items.Refresh();
        }

        private void btnAjouterMagazine_Click(object sender, RoutedEventArgs e)
        {
            Magazine test = new Magazine(Convert.ToInt16(txtNumMagazine.Text),dtpBouclageMagazine.Text,dtpParutionMagazine.Text,dtpPaiementMagazine.Text,Convert.ToInt32(txtBudgetMagazine.Text));
            cMagazine.Add(test);
            dtgMagazine.Items.Refresh();
        }

        private void btnModifierMagazine_Click(object sender, RoutedEventArgs e)
        {
            //On recherche à quel indice de la collection se trouve l'object selectionné dans le datagrid
            int indice = cMagazine.IndexOf((Magazine)dtgMagazine.SelectedItem);

            // On change les propritétés de l'objet à l'indice trouvé. On ne change pas le numéro de magazine via l'interface, trop de risques d'erreurs en base de données
            cMagazine.ElementAt(indice).DateParutionMagazine = dtpParutionMagazine.Text;
            cMagazine.ElementAt(indice).DatePaiementMagazine = dtpPaiementMagazine.Text;
            cMagazine.ElementAt(indice).DateBouclageMagazine = dtpBouclageMagazine.Text;
            cMagazine.ElementAt(indice).BudgetMagazine = Convert.ToInt32(txtBudgetMagazine.Text);

            dtgMagazine.Items.Refresh();
        }

        private void btnSupprimerMagazine_Click(object sender, RoutedEventArgs e)
        {
            cMagazine.Remove((Magazine)dtgMagazine.SelectedItem);
            //On préselectionne par défaut le premier élément du Datagrid après la suppression
            dtgMagazine.SelectedIndex = 0;
            dtgMagazine.Items.Refresh();
        }

        private void btnAjouterPigiste_Click(object sender, RoutedEventArgs e)
        {
            Pigiste ajtpigiste = new Pigiste(Convert.ToInt32(txtNumPigiste.Text), txtNomPigiste.Text, txtPrenomPigiste.Text, txtAdressePigiste.Text, txtCPPigiste.Text, txtVillePigiste.Text, txtMailPigiste.Text, txtNumSecuPigiste.Text, txtContratCadrePigiste.Text);
            cPigiste.Add(ajtpigiste);
            dtgPigiste.Items.Refresh();
        }

        private void btnModifierPigiste_Click(object sender, RoutedEventArgs e)
        {
            //On recherche à quel indice de la collection se trouve l'object selectionné dans le datagrid
            int indice = cPigiste.IndexOf((Pigiste)dtgPigiste.SelectedItem);
            // On change les propritétés de l'objet à l'indice trouvé. On ne change pas le numéro de magazine via l'interface, trop de risques d'erreurs en base de données
            cPigiste.ElementAt(indice).NomPigiste = txtNomPigiste.Text;
            cPigiste.ElementAt(indice).PrenomPigiste = txtPrenomPigiste.Text;
            cPigiste.ElementAt(indice).AdressePigiste = txtAdressePigiste.Text;
            cPigiste.ElementAt(indice).CPPigiste = txtCPPigiste.Text;
            cPigiste.ElementAt(indice).VillePigiste = txtVillePigiste.Text;
            cPigiste.ElementAt(indice).MailPigiste = txtMailPigiste.Text;
            cPigiste.ElementAt(indice).NumSecuPigiste = txtNumSecuPigiste.Text;
            cPigiste.ElementAt(indice).ContratCadrePigiste = txtContratCadrePigiste.Text;
            dtgPigiste.Items.Refresh();




        }

        private void btnSupprimerPigiste_Click(object sender, RoutedEventArgs e)
        {
            cPigiste.Remove((Pigiste)dtgPigiste.SelectedItem);
            dtgPigiste.SelectedIndex = 0;
            dtgPigiste.Items.Refresh();
        }

        #endregion

        private void txtMontantNetContrat_TextChanged(object sender, TextChangedEventArgs e)
        {
           
                
            
            
        }

        private void txtMontantBrutContrat_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double brut = Convert.ToDouble(txtMontantBrutContrat.Text);
                double ss = brut * 0.011; 
                double csg = brut * 0.985 * 0.075;
                double crds = brut * 0.985 * 0.005;
                double fp = brut * 0.0035;
                double net = brut - Math.Floor(ss + csg + crds + fp);
                txtMontantNetContrat.Text = Convert.ToString(net);
            }
            catch { txtMontantNetContrat.Text = ""; }
        }
    }
        
}

//SelectionChanged="dtgMagazine_SelectionChanged" a mettre dans le xaml