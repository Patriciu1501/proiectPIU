

namespace proiectPIU.Persoane
{
    public abstract class Persoana:IPersoana
    {
        const string DEFAULT_NUME = "Neinitializat";
        const string DEFAULT_DATAN = "Neinitializat";
        const bool DEFAULT_CARD = false;

        protected string nume;
        protected readonly string dataNasterii;
        protected int cartiImprumutate;
        protected bool cardEliberat;

        public string Nume
        {
            get
            {
                return nume;
            }

            protected set
            {
                nume = value;
            }
        }
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

            protected set
            {
                cardEliberat = value;
            }
        }


        protected Persoana(string nume=DEFAULT_NUME, string dataNasterii=DEFAULT_DATAN, bool card=DEFAULT_CARD)
        {
            this.Nume = nume;
            this.dataNasterii = dataNasterii;
        }

        public override string ToString()
        {
            return Nume;
        }

        public abstract void ImprumutaCarte(int durata, string caregorie, string denumire);
        public abstract void ReturneazaCarte();


    }
}