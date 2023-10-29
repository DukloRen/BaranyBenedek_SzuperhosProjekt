using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SzuperhosProjekt
{
    public static class Kepregeny
    {
        public static List<ISzuperhos> szuperhosok = new List<ISzuperhos>();
        public static void Szereplok(string fajl)
        {
            StreamReader olvaso= new StreamReader(fajl);
            while (!olvaso.EndOfStream)
            {
                string[] sor = olvaso.ReadLine().Split(' ');
                int x = int.Parse(sor[1]);
                if (sor[0] == "Vasember")
                {
                    Vasember vasember = new Vasember();
                    for (int i = 0; i < x; i++)
                    {
                        vasember.KutyutKeszit();
                    }
                    szuperhosok.Add(vasember);
                }
                else if (sor[0] == "Batman")
                {
                    Batman batman = new Batman();
                    for (int i = 0; i < x; i++)
                    {
                        batman.KutyutKeszit();
                    }
                    szuperhosok.Add(batman);
                }
            }
        }
        public static void Szuperhosok()
        {
            for (int i = 0; i < szuperhosok.Count; i++)
            {
                Console.WriteLine(szuperhosok[i]);
            }
        }
    }
}
