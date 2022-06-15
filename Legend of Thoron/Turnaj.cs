using System;
using System.Collections.Generic;
using System.Text;

namespace Legend_of_Thoron
{
    public class Turnaj
    {
        public Turnaj(Gladiator postava)
        {
            this.Gladiator = postava;
        }

        public Gladiator Gladiator { get; set; }
    }
}
