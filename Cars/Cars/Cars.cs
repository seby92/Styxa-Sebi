using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    internal class Cars : ICar
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }
    }
}
