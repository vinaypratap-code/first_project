using System;
class Cal
{
    static void main(String []args)
    {
        double num1, num2, result;
        char operation;
        Console.WriteLine("A simple Calculator by vinay !");
        Console.WriteLine("Enter first number : ");
        num1 =Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter Operation : ");
        operation =Convert.ToChar(Console.ReadLine());

        Console.WriteLine("Enter second number : ");
        num2 =Convert.ToDouble(Console.ReadLine());


        switch (operation)
        {
            case '+':
                 result = num1 + num2;
                 Console.WriteLine("Result = " + result);
            break;
            case '-':
                 result = num1 - num2;
                 Console.WriteLine("Result = " + result);
            break;
            case '*':
                result = num1  * num2;
                Console.WriteLine("Result = " + result);
            break;
            case '/':
                if(num2 != 0)
                {
                    result = num1  / num2;
                    Console.WriteLine("Result = " + result);
                }
                else
                {
                   Console.WriteLine("Error ! Division by zero is not allowed |");
                }
            break;
            case '%':
                result = num1  % num2;
                Console.WriteLine("Result = " + result);
            break;
            default:
                   Console.WriteLine("Invalid Operation ||");
            break;       
        }
        Console.WriteLine("|| Press any key to exit ||");
        Console.ReadKey();
    }
}