using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.Configuration.Json;
using System;
using System.IO;

namespace AppCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
            var configuration = builder.Build();
            string myKey1 = configuration["Rohan"];
            Console.WriteLine(myKey1);

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