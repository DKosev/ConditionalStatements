//Sort 3 real values in descending order using nested if statements.

using System;

class DescendingOrder
{
    static void Main()
    {
        Console.Write("Enter the first number:\n=> ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number:\n=> ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter the third number:\n=> ");
        int thirdNumber = int.Parse(Console.ReadLine());
        if (firstNumber > secondNumber)
        {
            if (firstNumber > thirdNumber)
            {
                if (secondNumber > thirdNumber)
                {
                    Console.WriteLine("The descending order will be like this:\n{0}\n{1}\n{2}", firstNumber, secondNumber, thirdNumber);
                }
                else
                {
                    Console.WriteLine("The descending order will be like this:\n{0}\n{1}\n{2}", firstNumber, thirdNumber, secondNumber);
                }
            }
            else
            {
                Console.WriteLine("The descending order will be like this:\n{0}\n{1}\n{2}", thirdNumber, firstNumber, secondNumber);
            }
        }
        else if (secondNumber > thirdNumber)
        {
            if (firstNumber > thirdNumber)
            {
                Console.WriteLine("The descending order will be like this:\n{0}\n{1}\n{2}", secondNumber, firstNumber, thirdNumber);
            }
            else
            {
                Console.WriteLine("The descending order will be like this:\n{0}\n{1}\n{2}", secondNumber, thirdNumber, firstNumber);
            }
        }
        else
        {
            Console.WriteLine("The descending order will be like this:\n{0}\n{1}\n{2}", thirdNumber, secondNumber, firstNumber);
        }
    }
}