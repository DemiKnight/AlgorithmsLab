using System;
using System.Text;

namespace L5_Ex1
{
    public class LinkList<Type> where Type : IComparable
    {
        private Link<Type> list = null;
        
        //TODO Explore whether using a while(list.NextLink == null) would be quicker.
        private int numberOfItems = 0;
        
        public void addValue(Type newInt)
        {
            numberOfItems++;
            list = new Link<Type>(newInt, list);            
        }


        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            Link<Type> tempLink = list;
            
            
            output.Append("[");
            for (int index = 0; index < numberOfItems; index++)
            {
                output.Append(tempLink.Value + ",");
                tempLink = tempLink.NextLink;
            }
            
            
            output.Append("]");
            
            
            return output.ToString();
        }
        
        public bool IsPresentItem(Type item)
        {
            Link<Type> tempLIst = list;
            for (int index = 0; index < numberOfItems; index++)
            {
                if (tempLIst.Value.CompareTo(item) == 0) return true;

                tempLIst = tempLIst.NextLink;
            }
            
            return false;
        }
        

        public void RemoveItem(Type item)
        {
            //Remove all first instances of the item, if needed
            if (item.CompareTo(list.Value) == 0)
                do
                {
                    RemoveFirst();
                } while (list.Value.CompareTo(list.Value) == 0);
            
            //Due to RemoveFirst() mutating list, it needs to be called first.
            Link<Type> tempLink = list; //Remove and just use list
            Link<Type> previous = tempLink;

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
                if (tempLink.Value.CompareTo(item) == 0)
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
        
        public void Sort()
        {
            for (Link<Type> targetLink = list; targetLink != null ;targetLink = targetLink.NextLink)
            {
                Link<Type> highestVal = null;

                for (Link<Type> rangeSelected = targetLink.NextLink; rangeSelected != null; rangeSelected = rangeSelected.NextLink)
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
        
        public void InsertOrder(int newItem)
        {
            Sort();

            for (Link<Type> target = list; target != null; target = target.NextLink)
            {
                if (target.Value > newItem && target.NextLink.Value < newItem)
                {
                    Link<Type> oldLink = target.NextLink;
                    target.NextLink = new Link<Type>(newItem, oldLink);
                }
            }
        }

        public int CalcLength()
        {
            Link<Type> tempLink = list;
            int numOfItems = 0;
            while (tempLink.NextLink != null)
            {
                numOfItems++;
                tempLink = tempLink.NextLink;
            }

            return numOfItems;
        }

        public void AppendItem(int index)
        {
            for (Link<Type> selectLink = list; selectLink == null; selectLink = selectLink.NextLink)
            {
                if (selectLink.NextLink == null)
                    selectLink.NextLink = new Link<Type>(index);
                
            }
        }
        
        public void Concat(LinkList<Type> newList)
        {
            bool finished = true;
            for (Link<Type> selectLink = list; selectLink != null && finished; selectLink = selectLink.NextLink)
            {
                if (selectLink.NextLink == null)
                {
                    selectLink.NextLink = newList.list;
                    finished = false;
                }
            }

            numberOfItems += newList.Length;
        }
        
        public void Copy(ref LinkList<Type> newList)
        {
            for (Link<Type> selectLink = list; selectLink != null; selectLink = selectLink.NextLink)
            {
                newList.addValue(selectLink.Value);
            }
            
        }
        
        public int Length => numberOfItems;

        public Link<Type> getBase
        {
            get => list;
        }
    }
}