namespace _10.CustomListIterator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using _10.CustomListIterator.Generics;

    class Startup
    {
        static void Main(string[] args)
        {
            var customList = new CustomList<string>();
            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                var cmdArgs = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var command = cmdArgs[0];

                switch (command)
                {
                    case "Add":
                        customList.Add(cmdArgs[1]);
                        break;
                    case "Remove":
                        customList.Remove(int.Parse(cmdArgs[1]));
                        break;
                    case "Contains":
                        Console.WriteLine(customList.Contains(cmdArgs[1]));
                        break;
                    case "Swap":
                        customList.Swap(int.Parse(cmdArgs[1]), int.Parse(cmdArgs[2]));
                        break;
                    case "Greater":
                        Console.WriteLine(customList.CountGreaterThan(cmdArgs[1]));
                        break;
                    case "Max":
                        Console.WriteLine(customList.Max());
                        break;
                    case "Min":
                        Console.WriteLine(customList.Min());
                        break;
                    case "Sort":
                        customList.Sort();
                        break;
                    case "Print":
                        foreach (var item in customList)
                        {
                            Console.WriteLine(item);
                        }

                        break;
                    default:
                        throw new ArgumentException("Invalid input!");
                }
            }
        }
    }
}
