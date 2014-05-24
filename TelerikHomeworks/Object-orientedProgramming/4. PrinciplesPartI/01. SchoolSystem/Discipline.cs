using System;
using System.Collections.Generic;

namespace _01.SchoolSystem
{
    class Discipline : ICommentable
    {
        private string name;
        private byte numbOfLectures;
        private byte numbOfExercises;
        private List<string> comments;

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
        public byte NumbOfLectures
        {
            get
            {
                return this.numbOfLectures;
            }
            set
            {
                this.numbOfLectures = value;
            }
        }
        public byte NumbOfExercises
        {
            get
            {
                return this.numbOfExercises;
            }
            set
            {
                this.numbOfExercises = value;
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

        public Discipline(string name, byte lectures, byte exercises)
        {
            this.Name = name;
            this.NumbOfLectures = lectures;
            this.NumbOfExercises = exercises;
            this.Comments = new List<string>();
        }

        public void AddComment(string comment)
        {
            this.Comments.Add(comment);
        }
    }
}
