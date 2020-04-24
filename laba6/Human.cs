using System;
namespace Lab6
{
    class Human
    {
        protected string name;
        protected int age;
        protected string country;
        public static int ID;

        public Human() : this("Неизвестно")
        {
        }
        public Human(string a) : this(a, 0, "Неизвестно")
        {
        }
        public Human(string a, string c) : this(a, 0, c)
        {
        }
        public Human(string a, int b) : this(a, b, "Неизвестно")
        {
        }
        public Human(int b, string c) : this("Неизвестно", b, c)
        {
        }
        public Human(string a, int b, string c)
        {
            name = a;
            age = b;
            country = c;
        }

        public void setValue(string nameValue, string countryValue)
        {
            name = nameValue;
            country = countryValue;
        }
        public string getName()
        {
            return name;
        }
        public string getCountry()
        {
            return country;
        }

        public void setValue(int ageValue)
        {
            age = ageValue;
        }
        public int getAge()
        {
            return age;
        }

        public virtual void getInfo()
        {
            Console.WriteLine($"Имя: {name}");
            Console.WriteLine($"Возраст: {age}");
            Console.WriteLine($"Страна: {country}");
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine("");
        }

        public int generateID()
        {
            Random rnd = new Random();
            return ID = rnd.Next(100000, 999999);
        }

    }
}
