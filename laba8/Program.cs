using System;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Spec[] array = new Spec[5];
            array[0] = new Spec("Ян", 17, "Беларусь", (courseNum)1, "ИиТП", "математика, информатика");
            array[1] = new Spec("Полина", 18, "Беларусь", (courseNum)1, "ИиТП", "математика, информатика");
            array[2] = new Spec("Максим", 18, "Беларусь", (courseNum)1, "ИиТП", "математика, информатика");
            array[3] = new Spec("Лиза", 15, "Беларусь", (courseNum)3, "ПОИТ", "информатика, математика");
            array[4] = new Spec("Юля", 18, "Беларусь", (courseNum)1, "ИиТП", "математика, информатика");

            for (int i = 0; i < 5; i++)
            {
                try
                {
                    if (array[i].getAge() < 17)
                    {
                        throw new Exception();
                    }
                }
                catch (Exception)
                {
                    array[i].checkAge += (mes) => Console.ForegroundColor = ConsoleColor.Red;
                }

                try
                {
                    if (array[i].av < 5)
                    {
                        throw new Exception();
                    }
                }
                catch (Exception)
                {
                    array[i].checkAvMarks += (mes) => Console.ForegroundColor = ConsoleColor.Red;
                }

                array[i].checkAge += delegate (string mes)
                {
                    Console.WriteLine(mes);
                };
                array[i].checkAvMarks += delegate (string mes)
                {
                    Console.WriteLine(mes);
                };
              
                array[i].getInfo();
            }



            
        }
    }
}
