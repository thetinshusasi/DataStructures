using DataStructures.DataStructures.LinkedList;
using DataStructures.DataStructures.Stack;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            #region LinkedList Code
            //Console.WriteLine("Single Linked List");
            //SingleLinkedListAddToFirst();
            //Console.WriteLine(@"///////////////////////////////////////////////////////");
            //SingleLinkedListAddToLast();
            //Console.WriteLine(@"///////////////////////////////////////////////////////");
            //SingleLinkedListRemoveFirst();
            //Console.WriteLine(@"///////////////////////////////////////////////////////");
            //SingleLinkedListRemoveLast();
            //Console.WriteLine(@"///////////////////////////////////////////////////////");
            //SingleLinkedListContains();
            //Console.WriteLine(@"///////////////////////////////////////////////////////");
            //SingleLinkedListRemoveItem();
            //Console.WriteLine(@"///////////////////////////////////////////////////////");
            #endregion LinkedList Code

            #region Double LinkedList Code
            //Console.WriteLine("Double Linked List");
            //DoubleLinkedListAddToFirst();
            //Console.WriteLine(@"///////////////////////////////////////////////////////");
            //DoubleLinkedListAddToLast();
            //Console.WriteLine(@"///////////////////////////////////////////////////////");
            //DoubleLinkedListRemoveFirst();
            //Console.WriteLine(@"///////////////////////////////////////////////////////");
            //DoubleLinkedListRemoveLast();
            //Console.WriteLine(@"///////////////////////////////////////////////////////");
            //DoubleLinkedListContains();
            //Console.WriteLine(@"///////////////////////////////////////////////////////");
            //DoubleLinkedListRemoveItem();
            //Console.WriteLine(@"///////////////////////////////////////////////////////");

            #endregion Double LinkedList Code

            #region Stack via LinkedList           

            #endregion  Stack via LinkedList

            #region PostFix            
            Console.WriteLine("PostFix");
            Console.WriteLine(CalculatePostfix()); 
            Console.WriteLine(@"///////////////////////////////////////////////////////");
            #endregion PostFix 


            Console.ReadKey();
        }

        #region Single Linked List Static Cases Functions
        private static void SingleLinkedListAddToFirst()
        {
            Console.WriteLine("Method Name : " + "SingleLinkedListAddToFirst");
            CustomLinkedList<int> customLinkedList = new CustomLinkedList<int>();
            LinkedListNode<int> node1 = new LinkedListNode<int>(1);
            Console.WriteLine("Entering the first node and printing");
            customLinkedList.AddToFirst(node1);
            customLinkedList.PrintLinkedList();
            Console.WriteLine("Entering multiple Nodes  and printing");
            LinkedListNode<int> node2 = new LinkedListNode<int>(2);
            customLinkedList.AddToFirst(node2);
            LinkedListNode<int> node3 = new LinkedListNode<int>(3);
            customLinkedList.AddToFirst(node3);
            LinkedListNode<int> node4 = new LinkedListNode<int>(4);
            customLinkedList.AddToFirst(node4);
            customLinkedList.PrintLinkedList();
            Console.WriteLine("No of item in he list is  : " + customLinkedList.Count);
        }
        private static void SingleLinkedListAddToLast()
        {
            Console.WriteLine("Method Name : " + "SingleLinkedListAddToLast");
            CustomLinkedList<int> customLinkedList = new CustomLinkedList<int>();
            LinkedListNode<int> node1 = new LinkedListNode<int>(1);
            Console.WriteLine("Entering the first node and printing");
            customLinkedList.AddToLast(node1);
            customLinkedList.PrintLinkedList();
            Console.WriteLine("Entering multiple Nodes  and printing");
            LinkedListNode<int> node2 = new LinkedListNode<int>(2);
            customLinkedList.AddToLast(node2);
            LinkedListNode<int> node3 = new LinkedListNode<int>(3);
            customLinkedList.AddToLast(node3);
            LinkedListNode<int> node4 = new LinkedListNode<int>(4);
            customLinkedList.AddToLast(node4);
            customLinkedList.PrintLinkedList();
            Console.WriteLine("No of item in he list is  : " + customLinkedList.Count);

        }
        private static void SingleLinkedListRemoveFirst()
        {
            Console.WriteLine("Method Name : " + "SingleLinkedListRemoveFirst");
            CustomLinkedList<int> customLinkedList = new CustomLinkedList<int>();
            LinkedListNode<int> node1 = new LinkedListNode<int>(1);
            customLinkedList.AddToLast(node1);
            LinkedListNode<int> node2 = new LinkedListNode<int>(2);
            customLinkedList.AddToLast(node2);
            LinkedListNode<int> node3 = new LinkedListNode<int>(3);
            customLinkedList.AddToLast(node3);
            LinkedListNode<int> node4 = new LinkedListNode<int>(4);
            customLinkedList.AddToLast(node4);
            customLinkedList.PrintLinkedList();
            Console.WriteLine("No of item in he list is  : " + customLinkedList.Count);
            Console.WriteLine("Removing first item from the list");
            customLinkedList.RemoveFirst();
            customLinkedList.PrintLinkedList();
            Console.WriteLine("No of item in he list is  : " + customLinkedList.Count);


        }
        private static void SingleLinkedListRemoveLast()
        {
            Console.WriteLine("Method Name : " + "SingleLinkedListRemoveLast");
            CustomLinkedList<int> customLinkedList = new CustomLinkedList<int>();
            LinkedListNode<int> node1 = new LinkedListNode<int>(1);
            customLinkedList.AddToLast(node1);
            LinkedListNode<int> node2 = new LinkedListNode<int>(2);
            customLinkedList.AddToLast(node2);
            LinkedListNode<int> node3 = new LinkedListNode<int>(3);
            customLinkedList.AddToLast(node3);
            LinkedListNode<int> node4 = new LinkedListNode<int>(4);
            customLinkedList.AddToLast(node4);
            customLinkedList.PrintLinkedList();
            Console.WriteLine("No of item in he list is  : " + customLinkedList.Count);
            Console.WriteLine("Removing first item from the list");
            customLinkedList.RemoveLast();
            customLinkedList.PrintLinkedList();
            Console.WriteLine("No of item in he list is  : " + customLinkedList.Count);

            customLinkedList.RemoveLast();
            customLinkedList.PrintLinkedList();
            Console.WriteLine("No of item in he list is  : " + customLinkedList.Count);


            customLinkedList.RemoveLast();
            customLinkedList.PrintLinkedList();
            Console.WriteLine("No of item in he list is  : " + customLinkedList.Count);


            customLinkedList.RemoveLast();
            customLinkedList.PrintLinkedList();
            Console.WriteLine("No of item in he list is  : " + customLinkedList.Count);


            customLinkedList.RemoveLast();
            customLinkedList.PrintLinkedList();
            Console.WriteLine("No of item in he list is  : " + customLinkedList.Count);



        }
        private static void SingleLinkedListContains()
        {
            Console.WriteLine("Method Name : " + "SingleLinkedListContains");
            CustomLinkedList<int> customLinkedList = new CustomLinkedList<int>();
            LinkedListNode<int> node1 = new LinkedListNode<int>(1);
            customLinkedList.AddToLast(node1);
            LinkedListNode<int> node2 = new LinkedListNode<int>(2);
            customLinkedList.AddToLast(node2);
            LinkedListNode<int> node3 = new LinkedListNode<int>(3);
            customLinkedList.AddToLast(node3);
            LinkedListNode<int> node4 = new LinkedListNode<int>(4);
            customLinkedList.AddToLast(node4);
            customLinkedList.PrintLinkedList();
            Console.WriteLine("Does 1 exist in the list : " + customLinkedList.Contains(1));
            Console.WriteLine("Does 10 exist in the list : " + customLinkedList.Contains(10));




        }
        private static void SingleLinkedListRemoveItem()
        {
            Console.WriteLine("Method Name : " + "SingleLinkedListRemoveItem");
            CustomLinkedList<int> customLinkedList = new CustomLinkedList<int>();
            LinkedListNode<int> node1 = new LinkedListNode<int>(1);
            customLinkedList.AddToLast(node1);
            LinkedListNode<int> node2 = new LinkedListNode<int>(2);
            customLinkedList.AddToLast(node2);
            LinkedListNode<int> node3 = new LinkedListNode<int>(3);
            customLinkedList.AddToLast(node3);
            LinkedListNode<int> node4 = new LinkedListNode<int>(4);
            customLinkedList.AddToLast(node4);
            customLinkedList.PrintLinkedList();
            Console.WriteLine("Does 1 removed from the list : " + customLinkedList.Remove(1));
            customLinkedList.PrintLinkedList();
            Console.WriteLine("Does 10 removed from the list : " + customLinkedList.Remove(10));
            customLinkedList.PrintLinkedList();
            Console.WriteLine("Does 3 removed from the list : " + customLinkedList.Remove(3));
            customLinkedList.PrintLinkedList();
            LinkedListNode<int> node5 = new LinkedListNode<int>(5);
            customLinkedList.AddToLast(node5);
            LinkedListNode<int> node6 = new LinkedListNode<int>(6);
            customLinkedList.AddToLast(node6);
            customLinkedList.PrintLinkedList();
            Console.WriteLine("Does 6 removed from the list : " + customLinkedList.Remove(6));
            customLinkedList.PrintLinkedList();

        }
        #endregion Single Linked List Static Cases Functions



        #region Double Linked List Static Cases Functions
        private static void DoubleLinkedListAddToFirst()
        {
            Console.WriteLine("Method Name : " + "DoubleLinkedListAddToFirst");
            CustomDoublyLinkedList<int> CustomDoublyLinkedList = new CustomDoublyLinkedList<int>();
            DoublyLinkedListNode<int> node1 = new DoublyLinkedListNode<int>(1);
            Console.WriteLine("Entering the first node and printing");
            CustomDoublyLinkedList.AddToFirst(node1);
            CustomDoublyLinkedList.PrintLinkedList();
            Console.WriteLine("Entering multiple Nodes  and printing");
            DoublyLinkedListNode<int> node2 = new DoublyLinkedListNode<int>(2);
            CustomDoublyLinkedList.AddToFirst(node2);
            DoublyLinkedListNode<int> node3 = new DoublyLinkedListNode<int>(3);
            CustomDoublyLinkedList.AddToFirst(node3);
            DoublyLinkedListNode<int> node4 = new DoublyLinkedListNode<int>(4);
            CustomDoublyLinkedList.AddToFirst(node4);
            CustomDoublyLinkedList.PrintLinkedList();
            Console.WriteLine("No of item in he list is  : " + CustomDoublyLinkedList.Count);
        }
        private static void DoubleLinkedListAddToLast()
        {
            Console.WriteLine("Method Name : " + "DoubleLinkedListAddToLast");
            CustomDoublyLinkedList<int> CustomDoublyLinkedList = new CustomDoublyLinkedList<int>();
            DoublyLinkedListNode<int> node1 = new DoublyLinkedListNode<int>(1);
            Console.WriteLine("Entering the first node and printing");
            CustomDoublyLinkedList.AddToLast(node1);
            CustomDoublyLinkedList.PrintLinkedList();
            Console.WriteLine("Entering multiple Nodes  and printing");
            DoublyLinkedListNode<int> node2 = new DoublyLinkedListNode<int>(2);
            CustomDoublyLinkedList.AddToLast(node2);
            DoublyLinkedListNode<int> node3 = new DoublyLinkedListNode<int>(3);
            CustomDoublyLinkedList.AddToLast(node3);
            DoublyLinkedListNode<int> node4 = new DoublyLinkedListNode<int>(4);
            CustomDoublyLinkedList.AddToLast(node4);
            CustomDoublyLinkedList.PrintLinkedList();
            Console.WriteLine("No of item in he list is  : " + CustomDoublyLinkedList.Count);

        }
        private static void DoubleLinkedListRemoveFirst()
        {
            Console.WriteLine("Method Name : " + "DoubleLinkedListRemoveFirst");
            CustomDoublyLinkedList<int> CustomDoublyLinkedList = new CustomDoublyLinkedList<int>();
            DoublyLinkedListNode<int> node1 = new DoublyLinkedListNode<int>(1);
            CustomDoublyLinkedList.AddToLast(node1);
            DoublyLinkedListNode<int> node2 = new DoublyLinkedListNode<int>(2);
            CustomDoublyLinkedList.AddToLast(node2);
            DoublyLinkedListNode<int> node3 = new DoublyLinkedListNode<int>(3);
            CustomDoublyLinkedList.AddToLast(node3);
            DoublyLinkedListNode<int> node4 = new DoublyLinkedListNode<int>(4);
            CustomDoublyLinkedList.AddToLast(node4);
            CustomDoublyLinkedList.PrintLinkedList();
            Console.WriteLine("No of item in he list is  : " + CustomDoublyLinkedList.Count);
            Console.WriteLine("Removing first item from the list");
            CustomDoublyLinkedList.RemoveFirst();
            CustomDoublyLinkedList.PrintLinkedList();
            Console.WriteLine("No of item in he list is  : " + CustomDoublyLinkedList.Count);


        }
        private static void DoubleLinkedListRemoveLast()
        {
            Console.WriteLine("Method Name : " + "DoubleLinkedListRemoveLast");
            CustomDoublyLinkedList<int> CustomDoublyLinkedList = new CustomDoublyLinkedList<int>();
            DoublyLinkedListNode<int> node1 = new DoublyLinkedListNode<int>(1);
            CustomDoublyLinkedList.AddToLast(node1);
            DoublyLinkedListNode<int> node2 = new DoublyLinkedListNode<int>(2);
            CustomDoublyLinkedList.AddToLast(node2);
            DoublyLinkedListNode<int> node3 = new DoublyLinkedListNode<int>(3);
            CustomDoublyLinkedList.AddToLast(node3);
            DoublyLinkedListNode<int> node4 = new DoublyLinkedListNode<int>(4);
            CustomDoublyLinkedList.AddToLast(node4);
            CustomDoublyLinkedList.PrintLinkedList();
            Console.WriteLine("No of item in he list is  : " + CustomDoublyLinkedList.Count);
            Console.WriteLine("Removing first item from the list");
            CustomDoublyLinkedList.RemoveLast();
            CustomDoublyLinkedList.PrintLinkedList();
            Console.WriteLine("No of item in he list is  : " + CustomDoublyLinkedList.Count);

            CustomDoublyLinkedList.RemoveLast();
            CustomDoublyLinkedList.PrintLinkedList();
            Console.WriteLine("No of item in he list is  : " + CustomDoublyLinkedList.Count);


            CustomDoublyLinkedList.RemoveLast();
            CustomDoublyLinkedList.PrintLinkedList();
            Console.WriteLine("No of item in he list is  : " + CustomDoublyLinkedList.Count);


            CustomDoublyLinkedList.RemoveLast();
            CustomDoublyLinkedList.PrintLinkedList();
            Console.WriteLine("No of item in he list is  : " + CustomDoublyLinkedList.Count);


            CustomDoublyLinkedList.RemoveLast();
            CustomDoublyLinkedList.PrintLinkedList();
            Console.WriteLine("No of item in he list is  : " + CustomDoublyLinkedList.Count);



        }
        private static void DoubleLinkedListContains()
        {
            Console.WriteLine("Method Name : " + "DoubleLinkedListContains");
            CustomDoublyLinkedList<int> CustomDoublyLinkedList = new CustomDoublyLinkedList<int>();
            DoublyLinkedListNode<int> node1 = new DoublyLinkedListNode<int>(1);
            CustomDoublyLinkedList.AddToLast(node1);
            DoublyLinkedListNode<int> node2 = new DoublyLinkedListNode<int>(2);
            CustomDoublyLinkedList.AddToLast(node2);
            DoublyLinkedListNode<int> node3 = new DoublyLinkedListNode<int>(3);
            CustomDoublyLinkedList.AddToLast(node3);
            DoublyLinkedListNode<int> node4 = new DoublyLinkedListNode<int>(4);
            CustomDoublyLinkedList.AddToLast(node4);
            CustomDoublyLinkedList.PrintLinkedList();
            Console.WriteLine("Does 1 exist in the list : " + CustomDoublyLinkedList.Contains(1));
            Console.WriteLine("Does 10 exist in the list : " + CustomDoublyLinkedList.Contains(10));




        }
        private static void DoubleLinkedListRemoveItem()
        {
            Console.WriteLine("Method Name : " + "DoubleLinkedListRemoveItem");
            CustomDoublyLinkedList<int> CustomDoublyLinkedList = new CustomDoublyLinkedList<int>();
            DoublyLinkedListNode<int> node1 = new DoublyLinkedListNode<int>(1);
            CustomDoublyLinkedList.AddToLast(node1);
            DoublyLinkedListNode<int> node2 = new DoublyLinkedListNode<int>(2);
            CustomDoublyLinkedList.AddToLast(node2);
            DoublyLinkedListNode<int> node3 = new DoublyLinkedListNode<int>(3);
            CustomDoublyLinkedList.AddToLast(node3);
            DoublyLinkedListNode<int> node4 = new DoublyLinkedListNode<int>(4);
            CustomDoublyLinkedList.AddToLast(node4);
            CustomDoublyLinkedList.PrintLinkedList();
            Console.WriteLine("Does 1 removed from the list : " + CustomDoublyLinkedList.Remove(1));
            CustomDoublyLinkedList.PrintLinkedList();
            Console.WriteLine("Does 10 removed from the list : " + CustomDoublyLinkedList.Remove(10));
            CustomDoublyLinkedList.PrintLinkedList();
            Console.WriteLine("Does 3 removed from the list : " + CustomDoublyLinkedList.Remove(3));
            CustomDoublyLinkedList.PrintLinkedList();
            DoublyLinkedListNode<int> node5 = new DoublyLinkedListNode<int>(5);
            CustomDoublyLinkedList.AddToLast(node5);
            DoublyLinkedListNode<int> node6 = new DoublyLinkedListNode<int>(6);
            CustomDoublyLinkedList.AddToLast(node6);
            CustomDoublyLinkedList.PrintLinkedList();
            Console.WriteLine("Does 6 removed from the list : " + CustomDoublyLinkedList.Remove(6));
            CustomDoublyLinkedList.PrintLinkedList();

        }
        #endregion Double Linked List Static Cases Functions

        #region Stack Linked List Static Cases Functions

        /// Simple enough that its easy
        #endregion Stack Linked List Static Cases Functions


        #region Postfix Cal functions
        private static int CalculatePostfix()
        {
            var expr = "52+";
            var postfix = new PostfixCalculator();
            var output = postfix.CalculatePostfix(expr);
            return output;
        }
        #endregion Postfix Cal functions


    }
}
