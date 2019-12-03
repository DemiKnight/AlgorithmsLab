using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection.Metadata.Ecma335;

namespace L8_Ex1
{
    public class BinaryTree<T> where T : IComparable
    {
        protected Node<T> _mainNode;
//        private readonly GetOrder _DEFAULT_SORT = GetOrder.InOrder; 
        protected int _degree = 0;
        protected int _height = 0;

        public BinaryTree(T startingVal)
        {
            _mainNode = new Node<T>(startingVal);            
        }

        public Node<T> MainNode
        {
            get => _mainNode;
            set => _mainNode = value;
        }

        public string GetTree(GetOrder order = default)
        {
            string returnStr = "";

            GetTree(ref returnStr, order);

            return returnStr;
        }
        

        public override string ToString()
        {
            return GetTree();
        }

        public void GetTree(ref string returnStr)
        {
            GetTree(ref returnStr, GetOrder.InOrder);
        }

        public void GetTree(ref string returnStr, GetOrder order)
        {
            switch (order)
            {
                case GetOrder.InOrder:
                    InOrder(ref returnStr, ref _mainNode);
                    break;
                case GetOrder.PreOrder:
                    PreOrder(ref returnStr, ref _mainNode);
                    break;
                default: case GetOrder.PostOrder: 
                    PostOrder(ref returnStr, ref _mainNode);
                    break;
            }
        }

        
        protected void PreOrder(ref string returnStr, ref Node<T> selectedNode)
        {
            if (selectedNode != null)
            {
                returnStr += " " +  selectedNode.Data;

                if (selectedNode.Left != null)
                {
                     PreOrder(ref returnStr, ref selectedNode.Left);
                }
                
                if (selectedNode.Right != null)
                {
                    PreOrder(ref returnStr, ref selectedNode.Right);
                }
            }
        }
        
        protected void PostOrder(ref string returnStr, ref Node<T> selectedNode)
        {
            if (selectedNode != null)
            {
                if (selectedNode.Left != null)
                {
                    PostOrder(ref returnStr, ref selectedNode.Left);
                }
                
                if (selectedNode.Right != null)
                {
                    PostOrder(ref returnStr, ref selectedNode.Right);
                }
                
                returnStr += " " +  selectedNode.Data;
            }
        }

        protected void InOrder(ref string returnStr, ref Node<T> selectedNode)
        {
            if (selectedNode != null)
            {
                if (selectedNode.Left != null)
                {
                    InOrder(ref returnStr, ref selectedNode.Left);
                }
                returnStr += " " +  selectedNode.Data;
                if (selectedNode.Right != null)
                {
                    InOrder(ref returnStr, ref selectedNode.Right);
                }
            }
        }

        public void Copy(Node<T> copyToTree)
        {
            copy(ref _mainNode, copyToTree);
        }

        protected void copy(ref Node<T> mainNode, Node<T> copyFrom)
        {
            if (copyFrom != null)
            {
                mainNode = new Node<T>(copyFrom.Data);
                
                if (copyFrom.Left != null)
                {
                    if (mainNode.Left == null) mainNode.Left = new Node<T>();

                    copy( ref mainNode.Left , copyFrom.Left);
                }
                
                
                if (copyFrom.Right != null)
                {
                    if (mainNode.Right == null) mainNode.Right = new Node<T>();
                    copy(ref mainNode.Right, copyFrom.Right);
                }
            }
        }

        public int Degree => _degree;

        public int Height => _height;
        
        
    }
}