using System;
using Tasks2Library;

namespace Task2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());

            TasksHelper.Task3(ref a, ref b, ref c);

            Console.WriteLine($"{a} {b} {c}");
        }
    }
}
