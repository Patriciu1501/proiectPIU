

namespace proiectPIU
{
    using System;
    using System.Linq;
    using Persoane;
    using BibliotecaF;
    

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

                    Console.WriteLine("1.Administrare carti");
                    Console.WriteLine("2.Administrare persoane");

                    switch (Console.ReadKey().KeyChar) {

                        case '1':

                            break;

                        case '2':
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
