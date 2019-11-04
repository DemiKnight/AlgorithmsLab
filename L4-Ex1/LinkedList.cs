using System;
using System.Diagnostics;
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
                bool Nend = true;
                bool found = false;
                
                Link tempLink = newList;
                
                while (Nend)
                {
                    

                    if (!found)
                    {
                        if (tempLink.NextLink == null)
                        {
                            tempLink.NextLink = new Link(item);
                            Nend = false;
                        }else if (tempLink.Value == item)
                        {
                            tempLink.NextLink = new Link(item, tempLink.NextLink);
                            found = true;
                        } else if (tempLink.Value < item)
                        {
                            tempLink.NextLink = new Link(item, tempLink.NextLink);
                            found = true;
                        }else /*if (tempLink.Value > item)*/
                        {
                            //Matched none of the citeria
                            tempLink = tempLink.NextLink;
                        }                  
                    }
                    else
                    {
                        tempLink = tempLink.NextLink;
                    }
                    
                    
                    
                }
            }
        }

        public void InsertOrder2(int newItem)
        {
            for (Link targetLink = list; targetLink != null ;targetLink = targetLink.NextLink)
            {
                Link highestVal = null;

                for (Link rangeSelected = targetLink.NextLink; rangeSelected != null; rangeSelected = rangeSelected.NextLink)
                {
                    if (targetLink.Value < rangeSelected.Value)
                    {
                        if (highestVal == null || highestVal.Value < rangeSelected.Value)
                        {
                            highestVal = rangeSelected;                            
                        }
                    }
                }

                if (highestVal != null)
                {
                    int tempInt = targetLink.Value;

                    targetLink.Value = highestVal.Value;
                    highestVal.Value = tempInt;
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