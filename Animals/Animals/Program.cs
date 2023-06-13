using System;

namespace Animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pig malac = new Pig();
            malac.animalSound();
            Crow varju = new Crow();
            varju.animalSound();
        }
    }
}
