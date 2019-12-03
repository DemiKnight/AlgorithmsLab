using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace L8_Ex1
{
    public class Node<T> where T : IComparable
    {
        private T _data;
        private int _level = 0;
        public Node<T> Left, Right;

        public Node(T data)
        {
            this._data = data;
        }

        public Node()
        {
        }

        public T Data
        {
            get => _data;
            set => _data = value;
        }
        
    }
}