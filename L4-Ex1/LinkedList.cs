using System;
using System.Text;

namespace L4_Ex1
{
    public class LinkedList
    {
        private Link list = null;
        
        //TODO Explore whether using a while(list.NextLink == null) would be quicker.
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


        public void Remove2()
        {
//            Link mainIterator = list;
//            Link 
            
        }

        public void RemoveItem(int item)
        {
            //Remove all first instances of the item, if needed
            if (item == list.Value)
                do
                {
                    RemoveFirst();
                } while (list.Value == item);
            
            //Due to RemoveFirst() mutating list, it needs to be called first.
            Link tempLink = list; //Remove and just use list
            Link previous = tempLink;

            /*do
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
                
            } while (tempLink.NextLink != null);*/
            
//            for (Link index = tempLink; index.NextLink != null; index = index.NextLink)
            for (int index = 0; index < numberOfItems; index++)
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
        }

        public void RemoveFirst()
        {
            list = list.NextLink;
            numberOfItems--;
        }

        public void InsertInOrder(int item)
        {
            numberOfItems++;
            Link newList = new Link(list.Value, new Link(list.NextLink.Value));
            list = list.NextLink.NextLink;
            
            for (int index = 0; index < numberOfItems ; index++)
            {
                bool Nend = false;
                
                while (Nend)
                {
                    if (list.Value == item)
                    {
                        
                    }                    
                }
            }
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