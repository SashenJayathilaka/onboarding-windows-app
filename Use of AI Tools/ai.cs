using System;

class Program
{
    // Optimized function for repetitive calculation
    static int CalculateResult(int x, int y, Func<int, int, int> operation)
    {
        return operation(x, y);
    }

    static void Main()
    {
        // Example usage
        int sum = CalculateResult(5, 10, (a, b) => a + b);
        int product = CalculateResult(5, 10, (a, b) => a * b);
        int difference = CalculateResult(10, 5, (a, b) => a - b);

        int quotient = CalculateResult(10, 5, (a, b) => a / b);
    }
}