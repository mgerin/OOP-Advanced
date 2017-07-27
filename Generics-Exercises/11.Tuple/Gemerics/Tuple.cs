namespace _11.Tuple.Gemerics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Tuple<TK, TV>
    {
        public Tuple(TK key, TV value)
        {
            this.Key = key;
            this.Value = value;
        }

        public TK Key { get; set; }

        public TV Value { get; set; }
    }
}
