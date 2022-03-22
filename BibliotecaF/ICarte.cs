namespace proiectPIU.BibliotecaF
{
    public interface ICarte
    {

        string Denumire { get; set; }
        string Autor { get;  }
        int NumarPagini { get; set; }

        CategorieCarte Categoria { get; set; }
    }
}
