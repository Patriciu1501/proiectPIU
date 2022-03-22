﻿
namespace proiectPIU.Persoane
{
    using System;
    using BibliotecaF;

    public class Bibliotecar : Persoana {



        public Bibliotecar(string nume, string dataNasterii):base(nume, dataNasterii) {

        }


        public override void ImprumutaCarte(int durata, string categorie, string denumire = "")
        {
            
        }

        public override void ReturneazaCarte()
        {
            throw new NotImplementedException();
        }


        public void AdaugareCarte(Carte carte) {

            Biblioteca.carti.Add(carte);

            Biblioteca.OnModificareNumarCarti?.Invoke();
        }
    }
}

