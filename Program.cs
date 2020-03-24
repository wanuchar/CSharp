using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            Console.WriteLine("Введите строку: ");
            str = Console.ReadLine();

            StringArray(str);
        }

        static void StringArray(string str) {
            string result = string.Join(" ", str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
            string[] temp = result.Split(' ');

            for (int i = temp.Length - 1; i >= 0; i--) {
                Console.Write(temp[i] + " ");
            }
        }

    }
}
