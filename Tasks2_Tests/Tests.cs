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
    }
}