using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace L6_Ex3
{
    public class BookManager
    {
        Dictionary<string, Book> bookStore = new Dictionary<string, Book>();


        public void addBook(Book newBook)
        {
            bookStore.Add(newBook.Name,newBook);
        }

        public void addBook(ICollection<Book> newBooks)
        {
            foreach(Book newBook in newBooks)
                addBook(newBook);
        }
        
        /**
         * @return 0 for successful, -1 for not found.
         */
        public short removeBook(Book newBook)
        {
            return (short) (bookStore.Remove(newBook.Name) ? 0 : -1);
        }

        /**
         * 0 for successful, 1... for number of books unable to be removed
         */
        public short removeBook(ICollection<Book> newBooks)
        {
            short numberOfBooksRemoved = (short) newBooks.Count;

            foreach (Book selectedBOok in newBooks)
            {
                if(!bookStore.Remove(selectedBOok.Name)) numberOfBooksRemoved -= 1;
            }
            

            return numberOfBooksRemoved;
        }
        
        /**
         * @param newBooks Books to be removed.
         * @param unableToBeAdded Books that couldn't be removed, due to not being present.
         */
        public void removeBook(ICollection<Book> newBooks, ref ICollection<Book> unableToBeAdded)
        {
            foreach (Book selectedBOok in newBooks)
            {
                if (!bookStore.Remove(selectedBOok.Name))
                {
                    if (unableToBeAdded == null) unableToBeAdded = new List<Book>();
                    
                    unableToBeAdded.Add(selectedBOok);
                }
            }    
            
        }

        /**
         * @return A array of any books with OnLoan, or null if none are found.
         */
        public Book[] getOnLoanBooks()
        {
            List<Book> tempList = new List<Book>();

            foreach (KeyValuePair<string, Book> selectedBOok in bookStore)
                if(selectedBOok.Value.OnLoan) tempList.Add(selectedBOok.Value);

            return tempList.ToArray();
        }
        
        /**
         * @param bookSubstring Either book title or isbn
         * @null if none found.
         */
        public Book[] searchBooks(string bookSubstring)
        {
            List<Book> tempList = new List<Book>();

            foreach (KeyValuePair<string, Book> selectedBOok in bookStore)
                if(
                    selectedBOok.Key.Contains(bookSubstring, StringComparison.OrdinalIgnoreCase) || 
                    selectedBOok.Value.Isbn.Contains(bookSubstring, StringComparison.OrdinalIgnoreCase)) tempList.Add(selectedBOok.Value);

            return tempList.ToArray();
        }
        
        public Book[] getBooks()
        {
            List<Book> tempList = new List<Book>();
            
            foreach (KeyValuePair<string, Book> selectedBOok in bookStore)
                tempList.Add(selectedBOok.Value);
            
            return tempList.ToArray();
        }
         
        
        
    }
}