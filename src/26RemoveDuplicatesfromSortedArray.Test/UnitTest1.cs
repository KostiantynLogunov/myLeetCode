namespace _26RemoveDuplicatesfromSortedArray.Test
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
            int[] arr = new int[] { 1, 1, 2 };
            int expectedCount = 2;
            int[] expectedResult = new int[] { 1, 2};

            int count = Program.RemoveDuplicates(arr);

            Assert.That(count, Is.EqualTo(expectedCount));
        }

        [Test]
        public void Test2()
        {
            int[] arr = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            int expectedCount = 5;
            int[] expectedResult = new int[] { 0, 1, 2, 3, 4 };

            int count = Program.RemoveDuplicates(arr);

            Assert.That(count, Is.EqualTo(expectedCount));
        }
    }
}