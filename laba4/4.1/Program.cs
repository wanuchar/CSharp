using System;

namespace Laba4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"About CPU:\n{System.CPUInform()}");
            Console.WriteLine($"About memory:\n{System.MemoryInform()}");
            Console.ReadKey();
        }
    }
}
