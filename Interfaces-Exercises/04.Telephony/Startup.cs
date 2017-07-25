namespace _04.Telephony
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using _04.Telephony.Entities;

    class Startup
    {
        static void Main(string[] args)
        {
            var smartphone = new Smartphone();

            Console.ReadLine().Trim().Split().ToList()
                .ForEach(number => smartphone.Call(number));

            Console.ReadLine().Trim().Split().ToList()
                .ForEach(link => smartphone.Browse(link));
        }
    }
}
