using System;

namespace Hazi_06_14
{
    public class Program
    {
        public void Main(string[] args)
        {
            int a = 0, b = 1, c = 0, i, szam, osszeg = 0;
            Console.Write("Hany szam osszeget szamoljuk ki? ");
            szam = int.Parse(Console.ReadLine());
            for (i = 1; i < szam; i++)
            {
                a = b;
                b = c;
                c = a + b;
                osszeg += c;
            }
            Console.WriteLine(osszeg);
        }
    }
}
