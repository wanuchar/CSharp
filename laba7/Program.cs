using System;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number number: ");
            var num1 = Enter();
            Console.WriteLine($"{num1.ShowFull()}");

            Console.WriteLine("Enter the second number number: ");
            var num2 = Enter();
            Console.WriteLine($"{num2.ShowFull()}");

            Console.WriteLine($"1. {num1.FractionStr()} > {num2.FractionStr()} = " + (num1 > num2));
            Console.WriteLine($"   {num1.RNumStr()} > {num2.RNumStr()} = " + (num1 > num2)+ '\n');
            Console.WriteLine($"2. {num1.FractionStr()} < {num2.FractionStr()} = " + (num1 < num2));
            Console.WriteLine($"   {num1.RNumStr()} < {num2.RNumStr()} = " + (num1 < num2) + '\n');
            Console.WriteLine($"3. {num1.FractionStr()} >= {num2.FractionStr()} = " + (num1 >= num2));
            Console.WriteLine($"   {num1.RNumStr()} >= {num2.RNumStr()} = " + (num1 >= num2) + '\n');
            Console.WriteLine($"4. {num1.FractionStr()} <= {num2.FractionStr()} = " + (num1 <= num2));
            Console.WriteLine($"   {num1.RNumStr()} <= {num2.RNumStr()} = " + (num1 <= num2) + '\n');
            Console.WriteLine($"5. {num1.FractionStr()} == {num2.FractionStr()} = " + (num1 == num2));
            Console.WriteLine($"   {num1.RNumStr()} == {num2.RNumStr()} = " + (num1 == num2) + '\n');
            Console.WriteLine($"6. {num1.FractionStr()} != {num2.FractionStr()} = " + (num1 != num2));
            Console.WriteLine($"   {num1.RNumStr()} != {num2.RNumStr()} = " + (num1 != num2) + '\n');
            Console.WriteLine($"7. {num1.FractionStr()} + {num2.FractionStr()} = " + (num1 + num2).FractionStr());
            Console.WriteLine($"   {num1.RNumStr()} + {num2.RNumStr()} = " + (num1 + num2).RNumStr() + '\n');
            Console.WriteLine($"8. {num1.FractionStr()} - {num2.FractionStr()} = " + (num1 - num2).FractionStr());
            Console.WriteLine($"   {num1.RNumStr()} - {num2.RNumStr()} = " + (num1 - num2).RNumStr() + '\n');
            Console.WriteLine($"9. {num1.FractionStr()} * {num2.FractionStr()} = " + (num1 * num2).FractionStr());
            Console.WriteLine($"   {num1.RNumStr()} * {num2.RNumStr()} = " + (num1 * num2).RNumStr() + '\n');
            if (num2 != 0)
            {
                Console.WriteLine($"10. {num1.FractionStr()} / {num2.FractionStr()} = " + (num1 / num2).FractionStr());
                Console.WriteLine($"   {num1.RNumStr()} / {num2.RNumStr()} = " + (num1 / num2).RNumStr() + '\n');
            }
        }

        public static RNum Enter()
        {
            int a;
            Console.WriteLine("(0 - fraction, 1 - number): ");
            while (!int.TryParse(Console.ReadLine(), out a) || a < 0 || a > 1)
            {
                Console.WriteLine("Incorrect input. Try again.\n");
            }
            if (a == 0)
            {
                return GetFraction();
            }
            else
            {
                return GetNum();
            }

        }

        public static RNum GetFraction()
        {
            Console.WriteLine("Fraction: ");
            string str = Console.ReadLine();
            while (!CheckFraction(str))
            {
                Console.Write("Incorrect input, repeat: ");
                str = Console.ReadLine();
            }

            RNum r = RNum.GetFractionFromStr(str);
            return r;
        }

        public static bool CheckFraction(string str)
        {
            if (String.IsNullOrEmpty(str))
            {
                return false;
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (i == 0 && str[i] == '-') i++;
                if (str[i] == '/' && i != str.Length - 1) i++;
                if (!char.IsDigit(str[i]) || (str[i] == '0' && i == str.Length - 1 && str[i - 1] == '/')) return false;
            }
            return true;
        }

        public static RNum GetNum()
        {
            Console.WriteLine("Number: ");
            string str = Console.ReadLine();
            double a = CheckNum(str);

            RNum r = RNum.GetNumberFromStr(a);
            return r;
        }

        public static double CheckNum(string str)
        {
            double a;
            while(!double.TryParse(str, out a))
            {
                Console.Write("Incorrect input, repeat: ");
                str = Console.ReadLine();
            }
            return a;
        }

    }
}
