﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustList
{
    public class CustomList <T> : IEnumerable
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
                capacity = capacity * 2;
                T[] array1 = new T[capacity];
                for (int i = 0; i < _items.Length; i++)
                {
                    array1[i] = _items[i];
                }
                _items = array1;
                //move items over
                //new array is now _items array.
            }
            _items[count] = itemToAdd;
            count++;
        }

        public bool Remove(T itemToRemove)
        {

            T[] array1 = new T[capacity];
            bool isremoved = false;
            for (int i = 0, j = 0; i < count; i++, j++)
            {

                if (_items[i].Equals(itemToRemove))
                {
                    j--;
                    isremoved = true;
                    
                }
                else
                {
                    array1[j] = _items[i];
                }
                
            }
            _items = array1;
            if (isremoved)
            {
                 count--;
            }
            return isremoved;
        }
        public override string ToString()
        {
            string items = "";
            for (int i = 0; i < count; i++)
            {
                if (i == 0)
                {
                    items = items + _items[i].ToString();
                }
                else
                {
                    items = items  + " " + _items[i].ToString();
                }
                
                
            }
            return items;

        }
        public static CustomList<T> operator +(CustomList<T> numbers1, CustomList<T> numbers2)
        {
            CustomList<T> numbers3 = new CustomList<T>();

            for (int i = 0; i < numbers1.Count; i++)
            {
                numbers3.Add(numbers1[i]);
            }
            for (int i = 0; i < numbers1.Count; i++)
            {
                numbers3.Add(numbers2[i]);
            }


            return numbers3;
        }
        public bool Contains(T thing)
        {

            for (int i = 0; i < Count; i++)
            {
                if (_items[i].Equals(thing))
                {
                    return true;
                }
                
            }
            return false;
        }
        public static CustomList<T> operator -(CustomList<T> numbers1, CustomList<T> numbers2)
        {
            
            for (int i = 0; i < numbers2.Count; i++)
            {
                while(numbers1.Contains(numbers2[i]))
                {
                    numbers1.Remove(numbers2[i]);
                }
            }
            return numbers1;
        }
        public IEnumerator GetEnumerator()
        {
           
            for (int i = 0; i < _items.Length; i++)
            {
                yield return _items[i];
                
            }
            
        }


    }
}
