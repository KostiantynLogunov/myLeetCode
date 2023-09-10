namespace _1TwoSum.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            int[] arr = new int[] { 2, 7, 11, 15 };
            int target = 9;
            int[] expectedResult = new int[] { 0, 1 };

            int[] result = Program.TwoSum(arr, target);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Test2()
        {
            int[] arr = new int[] { 3, 2, 4 };
            int target = 6;
            int[] expectedResult = new int[] { 1, 2 };

            int[] result = Program.TwoSum(arr, target);

            Assert.That(result, Is.EqualTo(expectedResult));
        }
        [Test]
        public void Test3()
        {
            int[] arr = new int[] { 3, 3 };
            int target = 6;
            int[] expectedResult = new int[] { 0, 1 };

            int[] result = Program.TwoSum(arr, target);

            Assert.That(result, Is.EqualTo(expectedResult));
        }
        [Test]
        public void Test4()
        {
            int[] arr = new int[] { 3, 2, 3 };
            int target = 6;
            int[] expectedResult = new int[] { 0, 2 };

            int[] result = Program.TwoSum(arr, target);

            Assert.That(result, Is.EqualTo(expectedResult));
        }
        [Test]
        public void Test5()
        {
            int[] arr = new int[] { -1, -2, -3, -4, -5 };
            int target = -8;
            int[] expectedResult = new int[] { 2, 4 };

            int[] result = Program.TwoSum(arr, target);

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}