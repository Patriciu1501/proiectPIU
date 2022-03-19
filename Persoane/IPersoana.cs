
namespace proiectPIU.Persoane
{
    public interface IPersoana
    {
        string Nume { get; }
        string DataNasterii { get; }

        bool CardEliberat { get; }
        bool Student { get; }
        bool Elev { get; }
        bool Profesor { get; }

        int CartiImprumutate { get; }

        void ImprumutaCarte(int durata, string categorie, string denumire);
        void ReturneazaCarte();

        
    }
}
