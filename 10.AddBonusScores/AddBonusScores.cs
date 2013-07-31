//Write a program that applies bonus scores to given scores in the range [1..9]. The program reads a digit as an input. If the digit is between 1 and 3, the program multiplies it by 10; if it is between 4 and 6, multiplies it by 100; if it is between 7 and 9, multiplies it by 1000. If it is zero or if the value is not a digit, the program must report an error. Use a switch statement and at the end print the calculated new value in the console.

using System;

class AddBonusScores
{
    static void Main()
    {
        Console.Write("Enter a number between 1 - 9\n=> ");
        byte inputValue = byte.Parse(Console.ReadLine());

        switch (inputValue)
        {
            case 1:
            case 2:
            case 3:
                int multiplyBy10 = (inputValue * 10);
                Console.WriteLine("Result:\n=> {0}", multiplyBy10);
                break;
            case 4:
            case 5:
            case 6:
                int multiplyBy100 = (inputValue * 100);
                Console.WriteLine("Result:\n=> {0}", multiplyBy100);
                break;
            case 7:
            case 8:
            case 9:
                int multiplyBy1000 = (inputValue * 1000);
                Console.WriteLine("Result:\n=> {0}", multiplyBy1000);
                break;
            default:
                Console.WriteLine("Error! Try Again!");
                Main();
                break;
        }
    }
}