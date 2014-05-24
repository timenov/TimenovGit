using System;
using System.Collections.Generic;
using System.Linq;

//The code is not good but this is only a test
namespace _02.Humans
{
    class MainClass
    {
        public static void Main()
        {
            List<Human> humans = new List<Human>();

            Console.WriteLine("Test workers:");
            //Test methods return the Lists of items and call the Print method
            humans.AddRange(TestWorker());
            Console.WriteLine("\nTest students:");
            humans.AddRange(TestStudent());

            var query = humans.OrderBy(x => x.FirstName).ThenBy(x => x.LastName);
            Console.WriteLine("\nMerge lists:");
            Print(query);
        }

        public static List<Worker> TestWorker()
        {
            List<Worker> workers = new List<Worker>()
            {
                new Worker("Rumen", "Ivanov", 145.0M, 8),
                new Worker("Yasen", "Dimitrov", 122.22M, 6),
                new Worker("Angel", "Ivanov", 242.0M, 8),
                new Worker("Milen", "Tanev", 172.50M, 8),
                new Worker("Maria", "Yancheva", 115.0M, 4),
                new Worker("Krasen", "Milanov", 178.0M, 8),
                new Worker("Silvia", "Bogdanova", 245.88M, 8),
                new Worker("Slaveya", "Mincheva", 145.0M, 6),
                new Worker("Nikolay", "Ivanov", 45.0M, 4),
                new Worker("Aleksandra", "Slavcheva", 135.0M, 8)
            };
            workers = workers.OrderByDescending(x => x.MoneyPerHour()).ToList();

            Print(workers);

            return workers;
        }

        public static List<Student> TestStudent()
        {
            List<Student> students = new List<Student>()
            {
                new Student("Kosta", "Yanev", 3.43f),
                new Student("Blagoy", "Dimitrov", 3.62f),
                new Student("Angel", "Milanov", 4.25f),
                new Student("Kurdo", "Kolenkov", 6.00f),
                new Student("Iliya", "Kupenov", 6.00f),
                new Student("Krasen", "Krastev", 5.43f),
                new Student("Kamelia", "Bogdanova", 5.63f),
                new Student("Bojidara", "Milusheva", 4.43f),
                new Student("Kolio", "Milchev", 3.92f),
                new Student("Stefka", "Yankova", 2.23f)
            };

            students = (from student in students
                       orderby student.Grade descending
                       select student).ToList();

            Print(students);

            return students;
        }

        public static void Print<T>(IEnumerable<T> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
