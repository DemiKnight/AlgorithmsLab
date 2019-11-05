using System;

namespace L6_Ex3
{
    class Program
    {
        static BookManager bookM = new BookManager();
        
        
        static void Main(string[] args)
        {
            bookM.addBook(new Book("9780393356250", "Odyssey"));
            bookM.addBook(new Book("9780151010264", "Animal Farm"));
            bookM.addBook(new Book("9780141439518", "Pride and Prejudice"));
            bookM.addBook(new Book("9781520560885", "Through the Looking-Glass"));
            bookM.addBook(new Book("9020101020102", "Weird Book"));
            
            Console.WriteLine();
            
            Array.ForEach(bookM.getBooks(), book => Console.WriteLine(book.ToString()));
            
            Console.WriteLine();

            Console.WriteLine(bookM.searchBooks("Od")[0].ToString());

            bookM.removeBook(bookM.searchBooks("weird"));

            Array.ForEach(bookM.getBooks(), book => Console.WriteLine(book.ToString()));
        }
    }
}