
namespace proiectPIU.Persoane
{
    using System;

    public class Student:Persoana
    {
        private int medie;
        private bool integralist;


        public int Medie { get => medie; private set => medie = value; }
        public bool Integralist { get => integralist; private set => integralist = value; }


        public Student(string nume, string dataNasterii, int medie, bool integralist):base(nume, dataNasterii) {

            this.medie = medie;
            this.integralist = integralist;

        }

        public override void ImprumutaCarte(int durata, string categorie, string denumire="")
        {
            
        }

        public override void ReturneazaCarte()
        {
            throw new NotImplementedException();
        }
    }
}