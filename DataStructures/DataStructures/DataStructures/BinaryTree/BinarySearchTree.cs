using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.DataStructures.BinaryTree
{
    public class BinarySearchTree<T> :IEnumerable<T> where T : IComparable<T>
    {
        public BinaryTreeNode<T> Root { get; set; }
        public int Count { get; private set; }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        void Insert( T node)
        {
            if (Root == null)
            {
                Root = new BinaryTreeNode<T>(node);
            }
            else
            {
                AddTo(Root, node);
            }


            Count++;
        }

        void AddTo(BinaryTreeNode<T> CurrNode, T value)
        {
            if (CurrNode.Value.CompareTo(value) >= 0)
            {
                if (CurrNode.Right == null)
                {
                    CurrNode.Right = new BinaryTreeNode<T>(value);
                }
                else
                {
                    AddTo(CurrNode.Right, value);
                }
            }
            else 
            {
                if (CurrNode.Left == null)
                {
                    CurrNode.Left = new BinaryTreeNode<T>(value);
                }
                else
                {
                    AddTo(CurrNode.Left, value);
                }
            }


        }
    }
}
