using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzuperhosProjekt
{
    public class Batman : ISzuperhos, IMilliardos
    {
        private double lelemenyesseg;

        public Batman()
        {
            this.lelemenyesseg = 100;
        }
        public double MekkoraAzEreje()
        {
            return this.lelemenyesseg * 2;
        }

        public bool LegyoziE(ISzuperhos szuperhos)
        {
            if (szuperhos.MekkoraAzEreje()<this.lelemenyesseg)
            {
                Console.WriteLine("Batman letudja győzni!");
            }
            else
            {
                Console.WriteLine("Batman nem képes legyőzni!");
            }
            return szuperhos.MekkoraAzEreje() < this.lelemenyesseg;
        }
        public void KutyutKeszit()
        {
            this.lelemenyesseg += 50;
        }
        public override string ToString()
        {
            return $"Batman: leleményesség: {this.lelemenyesseg}";
        }
    }
    }
