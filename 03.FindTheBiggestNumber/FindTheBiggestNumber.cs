//Write a program that finds the biggest of three integers using nested if statements.

using System;

class FindTheBiggestNumber
{
    static void Main()
    {
        Console.Write("Enter the first number:\n=> ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number:\n=> ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter the third number:\n=> ");
        int thirdNumber = int.Parse(Console.ReadLine());
        if (firstNumber > secondNumber && firstNumber > thirdNumber)
        {
            Console.WriteLine("The first number '{0}' is the biggest!", firstNumber);
        }
        else if (secondNumber > firstNumber && secondNumber > thirdNumber)
        {
            Console.WriteLine("The second number '{0}' is the biggest!", secondNumber);
        }
        else
        {
            Console.WriteLine("The third number '{0}' is the biggest!", thirdNumber);
        }
    }
}
