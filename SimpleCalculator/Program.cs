// See https://aka.ms/new-console-template for more information
using SimpleCalculator;

Console.WriteLine("Hello, World!");

double num1 = 0;
double num2 = 0;


Console.WriteLine("-- SIMPLE CALCULATOR --");

Console.Write("Enter first number: ");
num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter second number: ");
num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("" +
    "Choose an operation:\n" +
    "1. Addition\n" +
    "2. Subtraction\n" +
    "3. Multiplication\n" +
    "4. Division\n");

Console.Write("Enter the operation number (1-4): ");
compute();



void compute()
{
    string op = Console.ReadLine()!;

    Operation operation = new();

    try
    {
        switch (op)
        {
            case "1":
                operation.Addition(num1, num2);
                break;
            case "2":
                operation.Subtract(num1, num2);
                break;
            case "3":
                operation.Multiple(num1, num2);
                break;
            case "4":
                operation.Divide(num1, num2);
                break;
        }
    }
    catch (Exception e)
    {
        Console.WriteLine(e);
    }
}


