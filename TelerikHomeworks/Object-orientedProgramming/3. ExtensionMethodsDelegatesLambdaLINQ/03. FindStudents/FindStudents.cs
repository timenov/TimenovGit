using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.FindStudents
{
    class FindStudents
    {
        static void Main()
        {
            Student[] students = new Student[]{
                new Student("Gosho", "Maznekov", 19),
                new Student("Petko", "Taralenkov", 20),
                new Student("Svetlin", "Nakov", 30),
                new Student("FirstName", "LastName", 23),
                new Student("Petko", "Petkov", 22),
                new Student("Gosho", "Zurlekov", 25)
            };

            var studentsQuery =
                from student in students
                where string.Compare(student.FirstName, student.LastName) < 0
                select student;

            foreach (var student in studentsQuery)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }

            Console.WriteLine("\nNew query:");
            studentsQuery =
                from student in students
                where student.Age >= 18 && student.Age <= 24
                select student;

            foreach (var student in studentsQuery)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }

            Console.WriteLine("\nNew query (with lambda):");
            studentsQuery = students.OrderByDescending(student => student.FirstName).ThenByDescending(student => student.LastName);

            foreach (var student in studentsQuery)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }

            Console.WriteLine("\nNew query (with LINQ):");
            studentsQuery = from student in students
                            orderby student.FirstName descending, student.LastName descending
                            select student;
            foreach (var student in studentsQuery)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
        }
    }
}
