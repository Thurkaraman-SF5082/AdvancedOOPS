using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagement
{
    public partial class CustomList<T>
    {
        int _count;
        int _capacity;
        public int Count { get{return _count;} }
        public int Capacity {get {return _capacity;}}
        private T[] _array;

        public CustomList()
        {
            _count=0;
            _capacity=4;
            _array=new T[_capacity];
        }
         public CustomList(int size)
        {
            _count=0;
            _capacity=size;
            _array=new T[_capacity];
        }

        public void Add(T element)
        {
            if(_count==_capacity)
            {
                GrowSize();
            }
            _array[_count++]=element;
        }
        public T this[int index]
        {
            get{return _array[index];}
        }
        void GrowSize()
        {
            _capacity = _capacity*2;
            T[] temp = new T[_capacity];
            for(int i=0;i<_count;i++)
            {
                temp[i]=_array[i];
            }
            _array=temp;
        }

        public void AddRange(CustomList<T> list)
        {
            _capacity = _count+list.Count+4;
            T[] temp = new T[_capacity];
            for(int i=0;i<_count;i++)
            {
                temp[i]=_array[i];
            }
            int k=0;
            for(int i=_count;i<_count+list.Count;i++)
            {
                temp[i]=list[k++];
            }
            _array=temp;
            _count+=list.Count;
        }

        public int IndexOf(T element)
        {
            for(int i=0;i<_count;i++)
            {
                if(element.Equals(_array[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        public void RemoveAt(int index)
        {
            for(int i=0;i<_count-1;i++)
            {
                if(i>=index)
                {
                    _array[i]=_array[i+1];
                }
            }
            _count--;
        }

        public void Remove(T element)
        {
            int index = IndexOf(element);
            RemoveAt(index);
        }

        public T[] ToArray()
        {
            T[] temp = new T[_count];
            for(int i=0;i<_count;i++)
            {
                temp[i]=_array[i];
            }
            return temp;
        }
    }
}