using System.Collections.Generic;

namespace Lec2
{
    public class Horror : Book
    {
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
    }
}