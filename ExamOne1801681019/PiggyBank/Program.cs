using System;

namespace PiggyBank
{
    class Program
    {
        static void Main(string[] args)
        {

            double sum=0;
            for (int i = 0; i < 365; i++)
            {
                Random rand = new Random();
                int number = rand.Next(0, 100000);
                double SQRTnumber = Math.Sqrt(number);
                if (number >= 1 && number <= 300)
                {
                    SQRTnumber = SQRTnumber * 5.1;
                }

                if (number >= 301 && number <= 600)
                {
                    SQRTnumber = SQRTnumber * 10.098;
                }

                if (number >= 601 && number <= 999)
                {
                    SQRTnumber = SQRTnumber * 100.00001;
                }
                sum = sum + SQRTnumber;
            }
            

            Console.WriteLine($"The total piggy sum for a year is {sum}");
        }
    }
}
