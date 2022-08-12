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
            Console.WriteLine("Input 2 numbers");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());   
            Console.WriteLine($"Sum = {calc.Add(x, y)}");
            Console.WriteLine("Input 2 numbers");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Multiply = {calc.Multiply(x, y)}");
            Console.WriteLine("Input 2 numbers");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Subtract = {calc.Subtract(x, y)}");
            Console.ReadLine();
        }
    }
}
