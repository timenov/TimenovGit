using System;
using System.Collections.Generic;

namespace _01.SchoolSystem
{
    public interface ICommentable
    {
        List<string> Comments { get; }

        void AddComment(string comment);
    }
}
