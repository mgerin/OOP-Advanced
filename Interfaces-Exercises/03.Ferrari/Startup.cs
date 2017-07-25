namespace _03.Ferrari
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using _03.Ferrari.Entities;
    using _03.Ferrari.Entities.Interfaces;

    class Startup
    {
        static void Main(string[] args)
        {
            string model = "488-Spider";
            string driverName = Console.ReadLine();
            Ferrari ferrari = new Ferrari(model, driverName);
            Console.WriteLine(ferrari.ToString());

            string ferrariName = typeof(Ferrari).Name;
            string iCarInterfaceName = typeof(ICar).Name;

            bool isCreated = typeof(ICar).IsInterface;
            if (!isCreated)
            {
                throw new Exception("No interface ICar was created");
            }
        }
    }
}
