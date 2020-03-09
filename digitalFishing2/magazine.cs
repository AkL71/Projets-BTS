using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalFishing
{
    public class Magazine
    {
        #region Champs
        private int _numMagazine;
        private string _dateBouclageMagazine;
        private string _dateParutionMagazine;
        private string _datePaiementMagazine;
        private int _budgetMagazine;
        #endregion


        #region Constructeur
        public Magazine(int n, string db, string dp, string dpt, int b)
        {
            _numMagazine = n;
            _dateBouclageMagazine = db ;
            _dateParutionMagazine = dp ;
            _datePaiementMagazine = dpt;
            _budgetMagazine = b;
        }
        #endregion

        #region Accesseurs/Mutateurs
        public int NumMagazine
        {
            get { return _numMagazine; }
            set { _numMagazine = value; }
        }

        public string DateParutionMagazine
        {
            get { return _dateParutionMagazine; }
            set { _dateParutionMagazine = value; }
        }


        public string DateBouclageMagazine
        {
            get { return _dateBouclageMagazine; }
            set { _dateBouclageMagazine = value; }
        }

        public string DatePaiementMagazine
        {
            get { return _datePaiementMagazine; }
            set { _datePaiementMagazine = value; }
        }

        public int BudgetMagazine
        {
            get { return _budgetMagazine; }
            set { _budgetMagazine = value; }
        }
        #endregion


        #region Methodes
        public override string ToString()
        {
            // Méthode ToString() surchargée qui écrase la méthode ToString() de base
            return Convert.ToString(_numMagazine);
        }
        #endregion

    }
}
