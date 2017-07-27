namespace _12.Threeuple.Generics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Threeuple<TI1, TI2, TI3>
    {
        public Threeuple(TI1 item1, TI2 item2, TI3 item3)
        {
            this.Item1 = item1;
            this.Item2 = item2;
            this.Item3 = item3;
        }

        private TI1 Item1 { get; }

        private TI2 Item2 { get; }

        private TI3 Item3 { get; }

        public override string ToString()
        {
            return $"{this.Item1} -> {this.Item2} -> {this.Item3}";
        }
    }
}
