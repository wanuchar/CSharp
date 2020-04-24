using System;
namespace Lab6
{
    class Spec : Student, IAvMark, IComparable
    {
        public struct specialty
        {
            public string specName;
            public string mainSub;

        }

        public specialty specStruct;
        double av;

        public Spec() : this("Неизвестно", 0, "Неизвестно", 0, "Неизвестно", "Неизвестно" )
        {
            ID = 0;
        }
        public Spec(string a, int b, string c, courseNum f, string g, string h)
        {
            name = a;
            age = b;
            country = c;
            ID = generateID();
            course = (int)f;
            av = avMark();
            specStruct.specName = g;
            specStruct.mainSub = h;
        }

        public override void getInfo()
        {
            Console.WriteLine($"Имя: {name}");
            Console.WriteLine($"Возраст: {age}");
            Console.WriteLine($"Страна: {country}");
            Console.WriteLine($"Курс: {course}");
            Console.WriteLine($"Специальность: {specStruct.specName}");
            Console.WriteLine($"Профильный предмет: {specStruct.mainSub}");
            Console.WriteLine($"Средний бал: {Math.Round(av, 2)}");
            checkProgress(av);
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine("");
        }

        public double avMark()
        {
            
            Random rnd = new Random();
            double sum = 0;
            for (int i = 0; i < 3; i++)
            {
                IAvMark.arrayMark[i] = rnd.Next(4, 10);
                sum += IAvMark.arrayMark[i];
            }

            return sum / 3;
        }

        public void checkProgress(double av)
        {
            string levelOfProgress = "";

            if (av > 9)
            {
                levelOfProgress = "Наивысшая";
            }
            else if (av > 8)
            {
                levelOfProgress = "Повышенная";
            }
            else if (av > 6)
            {
                levelOfProgress = "Обычная";
            }
            else if (av > 5)
            {
                levelOfProgress = "Минимальная";
            }
            else levelOfProgress = "Нет"; 

            Console.WriteLine($"Стипендия: {levelOfProgress}");
        }

        public int CompareTo(object obj)
        {
            if (this.getAge() > ((Spec)obj).getAge())
            {
                return 1;
            }
            else if (this.getAge() < ((Spec)obj).getAge())
            {
                return -1;
            }
            else
                return 0;
        }
    } 
}
