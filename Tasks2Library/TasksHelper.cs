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
    }
}
