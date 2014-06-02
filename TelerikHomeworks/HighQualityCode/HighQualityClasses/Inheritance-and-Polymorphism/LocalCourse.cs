namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;

    public class LocalCourse : Course
    {
        public string Lab { get; set; }

        public LocalCourse(string name, string teacher = "", IList<string> students = null)
            : base(name, teacher, students)
        {
            return;
        }

        public override string ToString()
        {
            return this.ToStringHelper(new KeyValuePair<string, string>("Lab", this.Lab));
        }
    }
}