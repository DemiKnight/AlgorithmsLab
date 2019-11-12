using System;

namespace L7_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            printNumbers(5);
//            Console.ReadLine();
        }
        
        static void printNumbers(int n)
        {
            if (n>0)
            {
                Console.WriteLine(" n = {0} ", n);
                printNumbers ( n - 1 );
            }
            Console.WriteLine("{0} Recursive Unfolding ", n);
            
            // 6 times called.
            // All function spaces are cleared.
        }
    }
}