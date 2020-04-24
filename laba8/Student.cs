using System;
namespace Lab8
{
    enum courseNum
    {
        First = 1,
        Second,
        Third,
        Fourth
    }

    class Student : Human
    {
        public int course;

        public Student() : this("Неизвестно", 0, "Неизвестно", 0)
        {
        }
        public Student(string a, int b, string c, courseNum f)
        {
            name = a;
            age = b;
            country = c;
            ID = generateID();
            course = (int)f;
        }

        public override void getInfo()
        {
            Console.WriteLine($"Имя: {name}");
            Console.WriteLine($"Возраст: {age}");
            Console.WriteLine($"Страна: {country}");
            Console.WriteLine($"Курс: {course}");
            Console.WriteLine($"ID: {ID}");
        }


    }
}
