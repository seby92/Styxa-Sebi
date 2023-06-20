using System;

namespace Megforditas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Megforditas string1 = new Megforditas();
            Console.Write("Mit forditsunk meg? ");
            string forditott = Console.ReadLine();
            Console.WriteLine(string1.Forditsdmeg(forditott));
        }
    }
}
