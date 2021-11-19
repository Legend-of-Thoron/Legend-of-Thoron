using System;
using System.Collections.Generic;
using System.Text;

namespace Legend_of_Thoron
{
    public static class Test
    {
        public static void Run()
        {

            var hrdina = new Hrdina();
            hrdina.Jmeno = "John Cena";
            hrdina.Sila = 999;
            hrdina.Obrana = 999;
            hrdina.ZakladniHP = 999;
            hrdina.AktualniHP = 999;
            hrdina.Zlataky = 999999999;

            var zbran = new Zbrane();


            hrdina.Statistiky();

            hrdina.SebratZbran(zbran.opotrebovany_mec);
            hrdina.SebratZbran(zbran.v_nova_sekera);

            hrdina.Inventar();

            hrdina.NasaditZbran(zbran.opotrebovany_mec);

            hrdina.Inventar();
        }
    }
}
