
namespace proiectPIU.BibliotecaF
{

 

    public interface IBiblioteca
    {
        Bibliotecar Personal { get; set; }
        int OraDeschidere { get; }
        int OraInchidere { get; }
        bool BibliotecaDeschisa { get; }
    }
}
