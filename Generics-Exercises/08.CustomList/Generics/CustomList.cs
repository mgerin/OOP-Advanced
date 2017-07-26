namespace _08.CustomList.Generics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CustomList<T>
        where T : IComparable<T>
    {
        private IList<T> data;

        public CustomList()
        {
            this.data = new List<T>();
        }

        public void Add(T item)
        {
            this.data.Add(item);
        }

        public T Remove(int index)
        {
            var removed = this.data[index];
            this.data.RemoveAt(index);

            return removed;
        }

        public bool Contains(T element)
        {
            return this.data.Contains(element);
        }

        public void Swap(int first, int second)
        {
            var firstItem = this.data[first];
            var secondItem = this.data[second];

            this.data.RemoveAt(first);
            this.data.Insert(first, secondItem);
            this.data.RemoveAt(second);
            this.data.Insert(second, firstItem);
        }

        public int CountGreaterThan(T element)
        {
            return this.data.Count(d => d.CompareTo(element) > 0);
        }

        public T Max()
        {
            return this.data.Max();
        }

        public T Min()
        {
            return this.data.Min();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this.data.GetEnumerator();
        }
    }
}
