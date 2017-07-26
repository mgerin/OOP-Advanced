using System;

class Startup
{
    static void Main(string[] args)
    {
        var scale = new Scale<string>("B", "b");
        Console.WriteLine(scale.GetHavier());
    }
}
