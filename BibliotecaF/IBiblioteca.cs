
namespace proiectPIU.BibliotecaF
{
    using Persoane;

    public interface IBiblioteca
    {
        Bibliotecar Personal { get; }

        int OraDeschidere { get; }
        int OraInchidere { get; }
        bool BibliotecaDeschisa { get; }
    }
}
