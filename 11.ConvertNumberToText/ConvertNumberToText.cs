//* Write a program that converts a number in the range [0...999] to a text corresponding to its English pronunciation. Examples: 0  "Zero" 273  "Two hundred seventy three" 400  "Four hundred" 501  "Five hundred and one" 711  "Seven hundred and eleven"

using System;

class ConvertNumberToText
{
    static void Main()
    {
        Console.Write("Enter a number:\n=> ");
        int inputValue = int.Parse(Console.ReadLine());
        int firstType = inputValue / 100;
        int secondType = (inputValue - (firstType * 100)) / 10;
        int thirdType = inputValue - (firstType * 100) - (secondType * 10);
        if (inputValue > 999)
        {
            Console.WriteLine("Error! Please enter number in range 0...999!");
            Main();
        }
        else
        {
            if (inputValue < 20)
            {
                switch (inputValue)
                {
                    case 1: 
                        Console.WriteLine("One"); 
                        break;
                    case 2: 
                        Console.WriteLine("Two"); 
                        break;
                    case 3: 
                        Console.WriteLine("Three"); 
                        break;
                    case 4: 
                        Console.WriteLine("Four"); 
                        break;
                    case 5: 
                        Console.WriteLine("Five"); 
                        break;
                    case 6: 
                        Console.WriteLine("Six"); 
                        break;
                    case 7: 
                        Console.WriteLine("Seven"); 
                        break;
                    case 8: 
                        Console.WriteLine("Eight"); 
                        break;
                    case 9: 
                        Console.WriteLine("Nine"); 
                        break;
                    case 10: 
                        Console.WriteLine("Ten"); 
                        break;
                    case 11: 
                        Console.WriteLine("Eleven"); 
                        break;
                    case 12: 
                        Console.WriteLine("Twelve"); 
                        break;
                    case 13: 
                        Console.WriteLine("Thirteen"); 
                        break;
                    case 14: 
                        Console.WriteLine("Fourteen"); 
                        break;
                    case 15: 
                        Console.WriteLine("Fifteen"); 
                        break;
                    case 16: 
                        Console.WriteLine("Sixteen"); 
                        break;
                    case 17: 
                        Console.WriteLine("Seventeen"); 
                        break;
                    case 18: 
                        Console.WriteLine("Eighteen"); 
                        break;
                    case 19: 
                        Console.WriteLine("Nineteen"); 
                        break;
                 /* default:
                        Console.WriteLine("Error!");
                        break; */
                }
            }
            else
            {
                switch (firstType)
                {
                    case 1: 
                        Console.Write("One Hundred "); 
                        break;
                    case 2: 
                        Console.Write("Two Hundred "); 
                        break;
                    case 3: 
                        Console.Write("Three Hundred "); 
                        break;
                    case 4: 
                        Console.Write("Four Hundred "); 
                        break;
                    case 5: 
                        Console.Write("Five Hundred "); 
                        break;
                    case 6: 
                        Console.Write("Six Hundred "); 
                        break;
                    case 7: 
                        Console.Write("Seven Hundred "); 
                        break;
                    case 8: 
                        Console.Write("Eight Hundred "); 
                        break;
                    case 9: 
                        Console.Write("Nine Hundred "); 
                        break;
                 /* default:
                        Console.WriteLine("Error!");
                        break; */
                }
                if (firstType < 1)
                {
                    switch (secondType)
                    {
                        case 2: 
                            Console.Write("Twenty "); 
                            break;
                        case 3: 
                            Console.Write("Thirty "); 
                            break;
                        case 4: 
                            Console.Write("Fourty "); 
                            break;
                        case 5: 
                            Console.Write("Fifty "); 
                            break;
                        case 6: 
                            Console.Write("Sixty "); 
                            break;
                        case 7: 
                            Console.Write("Seventy "); 
                            break;
                        case 8: 
                            Console.Write("Eighty "); 
                            break;
                        case 9: 
                            Console.Write("Ninety "); 
                            break;
                     /* default:
                            Console.WriteLine("Error!");
                            break; */
                    }
                    switch (thirdType)
                    {
                        case 1: 
                            Console.WriteLine("One"); 
                            break;
                        case 2: 
                            Console.WriteLine("Two"); 
                            break;
                        case 3: 
                            Console.WriteLine("Three"); 
                            break;
                        case 4: 
                            Console.WriteLine("Four"); 
                            break;
                        case 5: 
                            Console.WriteLine("Five"); 
                            break;
                        case 6: 
                            Console.WriteLine("Six"); 
                            break;
                        case 7: 
                            Console.WriteLine("Seven"); 
                            break;
                        case 8: 
                            Console.WriteLine("Eight"); 
                            break;
                        case 9: 
                            Console.WriteLine("Nine"); 
                            break;
                     /* default:
                            Console.WriteLine("Error!");
                            break; */
                    }
                }
                else
                {
                    switch (secondType)
                    {
                        case 2: 
                            Console.Write("Twenty "); 
                            break;
                        case 3: 
                            Console.Write("Thirty "); 
                            break;
                        case 4: 
                            Console.Write("Fourty "); 
                            break;
                        case 5: 
                            Console.Write("Fifty "); 
                            break;
                        case 6: 
                            Console.Write("Sixty "); 
                            break;
                        case 7: 
                            Console.Write("Seventy "); 
                            break;
                        case 8: 
                            Console.Write("Eighty "); 
                            break;
                        case 9: 
                            Console.Write("Ninety "); 
                            break; 
                     /* default:
                            Console.WriteLine("Error!");
                            break; */
                    }
                    switch (thirdType)
                    {
                        case 1: 
                            Console.WriteLine("One"); 
                            break;
                        case 2: 
                            Console.WriteLine("Two"); 
                            break;
                        case 3: 
                            Console.WriteLine("Three"); 
                            break;
                        case 4: 
                            Console.WriteLine("Four"); 
                            break;
                        case 5: 
                            Console.WriteLine("Five"); 
                            break;
                        case 6: 
                            Console.WriteLine("Six"); 
                            break;
                        case 7: 
                            Console.WriteLine("Seven"); 
                            break;
                        case 8: 
                            Console.WriteLine("Eight"); 
                            break;
                        case 9: Console.WriteLine("Nine"); 
                            break;
                     /* default:
                            Console.WriteLine("Error!");
                            break; */
                    }
                }
            }
        }
    }
}
