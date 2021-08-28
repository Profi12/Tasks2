namespace Tasks2Library
{
    public class TasksHelper
    {
        public static int Task1(int a, int b)
        {
            int result;
            if (a > b)
            {
                result = a + b;
            }
            else if (a < b)
            {
                result = a - b;
            }
            else
            {
                result = a * b;
            }

            return result;
        }

        public static int Task2(int x, int y)
        {
            int result;
            if (y > 0 && x > 0)
            {
                result = 1;
            }
            else if (y < 0 && x < 0)
            {
                result = 3;
            }
            else if (y > 0 && x < 0)
            {
                result = 2;
            }
            else if (y == 0 || x == 0)
            {
                result = -1;
            }
            else
            {
                result = 4;
            }

            return result;
        }

        public static void Task3(ref double a, ref double b, ref double c)
        {
            if (a > b)
            {
                Swap(ref a, ref b);
            }
            if (a > c)
            {
                Swap(ref a, ref c);
            }
            if (b > c)
            {
                Swap(ref b, ref c);
            }
        }

        private static void Swap(ref double a, ref double b)
        {
            double c = b;
            b = a;
            a = c;
        }
    }
}