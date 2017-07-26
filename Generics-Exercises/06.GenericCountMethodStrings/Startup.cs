namespace _06.GenericCountMethodStrings
{
    using System;
    using _06.GenericCountMethodStrings.Generics;

    class Startup
    {
        static void Main(string[] args)
        {
            var numberOfItems = int.Parse(Console.ReadLine());
            var box = new Box<string>();

            for (int i = 0; i < numberOfItems; i++)
            {
                box.Add(Console.ReadLine());
            }

           Console.WriteLine(box.Compare(Console.ReadLine()));
        }
    }
}
