namespace proiectPIU.BibliotecaF
{
    public interface ICarte
    {

        string Denumire { get; set; }
        string Autor { get; set; }
        string Editura { get; set; }
        int NumarPagini { get; set; }

        CategorieCarte Categoria { get; set; }
    }
}
