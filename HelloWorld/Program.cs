using System;
using System.Text;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please, tell me your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"Your age: {age}.");
            Console.ReadKey();
        }
    }
}