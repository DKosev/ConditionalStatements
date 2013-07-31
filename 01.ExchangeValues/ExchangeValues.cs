//Write an if statement that examines two integer variables and exchanges their values if the first one is greater than the second one.

using System;

class ExchangeValues
{
    static void Main()
    {
        Console.Write("Enter value for 'a':\na = ");
        int aValue = int.Parse(Console.ReadLine());
        Console.Write("Enter value for 'b':\nb = ");
        int bValue = int.Parse(Console.ReadLine());
        if (aValue > bValue)
        {
            int tempValue;
            tempValue = aValue;
            aValue = bValue;
            bValue = tempValue;
            Console.WriteLine("We have 'a' greater than 'b', so we changed their values:\na = {0}\nb = {1}", aValue, bValue);
        }
        else if (aValue < bValue)
        {
            Console.WriteLine("'b' is greater than 'a'");
        }
        else
        {
            Console.WriteLine("The both numbers are equal!");
        }
    }
}
