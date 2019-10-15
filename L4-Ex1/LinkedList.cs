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


        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            Link tempLink = list;
            
            
            output.Append("[");
            for (int index = 0; index < numberOfItems; index++)
            {
                output.Append(tempLink.Value + ",");
                tempLink = tempLink.NextLink;
            }
            
            
            output.Append("]");
            
            
            return output.ToString();
        }
        
        public bool IsPresentItem(int item)
        {
            Link tempLIst = list;
            for (int index = 0; index < numberOfItems; index++)
            {
                if (tempLIst.Value == item) return true;

                tempLIst = tempLIst.NextLink;
            }
            
            return false;
        }

        public void RemoveItem(int item)
        {
            Link tempLink = list; //Remove and just use list
            Link previous = tempLink;
            int tempMax = numberOfItems;

            for (int index = 0; index < tempMax; index++)
            {
                
                if (tempLink.Value == item)
                {
                    previous.NextLink = tempLink.NextLink;
                    numberOfItems--;
                }
                else
                {
                    previous = tempLink;
                }

                tempLink = previous;
                tempLink = tempLink.NextLink;
            }

            
            Console.WriteLine(tempLink);
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

        public void RemoveIndex(int index)
        {
            
        }
        
        public int Length => numberOfItems;

        public Link getBase
        {
            get => list;
        }
    }
}