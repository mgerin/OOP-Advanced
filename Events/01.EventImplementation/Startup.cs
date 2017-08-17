using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.EventImplementation
{
    using _01.EventImplementation.Events;

    public class Startup
    {
        public static void Main()
        {
            Dispatcher dispatcher = new Dispatcher();
            Handler handler = new Handler();

            dispatcher.NameChange += handler.OnDispatcherNameChange;

            string name = Console.ReadLine();
            while (name != "End")
            {
                dispatcher.Name = name;
                name = Console.ReadLine();
            }
        }
    }
}
