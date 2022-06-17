using System;
using System.Collections.Generic;
using System.Text;

namespace Legend_of_Thoron
{
    public class Zbran
    {
        public Zbran(string nazev, int sila, int cenaitemu)
        {
            this.Nazev = nazev;
            this.Sila = sila;
            this.CenaItemu = cenaitemu;
        }

        public string Nazev { get; set; }
        public int Sila { get; set; }
        public int CenaItemu { get; set; }
    }
    public class Zbrane{
        public Zbran opotrebovany_mec = new Zbran("Opotřebovaný Meč", 1, 30);
        public Zbran v_nova_sekera = new Zbran("Velice Nová Sekera", 10, 100);
        public Zbran netheritovy_mec = new Zbran("Netheritový meč", 22, 220);
        public Zbran nokia_kladivo = new Zbran("Nokia kladivo", 130, 1300);
        public Zbran safriho_vtipy = new Zbran("Šafriho Vtipy", 7, 70);
        public Zbran jushuv_Tpose = new Zbran("Jůchův T-Pose", 150, 1500);
        public Zbran zlaty_mec = new Zbran("Zlaty meč", 10, 100);
        public Zbran lego_pistol = new Zbran("LEGO pistol", 250, 2500);
        public Zbran zelezny_mec = new Zbran("Železný meč", 15, 150);
        public Zbran energy_mec = new Zbran("Energy meč", 20, 200);
        public Zbran pacidlo = new Zbran("Páčidlo", 50, 500);
        public Zbran master_mec = new Zbran("Master meč", 50, 500);
        public Zbran cepele_chaosu = new Zbran("Čepele chaosu", 100, 1000);
        public Zbran bronzovy_mec = new Zbran("Bronzový meč", 13, 130);
        public Zbran xvl1456 = new Zbran("XVL1456", 500, 5000);
        public Zbran crucible = new Zbran("Crucible", 100, 1000);
        public Zbran murasama = new Zbran("Murasama", 75, 750);
        public Zbran hot_dogger = new Zbran("Hot Dogger", 30, 300);
        public Zbran zenith = new Zbran("Zenith", 999, 9999);
        public Zbran lightsaber = new Zbran("Lightsaber", 30, 300);
        public Zbran dupstep_gun = new Zbran("Dubstep Gun", 50, 500);
        public Zbran gaster_blaster = new Zbran("Gaster Blaster", 25, 250);
        public Zbran dragunov = new Zbran("Dragunov", 250, 2500);
        public Zbran leviathan_sekera = new Zbran("Leviathan Sekera", 150, 1500);
        public Zbran rukavice_nekonecna = new Zbran("Rukavice nekonečna", 200, 2000);
        public Zbran ban_hammer = new Zbran("Ban Hammer", 999, 9999);
        public Zbrane()
        {}
    }
}

