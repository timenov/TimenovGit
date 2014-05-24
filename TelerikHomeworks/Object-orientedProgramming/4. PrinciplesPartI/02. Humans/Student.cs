using System;

namespace _02.Humans
{
    class Student : Human
    {
        private float grade;

        public float Grade
        {
            get
            {
                return this.grade;
            }
            set
            {
                if (value > 6.00f || value < 2.00f)
                {
                    throw new ArgumentOutOfRangeException("The grade must be on six point system.");
                }
                this.grade = value;
            }
        }

        public Student(string first, string last, float grade)
        {
            this.FirstName = first;
            this.LastName = last;
            this.Grade = grade;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2:F2}", this.FirstName, this.LastName, this.grade);
        }
    }
}
