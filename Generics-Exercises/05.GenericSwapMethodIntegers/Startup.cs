namespace _05.GenericSwapMethodIntegers
{
    using System;
    using _05.GenericSwapMethodIntegers.Generics;

    class Startup
    {
        static void Main(string[] args)
        {
            var numberOfInts = int.Parse(Console.ReadLine());
            var box = new Box<int>();

            for (int i = 0; i < numberOfInts; i++)
            {
                box.Add(int.Parse(Console.ReadLine()));
            }

            var swapPosition = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            box.Swap(int.Parse(swapPosition[0]), int.Parse(swapPosition[1]));

            Console.WriteLine(box);
        }
    }
}
