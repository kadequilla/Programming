// See https://aka.ms/new-console-template for more information
using SimpleCalculator;


Console.WriteLine("" +
    "---------------------\n" +
    "* Simple Calculator *\n" +
    "---------------------\n");

Console.Write("Enter first number: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter second number: ");
double num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("" +
    "Choose an operation:\n" +
    "1. Addition\n" +
    "2. Subtraction\n" +
    "3. Multiplication\n" +
    "4. Division\n");

Console.Write("Enter the operation number (1-4): \n");
compute();



void compute()
{
    string op = Console.ReadLine()!;

    try
    {
        switch (op)
        {
            case "1":
                Console.WriteLine($"Result of Division: {Operation.Addition(num1, num2)}");
                break;
            case "2":
                Console.WriteLine($"Result of Subtraction: {Operation.Subtract(num1, num2)}");
                break;
            case "3":
                Console.WriteLine($"Result of Multiplication: {Operation.Multiple(num1, num2)}");
                break;
            case "4":
                Console.WriteLine($"Result of Division: {Operation.Divide(num1, num2)}");
                break;
        }
    }
    catch (Exception e)
    {
        Console.WriteLine(e);
    }
}


