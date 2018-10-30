using System;

namespace AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int numberCount=0;
            double average=0;
            do
            {
                Console.WriteLine("Enter number : ");
                number = int.Parse(Console.ReadLine());
                if(number>=1&&number<=255)
                { 
                    if(number%2==0)
                    {
                        numberCount++;
                        average = (average + number) / numberCount;
                    }
                }
            } while (number!=0);
            Console.WriteLine($"Average : {average}");
        }
    }
}
