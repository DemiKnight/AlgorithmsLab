using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Lec2
{
    public class Book : IComparable
    {
        private string title;
        private Person author;
        private string[] blurb; 

        protected static readonly Person DEFAULT_AURTHOR = new Person("Stephen King", 72);
        protected static readonly Book DEFAULT_BOOK = new Book("Lorem Ipsum", DEFAULT_AURTHOR, new []{ "Fantastic Book about programming and pointers" } );
        
        public Book(string newTitle)
        {
            this.title = newTitle;
            this.author = DEFAULT_AURTHOR;
            this.blurb = DEFAULT_BOOK.blurb;
        }

        public Book(string title, Person author)
        {
            this.title = title;
            this.author = author;
            this.blurb = DEFAULT_BOOK.blurb;
        }

        public Book(string newTitle, Person newAuthor, List<string> newBlurb)
        {
            this.title = newTitle;
            this.author = newAuthor;
            this.blurb = newBlurb.ToArray(); //Is this unsecure?
        }

        public Book(string title, Person author, string[] blurb)
        {
            this.title = title;
            this.author = author;
            this.blurb = (string[]) blurb.Clone(); //Is this the proper way?
        }


        public string GetSummaryStr()
        {
            return String.Format("Title: {0}\nAuthor:\n\tName: {1}\n\tAge: {2}\nSummary: \n\t{3}", 
                this.title, 
                this.author.Name, 
                this.author.Age, 
                String.Join("\n\t", blurb));
        }

        public void GetSummary()
        {
            Console.WriteLine(GetSummaryStr());
        }
        
        public string Title
        {
            get => title;
            set => title = value;
        }

        public string[] Blurb
        {
            get => blurb;
            set => blurb = value;
        }

        public List<string> BlurbList
        {
            get
            {
                return new List<string>(blurb);
            }
            set { blurb = value.ToArray(); }
        }
        public Person Author
        {
            get => author;
            set => author = value;
        }

        public int CompareTo(object obj)
        {
            Book newBook = (Book) obj;
            
            return String.Compare(title, newBook.title, StringComparison.Ordinal);
        }
        
        public static Person DefaultAuthor
        {
            get => DEFAULT_AURTHOR;
        }
    }
}