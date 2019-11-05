using System;
using System.Collections.Generic;


namespace L5_Ex1
{
    public class Link <Type>  where Type:IComparable
    {
        private Type data;
        private Link<Type> nextLink;


        public Link(Type newItem)
        {
            data = newItem;
        }

        public Link(Type newItem, Link<Type> newLink)
        {
            data = newItem;
            nextLink = newLink;
        }

        public Type Value
        {
            get => data;
            set => data = value;
        }

        public Link<Type> NextLink
        {
            get => nextLink;
            set => nextLink = value;
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return -2;

            Link<Type> tempObj = obj as Link<Type>;

            if (data.CompareTo(tempObj.data) < 0)
            {
                return -1;
            }
            
            if (data.Equals(tempObj.data))
            {
                return 0;
            }
            
            if (data.CompareTo(tempObj.Value) > 0)
            {
                return 1;
            }

            return -2;
        }
    }
}