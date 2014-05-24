using System;
using System.Collections.Generic;

namespace _01.SchoolSystem
{
    class Teacher : Human, ICommentable
    {
        private List<Discipline> disciplines;
        private List<string> comments;

        public List<Discipline> Disciplines
        {
            get
            {
                return this.disciplines;
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

        public Teacher(string firstName, string lastName, bool isMale)
            : base(firstName, lastName, isMale)
        {
            this.disciplines = new List<Discipline>();
            this.Comments = new List<string>();
        }
        public Teacher(string firstName, string lastName, bool isMale, List<Discipline> disc)
            : base(firstName, lastName, isMale)
        {
            this.disciplines = disc;
            this.Comments = new List<string>();
        }

        public void AddComment(string comment)
        {
            this.Comments.Add(comment);
        }
    }
}
