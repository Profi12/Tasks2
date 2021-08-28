using System;
using Tasks2Library;

namespace Task2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());

            int result = TasksHelper.Task2(x, y);

            if (result != -1)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Point lies on the axis");
            }
        }
    }
}
