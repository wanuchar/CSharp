using System;
using System.Text;

namespace Lab2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder line;
            Console.WriteLine("Введите строку: ");
            line = new StringBuilder(Console.ReadLine());

            StringTran(line);
        }

        static void StringTran(StringBuilder line) {
            StringBuilder noPunctMark = new StringBuilder(string.Join(" ", line.ToString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)));

            StringBuilder BackPunctMark = noPunctMark;
            char PunctMark = ' ';
            for (int i = noPunctMark.Length - 1; i >= 0; i--) {
                if (char.IsPunctuation(noPunctMark[i]) && i == noPunctMark.Length - 1)
                {
                    PunctMark = noPunctMark[i];
                }
                else if (char.IsPunctuation(noPunctMark[i]) && char.IsWhiteSpace(noPunctMark[i + 1]))
                {
                    PunctMark = noPunctMark[i];
                }


                if (char.IsWhiteSpace(noPunctMark[i]))
                {
                    BackPunctMark.Insert(i + 1, PunctMark);
                    PunctMark = '\0';
                }
                else if (i == 0)
                {
                    BackPunctMark.Insert(i, PunctMark);
                    PunctMark = '\0';
                }
            }

            BackPunctMark = new StringBuilder(string.Join(" ", BackPunctMark.ToString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)));

            Console.Write(BackPunctMark);
        }
    }
}
