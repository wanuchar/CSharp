using System;
using System.IO;

namespace LAB1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix1;
            int[,] matrix2;
            int[,] matrix3 = new int[0,0];

            FileStream(out matrix1, out matrix2);
            string choose = "1";

            Console.WriteLine("Выберите действие, которое хотите выполнить: \n");
            Console.WriteLine("Нажмите 0, чтобы завершить программу");

            while (choose != "0")
            {
                Console.WriteLine("1. Вывести матрицы\n" +
                    "2. Сложение\n" +
                    "3. Вычитание\n" +
                    "4. Умножение\n" +
                    "5. Транспонировать 1 матрицу\n" +
                    "6. Транспонировать 2 матрицу\n" +
                    "7. Найти определитель 1 матрицы\n" +
                    "8. Найти определитель 2 матрицы\n" +
                    "9. Умножение 1 матрицы на число\n" +
                    "10. Умножение 2 матрицы на число\n");
                choose = Console.ReadLine();
                choose = choose.Replace(" ", string.Empty);
                Console.Clear();
                if (choose == "1")
                {
                    Console.WriteLine("Первая матрицы: ");
                    Output(matrix1);
                    Console.WriteLine();
                    Console.WriteLine("Вторая матрицы: ");
                    Output(matrix2);
                }
                else if (choose == "2")
                {
                    Sum(matrix1, matrix2, matrix3);
                }
                else if (choose == "3")
                {
                    Diff(matrix1, matrix2, matrix3);
                }
                else if (choose == "4")
                {
                    Mult(matrix1, matrix2, matrix3);
                }
                else if (choose == "5")
                {
                    Tran(matrix1, matrix3);
                }
                else if (choose == "6")
                {
                    Tran(matrix2, matrix3);
                }
                else if (choose == "7")
                {
                    int det = Determ(matrix1);
                    Console.WriteLine("\nОпределитель 1 матрицы: " + Determ(matrix1) + "\n");
                }
                else if (choose == "8")
                {
                    int det = Determ(matrix2);
                    Console.WriteLine("\nОпределитель 2 матрицы: " + det + "\n");

                }
                else if (choose == "9")
                {
                    string key;
                    Console.WriteLine("Введите число, на которое хотите умножить матрицу: ");
                    key = Console.ReadLine();
                    choose = choose.Replace(" ", string.Empty);
                    int num = 0;
                    if (proverka(key, num) == true)
                    {                      
                        MultChar(matrix1, key, matrix3);
                    }
                    else {
                        Console.WriteLine("\nЭто строка\n");
                    }

                }
                else if (choose == "10")
                {
                    string key;
                    Console.WriteLine("Введите число, на которое хотите умножить матрицу: ");
                    key = Console.ReadLine();
                    choose = choose.Replace(" ", string.Empty);
                    int num = 0;
                    if (proverka(key, num) == true)
                    {
                        MultChar(matrix2, key, matrix3);
                    }
                    else
                    {
                        Console.WriteLine("\nЭто строка\n");
                    }
                    
                    
                }

            }

        }
        


        //запись матрицы из файла
        static void FileStream (out int[,] matrix1, out int[,] matrix2)
        {

            string file1 = "/Users/user/Documents/ИСП/LAB1/LAB1/matriz1.txt";
            string file2 = "/Users/user/Documents/ИСП/LAB1/LAB1/matriz2.txt";
            if (!System.IO.File.Exists(file1) || !System.IO.File.Exists(file2))
            {
                Console.WriteLine("Файла не существует");
                Environment.Exit(0);
            }

            //StreamReader reader1 = new StreamReader(file1);
            //StreamReader reader2 = new StreamReader(file2);

            string[] lines1 = File.ReadAllLines(file1);
            int max = 0;
            for (int i = 0; i < lines1.Length; i++) {
                if (lines1[max].Split(' ').Length < lines1[i].Split(' ').Length) {
                    max = i;
                }
            }

            matrix1 = new int[lines1.Length, lines1[max].Split(' ').Length];

            for (int i = 0; i < lines1.Length; i++)
            {
                for (int j = 0; j < lines1[max].Split(' ').Length; j++) {
                    matrix1[i, j] = 0;
                }
            }


            for (int i = 0; i < lines1.Length; i++)
            {
                string[] temp = lines1[i].Split(' ');
                for (int j = 0; j < temp.Length; j++)
                {
                    try
                    {
                        matrix1[i, j] = Convert.ToInt32(temp[j]);
                }
                    catch
                    {
                        Console.WriteLine("В файле должны быть только целые числа");
                        Environment.Exit(0);
                    }
                }

            }

            string[] lines2 = File.ReadAllLines(file2);

            max = 0;
            for (int i = 0; i < lines2.Length; i++)
            {
                if (lines2[max].Split(' ').Length < lines2[i].Split(' ').Length)
                {
                    max = i;
                }
            }

            matrix2 = new int[lines2.Length, lines2[max].Split(' ').Length];

            for (int i = 0; i < lines2.Length; i++)
            {
                string[] temp = lines2[i].Split(' ');
                for (int j = 0; j < temp.Length; j++)
                {
                    try
                    {
                        matrix2[i,j] = Convert.ToInt32(temp[j]);
                    }
                    catch
                    {
                        Console.WriteLine("В файле должны быть только целые числа");
                        Environment.Exit(0);
                    }
                }
            }  
        }


        //Вывод матрицы в консоль
        static void Output (int[,] matrix) {

            for (int i = 0; i < matrix.GetLength(0); i++) {

                for (int j = 0; j < matrix.GetLength(1); j++) {

                    Console.Write(matrix[i, j] + " ");

                }

                Console.WriteLine();

            }
        }

        //проверка порядка
        static bool CheckSize (int[,] matrix1, int[,] matrix2)
        {
            if (matrix1.GetLength(0) != matrix2.GetLength(0) ||
                matrix1.GetLength(1) != matrix2.GetLength(1))
            {
                Console.WriteLine("Матрицы разного порядка");
                Console.ReadKey();
                return false;
            }
            else {
                return true;
            }

        }

        //сложение
        static void Sum (int[,] matrix1, int[,] matrix2, int[,] matrix3) {
            if (CheckSize(matrix1, matrix2)) {
                matrix3 = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
                for (int i = 0; i < matrix1.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix1.GetLength(1); j++)
                    {
                        matrix3[i, j] = matrix1[i,j] + matrix2[i,j];
                    }
                }

                Console.WriteLine("Третья матрицв: ");
                Output(matrix3);
                Console.ReadKey();
            }

        }

        //вычитание
        static void Diff (int[,] matrix1, int[,] matrix2, int[,] matrix3)
        {
            if (CheckSize(matrix1, matrix2))
            {
                matrix3 = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
                for (int i = 0; i < matrix1.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix1.GetLength(1); j++)
                    {
                        matrix3[i, j] = matrix1[i, j] - matrix2[i, j];
                    }
                }

                Console.WriteLine("Третья матрицв: ");
                Output(matrix3);
                Console.ReadKey();
            }

        }

        //проверка согласованность
        static bool CheckComp(int[,] matrix1,int[,] matrix2) {
            if (matrix1.GetLength(1) != matrix2.GetLength(0))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        static void Mult (int[,] matrix1, int[,] matrix2, int[,] matrix3)
        {

            if (CheckComp(matrix1, matrix2))
            {
                matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

                for (int i = 0; i < matrix1.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix2.GetLength(1); j++)
                    {
                        for (int t = 0; t < matrix1.GetLength(1); t++)
                        {
                            matrix3[i, t] += matrix1[i, t] * matrix2[t, j];
                        }
                    }
                }
            }
            else if (CheckComp(matrix2, matrix1))
            {
                matrix3 = new int[matrix2.GetLength(0), matrix1.GetLength(1)];

                for (int i = 0; i < matrix2.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix1.GetLength(1); j++)
                    {
                        for (int t = 0; t < matrix2.GetLength(1); t++)
                        {
                            matrix3[i, t] += matrix2[i, t] * matrix1[t, j];
                        }
                    }
                }

            }
            else
            {
                Console.WriteLine("Матрицы не согласованны ");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Третья матрица: ");
            Output(matrix3);
            Console.ReadKey();
        }

        //транспонирование
        static void Tran (int[,] matrix, int[,] matrixTran) {
            matrixTran = new int[matrix.GetLength(1), matrix.GetLength(0)];
            for(int i = 0; i < matrix.GetLength(1); i++)
            {
                for(int j = 0; j < matrix.GetLength(0); j++)
                {
                    matrixTran[i, j] = matrix[j, i];
                }
            }
            Console.WriteLine("Транспонированная матрица: ");
            Output(matrixTran);
            Console.ReadKey();
        }

        //определитель
        static int Determ (int[,] matrix) {
            int det = 0;
            if (matrix.Length == 1)
            {
                det = matrix[0, 0];
            }
            else if (matrix.Length == 4)
            {
                det = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
            } else
            {
                int sign = 1;
                for (int i = 0; i < matrix.GetLength(0); i++) {
                    int[,] minor = Minor(matrix, i, 0);
                    //дойти до минора 2х2
                    det +=sign*matrix[0, i] * Determ(minor);
                    sign *= -1;
                }

            }
            return det;
        }

        //минор
        static int[,] Minor (int[,] matrix, int colomn, int line) {
            int[,] result = new int[matrix.GetLength(0) - 1, matrix.GetLength(0) - 1];
            for (int i = 0, a = 0; a < matrix.GetLength(0) - 1; i++)
            {
                if (i == line)
                {
                    continue;
                }
                for (int j = 0, b = 0; j < matrix.GetLength(0); j++)
                {
                    if (j == colomn)
                        continue;
                    result[a, b] = matrix[i, j];
                    b++;
                }
                a++;
            }
            return result;
        }

        //умножение на число
        static void MultChar(int[,] matrix, string key, int[,] multMatrix) {
            int a = Convert.ToInt32(key);
            multMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); i++) {
                for (int j = 0; j < matrix.GetLength(1); j++) {
                    multMatrix[i, j] = matrix[i, j] * a;
                }
            }
            Console.WriteLine("Новая матрица: ");
            Output(multMatrix);
            Console.ReadKey();
        }

        //проверка на строку
        static bool proverka(string str, int num) {
            bool isNum = int.TryParse(str, out num);
            if (isNum)
                return true;
            else
        
                return false;
        }



    }
}
