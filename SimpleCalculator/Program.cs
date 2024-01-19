// See https://aka.ms/new-console-template for more information
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

string op = Console.ReadLine()!;

AROperation aROperation = new AROperation();

try
{
    switch (op)
    {
        case "1":
            aROperation.Addition(num1, num2);
            break;
        case "2":
            aROperation.Subtract(num1, num2);
            break;
        case "3":
            aROperation.Multiple(num1, num2);
            break;
        case "4":
            aROperation.Divide(num1, num2);
            break;
    }
}
catch (Exception e)
{
    Console.WriteLine(e);
}



class AROperation
{
    public void Addition(double num1, double num2)
    {
        Console.WriteLine($"Result is: {num1 + num2}");
    }

    public void Subtract(double num1, double num2)
    {
        Console.WriteLine($"Result is: {num1 - num2}");
    }

    public void Multiple(double num1, double num2)
    {
        Console.WriteLine($"Result is: {num1 * num2}");
    }

    public void Divide(double num1, double num2)
    {
        Console.WriteLine($"Result is: {num1 / num2}");
    }
}

