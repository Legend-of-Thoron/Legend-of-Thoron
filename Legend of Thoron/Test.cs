﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Legend_of_Thoron
{
    public static class Test
    {
        public static void Run()
        {
            BrneniList brneni = new BrneniList();
            var hra = new Hra();
            Gladiator Gladiator = hra.Gladiator;
            Gladiator.SebratBrneni(brneni.roztrhane_hadry);
            Gladiator.SebratBrneni(brneni.obrneny_habit);
            hra.Zapnout();
        }
    }
}
