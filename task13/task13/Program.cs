using System;
namespace task13
{
    internal class Program
    {
        delegate int Operation(int first, int second, int third);
        static void Main(string[] args)
        {
            Operation operation = delegate (int first, int second, int third)
            {
                return (first + second + third) / 3;
            };
            Console.WriteLine("Enter the first number: ");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number: ");
            int third = Convert.ToInt32(Console.ReadLine());
            double result = operation(first, second, third);
            Console.WriteLine($"Result: {result}");
        }
    }
}