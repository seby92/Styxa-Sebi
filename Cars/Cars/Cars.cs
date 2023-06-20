using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public abstract class Cars : ICar
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }

        public void door()
        {
            throw new NotImplementedException();
        }

        public void wheels()
        {
            throw new NotImplementedException();
        }

        public void window()
        {
            throw new NotImplementedException();
        }
    }
}
