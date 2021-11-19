using System;
using System.Collections.Generic;
using System.Text;

namespace Legend_of_Thoron
{
    public class Zbran
    {
        public Zbran(string nazev, int sila)
        {
            this.Nazev = nazev;
            this.Sila = sila;
        }

        public string Nazev { get; set; }
        public int Sila { get; set; }
    }
    public class Zbrane{
        public Zbran opotrebovany_mec = new Zbran("Opotřebovaný Meč", 1);
        public Zbran v_nova_sekera = new Zbran("Velice Nová Sekera", 10);
        public Zbrane()
        {}
    }
}

