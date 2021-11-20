using System;
using System.Collections.Generic;
using System.Text;

namespace Legend_of_Thoron
{
    public class Hra
    {
        public Hrdina Hrdina { get; set; }
        public Hra()
        {
            Console.WriteLine(" \\ Probíhá inicializace hry... \n");

            this.Hrdina = new Hrdina();

            Hrdina.Vytvorit();
        }

        public void Zapnout()
        {
            Console.WriteLine("\n \\ Probíhá zapínaní hry...");

            Console.WriteLine("\n     Welcome To      ");
            Console.WriteLine("The Legend of Thoron \n");
            this.Hlavni();
        }
        public void Hlavni()
        {
            Console.Clear();
            Console.WriteLine("\n \\ Hlavní menu");
            Console.WriteLine(" 1. Zkouknout statistiky");
            Console.WriteLine(" 2. Zobrazit inventář");
            Console.WriteLine(" 3. Bojovat s náhodným monstrem - Být 'Hrdina'");
            Console.WriteLine(" 4. Vybrat monstrum - Být 'Veterán'");
            Console.WriteLine(" 9. Odejít - Být 'Zbabělec'");
            var vyber = Console.ReadLine();
            if (vyber == "1")
            {
                this.Statistiky();
            }
            else if (vyber == "2")
            {
                this.Inventar();
            }
            else if (vyber == "3")
            {
                //this.NahodnySouboj();
            }
            else if (vyber == "4")
            {
                //this.SpecifickySouboj();

                //TODO Vytvořit menu na výběr monstra
                //this.Souboj();
            }
            else
            {
                Environment.Exit(-1);
            }
        }

        public void Statistiky()
        {
            Hrdina.Statistiky();
            this.Hlavni();
        }

        public void Inventar()
        {
            Hrdina.Inventar();
            this.Hlavni();
        }
    }
}
