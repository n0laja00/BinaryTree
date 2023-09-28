// See https://aka.ms/new-console-template for more information
using BinaryTree.models;
using System.Runtime.CompilerServices;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Tree Search\n");

            BinaryTreeModel binaryTree = new BinaryTreeModel();

            binaryTree.Insert(75);
            binaryTree.Insert(57);
            binaryTree.Insert(32);
            binaryTree.Insert(7);
            binaryTree.Insert(44);
            binaryTree.Insert(86);
            binaryTree.Insert(93);

            
            binaryTree.InOrderTraversal();
            Console.WriteLine("in order traversal (left -> root -> right)\n");
            
            binaryTree.PreOrderTraversal();
            Console.WriteLine("pre order traversal (root -> left -> right)\n");

            
            binaryTree.PostOrderTraversal();
            Console.WriteLine("post order traversal (left -> right -> root)\n");

            //find method
            Console.Write("Find 93, ja loysimme ");
            var node = binaryTree.Find(93);
            Console.Write(node.Data);

            //find recursive method
            Console.Write("\nFindRecursive 93, ja loysimme ");
            var nodeRec = binaryTree.FindRecursive(93);
            Console.Write(nodeRec.Data);
        }
    }
}



