namespace _03.GenericBoxOfInteger
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using _03.GenericBoxOfInteger.Generics;

    class Startup
    {
        static void Main(string[] args)
        {
            var numberOfInt = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfInt; i++)
            {
                Console.WriteLine(new Box<int>(int.Parse(Console.ReadLine())));
            }
        }
    }
}
