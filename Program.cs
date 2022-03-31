

namespace proiectPIU
{
    using System;
    using System.Collections.Generic;

    using AdministrareDate;
    using Persoane;
    using BibliotecaF;

    class Program
    {


        static void Main(string[] args)
        {

            int mod = 0;
            bool inapoiMainMenu;

            while (true) {

                inapoiMainMenu = false; // la aparitie/revenire in main-menu se reseteaza variabila la valoarea initiala(false)
                                        // altfel, nu voi putea intra in (2), se va considera de fiecare data ca se doreste iesirea in main-menu

                Console.WriteLine("\n1. Lansati aplicatie biblioteca");
                Console.WriteLine("2. Accesare optiuni administrator");
                Console.WriteLine("3. Iesire din program");
                Console.Write("=> ");

                bool parsareReusita = int.TryParse(Console.ReadLine(), out int optiune);
                Console.Clear();

                if (parsareReusita) {

                    if (optiune != 1 && optiune != 2 && optiune != 3) {

                        Console.WriteLine("Varianta gresita.");
                        Console.WriteLine("S-a ales automat a doua optiune.");
                        optiune = 2;

                    }
                }

                else {

                    Console.WriteLine("Varianta gresita.");
                    Console.WriteLine("S-a ales automat prima optiune.");
                    optiune = 1;
                }


                if (optiune == 3) {

                    Console.WriteLine("S-a iesit din program");
                    return;
                }

                else if (optiune == 2) {

                    #region MENU_ADMINISTRATOR


                    while (true) {

                        if (inapoiMainMenu == true) break;

                        Console.WriteLine("\n1. Administrare carti");
                        Console.WriteLine("2. Administrare persoane");
                        Console.WriteLine("3. *Tema Lab4-2");
                        Console.WriteLine("4. Inapoi");
                        Console.Write("=> ");

                        string valoare = Console.ReadLine();
                        Console.Clear();

                        switch (valoare) {

                            case "1":

                                List<string> dateCarti = null;
                                string dateDupaAutor = null;
                                string valoare2 = null;
                                bool inapoi = false;


                                while (true) {
                                    if (inapoi == true) break;


                                    Console.WriteLine("\n1. Adaugare carte");
                                    Console.WriteLine("2. Citire intreg fisier");
                                    Console.WriteLine("3. Cautare dupa autor");
                                    Console.WriteLine("4. Afisare date preluate dupa autor");
                                    Console.WriteLine("5. Afisare continut fisier");
                                    Console.WriteLine("6. Inapoi");
                                    Console.Write("=> ");


                                    valoare2 = Console.ReadLine();
                                    Console.Clear();


                                    switch (valoare2) {

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
                                            if (dateDupaAutor == null) {
                                                Console.WriteLine("Datele inca nu au fost citite");
                                            }

                                            else Console.WriteLine(dateDupaAutor);

                                            break;

                                        case "5":
                                            if (dateCarti == null) Console.WriteLine("Datele inca nu au fost preluate");
                                            else
                                                foreach (string i in dateCarti)
                                                    Console.WriteLine(i);

                                            break;

                                        case "6":
                                            inapoi = true;
                                            break;

                                        default:
                                            Console.WriteLine("Optiune invalida");
                                            break;

                                    }
                                }

                                break;

                            case "2":

                                List<string> datePersoane = null;
                                string dateDupaNume = null;
                                string valoare3 = null;
                                bool inapoi2 = false;

                                while (true) {

                                    if (inapoi2 == true) break;

                                    Console.WriteLine("\n1. Adaugare persoane");
                                    Console.WriteLine("2. Citire intreg fisier");
                                    Console.WriteLine("3. Cautare dupa nume");
                                    Console.WriteLine("4. Afisare date preluate dupa nume");
                                    Console.WriteLine("5. Afisare continut fisier");
                                    Console.WriteLine("6. Inapoi");
                                    Console.Write("=> ");

                                    valoare3 = Console.ReadLine();
                                    Console.Clear();


                                    switch (valoare3) {

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

                                            if (dateDupaNume == null) {
                                                Console.WriteLine("Datele inca nu au fost citite");
                                            }

                                            else Console.WriteLine(dateDupaNume);

                                            break;

                                        case "5":
                                            if (datePersoane == null) {
                                                Console.WriteLine("Datele inca nu au fost preluate");
                                            }

                                            else
                                                foreach (string i in datePersoane)
                                                    Console.WriteLine(i);

                                            break;

                                        case "6":
                                            inapoi2 = true;
                                            break;

                                        default:
                                            Console.WriteLine("Valoare invalida");
                                            break;

                                    }
                                }

                                break;

                            case "3":
                                TemaLab4_2 kek = new TemaLab4_2(args);
                                break;


                            case "4":
                                inapoiMainMenu = true;
                                break;


                            default:
                                Console.WriteLine("Optiune invalida");
                                break;
                        }
                    }

                    #endregion
                }

                else if (optiune == 1) {
                    #region MENU_BIBLIOTECA

                    int studentProfesor = 0;
                    string nume = string.Empty;

                    Console.WriteLine("Bine a-ti venit la biblioteca!");
                    Console.WriteLine("Sunteti profesor(1) sau student(2)? ");
                    Console.Write("Introduce-ti varianta(numarul):  ");

                    while (studentProfesor != 1 && studentProfesor != 2) {

                        if (int.TryParse(Console.ReadLine(), out int rezultat)) {

                            if (rezultat != 1 && rezultat != 2) {

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




                    // MENU-biblioteca
                    // in developing

                    #endregion
                }

            }

        }
    }
}
