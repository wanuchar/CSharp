using System;
using System.Linq;


namespace Lab2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string line;
            line = Console.ReadLine();

            LineTran(line);
        }

        static void LineTran(string line) {
            string trueLine = string.Join(" ", line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
            string lowerLine = trueLine.ToLower();
            char[] str = lowerLine.ToCharArray();
            char[] vowel = { 'a', 'e', 'i', 'o', 'u', 'y' };

            for (int i = 0; i < lowerLine.Length - 1; i++) {
                if (vowel.Contains(lowerLine[i])) {
                    if (str[i + 1] == 'z')
                    {
                        str[i + 1] = 'a';
                        i++;
                    }
                    else {
                        str[i + 1] = (char)((int)(str[i + 1]) + 1);
                        i++;
                    }
                }
            }

            lowerLine = new string(str);
            Console.WriteLine(lowerLine);

        }
    }
}
