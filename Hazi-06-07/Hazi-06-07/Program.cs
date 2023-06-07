using System;
using System.Collections.Generic;

namespace SchoolTrackerV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var studentNames = new List<string>();
            var studentNotes = new List<int>();

            bool nextStudent = true;

            while (nextStudent)
            {
                Console.Write("Add meg a nevet: ");
                string name = Console.ReadLine();
                studentNames.Add(name);

                Console.Write("Add meg a jegyet: ");
                int note = int.Parse(Console.ReadLine());
                studentNotes.Add(note);

                Console.Write("Lesz uj diak? y/n: ");
                nextStudent = Console.ReadLine() == "y";
            }

            for (int i = 0; i < studentNames.Count; i++)
            {
                Console.WriteLine($"Nev: {studentNames[i]}; Jegy: {studentNotes[i]}");
            }

        }
    }
}
