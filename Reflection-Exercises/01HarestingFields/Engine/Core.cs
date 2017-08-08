using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01HarestingFields.Engine
{
    public static class Core
    {
        public static void Run()
        {
            string input;
            while ((input = Console.ReadLine()) != "HARVEST")
            {
                var firstChar = input.First().ToString().ToUpper();
                input = input.Replace(input.First().ToString(), firstChar);

                var commandType = Type.GetType("_01HarestingFields.Engine." + input + "Command");

                if (commandType == null)
                {
                    throw new NotSupportedException($"Command {input} not supported!");
                }

                var command = Activator.CreateInstance(commandType);
                var executeMethod = command.GetType().GetMethod("Execute");
                var result = executeMethod.Invoke(command, new object[] { }) as string;

                Console.WriteLine(result);
            }
        }
    }
}
