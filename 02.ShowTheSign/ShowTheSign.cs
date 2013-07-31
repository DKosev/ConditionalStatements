//Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it. Use a sequence of if statements.

using System;

class ShowTheSign
{
    static void Main()
    {
        Console.Write("Enter the first real number:\na = ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter the second real number:\nb = ");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter the third real number:\nc = ");
        double thirdNumber = double.Parse(Console.ReadLine());
        if ((firstNumber == 0) || (secondNumber == 0) || (thirdNumber == 0))
        {
            Console.WriteLine("The product is zero!");
        }
        else if ((firstNumber < 0 & secondNumber > 0 & thirdNumber > 0) | 
                 (firstNumber > 0 & secondNumber < 0 & thirdNumber > 0) | 
                 (firstNumber > 0 & secondNumber > 0 & thirdNumber < 0) | 
                 (firstNumber < 0 & secondNumber < 0 & thirdNumber < 0))
        {
            Console.WriteLine("The product is negative!");
        }
        else 
        {
            Console.WriteLine("The product is positive!");
        }
    }
}