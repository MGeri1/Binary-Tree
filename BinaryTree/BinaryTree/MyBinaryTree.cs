using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class BinaryTree
    {
        public TreeNode Root;

        public BinaryTree()
        {
            this.Root = null;
        }

        public void Dump()
        {
            this.PrintTree(this.Root, 0);
        }

        private void PrintTree(TreeNode node, int role, string indent = "")
        {
            string prefix = "";
            switch (role)
            {
                case 0: // root node
                    prefix = "──  Root ";
                    break;
                case -1: // left node
                    prefix = indent + "├──  left  ";
                    break;
                case 1: // right node
                    prefix = indent + "└──  right ";
                    break;
                default:
                    break;
            }
            if (role != 0)
            {
                Console.WriteLine(indent + "│");
            }
            if (node == null)
            {
                Console.WriteLine(prefix + " null");
            }
            else
            {
                Console.WriteLine(prefix + node.Data);
                string padding = (role == -1) ? "│    " : "     ";

                this.PrintTree(node.Left, -1, indent + padding);
                this.PrintTree(node.Right, 1, indent + padding);
            }
            
            //log.debug(prefix + nodeConnection + nodeName);
            return;
        }
    }

    // Node of tree
    class TreeNode
    {
        public int Data;
        public TreeNode Left;
        public TreeNode Right;

        public TreeNode()
        {
            this.Data = 0;
            this.Left = null;
            this.Right = null;
        }
        public TreeNode(int value)
        {
            this.Data = value;
            this.Left = null;
            this.Right = null;
        }
    }
}
