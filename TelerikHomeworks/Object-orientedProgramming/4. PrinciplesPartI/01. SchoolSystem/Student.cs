using System;
using System.Collections.Generic;

namespace _01.SchoolSystem
{
    class Student : Human, ICommentable
    {
        private byte classNumber;
        private List<string> comments;

        public byte ClassNumber
        {
            get
            {
                return this.classNumber;
            }
            set
            {
                this.classNumber = value;
            }
        }
        public List<string> Comments
        {
            get
            {
                return this.comments;
            }
            private set
            {
                this.comments = value;
            }
        }

        public Student(string firstName, string lastName, bool isMale, byte number)
            : base(firstName, lastName, isMale)
        {
            this.classNumber = number;
            this.Comments = new List<string>();
        }

        public void AddComment(string comment)
        {
            this.Comments.Add(comment);
        }
    }
}
