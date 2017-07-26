namespace _02.GenericBoxOfString
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Startup
    {
        static void Main(string[] args)
        {
            var numberOfStrings = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfStrings; i++)
            {
                Console.WriteLine(new Box<string>(Console.ReadLine()));
            }
        }
    }
}
