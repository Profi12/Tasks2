using NUnit.Framework;
using System;
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
             double a, double b, double c, double expectedA, double expectedB, double expectedC)
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

            Assert.True(roots.X1 == expectedX1 || roots.X2 == expectedX1);
            Assert.True(roots.X1 == expectedX2 || roots.X2 == expectedX2);
        }

        [Test]
        public void Task4_WhenDLessThenZiro_ShouldNoRootsOfEquation()
        {
            Assert.IsNull(TasksHelper.Task4(1,2,17));
        }


        [TestCase(10, "Ten")]
        [TestCase(11, "Eleven")]
        [TestCase(12, "Twelve")]
        [TestCase(13, "Thirteen")]
        [TestCase(14, "Fouteen")]
        [TestCase(15, "Fifteen")]
        [TestCase(16, "Sixteen")]
        [TestCase(17, "Seventeen")]
        [TestCase(18, "Eighteen")]
        [TestCase(19, "Nineteen")]
        [TestCase(20, "Twenty")]
        [TestCase(30, "Thirty")]
        [TestCase(40, "Fourty")]
        [TestCase(50, "Fifty")]
        [TestCase(60, "Sixty")]
        [TestCase(70, "Seventy")]
        [TestCase(80, "Eighty")]
        [TestCase(90, "Ninty")]
        [TestCase(45, "Fourty five")]
        [TestCase(27, "Twenty seven")]
        [TestCase(21, "Twenty one")]
        [TestCase(32, "Thirty two")]
        [TestCase(43, "Fourty three")]
        [TestCase(54, "Fifty four")]
        [TestCase(65, "Sixty five")]
        [TestCase(76, "Seventy six")]
        [TestCase(87, "Eighty seven")]
        [TestCase(98, "Ninty eight")]
        public void Task5_WhenAFrom10To99_ShouldOperatingNumberNotation(int a, string expected)
        {
            Assert.AreEqual(expected, TasksHelper.Task5(a));
        }

        [Test]
        public void Task5_WhenAFrom0To9_ShouldThrowArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                TasksHelper.Task5(5);
            });
        }

        [Test]
        public void Task5_WhenAMore99_ShouldThrowArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                TasksHelper.Task5(101);
            });
        }
    }
}