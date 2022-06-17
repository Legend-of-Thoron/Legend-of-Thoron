using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Legend_of_Thoron
{
    public class Gladiator
    {


        public Gladiator()
        {
            Console.WriteLine(" \\ Probíhá inicializace gladiátora... \n");

            this.BatohBrneni = new List<Brneni>();
            this.BatohZbrane = new List<Zbran>();
            this.BatohLektvary = new List<Lektvar>();
            this.Sila = 10;
            this.ZakladniSila = 10;
            this.Obrana = 10;
            this.ZakladniObrana = 10;
            this.ZakladniHP = 30;
            this.AktualniHP = 30;
            this.Zlataky = 0;
            this.PocetSouboju = 0;
            this.Zije = true;
            this.PocetTurnaju = 0;
        }

        // Vlastnosti naší třídy
        public string Jmeno { get; set; }
        public int Sila { get; set; }
        public int ZakladniSila { get; set; }
        public int Obrana { get; set; }
        public int ZakladniObrana { get; set; }
        public int ZakladniHP { get; set; }
        public int AktualniHP { get; set; }
        public int Zlataky { get; set; }
        public int PocetSouboju { get; set; }
        public bool Zije { get; set; }
        public int PocetTurnaju { get; set; }
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
                Console.Write(" - Pojmenuj svého gladiátora: ");
                this.Jmeno = Console.ReadLine();
                if (this.Jmeno == "King")
                {
                    this.ZakladniSila = 50;
                    this.ZakladniObrana = 50;
                    this.Sila = ZakladniSila;
                    this.Obrana = ZakladniObrana;
                }
            }

            Console.WriteLine(" \\ Gladiátor vytvořen... \n");
        }
        public void Statistiky()
        {
            Console.Clear();
            Console.WriteLine("\n ------ " + this.Jmeno + " ------");
            Console.WriteLine("  Síla: " + this.Sila);
            Console.WriteLine("  Obrana: " + this.Obrana);
            Console.WriteLine("  Životy: " + this.AktualniHP + "/" + this.ZakladniHP);
            Console.WriteLine("  Zlaťáky: " + this.Zlataky);
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("\n 9. Zpět do menu");
            Console.ReadKey();
        }
        public void SebratZbran(Zbran zbran)
        {
            this.BatohZbrane.Add(zbran);
            Console.WriteLine("\n ! Sebral jsi {0}.", zbran.Nazev);
        }
        public void SebratBrneni(Brneni brneni)
        {
            this.BatohBrneni.Add(brneni);
            Console.WriteLine("\n ! Sebral jsi {0}.", brneni.Nazev);
        }
        public void SebratLektvar(Lektvar lektvar)
        {
            this.BatohLektvary.Add(lektvar);
            Console.WriteLine("\n ! Sebral jsi {0}.", lektvar.Nazev);
        }
        public void ZahoditLektvar(Lektvar lektvar)
        {
            this.BatohLektvary.Remove(lektvar);
        }
        public void NasaditZbran()
        {
            Console.Write("\n - Vyber si předmět z inventáře nebo vyber 9 aby jsi se vrátil zpět: ");
            int vyber;
            if (int.TryParse(Console.ReadLine(), out vyber))
            {
                if ((vyber - 1) < this.BatohZbrane.Count)
                {
                    Zbran zbran = this.BatohZbrane[vyber - 1];

                    if (BatohZbrane.Contains(zbran))
                    {
                        this.NasazenaZbran = zbran;
                        this.Sila = this.ZakladniSila + zbran.Sila;
                        this.InventarZbrane();
                    } else
                        this.InventarZbrane();
                } else
                    this.InventarZbrane();
            } else
                this.InventarZbrane();
        }
        public void NasaditBrneni()
        {
            Console.Write("\n - Vyber si předmět z inventáře nebo vyber 9 aby jsi se vrátil zpět: ");
            int vyber;
            if (int.TryParse(Console.ReadLine(), out vyber))
            {
                if ((vyber - 1) < this.BatohBrneni.Count)
                {
                    Brneni brneni = this.BatohBrneni[vyber - 1];

                    if (BatohBrneni.Contains(brneni))
                    {
                        this.NasazeneBrneni = brneni;
                        this.Obrana = this.ZakladniObrana + brneni.Obrana;
                        this.InventarBrneni();
                    }
                    else
                        this.InventarBrneni();
                }
                else
                    this.InventarBrneni();
            }
            else
                this.InventarBrneni();
        }
        public void NasaditLektvar()
        {
            Console.Write("\n - Vyber si předmět z inventáře nebo vyber 9 aby jsi se vrátil zpět: ");
            int vyber;
            if (int.TryParse(Console.ReadLine(), out vyber))
            {
                if ((vyber - 1) < this.BatohLektvary.Count)
                {
                    Lektvar lektvar = this.BatohLektvary[vyber - 1];

                    if (BatohLektvary.Contains(lektvar))
                    {
                        this.NasazenyLektvar = lektvar;
                        this.AktualniHP = this.AktualniHP + lektvar.AktualniHP;
                        while (this.AktualniHP > this.ZakladniHP) {
                            int OdebratHP = this.AktualniHP - this.ZakladniHP;
                            this.AktualniHP -= OdebratHP;
                        }
                        this.ZahoditLektvar(lektvar);
                        this.InventarLektvary();
                    }
                    else
                        this.InventarLektvary();
                }
                else
                    this.InventarLektvary();
            }
            else
                this.InventarLektvary();
        }
        public void Inventar()
        {
            Console.Clear();
            Console.WriteLine("\n \\ Inventář");
            Console.WriteLine(" 1. Zbraně");
            Console.WriteLine(" 2. Brnění");
            Console.WriteLine(" 3. Lektvary");
            Console.WriteLine(" 9. Zpět do menu");
            var vyber = Console.ReadLine();
            if (vyber == "1")
            {
                this.InventarZbrane();
            }
            else if (vyber == "2")
            {
                this.InventarBrneni();
            }
            else if (vyber == "3")
            {
                this.InventarLektvary();
            }
        }
        public void InventarZbrane()
        {
            Console.Clear();
            int i = 1;
            Console.WriteLine("\n ------ Zbraně v inventáři ------ \n");
            if (!(this.BatohZbrane.Count! >= 1))
            {
                Console.WriteLine(" ! Nemáš žádné zbraně.");
                Console.WriteLine("\n -------------------------------- \n");
            } else
            {
                foreach (var z in this.BatohZbrane)
                {

                    if (this.NasazenaZbran == z)
                        Console.WriteLine(" {0}. {1} [+{2} Síly] (Nasazeno)", i, z.Nazev, z.Sila);
                    else
                        Console.WriteLine(" {0}. {1} [+{2} Síly]", i, z.Nazev, z.Sila);
                    i++;
                }
                Console.WriteLine("\n --------------------------------");
                Console.WriteLine("\n 1. Nasadit zbraň");
            }
            Console.WriteLine(" 9. Zpět do inventáře");
            var vyber = Console.ReadLine();
            if (vyber == "1" && this.BatohZbrane.Count! >= 1)
            {
                this.NasaditZbran();
                this.Inventar();
            } else
                this.Inventar();
        }
        public void InventarBrneni()
        {
            Console.Clear();
            int i = 1;
            Console.WriteLine("\n ------ Brnění v inventáři ------ \n");
            if (!(this.BatohBrneni.Count! >= 1))
            {
                Console.WriteLine(" ! Nemáš žádné brnění.");
                Console.WriteLine("\n -------------------------------- \n");
            }
            else
            {
                foreach (var b in this.BatohBrneni)
                {

                    if (this.NasazeneBrneni == b)
                        Console.WriteLine(" {0}. {1} [+{2} Obrany] (Nasazeno)", i, b.Nazev, b.Obrana);
                    else
                        Console.WriteLine(" {0}. {1} [+{2} Obrany]", i, b.Nazev, b.Obrana);
                    i++;
                }
                Console.WriteLine("\n --------------------------------");
                Console.WriteLine("\n 1. Nasadit brnění");
            }
            Console.WriteLine(" 9. Zpět do inventáře");
            var vyber = Console.ReadLine();
            if (vyber == "1" && this.BatohBrneni.Count! >= 1)
            {
                this.NasaditBrneni();
                this.Inventar();
            }
            else
                this.Inventar();
        }
        public void InventarLektvary()
        {
            Console.Clear();
            int i = 1;
            Console.WriteLine("\n ------ Lektvary v inventáři ------ \n");
            if (!(this.BatohLektvary.Count! >= 1))
            {
                Console.WriteLine(" ! Nemáš žádné lektvary.");
                Console.WriteLine("\n -------------------------------- \n");
            }
            else
            {
                foreach (var l in this.BatohLektvary)
                {

                    if (this.NasazenyLektvar == l)
                        Console.WriteLine(" {0}. {1} [+{2} Zivota] (Nasazeno)", i, l.Nazev, l.AktualniHP);
                    else
                        Console.WriteLine(" {0}. {1} [+{2} Zivota]", i, l.Nazev, l.AktualniHP);
                    i++;
                }
                Console.WriteLine("\n --------------------------------");
                Console.WriteLine("\n 1. Použít lektvar");
            }
            Console.WriteLine(" 9. Zpět do inventáře");
            var vyber = Console.ReadLine();
            if (vyber == "1" && this.BatohLektvary.Count! >= 1)
            {
                this.NasaditLektvar();
                this.Inventar();
            }
            else
                this.Inventar();
        }
    }
}
