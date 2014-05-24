using System;

namespace _03.Animals
{
    class Dog : Animal
    {
        public Dog(string name, ushort age, bool isMale)
        {
            this.Name = name;
            this.Age = age;
            this.IsMale = isMale;
        }

        public override void Sound()
        {
            Console.WriteLine("Bau");
        }
    }
}
