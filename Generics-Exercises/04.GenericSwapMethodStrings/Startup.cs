namespace _04.GenericSwapMethodStrings
{
    using System;

    using _04.GenericSwapMethodStrings.Generics;

    class Startup
    {
        static void Main(string[] args)
        {
            var numberOfStrings = int.Parse(Console.ReadLine());
            var box = new Box<string>();

            for (int i = 0; i < numberOfStrings; i++)
            {
                box.Add(Console.ReadLine());
            }

            var swapPosition = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            box.Swap(int.Parse(swapPosition[0]), int.Parse(swapPosition[1]));

            Console.WriteLine(box);
        }
    }
}
