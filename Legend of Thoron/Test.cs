using System;
using System.Collections.Generic;
using System.Text;

namespace Legend_of_Thoron
{
    public static class Test
    {
        public static void Run()
        {
            BrneniList brneni = new BrneniList();
            Lektvary lektvar = new Lektvary();
            var hra = new Hra();
            Gladiator Gladiator = hra.Gladiator;
            var souboj = new souboj(Gladiator);
            Console.WriteLine(" \\ Rozpoznána Testovací verze hry!");
            Gladiator.SebratBrneni(brneni.roztrhane_hadry);
            Gladiator.SebratBrneni(brneni.obrneny_habit);
            Gladiator.SebratLektvar(lektvar.velky_lektvar);
            hra.Zapnout();
        }
    }
}
