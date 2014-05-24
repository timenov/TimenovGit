using System;
using System.Collections.Generic;
using System.Text;

namespace GenericList
{
    class GenericList<T>
        where T : IComparable
    {
        private T[] array;
        private int count;

        public int Count 
        {
            get 
            {
                return this.count;
            }
        }
        private int Capacity
        {
            get
            {
                return this.array.Length;
            }
        }

        public GenericList(int size)
        {
            this.array = new T[size];
            this.count = 0;
        }

        public void Add(T element)
        {
            this.array[count] = element;
            this.count++;
            if (count == this.Capacity)
            {
                AutoGrow();
            }
        }
        public void InsertAt(T element, int index)
        {
            T[] newArray = new T[this.Count + 1];
            if (index < 0 || index > this.Count)
            {
                throw new IndexOutOfRangeException("Index is outside of bounds of the list!");
            }
            else
            {
                if (index == 0)
                {
                    newArray[0] = element;
                    Array.Copy(this.array, 0, newArray, 1, this.Count);
                }
                else if (index == this.Count)
                {
                    Add(element);
                    return;
                }
                else
                {
                    Array.Copy(this.array, 0, newArray, 0, index);
                    newArray[index] = element;
                    Array.Copy(this.array, index, newArray, index + 1, this.Count - index);
                }
                this.count++;
                this.array = newArray;
                if (this.Count == this.Capacity)
                {
                    AutoGrow();
                }
            }
        }
        public void RemoveAt(int index)
        {
            T[] newArray = new T[this.Capacity];
            if (index < 0 || index > this.Count - 1)
            {
                throw new IndexOutOfRangeException("Index is outside of bound of the list!");
            }
            else
            {
                if (index == 0)
                {
                    Array.Copy(this.array, 1, newArray, 0, this.Count - 1);
                }
                else if (index == this.Count - 1)
                {
                    Array.Copy(this.array, 0, newArray, 0, this.Count - 1);
                }
                else
                {
                    Array.Copy(this.array, 0, newArray, 0, index);
                    Array.Copy(this.array, index + 1, newArray, index, this.Count - index - 1);
                }
                this.count--;
                this.array = newArray;
            }
        }
        public T Get(int index)
        {
            if (index < 0 || index > this.Count - 1)
            {
                throw new IndexOutOfRangeException("Index outside of bounds of the list!");
            }
            else
            {
                return this.array[index];
            }
        }
        public bool Contains(T element)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this.array[i].Equals(element))
                {
                    return true;
                }
            }
            return false;
        }
        public void Clear()
        {
            this.array = new T[this.Count];
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < this.count - 1; i++)
            {
                sb.Append(this.array[i] + ", ");
            }
            sb.Append(this.array[this.count-1]);
            return sb.ToString();
        }

        private void AutoGrow()
        {
            T[] newArray = new T[this.array.Length*2];
            Array.Copy(this.array, newArray, this.Count);
            this.array = newArray;
        }
    }
}
