using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace QuickFoodz
{
    public partial class CustomList<Type>
    {
        private int _count;
        private int _capacity;
        public int Count { get { return _count; } }
        public int Capacity { get { return _capacity; } }
        public Type[] _array;

        public Type this[int index]
        {
            get { return _array[index]; }
        }
        public CustomList()
        {
            _count = 0;
            _capacity = 4;
            _array = new Type[_capacity];
        }
        public CustomList(int size)
        {
            _count = 0;
            _capacity = size;
            _array = new Type[_capacity];
        }
        public void Add(Type element)
        {
            if (_capacity == _count)
            {
                GrowSize();
            }
            _array[_count] = element;
            _count++;
        }
        public void GrowSize()
        {
            _capacity *= 2;
            Type[] temp = new Type[_capacity];
            for (int i = 0; i < _count; i++)
            {
                temp[i] = _array[i];
            }
            _array = temp;

        }
        public void AddRange(CustomList<Type> elements)
        {
            _capacity = _count + elements.Count + 4;
            Type[] temp = new Type[_capacity];
            for (int i = 0; i < _count; i++)
            {
                temp[i] = _array[i];
            }
            int k = 0;
            for (int j = _count; j < _count + elements.Count; j++)
            {
                temp[j] = elements[k];
                k++;
            }
            _array = temp;
            _count += elements._count;
        }
        public bool Contains(Type element)
        {
            if (IndexOf(element) > 0)
            {
                return true;
            }
            return false;
        }
        public int IndexOf(Type element)
        {
            for (int i = 0; i < _count; i++)
            {
                if (_array[i].Equals(element))
                {
                    return i;
                }
            }
            return -1;
        }
        public bool Remove(Type element)
        {
            int result = IndexOf(element);
            if (result >= 0)
            {
                RemoveAt(result);
                return true;
            }
            return false;
        }
        public void RemoveAt(int position)
        {
            for (int i = position; i < _count; i++)
            {
                _array[i] = _array[i + 1];
            }
            _count--;
        }
        public void Insert(int position, Type element)
        {
            _capacity += 1;
            Type[] temp = new Type[_capacity];
            for (int i = 0; i < _count + 1; i++)
            {
                if (i < position)
                {
                    temp[i] = _array[i];
                }
                else if (i == position)
                {
                    temp[i] = element;
                }
                else
                {
                    temp[i] = _array[i - 1];
                }
            }
            _array = temp;
            _count++;
        }
        public void InsertRange(int position, CustomList<Type> elements)
        {
            _capacity += elements.Count;
            Type[] temp = new Type[_capacity];
            for (int i = 0; i < position; i++)
            {
                temp[i] = _array[i];
            }
            int j = 0;
            for (int i = position; i < position + elements.Count; i++)
            {
                temp[i] = elements[j];
                j++;
            }
            int k = position;
            for (int i = position + elements.Count; i < _count + elements.Count; i++)
            {
                temp[i] = _array[k];
                k++;
            }
            _array = temp;
            _count += elements.Count;
        }
        public void Reverse()
        {
            Type[] temp = new Type[_capacity];
            int j = 0;
            for (int i = _count; i >= 0; i--)
            {
                temp[j] = _array[i];
                j++;
            }
            _array = temp;
        }
        public void Sort()
        {
            for (int i = 0; i < _count; i++)
            {
                for (int j = 0; j < _count; j++)
                {
                    if (IsGreater(_array[j], _array[j + 1]))
                    {
                        Type temp = _array[j + 1];
                        _array[j + 1] = _array[j];
                        _array[j] = temp;
                    }
                }
            }
        }
        public bool IsGreater(Type value1, Type value2)
        {
            int result = Comparer<Type>.Default.Compare(value1, value2);

            if (result > 0)
            {
                return true;
            }
            return false;
        }
        public Type[] ToArray()
        {
            Type[] temp = new Type[_count];
            for (int i = 0; i < _count; i++)
            {
                temp[i] = _array[i];
            }
            return temp;
        }
    }
}