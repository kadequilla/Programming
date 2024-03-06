namespace SimpleCalculator;

public static class Solution
{
    public static void Run()
    {
        double num1;
        double num2;


        Console.WriteLine("\n\n" +
                          "---------------------\n" +
                          "* Simple Calculator *\n" +
                          "---------------------\n");

        Console.Write("Enter first number: ");
        while (!double.TryParse(Console.ReadLine(), out num1)) //while console input is not typeof double
        {
            Console.Write("Invalid input! \nEnter first number: ");
        }


        Console.Write("Enter second number: ");
        while (!double.TryParse(Console.ReadLine(), out num2))
        {
            Console.Write("Invalid input! \nEnter second number: ");
        }


        Console.WriteLine("" +
                          "Choose an operation:\n" +
                          "1. Addition\n" +
                          "2. Subtraction\n" +
                          "3. Multiplication\n" +
                          "4. Division\n");

        Compute(num1, num2);
    }

    static void Compute(double num1, double num2)
    {
        int op;

        Console.Write("Enter the operation number (1-4): ");
        while (!int.TryParse(Console.ReadLine(), out op))
        {
            Console.Write("Invalid input! \nEnter the operation number (1-4): ");
        }

        if (op > 4)
        {
            Console.Write("No operation found!");
            Console.Write("\n");
        }

        Console.Write("\n");

        try
        {
            switch (op)
            {
                case 1:
                    Console.WriteLine($"Result of Division: {Operation.Addition(num1, num2)}");
                    break;
                case 2:
                    Console.WriteLine($"Result of Subtraction: {Operation.Subtract(num1, num2)}");
                    break;
                case 3:
                    Console.WriteLine($"Result of Multiplication: {Operation.Multiple(num1, num2)}");
                    break;
                case 4:
                    Console.WriteLine($"Result of Division: {Operation.Divide(num1, num2)}");
                    break;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
}