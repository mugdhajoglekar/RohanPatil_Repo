
namespace ConsoleAppFramework
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number 1");
            int Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 2");
            int Num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the operator");
            string OperatorInput = Console.ReadLine();
            switch (OperatorInput)
            {
                case "+": Console.WriteLine("Answer = " + (Num1 + Num2)); break;
                case "-": Console.WriteLine("Answer = " + (Num1 - Num2)); break;
                case "*": Console.WriteLine("Answer = " + (Num1 * Num2)); break;
                case "/": Console.WriteLine("Answer = " + (Num1 / Num2)); break;
                default: Console.WriteLine("Invalid Input"); break;
            }
        }
    }
}
