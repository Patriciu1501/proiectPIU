
namespace proiectPIU.Persoane
{
    public interface IPersoana
    {
        string Nume { get; }
        string DataNasterii { get; }


        int CartiImprumutate { get; }

        void ImprumutaCarte(int durata, string categorie, string denumire);
        void ReturneazaCarte();

        
    }
}
