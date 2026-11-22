using System;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static async Task<int> printC(ConsoleColor color, int start, int end)
    {
        int number = start;

        for (number = start; number <= end; number++)
        {
            Console.ForegroundColor = color;
            Console.Write(number + " ");
            Console.ResetColor();

            await Task.Delay(50);
        }

        return number;
    }

    static async Task Main(string[] args)
    {
        Task<int> task1 = printC(ConsoleColor.Green, 1, 100);

        Task<int> task2 = printC(ConsoleColor.Red, 1, 100);

        int result1 = await task1;
        int result2 = await task2;

        Console.Write("Task 1 printed: " + result1);
        Console.Write("Task 2 printed: " + result2);

        Console.WriteLine("\nAll tasks completed!");
    }
}