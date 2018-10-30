using System;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int a =rand.Next(0,50);
            int b = rand.Next(51,100);
            int S = a * b;
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
            Console.WriteLine($"The rectangle area is: {a} * {b} = {S}");

        }
    }
}
