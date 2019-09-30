using System.Collections.Generic;

namespace Lec2
{
    public class SciFi : Book
    {
        public SciFi(string newTitle) : base(newTitle)
        {
        }

        public SciFi(string title, Person author) : base(title, author)
        {
        }

        public SciFi(string newTitle, Person newAuthor, List<string> newBlurb) : base(newTitle, newAuthor, newBlurb)
        {
        }

        public SciFi(string title, Person author, string[] blurb) : base(title, author, blurb)
        {
        }
    }
}