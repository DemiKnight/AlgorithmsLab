using System;
using System.Diagnostics;
using L8_Ex1;

namespace L10
{
    public class BSTree <T> : BinaryTree<T> where T:IComparable
    {
        protected uint _count;
        
        public BSTree(T startingVal) : base(startingVal)
        {
        }

        public void InsertItem(T item)
        {
            if (_mainNode == null)
                _mainNode = new Node<T>(item);
            else insertItem(item, ref _mainNode);
        }

        private void insertItem(T newItem, ref Node<T> mainNode)
        {
            if (mainNode.Data.CompareTo(newItem) > 0)
            {
                if (mainNode.Left == null) mainNode.Left = new Node<T>(newItem);
                else 
                {
                    insertItem(newItem, ref mainNode.Left);                            
                }
                
            }else if (mainNode.Data.CompareTo(newItem) < 0)
            {
                if (mainNode.Right == null) mainNode.Right = new Node<T>(newItem);
                else 
                {
                    insertItem(newItem, ref mainNode.Right);                            
                }

            }
        }

        public uint CalcCount()
        {
            return _calcCount(_mainNode);
        }

        private uint _calcCount(Node<T> nodeToCheck)
        {
            uint returnVal = 0;
            if (nodeToCheck != null) returnVal++;
            if (nodeToCheck.Left != null)  returnVal += _calcCount(nodeToCheck.Left);
            if (nodeToCheck.Right != null) returnVal += _calcCount(nodeToCheck.Right);

            return returnVal;
        }
        
        
        public uint CalcHeight()
        {
            return CalcHeight(_mainNode);
        }

        protected uint CalcHeight(Node<T> selectedNode)
        {
            uint leftHeight = 0, rightHeight = 0;
            
            if (selectedNode != null)
            {
                leftHeight++;
                rightHeight++;
                if (selectedNode.Left != null) leftHeight += CalcHeight(selectedNode.Left);
                if (selectedNode.Right != null) rightHeight += CalcHeight(selectedNode.Right);
            }

            return (leftHeight >= rightHeight ? leftHeight : rightHeight);
        }

        public Boolean Contains(T item)
        {
            return Contains(item, _mainNode);
        }

        protected Boolean Contains(T item, Node<T> restNode)
        {
            if (restNode.Data.Equals(item)) return true;
            if (restNode.Left != null) return Contains(item, restNode.Left);
            if (restNode.Right != null) return Contains(item, restNode.Right);
            return false;
        }
        
        public void RemoveItem(T item)
        {
            
        }

        protected void RemoveItem(T item, ref Node<T> nodeToChange)
        {
            if (nodeToChange != null)
            {
                //TODO Check if result is == 0. first tree.
                int result = nodeToChange.Data.CompareTo(item);
                
                Node<T> nodeTemp = (result < 0 && result != 0 ? nodeToChange.Left : nodeToChange.Right);
                
//                if ()
//                {
//                    
//                }
                
                
            }
        }

        protected void findSmallest(ref T smallestSoFar, ref Node<T> selectNode)
        {
            if (selectNode.Data.CompareTo(smallestSoFar) < 0) smallestSoFar = selectNode.Data;

            if (selectNode.Left != null)
            {
                findSmallest(ref smallestSoFar, ref selectNode.Left);
            }

            if (selectNode.Right != null)
            {
                findSmallest(ref smallestSoFar, ref selectNode.Right);
            }
        }

        public uint Count
        {
            get => _count;
        }
        
    }
}
