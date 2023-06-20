using System;

namespace Hazi_06_14_forditott_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Megforditas(string stringInput)
            {
                // Reverse using While loop  
                string reversestring = "";
                int length;

                length = stringInput.Length - 1;

                while (length >= 0)
                {
                    reversestring = reversestring + stringInput[length];
                    length--;
                }
                Console.WriteLine(reversestring);

                Console.ReadLine();

            }
        }
    }
}
