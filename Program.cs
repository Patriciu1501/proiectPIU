

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
            int studentProfesor;
            string nume = string.Empty;

            Console.WriteLine("Bine a-ti venit la biblioteca !");
            Console.WriteLine("Sunteti profesor(1) sau student(2)? ");
            Console.Write("Introduce-ti varianta(numarul):  ");
            try {

                studentProfesor = Console.Read() - 48;

                if (studentProfesor != 1 && studentProfesor != 2) 
                    throw new ArgumentException("Profesor sau Student: Varianta incorecta");
                

                Console.Write("Introduceti-va numele: ");
                nume = Console.ReadLine();

                





            } catch (ArgumentException arg) {

               

            }
            

            

            while (true) {



            }
            
            
        }
    }
}
