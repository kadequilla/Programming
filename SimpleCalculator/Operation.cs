namespace SimpleCalculator
{
    internal class Operation
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
}
