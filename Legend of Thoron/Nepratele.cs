using System.Collections.Generic;

namespace Legend_of_Thoron
{
    public class Nepratele : Gladiator
    {
        public Nepratele(string jmeno, int sila, int zakladniSila, int obrana, int zakladniObrana, int zakladniHP, int aktualniHP, int zlataky, Zbran zbran, Brneni brneni)
        {
            this.Jmeno = jmeno;
            this.Sila = sila;
            this.ZakladniSila = zakladniSila;
            this.Obrana = obrana;
            this.ZakladniObrana = zakladniObrana;
            this.ZakladniHP = zakladniHP;
            this.AktualniHP = aktualniHP;
            this.Zlataky = zlataky;
            this.Zbran = zbran;
            this.Brneni = brneni;
        }

        public string Jmeno { get; set; }
        public Zbran Zbran { get; set; }
        public Brneni Brneni { get; set; }
    }
}