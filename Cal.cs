using System;

// Calculator class start
class Cal
{
    // Entry point of the program
    static void Main(string[] args)
    {
        // Variable declaration
        double num1, num2, result;
        char operation;

        // User prompt for calculator
        Console.WriteLine("A simple Calculator by Vinay !");

        // Taking first number input
        Console.WriteLine("Enter first number: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        // Taking operation (+, -, *, /, %) input
        Console.WriteLine("Enter an operation (+, -, *, /, %): ");
        string input = Console.ReadLine();
        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("No operation entered. Exiting...");
            return;
        }

        operation = Convert.ToChar(input);

         // Taking second number input
        Console.WriteLine("Enter second number: ");
        num2 = Convert.ToDouble(Console.ReadLine());

         // Switch-case to handle different operations
        switch (operation)
        {
            case '+': //Addition
                result = num1 + num2;
                Console.WriteLine("Result = " + result);
                break;
            case '-': //Subtraction
                result = num1 - num2;
                Console.WriteLine("Result = " + result);
                break;
            case '*': //Multiplication
                result = num1 * num2;
                Console.WriteLine("Result = " + result);
                break;
            case '/':
                //Division with zero check
                if (num2 != 0)
                {
                    result = num1 / num2;
                    Console.WriteLine("Result = " + result);
                }
                else
                {
                    Console.WriteLine("Error! Division by zero is not allowed.");
                }
                break;
            case '%': //Modulo operation
                result = num1 % num2;
                Console.WriteLine("Result = " + result);
                break;
            default: //Invalid operator
                Console.WriteLine("Invalid operation.");
                break;
        }

        // Wait for user to press a key before exit
        Console.WriteLine("|| Press any key to exit ||");
        Console.ReadKey();
    }
}
