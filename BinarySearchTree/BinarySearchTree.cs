using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearchTree
    {
        Node root = null;

        public BinarySearchTree()
        {


        }




        public void AddToTree(int data)
            {
            Node node = new Node(data);
            if (root == null)
            {
                root = node;
            }
            else
            {
                Node temp = root;
                RecursiveAdd(node, temp);
            }
        }

        public void RecursiveAdd(Node node, Node temp)
        {       
            if (node.data <= temp.data)
            {
                if (temp.leftChild != null)
                {
                    RecursiveAdd(node, temp.leftChild);
                }
                else
                {
                    temp.leftChild = node;
                }     
            }
            else
            {
                if (temp.rightChild != null)
                {
                    RecursiveAdd(node, temp.rightChild);
                }
                else
                {
                    temp.rightChild = node;
                }           
            }
        }
       

        public bool Search(int target)
        {
            bool success = RecursiveSearch(target, root);
            if (success == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RecursiveSearch(int target, Node middle)
        {
            if (target == middle.data)
            {
                return true;
            }
            else if ( target < middle.data)
            {
                if (middle.leftChild == null)
                {
                    return false;
                }
                else 
                {
                    return RecursiveSearch(target, middle.leftChild);
                }            
            }
            else
            {
                if (middle.rightChild == null)
                {
                    return false;
                }
               else
                {
                    return RecursiveSearch(target, middle.rightChild);
                }           
            }
        }












    }
}
