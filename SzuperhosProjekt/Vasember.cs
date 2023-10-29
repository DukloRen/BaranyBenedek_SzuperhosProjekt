using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzuperhosProjekt
{
    public class Vasember : Bosszuallo, IMilliardos
    {
        private static Random RND = new Random();

        public Vasember() : base(150, true) { }
        public void KutyutKeszit()
        {
            this.Szuperero = this.Szuperero + (RND.NextDouble()*10);
        }
        public override bool MegmentiAVilagot()
        {
            if (this.Szuperero > 1000)
            {
                Console.WriteLine("Vasember megmenti a világot!");
            }
            else
            {
                Console.WriteLine("Vasember nem menti meg a világot!");
            }      
            return this.Szuperero>1000;
        }
        public override string ToString()
        {
            return $"Vasember: {base.ToString()}";
        }
    }
    }
