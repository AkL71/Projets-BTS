using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalFishing
{
    public class Contrat
    {
        #region Champs
        private int _numContrat;
        private string _lettreAccordContrat;
        private double _montantBrutContrat;
        private double _montantNetContrat;
        private bool _declarationAgessaContrat;
        private bool _factureContrat;
        private int _etatContrat;
        private Pigiste _pigisteContrat;
        private Magazine _magazineContrat;
        #endregion


        #region Constructeurs

        public Contrat(int n, string la, double mtb, double mtn, bool d, bool f, int e, Pigiste p, Magazine m)
        {
            _numContrat = n;
            _lettreAccordContrat = la;
            _montantBrutContrat = mtb;
            _montantNetContrat = mtn;
            _declarationAgessaContrat = d;
            _factureContrat = f;
            _etatContrat = e;
            _pigisteContrat = p;
            _magazineContrat = m;
        }

        
        public Contrat(int n, double mtb, double mtn, bool d, bool f, int e, Pigiste p, Magazine m)
        {
            _numContrat = n;
            _lettreAccordContrat = "1m2p-la-" + m.NumMagazine + "-" + p.NumPigiste;
            _montantBrutContrat = mtb;
            _montantNetContrat = mtn;
            _declarationAgessaContrat = d;
            _factureContrat = f;
            _etatContrat = e;
            _pigisteContrat = p;
            _magazineContrat = m;
        }
        #endregion


        #region Accesseurs/Mutateurs
        public int NumContrat
        {
            get { return _numContrat; }
            set { _numContrat = value; }
        }

        public string LettreAccordContrat
        {
            get { return _lettreAccordContrat; }
            set { _lettreAccordContrat = value; }
        }
        public double MontantBrutContrat
        {
            get { return _montantBrutContrat; }
            set { _montantBrutContrat = value; }
        }

        public double MontantNetContrat
        {
            get { return _montantNetContrat; }
            set { _montantNetContrat = value; }
        }

        public bool DeclarationAgessaContrat
        {
            get { return _declarationAgessaContrat; }
            set { _declarationAgessaContrat = value; }
        }
        public bool FactureContrat
        {
            get { return _factureContrat; }
            set { _factureContrat = value; }
        }
        public int EtatContrat
        {
            get { return _etatContrat; }
            set { _etatContrat = value; }
        }

        public Pigiste PigisteContrat
        {
            get { return _pigisteContrat; }
            set { _pigisteContrat = value; }
        }


        public Magazine MagazineContrat
        {
            get { return _magazineContrat; }
            set { _magazineContrat = value; }
        }
        #endregion

        #region Methodes

        #endregion
    }
}
