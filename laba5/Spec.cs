using System;
namespace Lab5
{
    class Spec : Student
    {
        public struct specialty {
           public string specName;
           public string mainSub;

        }

        public specialty specStruct;

        public Spec() : this("Неизвестно",0, "Неизвестно", 0, "Неизвестно", "Неизвестно")
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
            specStruct.specName = g;
            specStruct.mainSub = h;
        }

        public override void getInfo()
        {
            base.getInfo();
            Console.WriteLine($"Специальность: {specStruct.specName}");
            Console.WriteLine($"Профильный предмет: {specStruct.mainSub}");
        }
    }
}
