using System;
using MyCalc;

namespace HelloApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello User!");
            Console.WriteLine("Welcome to Jenkins");

            Calc calc = new Calc();

            Console.WriteLine($"Sum = {calc.Add(70, 80)}");
            Console.WriteLine($"Multiply = {calc.Multiply(4, 5)}");
            Console.WriteLine($"Multiply = {calc.Subtract(14, 25)}");
            Console.ReadLine();
        }
    }
}
