using System;
using System.Collections.Generic;
using System.Text;

namespace Legend_of_Thoron
{
    public class Zbran
    {
        public Zbran(string nazev, int sila, int cenaitemu)
        {
            this.Nazev = nazev;
            this.Sila = sila;
            this.CenaItemu = cenaitemu;
        }

        public string Nazev { get; set; }
        public int Sila { get; set; }
        public int CenaItemu { get; set; }
    }
    public class Zbrane{
        public Zbran opotrebovany_mec = new Zbran("Opotřebovaný Meč", 1, 30);
        public Zbran v_nova_sekera = new Zbran("Velice Nová Sekera", 10, 100);
        public Zbrane()
        {}
    }
}

