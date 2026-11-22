using System;
using System.Threading.Tasks;

class Program
{
    static async Task<int> printC(ConsoleColor color, int start, int end)
    {
        int numOfIterations = 0;

        for (int i = start; i <= end; i++)
        {
            Console.ForegroundColor = color;
            Console.Write(i + " ");
            Console.ResetColor();

            numOfIterations++;

            await Task.Delay(50);
        }

        return numOfIterations;
    }

    static async Task Main(string[] args)
    {
        Task<int> t1 = printC(ConsoleColor.Green, 1, 100);

        Task<int> t2 = printC(ConsoleColor.Cyan, 1, 100);

        int result1 = await t1;
        int result2 = await t2;

        Console.Write("Task 1 printed: " + result1);
        Console.Write("Task 2 printed: " + result2);

        Console.WriteLine("\nAll tasks completed!");
    }
}