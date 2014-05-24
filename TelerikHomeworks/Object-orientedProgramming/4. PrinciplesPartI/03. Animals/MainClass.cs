using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Animals
{
    class MainClass
    {
        static void Main()
        {
            #region defining and filling the list
            List<Animal> animals = new List<Animal>()
            {
                new Frog("Kermit", 23, true),
                new Dog("Karaman", 6, true),
                new Kitten("Pusinka", 0),
                new Cat("Atanas", 4, true),
                new Tomcat("Tom", 1),
                new Frog("Froggy", 14, true),
                new Dog("Vokil", 3, true),
                new Kitten("Bebe", 1),
                new Cat("Sisa", 7, false),
                new Tomcat("Timmy", 2),
                new Frog("Zelenka", 3, false),
                new Dog("Sara", 2, false),
                new Kitten("Maya", 0),
                new Cat("Miya", 4, false),
                new Tomcat("Pesho", 2),
                new Frog("Jabcho", 103, true),
                new Dog("Sayonara", 8, false),
                new Kitten("Margo", 1),
                new Cat("Yasha", 7, false),
                new Tomcat("Misho", 2)
            };
            # endregion
            var query = from animal in animals
                        group animal by animal.GetType().Name into groups
                        select new
                        {
                            AnimalType = groups.Key,
                            AverageAge = groups.Average(animal => animal.Age)
                        };

            foreach (var item in query)
            {
                Console.WriteLine(item.AnimalType + "'s average age: " + item.AverageAge);
            }
        }
    }
}
