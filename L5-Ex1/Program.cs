using System;
//using System.Collections.Generic;
//using System.Linq;

//using System.Collections.Generic;

namespace L5_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkList<int> mainList = new LinkList<int>();

            LinkList<int> copyList = new LinkList<int>();
            
            LinkList<int> concatList = new LinkList<int>(); 
            
            mainList.addValue(3);
            mainList.addValue(4);
            mainList.addValue(1);
            mainList.addValue(2);
            mainList.addValue(24);
            mainList.addValue(5);
            mainList.addValue(33);
            
            concatList.addValue(14);
            concatList.addValue(74);
            concatList.addValue(9);
            
            
            Console.WriteLine(mainList.ToString());
            
            mainList.InsertOrder(15);
            
            mainList.Concat(concatList);
            
            mainList.Copy(ref copyList);

            Console.WriteLine("Is 2 present? {0}", mainList.IsPresentItem(24));
            
            mainList.RemoveItem(5);

            mainList.Sort();

            Console.WriteLine(mainList.ToString());
        }
    }
}