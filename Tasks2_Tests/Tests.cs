using NUnit.Framework;
using Tasks2Library;

namespace Tasks2_Tests
{
    public class Tests
    {
        [TestCase(8, 5, 13)]
        [TestCase(5, 6, -1)]
        [TestCase(5, 5, 25)]
        public void Task1_WhenAnyAAndB_ShouldCalculateEquation(int a, int b, int expected)
        {
            Assert.AreEqual(expected, TasksHelper.Task1(a, b));
        }


        [TestCase(8, 5, 1)]
        [TestCase(-6, -6, 3)]
        [TestCase(-5, 5, 2)]
        [TestCase(0, 5, -1)]
        [TestCase(5, 0, -1)]
        [TestCase(0, 0, -1)]
        [TestCase(5, -5, 4)]
        public void Task2_WhenAnyXAndY_ShouldGetCoordinateQuater(int x, int y, int expected)
        {
            Assert.AreEqual(expected, TasksHelper.Task2(x, y));
        }


        [TestCase(8, 5, 2, 2, 5, 8)]
        [TestCase(5, 6, 1, 1, 5, 6)]
        [TestCase(5, 2, 3, 2, 3, 5)]
        [TestCase(1, 2, 3, 1, 2, 3)]
        public void Task3_WhenABCPassed_ShouldSortInAscendingOrder(
             double a,  double b,  double c, double expectedA, double expectedB, double expectedC)
        {
            TasksHelper.Task3(ref a, ref b, ref c);

            Assert.AreEqual(expectedA, a);
            Assert.AreEqual(expectedB, b);
            Assert.AreEqual(expectedC, c);
        }


        [TestCase(1, -2, -3, 3, -1)]
        [TestCase(-1, -2, 15, -5, 3)]
        [TestCase(1, 12, 36, -6, -6)]
        public void Task4_WhenDMoreZiro_ShouldQuadricRootsOfEquation(
            double a, double b, double c, double expectedX1, double expectedX2)
        {
            QuadricRoots roots = TasksHelper.Task4(a, b, c);

            Assert.True(roots.X1 == expectedX1 || roots.X1 == expectedX2);
            Assert.True(roots.X2 == expectedX1 || roots.X2 == expectedX2);
        }
    }
}