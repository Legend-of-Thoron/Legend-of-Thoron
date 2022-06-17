using System;
using System.Collections.Generic;
using System.Text;

namespace Legend_of_Thoron
{
    public class Obchod
    {
        public Gladiator Gladiator { get; set; }
        public Zbrane zbrane = new Zbrane();
        public BrneniList brneni = new BrneniList();
        public int Zlataky { get; set; }
        public Obchod(Gladiator gladiator)
        {
            Gladiator = gladiator;
            RandomZbrane.Add(zbrane.ban_hammer);
            RandomZbrane.Add(zbrane.bronzovy_mec);
            RandomZbrane.Add(zbrane.cepele_chaosu);
            RandomZbrane.Add(zbrane.crucible);
            RandomZbrane.Add(zbrane.dragunov);
            RandomZbrane.Add(zbrane.dupstep_gun);
            RandomZbrane.Add(zbrane.jushuv_Tpose);
            RandomZbrane.Add(zbrane.hot_dogger);
            RandomZbrane.Add(zbrane.opotrebovany_mec);
            RandomZbrane.Add(zbrane.safriho_vtipy);
            RandomZbrane.Add(zbrane.zenith);
            RandomZbrane.Add(zbrane.zlaty_mec);
            RandomZbrane.Add(zbrane.lightsaber);
            RandomBrneni.Add(brneni.hornicky_oblek);
            RandomBrneni.Add(brneni.kozene_hadry);
            RandomBrneni.Add(brneni.magicky_plast);
            RandomBrneni.Add(brneni.obrneny_habit);
            RandomBrneni.Add(brneni.roztrhane_hadry);
            RandomBrneni.Add(brneni.smradlve_trenky);
            RandomBrneni.Add(brneni.titaniova_zbroj);
            RandomBrneni.Add(brneni.uhelné_brneni);
            RandomBrneni.Add(brneni.zelezne_brneni);
            RandomBrneni.Add(brneni.zlata_zbroj);
        }

        public List<Zbran> RandomZbrane = new List<Zbran>();
        public List<Brneni> RandomBrneni = new List<Brneni>();
        public List<Zbran> RandomZbraneVybrane = new List<Zbran>();
        public List<Brneni> RandomBrneniVybrane = new List<Brneni>();
        
        
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

        public void NahodnaZbran()
        {
            for (int i = 0; i < 3; i++)
            {
                RandomZbraneVybrane.Add(RandomZbrane[new Random().Next(0,RandomZbrane.Count)]);
                RandomBrneniVybrane.Add(RandomBrneni[new Random().Next(0,RandomBrneni.Count)]);
            }
        }
        
        //Nakupovani
        public void NakupZbrani()
        {
            Console.Clear();
            Console.WriteLine("\n \\ Obchod");
            Console.WriteLine(" 1. Nakoupit Zbraňe");
            Console.WriteLine(" 2. Nakoupit Brnění");
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
        }

        public void NakupZbrane()
        {
            int i = 1;
            foreach (var z in RandomZbraneVybrane)
            {
                Console.WriteLine(" {0}. {1}, Sila: {2} [{3} coinu]", i, z.Nazev, z.Sila ,z.CenaItemu);
                i++;
            }
            Console.Write("\n - Vyber si předmět z obchodu nebo vyber 9 aby jsi se vrátil zpět: ");
            int vyber;
            if (int.TryParse(Console.ReadLine(), out vyber))
            {
                if ((vyber - 1) < 6)
                {
                    Zbran zbran = this.RandomZbraneVybrane[vyber - 1];

                    if (RandomZbrane.Contains(zbran) && Zlataky >= this.RandomZbraneVybrane[vyber - 1].CenaItemu)
                    {
                        Gladiator.BatohZbrane.Add(zbran);
                        Gladiator.Zlataky = Gladiator.Zlataky - this.RandomZbraneVybrane[vyber - 1].CenaItemu;
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
            int i = 1;
            foreach (var b in RandomBrneniVybrane)
            {
                Console.WriteLine(" {0}. {1}, Obrana: {2} [{3} coinu]", i, b.Nazev, b.Obrana ,b.CenaItemu);
                i++;
            }
            Console.Write("\n - Vyber si předmět z obchodu nebo vyber 9 aby jsi se vrátil zpět: ");
            int vyber;
            if (int.TryParse(Console.ReadLine(), out vyber))
            {
                if ((vyber - 1) < 6)
                {
                    Brneni brneni = this.RandomBrneniVybrane[vyber - 1];

                    if (RandomBrneni.Contains(brneni) && Zlataky >= this.RandomBrneniVybrane[vyber - 1].CenaItemu)
                    {
                        Gladiator.BatohBrneni.Add(brneni);
                        Gladiator.Zlataky = Gladiator.Zlataky - this.RandomBrneniVybrane[vyber - 1].CenaItemu;
                        this.NakupBrneni();
                    }
                    else
                        this.NakupBrneni();
                }
                else
                    this.NakupBrneni();
            }
            else
                this.NakupZbrani();
        }

        //Konec nakupu
        //Prodej zbrani
        public void ProdejZbrani()
        {
            Console.Clear();
            Console.WriteLine("\n \\ Obchod");
            Console.WriteLine(" 1. Prodej Zbraňí");
            Console.WriteLine(" 2. Prodej Brnění");
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
        }
        public void ProdejZbrane()
        {
            int i = 1;
            foreach (var Zbran in Gladiator.BatohZbrane)
            {
                Console.WriteLine(" {0}. {1}, Sila: {2} [{3} coinu]", i, Zbran.Nazev, Zbran.Sila ,Zbran.CenaItemu);
            }
            Console.Write("\n - Vyber si předmět z inventare nebo vyber 9 aby jsi se vrátil zpět: ");
            int vyber;
            if (int.TryParse(Console.ReadLine(), out vyber))
            {
                if ((vyber - 1) < Gladiator.BatohZbrane.Count)
                {
                    Zbran zbran = Gladiator.BatohZbrane[vyber - 1];

                    if (Gladiator.BatohZbrane.Contains(zbran) && zbran != Gladiator.NasazenaZbran)
                    {
                        Gladiator.BatohZbrane.Remove(zbran);
                        Gladiator.Zlataky = Gladiator.Zlataky + Gladiator.BatohZbrane[vyber - 1].CenaItemu;
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
            int i = 1;
            foreach (var Brneni in Gladiator.BatohBrneni)
            {
                Console.WriteLine(" {0}. {1}, Obrana: {2} [{3} coinu]", i, Brneni.Nazev, Brneni.Obrana ,Brneni.CenaItemu);
            }
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
                        Gladiator.Zlataky = Gladiator.Zlataky + Gladiator.BatohBrneni[vyber - 1].CenaItemu;
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




