namespace _07.GenericCountMethodDoubles
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using _07.GenericCountMethodDoubles.Generics;

    class Startup
    {
        static void Main(string[] args)
        {
            var numberOfItems = int.Parse(Console.ReadLine());
            var box = new Box<double>();

            for (int i = 0; i < numberOfItems; i++)
            {
                box.Add(double.Parse(Console.ReadLine()));
            }

            Console.WriteLine(box.Compare(double.Parse(Console.ReadLine())));
        }
    }
}
