using System;

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

        public static QuadricRoots Task4(double a, double b, double c)
        {
            double d = b * b - 4 * a * c;
            if (d < 0)
            {
                return null;
            }
            else
            {
                QuadricRoots quadricRoots = new QuadricRoots();
                quadricRoots.X1 = (-b - Math.Sqrt(d)) / (2 * a);
                quadricRoots.X2 = (-b + Math.Sqrt(d)) / (2 * a);

                return quadricRoots;
            }

        }

        public static string Task5(int a)
        {
            string result = string.Empty;
            if (a >= 10 && a <= 19)
            {
                switch (a)
                {
                    case 10:
                        result = "Ten";
                        break;
                    case 11:
                        result = "Eleven";
                        break;
                    case 12:
                        result = "Twelve";
                        break;
                    case 13:
                        result = "Thirteen";
                        break;
                    case 14:
                        result = "Fouteen";
                        break;
                    case 15:
                        result = "Fifteen";
                        break;
                    case 16:
                        result = "Sixteen";
                        break;
                    case 17:
                        result = "Seventeen";
                        break;
                    case 18:
                        result = "Eighteen";
                        break;
                    case 19:
                        result = "Nineteen";
                        break;

                }
            }
            else
            {
                switch (a / 10)
                {
                    case 2:
                        result = "Twenty";
                        break;
                    case 3:
                        result = "Thirty";
                        break;
                    case 4:
                        result = "Fourty";
                        break;
                    case 5:
                        result = "Fifty";
                        break;
                    case 6:
                        result = "Sixty";
                        break;
                    case 7:
                        result = "Seventy";
                        break;
                    case 8:
                        result = "Eighty";
                        break;
                    case 9:
                        result = "Ninty";
                        break;
                }

                switch (a % 10)
                {
                    case 0:
                        break;
                    case 1:
                        result += " one";
                        break;
                    case 2:
                        result += " two";
                        break;
                    case 3:
                        result += " three";
                        break;
                    case 4:
                        result += " four";
                        break;
                    case 5:
                        result += " five";
                        break;
                    case 6:
                        result += " six";
                        break;
                    case 7:
                        result += " seven";
                        break;
                    case 8:
                        result += " eight";
                        break;
                    case 9:
                        result += " nine";
                        break;
                }
            }

            return result;
        }

        private static void Swap(ref double a, ref double b)
        {
            double c = b;
            b = a;
            a = c;
        }
    }
}