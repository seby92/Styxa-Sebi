using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Ford : Cars, ICar
    {
        public Ford(string Name, string Color, int Age) { }
        //public string Name { get; set; }
        //public string Color { get; set; }
        //public int Age { get; set; }

        public void wheels()
        {
            Console.WriteLine("My Ford has 4 wheels");
        }
        public void window()
        {
            Console.WriteLine("My Ford has 4 windows");
        }
        public void door()
        {
            Console.WriteLine("My Ford has 2 doors");
        }
        public string Display()
        {
            return Name;
        }
    }
}
