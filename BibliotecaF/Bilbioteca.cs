
namespace proiectPIU.BibliotecaF
{
    using proiectPIU.Persoane;
    using System;
    using System.Globalization;


    public class Biblioteca : IBiblioteca
    {

        private const int oraDeschidere = 8;
        private const int oraInchidere = 16;

        private Bibliotecar personal;
        private readonly bool bibliotecaDeschisa;

        public int OraDeschidere
        {
            get
            {
                return oraDeschidere;
            }
        }

        public int OraInchidere
        {
            get
            {
                return oraInchidere;
            }
        }

        public bool BibliotecaDeschisa
        {
            get
            {
                return bibliotecaDeschisa;
            }
        }

        public Bibliotecar Personal
        {
            get
            {
                return personal;
            }
        }

        public Biblioteca()
        {
            string ziuaCurenta = DateTime.Now.DayOfWeek.ToString();
            int oraCurenta = DateTime.Now.Hour;

            bibliotecaDeschisa = true;

            if (ziuaCurenta == "Saturday" || ziuaCurenta == "Sunday") bibliotecaDeschisa = false;

            if (!(oraCurenta >= 8 && oraCurenta <= 16)) bibliotecaDeschisa = false;




        }

    }
}
