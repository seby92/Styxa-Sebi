using System;
using System.Collections.Generic;

namespace Cars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fiat punto = new Fiat("Punto", "red", 21);
            Fiat bravo = new Fiat("Bravo", "blue", 15);
            
            Ford fiesta = new Ford("Fiesta", "green", 4);
            Ford fusion = new Ford("Fusion", "orange", 9);
            
            Opel corsa = new Opel("Corsa", "yellow", 7);
            Opel astra = new Opel("Astra", "black", 8);

            var fiatok = new List<Fiat>() { punto, bravo };

            var fordok = new List<Ford>() { fiesta, fusion };

            var opelek = new List<Opel>() { corsa, astra };

            var kocsik = new List<ICar>() { corsa, astra, punto, bravo, fusion, fiesta };

            //kocsik.ForEach(el => el.Name);

            foreach (var el in kocsik)
            {
                el.Age();
                el.Color();
                el.Name();
            }
        }
    }
}
