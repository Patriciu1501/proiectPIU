
namespace AdministrareDate {

    using System;
    using System.IO;
    using System.Configuration;
    using System.Collections.Generic;

    public static class AdministrareCarti_FisierText {


        private static string caleFisier = @"C:\Users\STUDENT\Source\Repos\Patriciu1501\proiectPIU\AdministrareDate\FisierCarti.txt";

        static AdministrareCarti_FisierText() {

            Stream streamFisierText = File.Open(caleFisier, FileMode.OpenOrCreate);

            streamFisierText.Close();

        }

        public static void AdaugareCarte() {

            string denumire = string.Empty;
            string autor = string.Empty;
            string categorieText = string.Empty;


            Console.Write("Denumire carte: ");
            denumire = Console.ReadLine();
            Console.Write("Autor: ");
            autor = Console.ReadLine();
            Console.Write("Categoria: ");
            categorieText = Console.ReadLine();

            
            using(StreamWriter fisier = new StreamWriter(caleFisier, true)) {

                fisier.WriteLine(denumire + ";" + autor + ";" + categorieText);
            }


        }


        public static List<string> GetFullDate()
        {
            var date = new List<string>();


            using (StreamReader fisier = new StreamReader(caleFisier))
            {
                while (!fisier.EndOfStream)
                {
                    date.Add(fisier.ReadLine());
                }
            }


            Console.WriteLine("Au fost preluate toate datele.");

            return date;
        }


        public static string getDateDupaAutor(string autor)
        {
            string linieDate = null;

            using (StreamReader fisier = new StreamReader(caleFisier))
            {
                while (!fisier.EndOfStream)
                {
                    string linieIntreaga = fisier.ReadLine();
                    string[] linieSeparata = linieIntreaga.Split(';');

                    if(linieSeparata[1] == autor)
                    {
                        linieDate = linieIntreaga;
                        break;
                    }


                }
            }

            if (linieDate == null)
            {
                Console.WriteLine("Nu s-a putut gasi");
                linieDate = "Not found";
            }
            else Console.WriteLine("Datele au fost preluate cu succes");


            return linieDate;

        }

    }

    
}
