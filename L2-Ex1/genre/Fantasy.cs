using System.Collections.Generic;

namespace Lec2
{
    public class Fantasy : Book
    {
        protected static readonly Person DEFAULT_AURTHOR = new Person("J.R.R. Tolkien", 127);
        
        public Fantasy(string newTitle) : base(newTitle)
        {
        }

        public Fantasy(string title, Person author) : base(title, author)
        {
        }

        public Fantasy(string newTitle, Person newAuthor, List<string> newBlurb) : base(newTitle, newAuthor, newBlurb)
        {
        }

        public Fantasy(string title, Person author, string[] blurb) : base(title, author, blurb)
        {
        }
        
        public static Person DefaultAuthor
        {
            get => DEFAULT_AURTHOR;
        }
    }
}