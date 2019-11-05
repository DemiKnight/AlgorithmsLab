using System;
using System.Collections;
    
namespace L6_Ex1
{
    class Program
    {
        static ArrayList tempArray = new ArrayList() {"First", "Second", "Third", "Fourth"};
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            PrintArray();
            
            tempArray.Sort();
            
            PrintArray();
            
        }

        public static void PrintArray()
        {
            foreach (string str in tempArray)
                Console.WriteLine("{0}, ", str);
        }
    }
}