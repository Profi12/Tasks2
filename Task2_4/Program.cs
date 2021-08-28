using System;
using Tasks2Library;

namespace Task2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());

            QuadricRoots quadricRoots = TasksHelper.Task4(a, b, c);
            if (quadricRoots == null)
            {
                Console.WriteLine("No roots!");
            }

            Console.WriteLine($"x1 = {quadricRoots.X1}; x2 = {quadricRoots.X2}");
        }
    }
}
