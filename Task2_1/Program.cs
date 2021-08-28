using System;
using Tasks2Library;

namespace Task2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(TasksHelper.Task1(a, b));
        }
    }
}
