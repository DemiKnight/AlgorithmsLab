using System;
using System.Text;

namespace L5_Ex1
{
    public class LinkList <T> where T:IComparable
    {
        private Link<T> mainList = null;
        private uint numberOfItems;
        
        public LinkList(T newData)
        {
            mainList = new Link<T>(newData);
            numberOfItems++;
        }

        public LinkList(T[] newData)
        {
            Link<T> lastLink = null;
            foreach (T selectData in newData)
            {
                Link<T> newLink = new Link<T>(selectData);

                if (lastLink == null)
                {
                    mainList = newLink;
                    lastLink = newLink;
                }
                else
                {
                    lastLink.NextLink = newLink;
                    lastLink = newLink;
                }
                
                numberOfItems++;
            }
        }
        

        public void addItem(T newData)
        {
            Link<T> tempLink = mainList;
            for (int index = 0; index < numberOfItems; index++)
            {
                if (tempLink.NextLink == null)
                {
                    tempLink.NextLink = new Link<T>(newData);
                }
                else tempLink = tempLink.NextLink;
                
            }
            numberOfItems++;
        }

        public string DisplayList()
        {
            StringBuilder strReturn = new StringBuilder();

            for (
                Link<T> selectedLink = mainList; 
                selectedLink != null; 
                selectedLink = selectedLink.NextLink)
            {
                Console.WriteLine(selectedLink.Data.ToString());
                
            }
            
            return strReturn.ToString();
        }

        public uint Length => numberOfItems;

        public bool IsPresentItem(T item)
        {
            for (
                Link<T> selectedLink = mainList; 
                selectedLink != null; 
                selectedLink = selectedLink.NextLink)
            {
                Console.WriteLine(selectedLink.Data.ToString());
                                
            }

            return false;
        }

        public void RemoveItem(T Item)
        {
            if (mainList.CompareTo(Item) == 0)
            {
                
            }
        }

        public void RemoveFirst()
        {
            if (mainList.NextLink == null)
            {
                mainList = null;
            }
            else
            {
                mainList = mainList.NextLink;
            }

            numberOfItems--;
        }

    }
}