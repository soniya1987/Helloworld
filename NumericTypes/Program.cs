using System;

namespace NumericTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the length of the Rectangle :");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the width of the Rectangle :");
            int width = int.Parse(Console.ReadLine());

            //int area = length * width;

            Console.WriteLine("Area of Rectangle is " + AreaOfRectangle(length, width));
        }

        static int AreaOfRectangle(int length, int width)
        {
            return length * width;
        }
    }
}
