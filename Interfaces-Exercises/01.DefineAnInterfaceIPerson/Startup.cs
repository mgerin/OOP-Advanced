namespace _01.DefineAnInterfaceIPerson
{
    using System;
    using System.Reflection;

    using _01.DefineAnInterfaceIPerson.Entities;
    using _01.DefineAnInterfaceIPerson.Entities.Interfaces;

    class Startup
    {
        static void Main()
        {
            Type personInterface = typeof(Citizen).GetInterface("IPerson");
            PropertyInfo[] properties = personInterface.GetProperties();
            Console.WriteLine(properties.Length);
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            IPerson person = new Citizen(name, age);
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
        }
    }
}
