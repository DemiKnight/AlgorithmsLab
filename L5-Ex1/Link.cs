using System;
using System.Collections.Generic;

namespace L5_Ex1
{
    public class Link <T>  where T:IComparable
    {
        private T data;
        private Link<T> nextLink = null;

        public Link(T newData)
        {
            data = newData;
        }

        public Link(T newData, Link<T> newLink)
        {
            data = newData;
            nextLink = newLink;
        }

        public T Data
        {
            get => data;
            set => data = value;
        }

        public Link<T> NextLink
        {
            get => nextLink;
            set => nextLink = value;
        }

//        public int CompareTo<Type>(Link<Type> compareObj)
//        {
////            Link<T> testObj = (Link<Type>) compareObj;
//            
//            if (compareObj.Data == this.data) return -1;
////            Link<TempT> tempLink = obj as Link<T>;
////            Link<T> tempLink = compareObj as Link<T>;
//
//            if (testObj.Data == this.Data)
//            {
//                
//            }
//            
//        }


        public int CompareTo(Link<T> other)
        {
            if (other == null) return -1;

            Link<T> test = other as Link<T>;
            
            if (this.data.CompareTo(other.Data) == 0)
            {
                
            }
            
            
        }
    }
}