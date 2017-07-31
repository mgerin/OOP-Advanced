namespace _01.ListyIterator
{
    using _01.ListyIterator.Generics;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Startup
    {
        static void Main(string[] args)
        {
            string input;
            ListyIterator<string> listyIterator = null;
            while ((input = Console.ReadLine()) != "END")
            {
                var cmdArgs = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var command = cmdArgs[0];

                switch (command)
                {
                    case "Create":
                        var elements = cmdArgs.Skip(1).ToArray();
                        listyIterator = new ListyIterator<string>(elements);
                        break;
                    case "Move":
                        Console.WriteLine(listyIterator.Move());
                        break;
                    case "Print":
                        try
                        {
                            Console.WriteLine(listyIterator.Print());
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }

                        break;
                    case "HasNext":
                        Console.WriteLine(listyIterator.HasNext());
                        break;
                }
            }
        }
    }
}
