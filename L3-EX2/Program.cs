using System;

namespace L3_EX2
{
    class Program
    {
        static void Main(string[] args)
        {
            IntStack mystack = new IntStack();

            mystack.Push(10);
            System.Console.WriteLine(mystack.Pop());

            mystack.Push(20);
            mystack.Push(30);
            mystack.Push(40);

            System.Console.WriteLine(mystack.Pop());
            System.Console.WriteLine(mystack.Pop());
            System.Console.WriteLine(mystack.Pop());
        }
    }
}