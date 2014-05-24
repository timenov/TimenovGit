using System;

namespace _01.SchoolSystem
{
    class Human
    {
        private string firstName;
        private string lastName;
        private bool isMale;

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }
        }
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }
        public bool IsMale
        {
            get
            {
                return this.isMale;
            }
            set
            {
                this.isMale = value;
            }
        }

        public Human(string firstName, string lastName, bool isMale)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.IsMale = isMale;
        }
    }
}
