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
               
               /*

                while (node.data <= temp.data)
                {
                    while (temp.leftChild != null)
                    {
                        temp = temp.leftChild;

                    }
                    
                    temp.leftChild = node;
                    break;

                }

                while (node.data > temp.data)
                {
                    while (temp.rightChild != null)
                    {
                        temp = temp.rightChild;

                    }

                    temp.rightChild = node;
                    break;

                } */

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
       

        public void Search(int target)
        {
            Recursive(target, root);
            // recursive
            // check if initial key is equal
            // is greater or less than root?
            // if not move other way
            // return the node?

        }

        public Node Recursive(int target, Node middle)
        {
            if (target == middle.data)
            {
                return middle;
            }
            else if ( target < middle.data)
            {
                return Recursive(target, middle.leftChild);
            }
            else
            { 
                return Recursive(target, middle.rightChild);
            }
           

        }












    }
}
