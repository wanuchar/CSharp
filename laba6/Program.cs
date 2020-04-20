using System;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Spec[] array = new Spec[5];
            array[0] = new Spec("Ян", 17, "Беларусь", (courseNum)1, "ИиТП", "математика, информатика");
            array[1] = new Spec("Полина", 18, "Беларусь", (courseNum)1, "ИиТП", "математика, информатика");
            array[2] = new Spec("Максим", 18, "Беларусь", (courseNum)1, "ИиТП", "математика, информатика");
            array[3] = new Spec("Лиза", 20, "Беларусь", (courseNum)3, "ПОИТ", "информатика, математика");
            array[4] = new Spec("Юля", 18, "Беларусь", (courseNum)1, "ИиТП", "математика, информатика");
            for (int i = 0; i < 5; i++)
            {
                array[i].getInfo();
            }
        }
    }
}
