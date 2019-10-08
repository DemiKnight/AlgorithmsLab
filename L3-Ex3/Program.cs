using System;
using L3_EX2;

namespace L3_Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomGen = new Random();
            IntStack newStack = new IntStack();

            for (int index = 0; index < 10; index++)
            {
                newStack.Push(randomGen.Next(100));
            }

            for (int index = 0; index <= newStack.Length-1; index++)
            {
                    Console.WriteLine("{0} index, with value {1}", index, newStack.Pop());
            }
        }
    }
}