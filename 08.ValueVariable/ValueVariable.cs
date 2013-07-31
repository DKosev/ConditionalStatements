//Write a program that, depending on the user's choice inputs int, double or string variable. If the variable is integer or double, increases it with 1. If the variable is string, appends "*" at its end. The program must show the value of that variable as a console output. Use switch statement.

using System;

class ValueVariable
{
    static void Main()
    {
        Console.Write("Enter what type of variable you want to input:\n\t1. Int\n\t2. Double\n\t3. String\n=> ");
        byte variableName = byte.Parse(Console.ReadLine());

        switch (variableName)
        {
            case 1:
                Console.Write("Now you have to enter the value for the chosen variable:\n=> ");
                int variableValueInt = int.Parse(Console.ReadLine());
                int variableResultInt = (variableValueInt + 1);
                Console.WriteLine("Result:\n=> {0}", variableResultInt);
                break;
            case 2:
                Console.Write("Now you have to enter the value for the chosen variable:\n=> ");
                double variableValueDouble = double.Parse(Console.ReadLine());
                double variableResultDouble = variableValueDouble + 1;
                Console.WriteLine("Result:\n=> {0}", variableResultDouble);
                break;
            case 3:
                Console.Write("Now you have to enter the value for the chosen variable:\n=> ");
                string variableValueString = Console.ReadLine();
                string variableResultString = variableValueString + "*";
                Console.WriteLine("Result:\n=> {0}", variableResultString);
                break;
        }
    }
}
