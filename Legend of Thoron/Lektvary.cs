using System;
using System.Collections.Generic;
using System.Text;

namespace Legend_of_Thoron
{
    public class Lektvar
    {
        public Lektvar(string nazev, int aktualihp, int cenaitemu)
        {
            this.Nazev = nazev;
            this.AktualniHP = aktualihp;
            this.CenaItemu = cenaitemu;
        }

        public string Nazev { get; set; }
        public int AktualniHP { get; set; }
        public int CenaItemu { get; set; }
    }
    public class Lektvary
    {
        public Lektvar maly_lektvar = new Lektvar("Malý Lektvar", 5, 25);
        public Lektvar velky_lektvar = new Lektvar("Velký Lektvar", 15, 50);
        public Lektvar felix_felicis = new Lektvar("Felix Felicis", 25, 100);
        public Lektvar vyluh_z_ponozek = new Lektvar("Výluh Z Ponožek", 3, 5);
        public Lektvar okena = new Lektvar("Okena", 6, 10);
        public Lektvar stredni_lektvar = new Lektvar("Stredni Lektvar", 10, 35);
        public Lektvar neznama_tekutina = new Lektvar("Neznámá Tekutina", 18, 75);
        public Lektvar  modry_lektvar = new Lektvar("Modrý Lektvar", 12, 37);
        public Lektvar cerveny_lektvar = new Lektvar("Červený Lektvar", 16, 55);
        public Lektvar zlaty_lektvar = new Lektvar("Zlatý Lektvar", 20, 60);
        public Lektvary()
        { }
    }
}
