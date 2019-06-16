using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.DataStructures.Stack
{
   public class CustomStackViaArray<T>:IEnumerable<T>
    {
        public IEnumerator<T> GetEnumerator()
        {
            for(int i = _size -1; i >= 0; i--)
            {
                yield return _list[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <summary>
        /// Intializing to empty array for edge cases
        /// </summary>
        private T[] _list = new T[0];
        private int _size;

        public void Push(T item)
        {
            if(_size == _list.Length)
            {
                int len = _size == 0 ? 4 : _size * 2;
                var newArr = new T[len];
                _list.CopyTo(newArr, 0);
                _list = newArr;
            }
            _list[_size] = item;
            _size++;
        }

        public T Pop()
        {
            if(_size == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            _size--;
            return _list[_size];
        }

        public int Count
        {
            get
            {
                return _size;
            }
        }

        public void Clear()
        {
            _size = 0;

        }

        
    }
}
