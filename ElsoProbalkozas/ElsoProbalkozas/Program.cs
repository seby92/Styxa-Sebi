using System;
using System.Collections.Generic;

namespace ElsoProbalkozas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();


            bool nextStudent = true;

            while (nextStudent)
            {
                Student student = new Student();

                Console.Write("Add meg a nevet: ");
                string name = Console.ReadLine();

                Console.Write("Add meg a jegyet: ");
                int note = int.Parse(Console.ReadLine());

                student.Name = name;
                student.Note = note;

                students.Add(student);

                Console.Write("Lesz uj diak: y/n: ");
                nextStudent = Console.ReadLine() == "y";
            }

            //Student diak = new Student()
            //{
            //    Name = "Jani"
            //};
            //Console.WriteLine(diak.Name);

            //Student diak2 = new Student
            //{
            //    Name = diak.Name
            //};
            //diak.Name = "Jonas";

            //var students = new List<Student>();

            foreach (var item in students)
            {
                Console.WriteLine($"Nev: {item.Name}; Jegy: {item.Note}");
            }
        }
    }
}
