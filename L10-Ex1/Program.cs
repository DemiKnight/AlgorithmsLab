using System;
using L8_Ex1;

namespace L10
{
    class Program
    {
        static void Main(string[] args)
        {
            String outputStr = "";
            BSTree<int> testTree = new BSTree<int>(7);

            testTree.InsertItem(16);
            testTree.InsertItem(3);
            testTree.InsertItem(10);
            testTree.InsertItem(2);
            testTree.InsertItem(17);
            
            testTree.GetTree(ref outputStr, GetOrder.InOrder);
            Console.WriteLine(outputStr);
            Console.WriteLine(testTree.CalcHeight());
            Console.WriteLine(testTree.CalcCount());
            Console.WriteLine(testTree.Contains(5));

            testTree.RemoveItem(2);
            Console.WriteLine(outputStr);
        }
    }
}