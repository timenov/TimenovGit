using System;
using System.Collections.Generic;

namespace _01.SchoolSystem
{
    class School
    {
        private string name;
        private int number;
        private List<Class> classes;

        public string Name
        {
            get
            { 
                return this.name; 
            }
            set
            {
                this.name = value;
            }
        }
        public int Number
        {
            get
            {
                return this.number;
            }
            set
            {
                this.number = value;
            }
        }
        public List<Class> Classes
        {
            get
            {
                return this.classes;
            }
        }

        public School(string name, int number)
        {
            this.Name = name;
            this.Number = number;
        }
        public School(string name, int number, List<Class> classes)
            : this(name, number)
        {
            this.classes = classes;
        }
    }
}
