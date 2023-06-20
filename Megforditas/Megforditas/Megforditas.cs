using System;
using System.Collections.Generic;
using System.Text;

namespace Megforditas
{
    internal class Megforditas
    {
        public string Forditsdmeg(string szo)
        {
            string forditottSzo = string.Empty;

            for (int i = szo.Length - 1; i >= 0; i--)
            {
                forditottSzo += szo[i];
            }

            return forditottSzo;
        }
    }
}
