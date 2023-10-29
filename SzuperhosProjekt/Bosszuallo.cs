using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzuperhosProjekt
{
    public abstract class Bosszuallo : ISzuperhos
    {
        private double szuperero;
        private bool vanEGyengesege;

        public Bosszuallo(double szuperero, bool vanEGyengesege)
        {
            this.szuperero = szuperero;
            this.vanEGyengesege = vanEGyengesege;
        }

        public double Szuperero { get => szuperero; set => szuperero = value; }
        public bool VanEGyengesege { get => vanEGyengesege; set => vanEGyengesege = value; }

        public abstract bool MegmentiAVilagot();
        public double MekkoraAzEreje()
        {
            return szuperero = this.szuperero;
        }
        public bool LegyoziE(ISzuperhos szuperhos)
        {
            if (szuperhos.GetType() == typeof(Bosszuallo))
            {
                Bosszuallo szuperh = (Bosszuallo)szuperhos;
                if (szuperh.VanEGyengesege == true && szuperhos.MekkoraAzEreje() < this.szuperero)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (this.szuperero >= szuperhos.MekkoraAzEreje() * 2) //(gondolom ha több mint kétszer nagyobb akkor is legyőzi)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            if (this.VanEGyengesege==true)
            {
                return $"Szupererő: {this.szuperero}; van gyengesége";
            }
            else
            {
                return $"Szupererő: {this.szuperero}; nincs gyengesége";
            }
        }
    }
    }
