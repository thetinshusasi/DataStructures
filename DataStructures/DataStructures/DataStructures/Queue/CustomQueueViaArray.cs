using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.DataStructures.Queue
{
    public class CustomQueueViaArray<T> : IEnumerable<T>
    {
        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        T[] _list = new T[0];

        int _size = 0;

        int _head = 0;
        int _tail = -1;

        public void Enqueue(T item)
        {
            //Check if array is full
            if(_size == _list.Length)
            {
                int newLen = _size == 0 ? 4 : _size * 2;
                T[] newArray = new T[newLen];
                int index = 0;
                if (_size > 0)
                {
                    if(_head > _tail)
                    {
                        for(var i=_head; i < _list.Length; i++)
                        {
                            newArray[index] = _list[i];
                            index++;
                        }
                        for (var i = 0; i <= _tail; i++)
                        {
                            newArray[index] = _list[i];
                            index++;
                        }

                    }
                    else
                    {
                        for (var i = _head; i < _list.Length; i++)
                        {
                            newArray[index] = _list[i];
                            index++;
                        }
                    }

                    _head = 0;
                    _tail = index - 1;

                }
                else
                {
                    _head = 0;
                    _tail = -1;
                }
                _list = newArray;

            }

            if (_tail == _size - 1)
            {
                _tail = 0;
            }
            else
            {
                _tail++;
            }

            _list[_tail] = item;
            _size++;
        }

        public T Dequeue()
        {
            if (_size == 0)
            {
                throw new System.InvalidOperationException("The queue is empty");
            }

            T value = _list[_head];

            if (_head == _list.Length - 1)
            {
                // if the head is at the last index in the array - wrap around.
                _head = 0;
            }
            else
            {
                // move to the next value
                _head++;
            }

            _size--;

            return value;
        }
    }
}
