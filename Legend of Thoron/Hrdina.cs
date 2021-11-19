using System;
using System.Collections.Generic;
using System.Text;

namespace Legend_of_Thoron
{
    public class Hrdina
    {
        public Hrdina()
        {
            Console.WriteLine(" \\ Probíhá inicializace hrdiny... \n");

            this.BatohBrneni = new List<Brneni>();
            this.BatohZbrane = new List<Zbran>();
            this.BatohLektvary = new List<Lektvar>();
            this.Sila = 10;
            this.Obrana = 10;
            this.ZakladniHP = 30;
            this.AktualniHP = 30;
            this.Zlataky = 0;
        }

        // Vlastnosti naší třídy
        public string Jmeno { get; set; }
        public int Sila { get; set; }
        public int Obrana { get; set; }
        public int ZakladniHP { get; set; }
        public int AktualniHP { get; set; }
        public int Zlataky { get; set; }
        public Zbran NasazenaZbran { get; set; }
        public Brneni NasazeneBrneni { get; set; }
        public Lektvar NasazenyLektvar { get; set; }

        // TO-DO -
        public List<Brneni> BatohBrneni { get; set; }
        public List<Zbran> BatohZbrane { get; set; }
        public List<Lektvar> BatohLektvary { get; set; }

        // Metody naší třídy
        public void Vytvorit()
        {
            Console.WriteLine(" \\ Probíhá vytváření hrdiny...");
            while (String.IsNullOrWhiteSpace(this.Jmeno))
            {
                Console.Write(" - Pojmenuj svého hrdinu: ");
                this.Jmeno = Console.ReadLine();
                if(this.Jmeno == "King")
                {
                    this.Sila = 50;
                    this.Obrana = 50;
                }
            }

            Console.WriteLine(" \\ Hrdina vytvořen... \n");
        }
        public void Statistiky()
        {
            Console.WriteLine(" ------ " + this.Jmeno + " ------");
            Console.WriteLine("  Síla: " + this.Sila);
            Console.WriteLine("  Obrana: " + this.Obrana);
            Console.WriteLine("  Životy: " + this.AktualniHP + "/" + this.ZakladniHP);
            Console.WriteLine("  Zlaťáky: " + this.Zlataky);
        }
        public void SebratZbran(Zbran zbran)
        {
            this.BatohZbrane.Add(zbran);
            Console.WriteLine("\n ! Sebral jsi {0}.", zbran.Nazev);
        }
        public void ZahoditZbran(Zbran zbran)
        {
            this.BatohZbrane.Remove(zbran);
            Console.WriteLine("\n ! Zahodil jsi {0}.", zbran.Nazev);
        }
        public void NasaditZbran(Zbran zbran)
        {
            this.NasazenaZbran = zbran;
            Console.WriteLine("\n ! Zbraň {0} byla nasazena.", zbran.Nazev);
        }
            public void Inventar()
        {
            int i = 1;
            Console.WriteLine("\n ----------- INVENTÁŘ -----------");

            Console.WriteLine("\n ------ Zbraně v inventáři ------");
            if (this.BatohZbrane.Count! >= 1)
            {
                foreach (var predmet in this.BatohZbrane)
                {

                    if (this.NasazenaZbran == predmet)
                        Console.WriteLine(" {0}. {1} (Nasazeno)", i, predmet.Nazev);
                    else
                        Console.WriteLine(" {0}. {1}", i, predmet.Nazev);
                    i++;
                }
            }
            else
                Console.WriteLine(" ! Nemáš žádné zbraně.");

            i = 1;
            Console.WriteLine("\n ------ Brnění v inventáři ------");
            if (this.BatohBrneni.Count! >= 1)
            {
                foreach (var predmet in this.BatohBrneni)
                {

                    if (this.NasazeneBrneni == predmet)
                        Console.WriteLine(" {0}. {1} (Nasazeno)", i, predmet.Nazev);
                    else
                        Console.WriteLine(" {0}. {1}", i, predmet.Nazev);
                    i++;
                }
            }
            else
                Console.WriteLine(" ! Nemáš žádné brnění.");

            i = 1;
            Console.WriteLine("\n ------ Lektvary v inventáři ------");
            if (this.BatohLektvary.Count !>= 1)
            {
                foreach (var predmet in this.BatohLektvary)
                {
                    if (this.NasazenyLektvar == predmet)
                        Console.WriteLine(" {0}. {1} (Nasazeno)", i, predmet.Nazev);
                    else
                        Console.WriteLine(" {0}. {1}", i, predmet.Nazev);
                    i++;
                }
            } else
                Console.WriteLine(" ! Nemáš žádné lektvary.");
        }
    }
}
