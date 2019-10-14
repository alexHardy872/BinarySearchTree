using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {




            BinarySearchTree searchTree = new BinarySearchTree();


            searchTree.AddToTree(100);
            searchTree.AddToTree(82);
            searchTree.AddToTree(116);
            searchTree.AddToTree(78);
            searchTree.AddToTree(93);
            searchTree.AddToTree(105);
            searchTree.AddToTree(123);
            searchTree.AddToTree(3);

            Console.WriteLine(searchTree.Search(4));
            Console.WriteLine(searchTree.Search(123));
            Console.WriteLine(searchTree.Search(5));
            Console.WriteLine(searchTree.Search(93));
            Console.WriteLine(searchTree.Search(99));


            Console.ReadLine();




        }
    }
}
