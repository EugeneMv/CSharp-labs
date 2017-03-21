using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    class CollectionType<T> : ICollection<T>, IEnumerable<T>
    {
        List<T> Cont;

        public CollectionType()
        {
            Cont = new List<T>();
        }

        bool ICollection<T>.IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public int Count
        {
            get
            {
                return Cont.Count;
            }
        }
        public void Add(T el)
        {
            if (Cont.Count < 5)
                Cont.Add(el);
            else
                Console.WriteLine("Container is full");
        }
        public void Clear()
        {
            Cont.Clear();
        }
        public bool Contains(T item)
        {
            return Cont.Contains(item);
        }
        public void CopyTo(T[] array, int arrayIndex)
        {
            Cont.CopyTo(array, arrayIndex);
        }
        public bool Remove(T item)
        {
            return Cont.Remove(item);
        }
        public void Sort()
        {
            Cont.Sort();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Cont.GetEnumerator();
        }
        public IEnumerator<T> GetEnumerator()
        {
            return Cont.GetEnumerator();
        }

        public T this[int i]
        {
            get
            {
                return Cont[i];
            }
        }

        public T[] PriceEq(float value, out int j)
        {
            j = 0;
            T[] mass = new T[Cont.Count];
            for (int i = 0; i < Cont.Count; i++)
            {
                if (Cont[i].GetHashCode() == value)
                {
                    mass[j] = Cont[i];
                    j++;
                }
            }
            return mass;
        }

        public T LastObjOf(string sign, float value)
        {
            switch (sign)
            {
                case ">":
                    return Cont.FindLast(m => m.GetHashCode() > value);
                case "<":
                    return Cont.FindLast(m => m.GetHashCode() < value);
                case "=":
                    return Cont.FindLast(m => m.GetHashCode() == value);
            }
            return default(T);
        }
    }
}
