using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzuperhosProjekt
{
    public class Program
    {
        public static void Main(string[] args)              //Main függvény
        {
			try
			{
                Kepregeny.Szereplok("files/szuperhosok.txt");
                Kepregeny.Szuperhosok();
            }
			catch (Exception exception)
			{

				Console.WriteLine(exception.Message);
			}
        }
    }
}
