using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    internal class Fiat : Cars, ICar
    {
        public Fiat(string Name, string Color, int Age) { }
        //public string Name { get; set; }
        //public string Color { get; set; }
        //public int Age { get; set; }

        public void wheels()
        {
            Console.WriteLine("My Fiat has 4 wheels");
        }
        public void window()
        {
            Console.WriteLine("My Fiat has 4 windows");
        }
        public void door()
        {
            Console.WriteLine("My Fiat has 2 doors");
        }
        public string Display()
        {
            return Name;
        }

        
    }
}
