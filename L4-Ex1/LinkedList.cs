using System;
using System.Text;

namespace L4_Ex1
{
    public class LinkedList
    {
        private Link list = null;
        private int numberOfItems = 0;
        
        public void addValue(int newInt)
        {
            numberOfItems++;
            list = new Link(newInt, list);            
        }

        public void append()
        {
            Link currentLink = list;
            
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            Link tempLink = list;
            
            Console.WriteLine(list.Value);
            
            output.Append("[");
            while (tempLink.NextLink != null)
            {
                output.Append(tempLink.Value + ",");
                tempLink.NextLink = tempLink.NextLink.NextLink;
            }
            output.Append("]");
            
            
            return output.ToString();
        }
        
        public bool IsPresentItem(int item)
        {
            return false;
        }

        public void RemoveItem(int item)
        {
                
        }

        public void InsertInOrder(int item)
        {
            
        }
        
        public int CalcLength()
        {
            Link tempLink = list;
            int numOfItems = 0;
            while (tempLink.NextLink != null)
            {
                numOfItems++;
                tempLink = tempLink.NextLink;
            }

            return numOfItems;
        }

        public int Length => numberOfItems;

        public Link getBase
        {
            get => list;
        }
    }
}