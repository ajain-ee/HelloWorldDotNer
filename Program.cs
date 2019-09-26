using System;

namespace HelloWorldNet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nHi whats you name");
            var name = Console.ReadLine();
            Console.WriteLine($" Nice to meet you {name}");
        }
    }
}
