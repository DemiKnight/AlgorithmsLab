using System;
using System.Collections;
using System.Collections.Generic;

namespace L6_Ex2
{
    public class Program
    {
        static LinkedList<int> tempArray = new LinkedList<int>();
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            tempArray.AddFirst(1);
            tempArray.AddFirst(2);
            tempArray.AddFirst(3);
            tempArray.AddFirst(4);
            tempArray.AddFirst(5);
            
            PrintArray();
            
            tempArray.Remove(3);
            
            PrintArray();
            
            
        }

        public static void PrintArray()
        {
            foreach (int str in tempArray)
                Console.WriteLine("{0}, ", str);
        }
    }
}