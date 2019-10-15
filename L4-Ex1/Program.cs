using System;

namespace L4_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            LinkedList mainList = new LinkedList();
            
            mainList.addValue(1);
            mainList.addValue(2);
            mainList.addValue(3);
            mainList.addValue(4);
            mainList.addValue(5);
            
            Link testLink = new Link(1, 
                new Link(2, new Link(3)));
            
            Console.WriteLine(mainList.ToString());
            mainList.RemoveItem(3);
            Console.WriteLine(mainList.ToString());




        }
    }
}