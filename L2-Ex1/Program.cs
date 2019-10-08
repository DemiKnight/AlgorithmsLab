using System;

namespace Lec2
{
    class Program
    {
        static void Main(string[] args)
        {
            Book[] books = 
            {
                new Book("Moby Dick", 
                    new Person("Herman Melville", 200), 
                    new string[] { "Book about whales and that"}),
                new Horror("iT", Horror.DefaultAuthor, new String[] 
                    {
                        "It is a group of children who see - and feel - what makes Derry so horribly different.", 
                        "In the storm drains, in the sewers, IT lurks, taking on the shape of every nightmare, each one's deepest dread.",
                        "Sometimes is appears as an evil clown named Pennywise and sometimes IT reaches up, seizing, tearing, killing . . ."
                    }),
                new Fantasy("Lord Of The Rings", Fantasy.DefaultAuthor, new string[]
                {
                    "Sauron, the Dark Lord, has gathered to him all the Rings of Power – the means by which he intends to rule Middle-earth.",
                    "All he lacks in his plans for dominion is the One Ring – the ring that rules them all – which has fallen into the hands of the hobbit, Bilbo Baggins."
                }), 
                
            };

//            books[1].GetSummary();

            foreach (Book selectedBook in books) selectedBook.GetSummary();
//                Console.WriteLine("{0} : {1}", selectedBook.Title, selectedBook.Author.Name);
            
            
        }
    }
}