using System;
using Tasks2Library;

namespace Task2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{TasksHelper.Task5(a)}");
        }
    }
}
