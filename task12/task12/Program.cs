using System;
namespace task12
{
    internal class Program
    {
        delegate int Element();
        delegate double Array(Element[] elements);
        static int Random()
        {
            Random random = new Random();
            int num = random.Next(1, 50);
            Console.WriteLine(num);
            return num;
        }
        static void Main(string[] args)
        {
            Array array = delegate (Element[] elements)
            {
                int sum = 0;
                for (int i = 0; i < elements.Length; i++)
                {
                    sum += elements[i]();
                }
                return sum / elements.Length;
            };
            Console.WriteLine("Enter the number of elements in the array: ");
            int count = Convert.ToInt32(Console.ReadLine());
            Element[] elements = new Element[count];
            for (int i = 0; i < elements.Length; i++)
            {
                elements[i] = () => new Element(Random)();
            }
            Console.WriteLine($"Average: {array(elements)}");
        }
    }
}