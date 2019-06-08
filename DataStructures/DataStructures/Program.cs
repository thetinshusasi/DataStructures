using DataStructures.DataStructures.LinkedList;
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


            LinkedListAddToFirst();
            Console.WriteLine(@"///////////////////////////////////////////////////////");
            LinkedListAddToLast();
            Console.WriteLine(@"///////////////////////////////////////////////////////");
            LinkedListRemoveFirst();
            Console.WriteLine(@"///////////////////////////////////////////////////////");
            LinkedListRemoveLast();
            Console.WriteLine(@"///////////////////////////////////////////////////////");
            LinkedListContains();
            Console.WriteLine(@"///////////////////////////////////////////////////////");
            LinkedListRemoveItem();
            Console.WriteLine(@"///////////////////////////////////////////////////////");


            #endregion LinkedList Code

            Console.ReadKey();
        }

        private static void LinkedListAddToFirst()
        {
            Console.WriteLine("Method Name : " + "LinkedListAddToFirst");
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
        private static void LinkedListAddToLast()
        {
            Console.WriteLine("Method Name : " + "LinkedListAddToLast");
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
        private static void LinkedListRemoveFirst()
        {
            Console.WriteLine("Method Name : " + "LinkedListRemoveFirst");
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
        private static void LinkedListRemoveLast()
        {
            Console.WriteLine("Method Name : " + "LinkedListRemoveLast");
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
        private static void LinkedListContains()
        {
            Console.WriteLine("Method Name : " + "LinkedListContains");
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

        private static void LinkedListRemoveItem()
        {
            Console.WriteLine("Method Name : " + "LinkedListRemoveItem");
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
    }
}
