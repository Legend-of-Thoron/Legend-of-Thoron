using System;
using System.Collections.Generic;
using System.Text;

namespace Legend_of_Thoron
{
    public class Turnaj
    {
        public Turnaj(Gladiator postava)
        {
            this.Gladiator = postava;
            Console.WriteLine("Vítej gladiátore!");
            Console.WriteLine();

            
            
            if (postava.PocetSouboju >= 10 && postava.PocetTurnaju ==0)
            {
                int a = Boss1.AktualniHP; // hp bosse
                int b = postava.ZakladniHP + postava.Obrana; //hp postavy
                int c = 0;
                int d = 0;
                while (a<=c || b<=d)
                {
                    Console.WriteLine("Utkáváš se s Postupákem!");
                    c = a;
                    d = b;

                    a -= postava.Sila;
                    b -= Boss1.Sila;
                }
                Console.Clear();
                if (c < a)
                {
                    Console.WriteLine("Byl jsi poražen!");
                    postava.Zije = false;

                }
                else if (d < b)
                {
                    Console.WriteLine("Vyhrál jsi!");
                    
                    postava.Zlataky += Boss1.Zlataky;
                    postava.PocetTurnaju++;
                }
            }
            if (postava.PocetSouboju >= 25 && postava.PocetTurnaju == 1)
            {
                int e = Boss2.AktualniHP;
                int f = postava.ZakladniHP + postava.Obrana;
                int g = 0;
                int h = 0;
                while(e <= g || f <= h)
                {
                    Console.WriteLine("Utkáváš se s Marunou!");
                    g = e;
                    h = f;

                    e -= postava.Sila;
                    f -= Boss2.Sila;
                }
                Console.Clear();
                if (g < e)
                {
                    Console.WriteLine("Byl jsi poražen!");
                    postava.Zije = false;

                }
                else if (h < f)
                {
                    Console.WriteLine("Vyhrál jsi!");

                    postava.Zlataky += Boss2.Zlataky;
                    postava.PocetTurnaju++;
                }
            }
            if (postava.PocetSouboju >= 45 && postava.PocetTurnaju == 2)
            {
                int i = Boss3.AktualniHP;
                int j = postava.ZakladniHP + postava.Obrana;
                int k = 0;
                int l = 0;
                while (i <= k || j <= l)
                {
                    Console.WriteLine("Utkáváš se s Toulenem!");
                    k = i;
                    l = j;

                    i -= postava.Sila;
                    j -= Boss3.Sila;
                }
                Console.Clear();
                if (k < i)
                {
                    Console.WriteLine("Byl jsi poražen!");
                    postava.Zije = false;

                }
                else if (l < j)
                {
                    Console.WriteLine("Vyhrál jsi!");

                    postava.Zlataky += Boss3.Zlataky;
                    postava.PocetTurnaju++;
                }
            }
            if (postava.PocetSouboju >= 60 && postava.PocetTurnaju == 3)
            {
                int m = Boss4.AktualniHP;
                int n = postava.ZakladniHP + postava.Obrana;
                int o = 0;
                int p = 0;
                while (m <= o || n <= p)
                {
                    Console.WriteLine("Utkáváš se s Corelínou!");
                    o = m;
                    p = n;

                    m -= postava.Sila;
                    n -= Boss4.Sila;
                }
                Console.Clear();
                if (o < m)
                {
                    Console.WriteLine("Byl jsi poražen!");
                    postava.Zije = false;

                }
                else if (p < n)
                {
                    Console.WriteLine("Vyhrál jsi!");

                    postava.Zlataky += Boss4.Zlataky;
                    postava.PocetTurnaju++;
                }
            }
            if (postava.PocetSouboju >= 90 && postava.PocetTurnaju == 4)
            {
                int q = Boss5.AktualniHP;
                int r = postava.ZakladniHP + postava.Obrana;
                int s = 0;
                int t = 0;
                while (q <= s || r <= t)
                {
                    Console.WriteLine("Utkáváš se s Lordem Juliem Králem!");
                    s = q;
                    t = r;

                    q -= postava.Sila;
                    r -= Boss5.Sila;
                }
                Console.Clear();
                if (s < q)
                {
                    Console.WriteLine("Byl jsi poražen!");
                    postava.Zije = false;

                }
                else if (t < r)
                {
                    Console.WriteLine("Vyhrál jsi!");

                    postava.Zlataky += Boss5.Zlataky;
                    postava.PocetTurnaju++;
                }
            }  
        }


        //string jmeno, int sila, int obrana, int zakladniHP, int aktualniHP, int zlataky
        //                                                síla  obrana  hp
        public Nepratele Boss1 = new Nepratele("Postupák", 80, 200, 800, 1000, 300);
        public Nepratele Boss2 = new Nepratele("Maruna", 100, 300, 900, 1200, 400);
        public Nepratele Boss3 = new Nepratele("Toulen", 120, 400, 1100, 1500, 500);
        public Nepratele Boss4 = new Nepratele("Corelína", 150, 500, 1300, 1800, 600);
        public Nepratele Boss5 = new Nepratele("Lord Julius Král", 200, 700, 1300, 2000, 3000);

        public Gladiator Gladiator { get; set; }

        
    }
}
