using System;
using System.Collections.Generic;
using System.Text;

namespace Legend_of_Thoron
{
    public class Brneni
    {
        public Brneni(string nazev, int obrana)
        {
            this.Nazev = nazev;
            this.Obrana = obrana;
        }

        public string Nazev { get; set; }
        public int Obrana { get; set; }
    }
    public class BrneniList
    {
        public Brneni roztrhane_hadry = new Brneni("Roztrhané Hadry", 1);
        public Brneni obrneny_habit = new Brneni("Obrněný Hábit", 10);
        public BrneniList()
        { }
    }
}
