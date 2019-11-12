using System;

namespace L7_Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            range(10, 5);
        }

        static void range(int min, int max)
        {
            if (min > max) range(max, min);
            else if (min != max)
            {
                Console.WriteLine(min);
                min++;
                range(min, max);
            }else Console.WriteLine(min);
        }
    }
}