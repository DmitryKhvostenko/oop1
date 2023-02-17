using System;
namespace task11
{
    internal class Program
    {
        delegate int Operation(int x, int y);
        static void Main(string[] args)
        {
            int Add(int x, int y) => x + y;
            int Min(int x, int y) => x - y;
            int Mul(int x, int y) => x * y;
            int Del(int x, int y) => x / y;
            Console.WriteLine("Enter the first number: ");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose an operation + - * / : ");
            string oper = Console.ReadLine();
            switch (oper)
            {
                case "+":
                    Operation oper1 = Add;
                    Console.WriteLine($"Your result: {oper1(first, second)}");
                    break;
                case "-":
                    Operation oper2 = Min;
                    Console.WriteLine($"Your result: {oper2(first, second)}");
                    break;
                case "*":
                    Operation oper3 = Mul;
                    Console.WriteLine($"Your result: {oper3(first, second)}");
                    break;
                case "/":
                    Operation oper4 = Del;
                    Console.WriteLine($"Your result: {oper4(first, second)}");
                    break;
            }
        }
    }
}