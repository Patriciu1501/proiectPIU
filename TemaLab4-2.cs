

namespace proiectPIU {
    class TemaLab4_2
    {
        private string[][] cuvinte;

        TemaLab4_2(string[] argumente)
        {
            cuvinte = new string[26][];

            foreach (string cuvant in argumente)
            {
                cuvinte[(int) cuvant[0] - 48][cuvinte[(int) cuvant[0] - 48].Length] = cuvant;
            }

        }
    }
}
