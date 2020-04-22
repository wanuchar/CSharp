using System;
namespace Lab8
{
    public interface IAvMark
    {
        static int[] arrayMark = new int[3];

        double avMark();
        void checkProgress(double av);
    }
}
