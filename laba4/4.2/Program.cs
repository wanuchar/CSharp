using System;
using System.Runtime.InteropServices;

namespace Laba4._2
{
    class Program
    {
        [DllImport(@"C:\Users\yanmi\OneDrive\Desktop\Laba4c#\DLL\Debug\DLL.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int Add(int a, int b);

        [DllImport(@"C:\Users\yanmi\OneDrive\Desktop\Laba4c#\DLL\Debug\DLL.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int Sub(int a, int b);

        [DllImport(@"C:\Users\yanmi\OneDrive\Desktop\Laba4c#\DLL\Debug\DLL.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern double Av(double a, double b);

        static void Main(string[] args)
        {
            Calculation();
            Console.ReadKey();
        }

        public static void Calculation()
        {
            int a = 10, b = 20;
            Console.WriteLine($"Sum of a and b is {Add(a, b)}");
            Console.WriteLine($"Difference of a and b is {Sub(a, b)}");
            Console.WriteLine($"Average between a and b is {Av(a, b)}");
        }

    }

}
