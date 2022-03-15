
namespace proiectPIU.Persoane
{
    public interface IPersoana
    {
        string Nume { get; set; }
        string DataNasterii { get; }

        bool CardEliberat { get; set; }

        int CartiImprumutate { get; }

        void ImprumutaCarte(int durata, string categorie, string denumire);

        
    }
}
