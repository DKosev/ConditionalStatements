//We are given 5 integer numbers. Write a program that checks if the sum of some subset of them is 0. Example: 3, -2, 1, 1, 8  1+1-2=0.

using System;

class CheckSumOfSubset
{
    static void Main()
    {
        Console.Write("Enter five numbers to check if there is a zero sum of the subset:\n=> ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("=> ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("=> ");
        int thirdNumber = int.Parse(Console.ReadLine());
        Console.Write("=> ");
        int fourthNumber = int.Parse(Console.ReadLine());
        Console.Write("=> ");
        int fifthNumber = int.Parse(Console.ReadLine());

        if ((firstNumber + secondNumber == 0) ||
            (firstNumber + thirdNumber == 0) ||
            (firstNumber + fourthNumber == 0) ||
            (firstNumber + fifthNumber == 0) ||
            (secondNumber + thirdNumber == 0) ||
            (secondNumber + fourthNumber == 0) ||
            (secondNumber + fifthNumber == 0) ||
            (thirdNumber + fourthNumber == 0) ||
            (thirdNumber + fifthNumber == 0) ||
            (fourthNumber + fifthNumber == 0) ||
            (firstNumber + secondNumber + thirdNumber == 0) ||
            (firstNumber + secondNumber + fourthNumber == 0) ||
            (firstNumber + secondNumber + fifthNumber == 0) ||
            (firstNumber + thirdNumber + fourthNumber == 0) ||
            (firstNumber + thirdNumber + fifthNumber == 0) ||
            (firstNumber + fourthNumber + fifthNumber == 0) ||
            (secondNumber + thirdNumber + fourthNumber == 0) ||
            (secondNumber + thirdNumber + fifthNumber == 0) ||
            (secondNumber + fourthNumber + fifthNumber == 0) ||
            (thirdNumber + fourthNumber + fifthNumber == 0) ||
            (firstNumber + secondNumber + thirdNumber + fourthNumber == 0) ||
            (firstNumber + secondNumber + thirdNumber + fifthNumber == 0) ||
            (firstNumber + thirdNumber + fourthNumber + fifthNumber == 0) ||
            (secondNumber + thirdNumber + fourthNumber + fifthNumber == 0) ||
            (firstNumber + secondNumber + thirdNumber + fourthNumber + fifthNumber == 0))
        {
            Console.WriteLine("There is a zero sum of the subset!");
        }
        else
        {
            Console.WriteLine("There isn't a zero sum of the subset!");
        }
    }
}