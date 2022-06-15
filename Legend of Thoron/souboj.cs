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
            

            var zivoty = new Random().Next(postava.ZakladniHP-2, postava.ZakladniHP+2);
            
            //TODO: none
            nepritel = new Nepratele(this.namegen(6), new Random().Next(postava.Sila-2, postava.Sila+2), new Random().Next(postava.Obrana-2, postava.Obrana+2), zivoty, zivoty, new Random().Next(postava.Sila-(postava.Sila*2), postava.Sila+(postava.Sila*2)));

            //Console.WriteLine(nepritel.Jmeno);
            //Console.WriteLine(nepritel.Sila);
            //Console.WriteLine(nepritel.Obrana);
            //Console.WriteLine(nepritel.ZakladniHP);
            //Console.WriteLine(nepritel.Zlataky);

            Console.WriteLine("Souboj zaèal!");
            Console.WriteLine();

            int b = postava.ZakladniHP + postava.Obrana; // hp hrace
            int c = zivoty + nepritel.Obrana; // hp enemy
            int d = 0;
            int e = 0;
            Console.Clear();
            while (b<=postava.AktualniHP || c<=zivoty)
            {
                d = b;
                e = c;

                b -= nepritel.Sila;
                c -= postava.Sila;

                Console.WriteLine("Vaše HP: "+ postava.AktualniHP+postava.Obrana + " / " + postava.ZakladniHP);
                Console.WriteLine("Protivníkovy HP: " + zivoty);
                
            }
            Console.Clear();
            if (d < b)
            {
                Console.WriteLine("Byl jsi poražen!");
                postava.Zlataky -= nepritel.Zlataky / 2;
            }
            else if (e < c)
            {
                Console.WriteLine("Vyhrál jsi!");
                postava.PocetSouboju++;
                postava.Zlataky += nepritel.Zlataky;
            }


           
            












        }
        
        public Nepratele nepritel;
        
    }
}