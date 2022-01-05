using System;
using System.Collections.Generic;
using System.Text;

namespace Legend_of_Thoron
{
    public class Lektvar
    {
        public Lektvar(string nazev, int aktualihp)
        {
            this.Nazev = nazev;
            this.AktualniHP = aktualihp;
        }

        public string Nazev { get; set; }
        public int AktualniHP { get; set; }
    }
    public class Lektvary
    {
        public Lektvar maly_lektvar = new Lektvar("Malý Lektvar", 5);
        public Lektvar velky_lektvar = new Lektvar("Velký Lektvar", 25);
        //tvoje mamagfgfgfgfgfgfgf
        public Lektvary()
        { }
    }
}
