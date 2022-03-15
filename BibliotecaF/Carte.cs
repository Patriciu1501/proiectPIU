
namespace proiectPIU.BibliotecaF
{
    public class Carte : ICarte
    {

        private string denumire;
        private string autor;
        private string editura;
        private int numarPagini;
        private CategorieCarte categoria;



        public string Denumire { get; set; }
        public string Autor { get; set; }
        public string Editura { get; set; }
        public int NumarPagini { get; set; }

        public CategorieCarte Categoria { get; set; }

    }
}
