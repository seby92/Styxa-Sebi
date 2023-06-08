using System;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nev;
            string cnp;
            string szuletesiHonap;

            nev = ReadFromInput("Add meg a neved: ");
            cnp = ReadFromInput("Add meg a cnp-d: ");
            szuletesiHonap = ReadFromInput("Add meg a szuletesi honapod: ");

            Console.WriteLine("A neved: " + nev);
            Console.WriteLine($"A cnp-d: {cnp}");
            Console.WriteLine($"A szuletesi honapod: {1} {2} {3} {4} {5} {6} {7}", szuletesiHonap, "Januar", "Februar", "Marcius", "Majus", "Junius", "Julius");

            //switch (szuletesiHonap)
            //{
            //    case "1":
            //        Console.WriteLine("Januar");
            //        break;
            //    case "2":
            //        Console.WriteLine("februar");
            //        break;
            //}
            //Console.WriteLine(szuletesiHonap);


            // Ezt a kod reszletet itt hagyom ki-kommentelve, 
            // hogy legyen meg a pelda, hogy hogy epitettuk fel a programot lepesenkent


            //nev = ReadFromInput("Add meg a neved!");

            //while (nev == "")
            //{
            //    Console.WriteLine("Add meg a neved!");
            //    nev = Console.ReadLine();
            //}

            //Console.WriteLine("Add meg a cnp-d!");
            //cnp = Console.ReadLine();

            //if (cnp == "")
            //{
            //    Console.WriteLine("Add meg a cnp-d!");
            //    cnp = Console.ReadLine();
            //} else
            //{
            //    Console.WriteLine("Ugyes vagy!");
            //}

            //Console.WriteLine("Add meg a szuletesi honapod!");
            //szuletesiHonap = Console.ReadLine();

            //if (szuletesiHonap == "") 
            //{
            //    Console.WriteLine("Add meg a szuletesi honapod!");
            //    szuletesiHonap = Console.ReadLine();
            //}

            //if (szuletesiHonap == "januar")
            //{
            //    Console.WriteLine("Horoszkop 1");
            //}

            //if (szuletesiHonap == "februar")
            //{
            //    Console.WriteLine("Horoszkop 1");
            //}

            //switch (szuletesiHonap)
            //{
            //    case "1":
            //        Console.WriteLine("Januar");
            //        break;
            //    case "2":
            //        Console.WriteLine("februar");
            //        break;
            //}

            //Console.WriteLine(nev);
            //Console.WriteLine(cnp);
            //Console.WriteLine(szuletesiHonap);
        }

        static string ReadFromInput(string text)
        {
            string input;
            do
            {
                Console.Write(text);
                input = Console.ReadLine();
            } while (input == "");

            return input;
        }

    }
}
