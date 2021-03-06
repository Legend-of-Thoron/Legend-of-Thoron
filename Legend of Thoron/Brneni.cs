using System;
using System.Collections.Generic;
using System.Text;

namespace Legend_of_Thoron
{
    public class Brneni
    {
        public Brneni(string nazev, int obrana, int cenaitemu)
        {
            this.Nazev = nazev;
            this.Obrana = obrana;
            this.CenaItemu = cenaitemu;
        }

        public string Nazev { get; set; }
        public int Obrana { get; set; }
        public int CenaItemu { get; set; }
    }
    public class BrneniList
    {
        public Brneni roztrhane_hadry = new Brneni("Roztrhané Hadry", 2, 5);
        public Brneni obrneny_habit = new Brneni("Obrněný Hábit", 5, 10);
        public Brneni kozene_hadry = new Brneni("Kožené Hadry", 3, 15);
        public Brneni zelezne_brneni = new Brneni("Železné Brnění", 8, 30);
        public Brneni zlata_zbroj = new Brneni("Zlatá Zbroj", 7, 50);
        public Brneni magicky_plast = new Brneni("Magický Plášť", 10, 75);
        public Brneni hornicky_oblek = new Brneni("Hornický Oblek", 2, 25);
        public Brneni uhelné_brneni = new Brneni("Uhelné Brnění", 6, 35);
        public Brneni titaniova_zbroj = new Brneni("Titániová Zbroj", 9, 100);
        public Brneni smradlve_trenky = new Brneni("Smradlavé Trenky", 1, 5);
        public BrneniList()
        { }
    }
}
