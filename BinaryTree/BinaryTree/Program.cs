using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree myTree = new BinaryTree();

            myTree.Root = new TreeNode(2);
            myTree.Root.Left = new TreeNode(7);
            myTree.Root.Left.Left = new TreeNode(2);
            myTree.Root.Left.Right = new TreeNode(6);
            myTree.Root.Left.Right.Left = new TreeNode(5);
            myTree.Root.Left.Right.Right = new TreeNode(11);
            myTree.Root.Right = new TreeNode(5);
            myTree.Root.Right.Right = new TreeNode(9);
            myTree.Root.Right.Right.Left = new TreeNode(4);

            myTree.Dump();
            Console.ReadKey();
        }
    }
}
