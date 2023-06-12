using System;

namespace Tanulas_nappal_06_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Song holiday = new Song("Holiday", "Greenday", 200);
            Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);

            Console.WriteLine(holiday.title);
        }
    }
}
