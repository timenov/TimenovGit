using System;

namespace _04.PersonProject
{
    class Person
    {
        private string name;
        private byte? age;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public byte? Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public Person(string name, byte? age)
        {
            this.Name = name;
            this.Age = age;
        }

        public Person(string name)
            : this(name, null)
        {
        }

        public override string ToString()
        {
            return string.Format("Name: {0}\nAge: {1}", this.Name, this.Age != null ? this.Age.ToString() : "Not specified");
        }
    }
}
