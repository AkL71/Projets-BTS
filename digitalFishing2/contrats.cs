using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digitalFishing2
{
    class contrats
    {
        #region private
        private int _NumCollaboration;
        private String _LettreAccordCollaboration;
        private int _EtatCollaboration;
        private bool _AgessaCollaboration;
        private bool _FactureCollaboration;
        private double _MontantCollaboration;
        private double _MontantNCollaboration;
        private String _DatePaiementCollaboration;
        private pigiste _PigisteContrats;
        private magazine _MagazineContrats;
        #endregion

        #region get/set
        public int NumCollaboration
        {
            get { return _NumCollaboration; }
            set { _NumCollaboration = value; }
        }

        public String LettreAccordCollaboration
        {
            get { return _LettreAccordCollaboration; }
            set { _LettreAccordCollaboration = value; }
        }

        public int EtatCollaboration
        {
            get { return _EtatCollaboration; }
            set { _EtatCollaboration = value; }
        }

        public bool AgessaCollaboration
        {
            get { return _AgessaCollaboration; }
            set { _AgessaCollaboration = value; }
        }

        public bool FactureCollaboration
        {
            get { return _FactureCollaboration; }
            set { _FactureCollaboration = value; }
        }

        public double MontantCollaboration
        {
            get { return _MontantCollaboration; }
            set { _MontantCollaboration = value; }
        }

        public double MontantNCollaboration
        {
            get { return _MontantNCollaboration; }
            set { _MontantNCollaboration = value; }
        }

        public String DatePaiementCollaboration
        {
            get { return _DatePaiementCollaboration; }
            set { _DatePaiementCollaboration = value; }
        }

        public pigiste PigisteContrats
        {
            get { return _PigisteContrats; }
            set { _PigisteContrats = value; }
        }


        public magazine MagazineContrats
        {
            get { return _MagazineContrats; }
            set { _MagazineContrats = value; }
        }
        #endregion

        #region constructeur
        public contrats(int nc, String lac,int ec, bool ac,bool fc,double mc,double mnc, String dpc , pigiste np , magazine nm)
        {
            this.NumCollaboration = nc;
            this.LettreAccordCollaboration = lac;
            this.EtatCollaboration = ec;
            this.AgessaCollaboration = ac;
            this.FactureCollaboration = fc;
            this.MontantCollaboration = mc;
            this.MontantNCollaboration = mnc;
            this.DatePaiementCollaboration = dpc;
            this.PigisteContrats = np;
            this.MagazineContrats = nm;
        }
        #endregion

        #region toString
        public String toString()
        {
            return String.Format("num collab :"+NumCollaboration+ "lettre accord collab : "+LettreAccordCollaboration+ "etat collab : "+EtatCollaboration+ "agessa collab : "+AgessaCollaboration+ "Facture Collaboration : "+ FactureCollaboration+ "Montant Collaboration : "+ MontantCollaboration+ "Montant N Collaboration : "+ MontantNCollaboration+ "Date Paiement Collaboration :"+ DatePaiementCollaboration+ "Num Pigiste : "+ PigisteContrats + "Num Magazine : "+ MagazineContrats);
        }
        #endregion
    }
}
