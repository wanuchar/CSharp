using System;

namespace Lab3
{
    class Human
    {
        private string name;
        private int age;
        private string country;
        public static int ID;

        public Human() : this("Неизвестно")
        {
        }
        public Human(string a) : this (a , 0, "Неизвестно")
        {
        }
        public Human(string a, string c) : this (a, 0 ,c)
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

        public void getInfo()
        {
            Console.WriteLine($"Имя: {name} \nВозраст: {age} \nСтрана: {country}");
        }

    }

    class People
    {
        Human[] data;
        public People(int a)
        {
            data = new Human[a];
        }

        public Human this[int index]
        {
            get
            {
                return data[index];
            }
            set
            {
                data[index] = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int num = 3;
            Random rnd = new Random();
            People humans = new People(num);

            humans[0] = new Human();
            humans[0].setValue("Yan", "Belarus");
            humans[0].setValue(17);

            humans[1] = new Human("Ivan", 18, "Russia");

            humans[2] = new Human("Balint", "Germany");
            humans[2].setValue(26);

            humans[0].getInfo();
            Human.ID = rnd.Next(100000, 999999);
            Console.WriteLine($"ID: {Human.ID}\n");

            humans[1].getInfo();
            Human.ID = rnd.Next(100000, 999999);
            Console.WriteLine($"ID: {Human.ID}\n");

            humans[2].getInfo();
            Human.ID = rnd.Next(100000, 999999);
            Console.WriteLine($"ID: {Human.ID}\n");

        }
    }
}
