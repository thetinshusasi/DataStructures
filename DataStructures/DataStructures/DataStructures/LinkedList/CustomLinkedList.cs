using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.DataStructures.LinkedList
{
    public class CustomLinkedList<T> : ICollection<T>
    {
        public LinkedListNode<T> Head { get; private set; }
        public LinkedListNode<T> Tail { get; private set; }

        public void AddToFirst(LinkedListNode<T> node)
        {
            var tempNode = Head;
            Head = node;
            Head.Next = tempNode;
            Count++;
            if (Count == 1)
            {
                Tail = Head;
            }

        }
        public void AddToLast(LinkedListNode<T> node)
        {
            if (Count == 0)
            {
                Head = node;
            }
            else
            {
                Tail.Next = node;
            }
            Tail = node;

            Count++;
        }

        public void RemoveFirst()
        {
            if (Count == 0)
            {
                Console.WriteLine("No elements to remove");

            }
            else
            {
                Count--;
                Head = Head.Next;
                if (Count == 0)
                {
                    Tail = null;
                }
            }
        }

        public void RemoveLast()
        {

            if (Count == 0)
            {
                Console.WriteLine("no elements in the list");
            }
            else
            {
                if (Count == 1)
                {
                    Head = Tail = null;
                    Count--;
                }
                else
                {
                    LinkedListNode<T> prevNode = null;
                    var currNode = Head;
                    while (currNode != Tail)
                    {
                        prevNode = currNode;
                        currNode = currNode.Next;

                    }
                    prevNode.Next = null;
                    Tail = prevNode;
                    Count--;
                }
            }
        }

        public bool Remove(T value)
        {
            //Four cases to be handled
            //    1. Empty list
            //    2. Single Node (Previous will be null)
            //    3. Many Nodes
            //        a. Node is the first node
            //        b. Node can be subsequent Node ( middle or last)


            var currNode = Head;
            LinkedListNode<T> prevNode = null;

            while (currNode != null)
            {
                if (currNode.Value.Equals(value))
                {
                    ///it is node in the middle or end
                    if (prevNode != null)
                    {
                        ///case 3b
                        prevNode.Next = currNode.Next;

                        //it was the end , then update the tail 
                        if (currNode.Next == null)
                        {
                            Tail = prevNode;
                        }
                        Count--;
                    }
                    else
                    {
                        //case 2 or 3a
                        RemoveFirst();
                    }
                    return true;
                }
                prevNode = currNode;
                currNode = currNode.Next;
            }
            return false;
        }

        public void PrintLinkedList()
        {
            if (Head == null)
            {
                Console.WriteLine("No items in the custom linked List");
            }
            else
            {
                var currNode = Head;

                while (currNode != null)
                {
                    Console.Write(currNode.Value + " => ");
                    currNode = currNode.Next;
                }
                Console.Write("Null");
                Console.WriteLine();
                Console.WriteLine("List Printed");
            }
        }
        public int Count { get; private set; }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public void Add(T item)
        {
            AddToFirst(new LinkedListNode<T>(item));
        }

        public void Clear()
        {
            Head = Tail = null;
            Count = 0;
        }

        public bool Contains(T item)
        {

            var currNode = Head;
            while (currNode != null)
            {
                if (currNode.Value.Equals(item))
                {
                    return true;

                }
                currNode = currNode.Next;
            }


            return false;

        }

        /// <summary>
        /// Copies the node values into the specified array.
        /// </summary>
        /// <param name="array">The array to copy the linked list values to</param>
        /// <param name="arrayIndex">The index in the array to start copying at</param>
        public void CopyTo(T[] array, int arrayIndex)
        {
            LinkedListNode<T> current = Head;
            while (current != null)
            {
                array[arrayIndex++] = current.Value;
                current = current.Next;
            }
        }
        public IEnumerator<T> GetEnumerator()
        {
            LinkedListNode<T> current = Head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((System.Collections.Generic.IEnumerable<T>)this).GetEnumerator();
        }
    }
}
