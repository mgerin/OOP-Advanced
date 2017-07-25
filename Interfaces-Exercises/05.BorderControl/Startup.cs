namespace _05.BorderControl
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.InteropServices;
    using System.Text;
    using System.Threading.Tasks;

    using _05.BorderControl.Entities;

    class Startup
    {
        static void Main(string[] args)
        {
            var citizens = new List<Citizen>();
            var robots = new List<Robot>();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                var inputArgs = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (inputArgs.Length == 3)
                {
                    var name = inputArgs[0];
                    var age = int.Parse(inputArgs[1]);
                    var id = inputArgs[2];
                    var citizen = new Citizen(name, age, id);
                    citizens.Add(citizen);
                }
                else
                {
                    var model = inputArgs[0];
                    var id = inputArgs[1];

                    var robot = new Robot(model, id);
                    robots.Add(robot);
                }
            }

            var fakeIds = Console.ReadLine();

            robots.Where(r => r.Id.EndsWith(fakeIds))
                .Select(r => r.Id)
                .ToList()
                .ForEach(Console.WriteLine);
            citizens.Where(c => c.Id.EndsWith(fakeIds))
                .Select(c => c.Id)
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}
