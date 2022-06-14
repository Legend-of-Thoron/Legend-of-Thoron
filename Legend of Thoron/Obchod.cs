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
        public int CenaItemu { get; set; }
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

        public Zbran opotrebovany_mec = new Zbran("Opotřebovaný Meč", 1, 30);
        public Zbran v_nova_sekera = new Zbran("Velice Nová Sekera", 10, 100);

        public Lektvar maly_lektvar = new Lektvar("Malý Lektvar", 5, 25);
        public Lektvar velky_lektvar = new Lektvar("Velký Lektvar", 15, 50);
        public Lektvar felix_felicis = new Lektvar("Felix Felicis", 25, 100);
        public Lektvar vyluh_z_ponozek = new Lektvar("Výluh Z Ponožek", 3, 5);
        public Lektvar okena = new Lektvar("Okena", 6, 10);
        public Lektvar stredni_lektvar = new Lektvar("Stredni Lektvar", 10, 35);
        public Lektvar neznama_tekutina = new Lektvar("Neznámá Tekutina", 18, 75);
        public Lektvar modry_lektvar = new Lektvar("Modrý Lektvar", 12, 37);
        public Lektvar cerveny_lektvar = new Lektvar("Červený Lektvar", 16, 55);
        public Lektvar zlaty_lektvar = new Lektvar("Zlatý Lektvar", 20, 60);

        public Brneni roztrhane_hadry = new Brneni("Roztrhané Hadry", 2, 5);
        public Brneni obrneny_habit = new Brneni("Obrněný Hábit", 5, 10);
        public Brneni kozene_hadry = new Brneni("Kožené Hadry", 3, 15);
        public Brneni zelezne_brneni = new Brneni("Železné Brnění", 8, 30);
        public Brneni zlata_zbroj = new Brneni("Zlatá Zbroj", 7, 50);
        public Brneni magicky_plast = new Brneni("Magický Plášť", 10, 75);
        public Brneni hornicky_oblek = new Brneni("Hornický Oblek", 2, 25);
        public Brneni uhelné_brneni = new Brneni("Uhelné Brnění", 6, 35);
        public Brneni titaniova_zbroj = new Brneni("Titániová Zbroj", 9, 100);
        public Brneni smradlve_trenky = new Brneni("Smradlavé Trenky", 1, 5);



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

                    if (RandomZbrane.Contains(zbran) && Zlataky >= CenaItemu)
                    {
                        this.RandomZbrane = this.BatohZbrane;
                        this.Zlataky = Zlataky - CenaItemu;
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

                    if (RandomBrneni.Contains(brneni) && Zlataky >= CenaItemu)
                    {
                        this.RandomBrneni = this.BatohBrneni;
                        this.Zlataky = Zlataky - CenaItemu;
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

                    if (RandomLektvary.Contains(lektvar) && Zlataky >= CenaItemu)
                    {
                        this.RandomLektvary = this.BatohLektvary;
                        this.Zlataky = Zlataky - CenaItemu;
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
                if ((vyber - 1) < this.BatohZbrane.Count)
                {
                    Zbran zbran = this.BatohZbrane[vyber - 1];

                    if (BatohZbrane.Contains(zbran) && zbran != NasazenaZbran)
                    {
                        this.BatohZbrane.Remove(zbran);
                        this.Zlataky = Zlataky + CenaItemu;
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
                if ((vyber - 1) < this.BatohBrneni.Count)
                {
                    Brneni brneni = this.BatohBrneni[vyber - 1];

                    if (BatohBrneni.Contains(brneni) && brneni != NasazeneBrneni)
                    {
                        this.BatohBrneni.Remove(brneni);
                        this.Zlataky = Zlataky + CenaItemu;
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
                if ((vyber - 1) < this.BatohLektvary.Count)
                {
                    Lektvar lektvary = this.BatohLektvary[vyber - 1];

                    if (BatohLektvary.Contains(lektvary))
                    {
                        this.BatohLektvary.Remove(lektvary);
                        this.Zlataky = Zlataky + CenaItemu;
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




