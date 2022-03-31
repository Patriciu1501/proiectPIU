

namespace AdministrareDate
{
    using System;
    using System.IO;
    using System.Configuration;
    using System.Collections.Generic;

    public static class AdministrarePersoane_FisierText
    {
        private const string numeFisier = "Persoane.txt";

        static AdministrarePersoane_FisierText()
        {

            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);

            streamFisierText.Close();
        }

        public static void AdaugarePersoana()
        {
            string numeComplet = string.Empty;
            string studentProfesor = string.Empty;
            string dataNasterii = string.Empty;
            int numarCartiImprumutate = 0;


            using (StreamWriter fisier = new StreamWriter(numeFisier, true)) {

                fisier.WriteLine(numeComplet + ";" + dataNasterii + ";" + studentProfesor + ";" + numarCartiImprumutate);
            }
        }

        public static List<string> GetFullDate()
        {
            var date = new List<string>();


            using (StreamReader fisier = new StreamReader(numeFisier))
            {
                while (!fisier.EndOfStream)
                {
                    date.Add(fisier.ReadLine());
                }
            }



            return date;
        }



        public static string getDateDupaNume(string nume)
        {
            string linieDate = null;

            using (StreamReader fisier = new StreamReader(numeFisier))
            {
                while (!fisier.EndOfStream)
                {
                    string linieIntreaga = fisier.ReadLine();
                    string[] linieSeparata = linieIntreaga.Split(';');

                    if (linieSeparata[0] == nume)
                    {
                        linieDate = linieIntreaga;
                        break;
                    }


                }
            }

            if(linieDate == null)
            {
                Console.WriteLine("Nu s-a putut gasi");
                linieDate = "Not found";
            }
            else Console.WriteLine("Datele au fost preluate cu succes");


            return linieDate;

        }


}
}
