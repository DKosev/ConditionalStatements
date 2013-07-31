//Write a program that finds the greatest of given 5 variables.

using System;

class GreatestNumber
{
    static void Main()
    {
        Console.Write("Enter the first number:\n=> ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number:\n=> ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter the third number:\n=> ");
        int thirdNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter the fourth number:\n=> ");
        int fourthNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter the fifth number:\n=> ");
        int fifthNumber = int.Parse(Console.ReadLine());

        if (firstNumber >= secondNumber & firstNumber >= thirdNumber & firstNumber >= fourthNumber & firstNumber >= fifthNumber)
        {
            Console.WriteLine("The greatest number is: => {0}", firstNumber);
        }
        else if (secondNumber >= firstNumber & secondNumber >= thirdNumber & secondNumber >= fourthNumber & secondNumber >= fifthNumber)
        {
            Console.WriteLine("The greatest number is: => {0}", secondNumber);
        }
        else if (thirdNumber >= firstNumber & thirdNumber >= secondNumber & thirdNumber >= fourthNumber & thirdNumber >= fifthNumber)
        {
            Console.WriteLine("The greatest number is: => {0}", thirdNumber);
        }
        else if (fourthNumber >= firstNumber & fourthNumber >= secondNumber & fourthNumber >= thirdNumber & fourthNumber >= fifthNumber)
        {
            Console.WriteLine("The greatest number is: => {0}", fourthNumber);
        }
        else if (fifthNumber >= firstNumber & fifthNumber >= secondNumber & fifthNumber >= thirdNumber & fifthNumber >= fourthNumber)
        {
            Console.WriteLine("The greatest number is: => {0}", fifthNumber);
        }
        else
        {
            Console.WriteLine("Error!");
        }
    }
}
