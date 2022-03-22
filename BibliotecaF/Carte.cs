


namespace proiectPIU.BibliotecaF
{
    using System.Linq;
    public class Carte : ICarte
    {

        private string denumire;
        private string autor;
        private int numarPagini;
        private CategorieCarte categoria;



        public string Denumire { get => denumire; set => denumire = value; }
            
        
        public string Autor {

            get => autor;

            protected set {

                string[] valori = value.Split();

                bool hasDigit = false;

                for(int i = 0; i < value.Length; i++) {

                    if (char.IsDigit(value[i])) {

                        hasDigit = true;
                        break;
                    }
                }

                if(valori.Length != 2 || hasDigit) {

                    System.Console.WriteLine("A-ti introdus autor gresit pentru carte");
                    System.Console.Write("Introduce-ti numele corect: ");
                    string nume = System.Console.ReadLine();
                    Autor = nume;
                }

                autor = value;
            }
        }
        public int NumarPagini { get; set; }

        public CategorieCarte Categoria { get; set; }

        public Carte(string denumire, string autor, int numarPagini, CategorieCarte categorie) {

            this.Denumire = denumire;
            this.Autor = autor;
            this.NumarPagini = numarPagini;
            this.Categoria = categorie;
        }

    }
}
