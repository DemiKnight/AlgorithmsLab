using System.Collections.Generic;

namespace Lec2
{
    public class Horror : Book
    {
        protected static readonly Person DEFAULT_AURTHOR = new Person("Stephen King", 72);
        
        public Horror(string newTitle) : base(newTitle)
        {
        }

        public Horror(string title, Person author) : base(title, author)
        {
        }

        public Horror(string newTitle, Person newAuthor, List<string> newBlurb) : base(newTitle, newAuthor, newBlurb)
        {
        }

        public Horror(string title, Person author, string[] blurb) : base(title, author, blurb)
        {
        }
        
        public static Person DefaultAuthor
        {
            get => DEFAULT_AURTHOR;
        }
    }
}