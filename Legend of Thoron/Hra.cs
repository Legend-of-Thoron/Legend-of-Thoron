using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;

namespace Legend_of_Thoron
{
    public class Hra
    {
        public Gladiator Gladiator { get; set; }
        public Obchod Obchod { get; set; }
        public souboj Souboj { get; set; }
        public Turnaj Turnaj { get; set; }
        public Hra()
        {
            Console.WriteLine(" \\ Probíhá inicializace hry... \n");

            this.Gladiator = new Gladiator();
            this.Obchod = new Obchod(Gladiator);
            this.Obchod.NahodnaZbran();

            Gladiator.Vytvorit();
        }

        public void Zapnout()
        {
            Console.WriteLine("\n \\ Probíhá zapínaní hry...");
            Console.WriteLine();
            Console.WriteLine("          ,                    &&/                           ");
            Console.WriteLine("         .&&%                 &&&&(              &,          ");
            Console.WriteLine("         *&&&&#              %&&&&&            .&&&.         ");
            Console.WriteLine("         %&&&&&&            %&&&&&%           *&&&&%         ");
            Console.WriteLine("         %&&&&&&(          *&&&&&&.          #&&&&&&.        ");
            Console.WriteLine("          .&&&%                             ,&&&&&&%         ");
            Console.WriteLine("            ,         /&&&&&&&&&&&&&&&&&       /&&&.         ");
            Console.WriteLine("                   .%&&&&&&&&&&&&&&&&&&&&/                   ");
            Console.WriteLine("                 *&&&&&.              &&&&&.                 ");
            Console.WriteLine("              .&&&&&&(  ,&&&&&&&%/,.   ,&&&&(                ");
            Console.WriteLine("              &&&&&&#   /&&.    .*&&&&   (&&&&#&/            ");
            Console.WriteLine("              #&&&&&*   #&&.     ,&&&(    %&&&&              ");
            Console.WriteLine("              *&&&&&,   &&&    &&&&&&.  #&&&&.               ");
            Console.WriteLine("               &&&&&,   (&&&&&&&&&#(, (&&&&,                 ");
            Console.WriteLine("               %&&&&,         ,%&&&&&&&&&(                   ");
            Console.WriteLine("               ,&&&&*     .         .(%%                     ");
            Console.WriteLine("                &&&&(    .&&&&&(.      *%%                   ");
            Console.WriteLine("                    .    ,&&&&&&&&&&&&&&(                    ");
            Console.WriteLine("                              .(%&&&&&&                      ");
            Console.WriteLine("\n                    ! Hra připravena !                     ");
            Console.Write("\n \\ Stiskni jakékoliv tlačítko pro pokračování...");
            Console.ReadKey();
            this.Hlavni();
        }
        public void Hlavni()
        {
            while(Gladiator.Zije)
            {
                Console.Clear();
                Console.WriteLine("\n \\ Hlavní menu");
                Console.WriteLine(" 1. Zkouknout statistiky");
                Console.WriteLine(" 2. Zobrazit inventář");
                Console.WriteLine(" 3. Bojovat s náhodným protivníkem - Být 'Válečník'");
                Console.WriteLine(" 4. Turnament - Být 'Vůdce'");
                Console.WriteLine(" 5. Obchod (Albert)");
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
                    new souboj(Gladiator);
                }
                else if (vyber == "4")
                {
                    //TODO: Po každých 10 soubojích, je zpřístupněn turnaj s 5 nah. bojovníky a  1 bossem.
                    //TODO: Každý nový turnaj má více potřebných soubojů a více protivníků k dostažení bosse.
                    if (Gladiator.PocetSouboju > 10)
                        new Turnaj(Gladiator);
                    else
                        Console.WriteLine("Nemáš dostatek soubojů");
                }
                else if (vyber == "5")
                {
                    Obchod.Menu();
                }
                else
                {
                    Gladiator.Zije = false;
                    Environment.Exit(-1);
                }
            }
        }

        public void Statistiky()
        {
            Gladiator.Statistiky();
            this.Hlavni();
        }

        public void Inventar()
        {
            Gladiator.Inventar();
            this.Hlavni();
        }
    }
}
