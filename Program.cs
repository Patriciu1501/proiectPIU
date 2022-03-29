

namespace proiectPIU
{
    using System;
    using System.Linq;
    using Persoane;
    using BibliotecaF;
    using AdministrareDate;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {

            int mod = 0;

            Console.WriteLine("1. Lansati aplicatie biblioteca");
            Console.WriteLine("2. Accesare optiuni administrator");
            Console.Write("=> ");

            if(int.TryParse(Console.ReadLine(), out int optiune)) {

                if(optiune != 1 && optiune != 2) {

                    Console.WriteLine("Varianta gresita.");
                    Console.WriteLine("S-a ales automat prima optiune.");
                    optiune = 1;
                    
                }
            }
            
            else{

                Console.WriteLine("Varianta gresita.");
                Console.WriteLine("S-a ales automat prima optiune."); 
                optiune = 1;
            }

            if(optiune == 2) {

                #region MENU_ADMINISTRATOR

                while (true) {

                    Console.WriteLine("\n1.Administrare carti");
                    Console.WriteLine("2.Administrare persoane");
                    Console.Write("=> ");

                    char valoare = (char)Console.Read();

                    switch (valoare) {

                        case '1':

                            List<string> dateCarti = null;
                            string dateDupaAutor = null;
                            string valoare2 = null;
                            bool inapoi = false;


                            while (true)
                            {
                                if (inapoi == true) break;
                                

                                Console.WriteLine("\n1. Adaugare carte");
                                Console.WriteLine("2. Citire intreg fisier");
                                Console.WriteLine("3.Cautare dupa autor");
                                Console.WriteLine("4.Afisare date preluate dupa autor");
                                Console.WriteLine("5.Afisare continut fisier");
                                Console.WriteLine("6. Inapoi");
                                Console.Write("=> ");

                                
                                valoare2 = Console.ReadLine();
                                valoare2 = Console.ReadLine();
                               
                                

                                switch (valoare2)
                                {

                                    case "1":
                                        AdministrareCarti_FisierText.AdaugareCarte();
                                        break;
                                    case "2":
                                        dateCarti = AdministrareCarti_FisierText.GetFullDate();
                                        break;
                                    case "3":
                                        Console.Write("Introduce-ti numele complet al autorului: ");
                                        string autor = Console.ReadLine();
                                        dateDupaAutor = AdministrareCarti_FisierText.getDateDupaAutor(autor);
                                        break;

                                    case "4":
                                        if (dateDupaAutor == null)
                                        {
                                            Console.WriteLine("Datele inca nu au fost citite");
                                        }

                                        else Console.WriteLine(dateDupaAutor);
                                        break;

                                    case "5":
                                        if (dateCarti == null) Console.WriteLine("Datele inca nu au fost preluate");
                                        else
                                        {
                                            foreach (string i in dateCarti) Console.WriteLine(i);
                                        }

                                        break;

                                    case "6": inapoi = true; break;

                                    default:
                                        Console.WriteLine("Optioune invalida");
                                        break;

                                }
                            }

                            break;

                        case '2':

                            List<string> datePersoane = null;
                            string dateDupaNume = null;
                            string valoare3 = null;
                            bool inapoi2 = false;

                            while (true)
                            {

                                if (inapoi2 == true) break;

                                Console.WriteLine("\n1. Adaugare persoane");
                                Console.WriteLine("2. Citire intreg fisier");
                                Console.WriteLine("3.Cautare dupa nume");
                                Console.WriteLine("4.Afisare date preluate dupa nume");
                                Console.WriteLine("5.Afisare continut fisier");
                                Console.WriteLine("6.Inapoi");
                                Console.Write("=> ");

                                valoare3 = Console.ReadLine();
                                valoare3 = Console.ReadLine();


                                switch (valoare3)
                                {

                                    case "1":
                                        AdministrarePersoane_FisierText.AdaugarePersoana();
                                        break;
                                    case "2":
                                        datePersoane = AdministrarePersoane_FisierText.GetFullDate();
                                        break;
                                    case "3":
                                        Console.Write("Introducde-ti numele complet: ");
                                        string numeComplet = Console.ReadLine();
                                        dateDupaNume = AdministrarePersoane_FisierText.getDateDupaNume(numeComplet);
                                        break;
                                    case "4":

                                        if (dateDupaNume == null)
                                        {
                                            Console.WriteLine("Datele inca nu au fost citite");
                                        }

                                        else Console.WriteLine(dateDupaNume);
                                        break;

                                    case "5":
                                        if (datePersoane == null)
                                        {
                                            Console.WriteLine("Datele inca nu au fost preluate");
                                        }

                                        else foreach (string i in datePersoane) Console.WriteLine(i);

                                        break;

                                    case "6": inapoi2 = true; break;

                                    default:
                                        Console.WriteLine("Optioune invalida");
                                        break;

                                }
                            }
                            break;


                        default:
                            Console.WriteLine("Optiune invalida");
                            break;
                    }
                }

                #endregion
            }
            

            int studentProfesor = 0;
            string nume = string.Empty;
            
            Console.WriteLine("Bine a-ti venit la biblioteca!");
            Console.WriteLine("Sunteti profesor(1) sau student(2)? ");
            Console.Write("Introduce-ti varianta(numarul):  ");
           
            while(studentProfesor != 1 && studentProfesor != 2) {

                if(int.TryParse(Console.ReadLine(), out int rezultat)) {

                    if(rezultat != 1 && rezultat != 2) {

                        Console.WriteLine("Varianta gresita =>");
                        Console.WriteLine("A-ti fost setat automat student");
                        studentProfesor = 1;
                    }

                    else studentProfesor = rezultat;
                } 
                
                else {

                    Console.WriteLine("Varianta gresita =>");
                    Console.WriteLine("A-ti fost setat automat student");
                    studentProfesor = 1;
                }

            }
            

            #region MENU_BIBLIOTECA

            // MENU-biblioteca
            // in developing

            #endregion

     
            
        }
    }
}
