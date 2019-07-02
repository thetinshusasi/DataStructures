using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.DataStructures.Queue
{
    class CustomPriorityQueueViaLinkedList<T> : IEnumerable<T> where T : IComparable<T>
    {
        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        LinkedList<T> _list = new LinkedList<T>();

        public T Dequeue()
        {
            if (_list.Count == 0)
            {
                throw new InvalidOperationException("list is empty");
            }
            T value = _list.First.Value;
            _list.RemoveFirst();
            return value;
        }

        public T Peek()
        {
            if (_list.Count == 0)
            {
                throw new InvalidOperationException("list is empty");
            }

            return _list.First.Value;

        }

        public int Count
        {
            get
            {
                return _list.Count;
            }
        }

        public void Enqueue(T item)
        {

            if (_list.Count == 0)
            {
                _list.AddLast(item);
            }
            else
            {
                var curValue = _list.First;
                while (curValue != null && curValue.Value.CompareTo(item) > 0)
                {
                    curValue = curValue.Next;
                }

                if (curValue == null)
                {
                    _list.AddLast(item);
                }
                else
                {
                    _list.AddBefore(curValue, item);
                }
            }

        }
    }
}
