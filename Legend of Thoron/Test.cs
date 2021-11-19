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

            var zbran = new Zbrane();

            int vyber;


            hrdina.Statistiky();

            hrdina.SebratZbran(zbran.opotrebovany_mec);

            hrdina.Inventar();
           
            hrdina.NasaditZbran();

            hrdina.Inventar();
        }
    }
}
