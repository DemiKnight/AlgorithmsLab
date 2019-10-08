using System;

namespace L3_Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            IntQueue newQueue = new IntQueue();
            
            newQueue.Enqueue(10);
            newQueue.Enqueue(22);
            newQueue.Enqueue(30);
            newQueue.Enqueue(44);
            newQueue.Enqueue(2);
            
            Console.WriteLine(newQueue.Dequeue());
            Console.WriteLine(newQueue.Dequeue());
            Console.WriteLine(newQueue.Dequeue());
            
            Console.WriteLine("Hello World!");
            Console.WriteLine(newQueue.ToString());
        }
    }
}