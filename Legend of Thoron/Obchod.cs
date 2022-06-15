using System;
using System.Collections.Generic;
using System.Text;

namespace Legend_of_Thoron
{
    public class Obchod
    {
        public List<Brneni> BatohBrneni { get; set; }
        public List<Zbran> BatohZbrane { get; set; }
        public List<Lektvar> BatohLektvary { get; set; }
        public Gladiator Gladiator { get; set; }
        public int Zlataky { get; set; }
        public Zbran NasazenaZbran { get; set; }
        public Brneni NasazeneBrneni { get; set; }
        public Lektvar NasazenyLektvar { get; set; }
        public Obchod(Gladiator gladiator)
        {
            Gladiator = gladiator;
        }

        List<Zbran> RandomZbrane = new List<Zbran>();
        List<Lektvar> RandomLektvary = new List<Lektvar>();
        List<Brneni> RandomBrneni = new List<Brneni>();



        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("\n \\ Obchod");
            Console.WriteLine(" 1. Nakoupit");
            Console.WriteLine(" 2. Prodat");
            Console.WriteLine(" 9. Zpět do menu");
            var vyber = Console.ReadLine();
            if (vyber == "1")
            {
                this.NakupZbrani();
            }
            else if (vyber == "2")
            {
                this.ProdejZbrani();
            }
        }

        //Nakupovani

        public void NakupZbrani()
        {
            Console.Clear();
            Console.WriteLine("\n \\ Obchod");
            Console.WriteLine(" 1. Nakoupit Zbraňe");
            Console.WriteLine(" 2. Nakoupit Brnění");
            Console.WriteLine(" 3. Nakoupit Lektvary");
            Console.WriteLine(" 9. Zpět");
            var vyber = Console.ReadLine();
            if (vyber == "1")
            {
                this.NakupZbrane();
            }
            else if (vyber == "2")
            {
                this.NakupBrneni();
            }
            else if (vyber == "3")
            {
                this.NakupLektvaru();
            }
        }

        public void NakupZbrane()
        {

            Console.Write("\n - Vyber si předmět z obchodu nebo vyber 9 aby jsi se vrátil zpět: ");
            int vyber;
            if (int.TryParse(Console.ReadLine(), out vyber))
            {
                if ((vyber - 1) < 6)
                {
                    Zbran zbran = this.RandomZbrane[vyber - 1];

                    if (RandomZbrane.Contains(zbran) && Zlataky >= this.RandomBrneni[vyber - 1].CenaItemu)
                    {
                        Gladiator.BatohZbrane.Add(zbran);
                        Gladiator.Zlataky = Gladiator.Zlataky - this.RandomBrneni[vyber - 1].CenaItemu;
                        this.NakupZbrane();
                    }
                    else
                        this.NakupZbrane();
                }
                else
                    this.NakupZbrane();
            }
            else
                this.NakupZbrani();
        }
        public void NakupBrneni()
        {
            Console.Write("\n - Vyber si předmět z obchodu nebo vyber 9 aby jsi se vrátil zpět: ");
            int vyber;
            if (int.TryParse(Console.ReadLine(), out vyber))
            {
                if ((vyber - 1) < 6)
                {
                    Brneni brneni = this.RandomBrneni[vyber - 1];

                    if (RandomBrneni.Contains(brneni) && Zlataky >= this.RandomBrneni[vyber - 1].CenaItemu)
                    {
                        Gladiator.BatohBrneni.Add(brneni);
                        Gladiator.Zlataky = Gladiator.Zlataky - this.RandomBrneni[vyber - 1].CenaItemu;
                        this.NakupBrneni();
                    }
                    else
                        this.NakupBrneni();
                }
                else
                    this.NakupBrneni();
            }
            else
                this.NakupZbrane();
        }
        public void NakupLektvaru()
        {
            Console.Write("\n - Vyber si předmět z obchodu nebo vyber 9 aby jsi se vrátil zpět: ");
            int vyber;
            if (int.TryParse(Console.ReadLine(), out vyber))
            {
                if ((vyber - 1) < 6)
                {
                    Lektvar lektvar = this.RandomLektvary[vyber - 1];

                    if (RandomLektvary.Contains(lektvar) && Zlataky >= this.RandomBrneni[vyber - 1].CenaItemu)
                    {
                        Gladiator.BatohLektvary.Add(lektvar);
                        Gladiator.Zlataky = Gladiator.Zlataky - this.RandomBrneni[vyber - 1].CenaItemu;
                        this.NakupLektvaru();
                    }
                    else
                        this.NakupLektvaru();
                }
                else
                    this.NakupLektvaru();
            }
            else
                this.NakupZbrane();
        }

