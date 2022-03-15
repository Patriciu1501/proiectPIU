using System;

namespace proiectPIU.Persoane
{
    public abstract class Persoana:IPersoana
    {
        const string DEFAULT_NUME = "Neinitializat";
        const string DEFAULT_DATAN = "xx/xx/xxxx";
        const bool DEFAULT_CARD = false;

        protected string nume;
        protected readonly string dataNasterii;
        protected int cartiImprumutate;
        protected bool cardEliberat;

        public string Nume { get; set; }
        public string DataNasterii
        {
            get
            {
                return dataNasterii;
            }
        }
               
        public int CartiImprumutate
        {
            get
            {
                return cartiImprumutate;
            }

            protected set
            {
                cartiImprumutate += value;
            }
        }

        public bool CardEliberat
        {
            get
            {
                return cardEliberat;
            }

            set
            {
                cardEliberat = value;
            }
        }


        protected Persoana(string nume=DEFAULT_NUME, string dataNasterii=DEFAULT_DATAN, bool card=DEFAULT_CARD)
        {
            this.Nume = nume;
            this.dataNasterii = dataNasterii;
        }


        public abstract void ImprumutaCarte(int durata, string caregorie, string denumire);
        


    }
}
