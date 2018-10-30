using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            do
            {
                Console.WriteLine("Do you want to calculate some numbers? (yes or no)");
                answer=Console.ReadLine();
            } while (answer!="yes");

            Console.WriteLine("Enter first number:");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            double secondNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter operation ( +,-,*,/ ) :");
            char operation = char.Parse(Console.ReadLine());

            double result;

            if(operation=='+')
            {
                result = (firstNumber + secondNumber)+(firstNumber + secondNumber)/10;
                Math.Round(result, 2);
                Console.WriteLine($"The result is :{result}");
            }
            else
            {
                if(operation=='-')
                {
                    if(firstNumber>secondNumber)
                    {
                        firstNumber = firstNumber * firstNumber;
                        result = firstNumber - secondNumber;
                        Math.Round(result, 2);
                        Console.WriteLine($"The result is :{result}");
                    }
                    else
                    {
                        if (secondNumber>firstNumber)
                        {
                            secondNumber = secondNumber * secondNumber;
                            result = secondNumber - firstNumber;
                            Math.Round(result, 2);
                            Console.WriteLine($"The result is :{result}");
                        }
                        else
                        {
                            result = firstNumber - secondNumber;
                            Math.Round(result, 2);
                            Console.WriteLine($"The result is :{result}");
                        }
                    }
                    
                }
                else
                {
                    if (operation=='*')
                    {
                        result = firstNumber * Math.Sqrt(secondNumber);
                        Math.Round(result, 2);
                        Console.WriteLine($"The result is :{result}");
                    }
                    else
                    {
                        if(operation=='/')
                        {
                            if(secondNumber==0)
                            {
                                Console.WriteLine("Error! Cannot divide by 0");
                            }
                            else
                            {
                                result = firstNumber / secondNumber;
                                Math.Round(result, 2);
                                Console.WriteLine($"The result is :{result}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Enter a valid operation");
                        }
                    }
                }
            }
            
        }
    }
}
