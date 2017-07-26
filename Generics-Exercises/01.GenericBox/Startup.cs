namespace _01.GenericBox
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using _01.GenericBox.Generics;

    class Startup
    {
        static void Main(string[] args)
        {
            var strings = new Box<string>("life in a box");
            Console.WriteLine(strings);
        }
    }
}
