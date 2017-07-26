namespace _06.GenericCountMethodStrings.Generics
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;

    public class Box<T>
        where T : IComparable<T>
    {
        private IList<T> data;

        public Box()
        {
            this.data = new List<T>();
        }

        public void Add(T item)
        {
            this.data.Add(item);
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

        public int Compare(T element)
        {
            var count = this.data.Count(d => d.CompareTo(element) > 0);

            return count;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            foreach (var d in this.data)
            {
                sb.AppendLine($"{typeof(T).FullName}: {d}");
            }
            return sb.ToString().Trim();
        }
    }
}
