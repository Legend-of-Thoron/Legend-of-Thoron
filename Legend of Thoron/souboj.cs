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
            int b = 2; //b tells how many times a new letter has been added. It's 2 right now because the first two letters are already in the name.
            while (b < len)
            {
                Name += consonants[r.Next(consonants.Length)];
                b++;
                Name += vowels[r.Next(vowels.Length)];
                b++;
            }

            return Name;
        }
        public souboj()
        {
            Zbrane zbrane = new Zbrane();
            List<Zbran> zbraneList = new List<Zbran>();
            zbraneList.Add(zbrane.opotrebovany_mec);
            
            BrneniList brneni = new BrneniList();
            List<Brneni> brneniList = new List<Brneni>();
            brneniList.Add(brneni.kozene_hadry);
            
            //TODO: random generator statistik nepřítele, odvozené od postavy.
            nepritel = new Nepratele(this.namegen(10), 1, 1, 1, 1, 1, 1, 2, zbraneList[0], brneniList[0]);
            
            Console.WriteLine(nepritel.Jmeno);
        }
        
        public Nepratele nepritel;
    }
}