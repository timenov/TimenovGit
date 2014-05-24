using System;
using System.Collections.Generic;

namespace _01.SchoolSystem
{
    class Class : ICommentable
    {
        private List<Teacher> teachers;
        private char classLetter;
        private List<string> comments;

        public List<Teacher> Teachers
        {
            get
            {
                return teachers;
            }
        }
        public char ClassLetter
        {
            get
            {
                return this.classLetter;
            }
            set
            {
                this.classLetter = value;
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

        public Class(List<Teacher> teachers)
        {
            this.teachers = teachers;
            this.Comments = new List<string>();
        }

        public void AddComment(string comment)
        {
            this.Comments.Add(comment);
        }
    }
}
