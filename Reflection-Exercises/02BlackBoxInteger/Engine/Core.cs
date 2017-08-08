using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02BlackBoxInteger.Models;

namespace _02BlackBoxInteger.Engine
{
    public static class Core
    {
        public static void Run()
        {
            string input;
            var blackBoxInstance = Activator.CreateInstance(typeof(BlackBoxInt), true);
            while ((input = Console.ReadLine()) != "END")
            {
                var cmdArgs = input.Split(new[] {'_'}, StringSplitOptions.RemoveEmptyEntries);
                var command = cmdArgs[0];
                var value = int.Parse(cmdArgs[1]);

                var commandType = Type.GetType("_02BlackBoxInteger.Engine.Commands." + command + "Command");

                if (commandType == null)
                {
                    throw new NotSupportedException($"Command {command} not supported!");
                }

                var commandInstance = Activator.CreateInstance(commandType);
                var executeMethod = commandInstance.GetType().GetMethod("Execute");
                var result = executeMethod.Invoke(commandInstance, new object[] {blackBoxInstance, value}) as string;

                Console.WriteLine(result);
            }
        }
    }
}
