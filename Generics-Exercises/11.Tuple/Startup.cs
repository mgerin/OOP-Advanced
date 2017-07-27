namespace _11.Tuple
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using _11.Tuple.Gemerics;

    class Startup
    {
        static void Main(string[] args)
        {
            var nameAndAddress = Console.ReadLine().Split();
            var fullName = nameAndAddress[0] + " " + nameAndAddress[1];
            var address = nameAndAddress[2];
            var firstTuple = new Gemerics.Tuple<string, string>(fullName, address);

            var personAndBeer = Console.ReadLine().Split();
            var name = personAndBeer[0];
            var countOfBeers = int.Parse(personAndBeer[1]);
            var secondTuple = new Gemerics.Tuple<string, int>(name, countOfBeers);

            var intAndDouble = Console.ReadLine().Split();
            var firstNum = int.Parse(intAndDouble[0]);
            var secondNum = double.Parse(intAndDouble[1]);
            var thirdTuple = new Gemerics.Tuple<int, double>(firstNum, secondNum);

            Console.WriteLine($"{firstTuple.Key} -> {firstTuple.Value}");
            Console.WriteLine($"{secondTuple.Key} -> {secondTuple.Value}");
            Console.WriteLine($"{thirdTuple.Key} -> {thirdTuple.Value}");
        }
    }
}
