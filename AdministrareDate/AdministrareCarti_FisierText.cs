
namespace AdministrareDate {

    using System;
    using System.IO;
    using System.Configuration;
    using proiectPIU.BibliotecaF;

    public static class AdministrareCarti_FisierText {


        static AdministrareCarti_FisierText() {

            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);

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

            
            using(StreamWriter fisier = new StreamWriter(ConfigurationManager.AppSettings["NumeFisier"], true)) {

                fisier.WriteLine(denumire + ";" + autor + ";" + categorieText);
            }


        }

    }
}
