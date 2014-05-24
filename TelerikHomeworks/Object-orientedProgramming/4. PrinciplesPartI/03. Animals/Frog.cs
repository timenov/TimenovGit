using System;

namespace _03.Animals
{
    class Frog : Animal
    {
        public Frog(string name, ushort age, bool isMale)
        {
            this.Name = name;
            this.Age = age;
            this.IsMale = isMale;
        }

        public override void Sound()
        {
            Console.WriteLine("Kryak");
        }
    }
}
