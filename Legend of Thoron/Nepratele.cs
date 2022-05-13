using System.Collections.Generic;

namespace Legend_of_Thoron
{
    public class Nepratele : Gladiator
    {
        public Nepratele(string jmeno, int sila, int obrana, int zakladniHP, int aktualniHP, int zlataky)
        {
            this.Jmeno = jmeno;
            this.Sila = sila;
            this.Obrana = obrana;
            this.ZakladniHP = zakladniHP;
            this.AktualniHP = aktualniHP;
            this.Zlataky = zlataky;
        }

        public string Jmeno { get; set; }
    }
}