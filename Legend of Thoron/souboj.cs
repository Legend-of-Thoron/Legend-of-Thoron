using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Legend_of_Thoron
{
    public class souboj
    {
        public string namegen(int len)
        {
            Random r = new Random();
            string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "l", "n", "p", "q", "r", "s", "sh", "zh", "t", "v", "w", "x" };
            string[] vowels = { "a", "e", "i", "o", "u", "ae", "y" };
            string Name = "";
            Name += consonants[r.Next(consonants.Length)].ToUpper();
            Name += vowels[r.Next(vowels.Length)];
            int b = 2;
            while (b < len)
            {
                Name += consonants[r.Next(consonants.Length)];
                b++;
                Name += vowels[r.Next(vowels.Length)];
                b++;
            }

            return Name;
        }
        public souboj(Gladiator postava)
        {
            Zbrane zbrane = new Zbrane();
            List<Zbran> zbraneList = new List<Zbran>();
            zbraneList.Add(zbrane.opotrebovany_mec);
            
            BrneniList brneni = new BrneniList();
            List<Brneni> brneniList = new List<Brneni>();
            brneniList.Add(brneni.kozene_hadry);
            var zivoty = new Random().Next(postava.ZakladniHP-2, postava.ZakladniHP+2);
            
            //TODO: none
            nepritel = new Nepratele(this.namegen(6), new Random().Next(postava.Sila-2, postava.Sila+2), new Random().Next(postava.Obrana-2, postava.Obrana+2), zivoty, zivoty, new Random().Next(postava.Sila-(postava.Sila*2), postava.Sila+(postava.Sila*2)));
            
            Console.WriteLine(nepritel.Jmeno);
            Console.WriteLine(nepritel.Sila);
            Console.WriteLine(nepritel.Obrana);
            Console.WriteLine(nepritel.ZakladniHP);
            Console.WriteLine(nepritel.Zlataky);
        }
        
        public Nepratele nepritel;
    }
}