        //Konec nakupu
        //Prodej zbrani
        public void ProdejZbrani()
        {
            Console.Clear();
            Console.WriteLine("\n \\ Obchod");
            Console.WriteLine(" 1. Prodej Zbraňí");
            Console.WriteLine(" 2. Prodej Brnění");
            Console.WriteLine(" 3. Prodej Lektvarů");
            Console.WriteLine(" 9. Zpět");
            var vyber = Console.ReadLine();
            if (vyber == "1")
            {
                this.ProdejZbrane();
            }
            else if (vyber == "2")
            {
                this.ProdejBrneni();
            }
            else if (vyber == "3")
            {
                this.ProdejLektvaru();
            }
        }
        public void ProdejZbrane()
        {

            Console.Write("\n - Vyber si předmět z inventare nebo vyber 9 aby jsi se vrátil zpět: ");
            int vyber;
            if (int.TryParse(Console.ReadLine(), out vyber))
            {
                if ((vyber - 1) < Gladiator.BatohZbrane.Count)
                {
                    Zbran zbran = Gladiator.BatohZbrane[vyber - 1];

                    if (BatohZbrane.Contains(zbran) && zbran != Gladiator.NasazenaZbran)
                    {
                        Gladiator.BatohZbrane.Remove(zbran);
                        Gladiator.Zlataky = Gladiator.Zlataky + this.RandomBrneni[vyber - 1].CenaItemu;
                        this.ProdejZbrane();
                    }
                    else
                        this.ProdejZbrane();
                }
                else
                    this.ProdejZbrane();
            }
            else
                this.ProdejZbrani();
        }
        public void ProdejBrneni()
        {

            Console.Write("\n - Vyber si předmět z inventare nebo vyber 9 aby jsi se vrátil zpět: ");
            int vyber;
            if (int.TryParse(Console.ReadLine(), out vyber))
            {
                if ((vyber - 1) < Gladiator.BatohBrneni.Count)
                {
                    Brneni brneni = Gladiator.BatohBrneni[vyber - 1];

                    if (Gladiator.BatohBrneni.Contains(brneni) && brneni != Gladiator.NasazeneBrneni)
                    {
                        Gladiator.BatohBrneni.Remove(brneni);
                        Gladiator.Zlataky = Gladiator.Zlataky + this.RandomBrneni[vyber - 1].CenaItemu;
                        this.ProdejBrneni();
                    }
                    else
                        this.ProdejBrneni();
                }
                else
                    this.ProdejBrneni();
            }
            else
                this.ProdejZbrani();
        }
        public void ProdejLektvaru()
        {

            Console.Write("\n - Vyber si předmět z inventare nebo vyber 9 aby jsi se vrátil zpět: ");
            int vyber;
            if (int.TryParse(Console.ReadLine(), out vyber))
            {
                if ((vyber - 1) < Gladiator.BatohLektvary.Count)
                {
                    Lektvar lektvary = Gladiator.BatohLektvary[vyber - 1];

                    if (Gladiator.BatohLektvary.Contains(lektvary))
                    {
                        Gladiator.BatohLektvary.Remove(lektvary);
                        Gladiator.Zlataky = Gladiator.Zlataky + this.RandomBrneni[vyber - 1].CenaItemu;
                        this.ProdejLektvaru();
                    }
                    else
                        this.ProdejLektvaru();
                }
                else
                    this.ProdejLektvaru();
            }
            else
                this.ProdejZbrani();
        }


        //Konec prodeje
    }

}




