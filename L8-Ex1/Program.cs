using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace L8_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> testTree = new BinaryTree<int>(6);
            BinaryTree<int> testTree2 = new BinaryTree<int>(1);
            
            testTree.MainNode.Left = new Node<int>(2);
            testTree.MainNode.Right = new Node<int>(15);
            testTree.MainNode.Left.Right = new Node<int>(5);
            
            testTree2.MainNode.Left = new Node<int>(2);
            testTree2.MainNode.Right = new Node<int>(3);
            testTree2.MainNode.Left.Left = new Node<int>(4);
            testTree2.MainNode.Left.Right = new Node<int>(5);
            
            testTree2.MainNode.Right.Left = new Node<int>(6);
            testTree2.MainNode.Right.Right = new Node<int>(7);
            
            String testStr = "";
            testTree.GetTree(ref testStr, GetOrder.InOrder);
            Console.WriteLine(testStr);
    
            testTree.Copy(testTree2.MainNode);

            testStr = "";
            testTree2.GetTree(ref testStr, GetOrder.InOrder);
            Console.WriteLine(testStr);


        }
    }
}