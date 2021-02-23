using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustList
{
    public class CustomList <T>
    {
        private T[] _items;

        private int count;
        public int Count { get => count; }   
        private int capacity;
        public int Capacity { get => capacity; }

        public T this[int index] { get => _items[index]; set => _items[index] = value; } 
        
        public CustomList()
        {
            count = 0;
            capacity = 4;
            _items = new T[capacity];
        }

        public void Add(T itemToAdd)
        {
            if (count == capacity)
            {
                //create new  array
                //move items over
                //new array is now _items array.
            }
            _items[count] = itemToAdd;
            count++;
        }
    }
}
