using System;

namespace Lab5
{

    class Program
    {
        static int CheckInt()
        {
            int a;
            while (!int.TryParse(Console.ReadLine(), out a) || a <= 0)
            {
                Console.Write("Incorrect input. Try again: ");
            }
            return a;
        }

        static void Main(string[] args)
        {
        
            Spec studSpec = new Spec("Ян", 17, "Беларусь", (courseNum)1, "ИиТП", "математика, информатика");
            studSpec.getInfo();


        }
    }
}
