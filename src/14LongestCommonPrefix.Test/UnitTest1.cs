namespace _14LongestCommonPrefix.Test
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
            string[] strs = new string[] { "flower", "flow", "flight" };
            string expectedResult = "fl";
            
            string result = Program.LongestCommonPrefix(strs);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Test2()
        {
            string[] strs = new string[] { "dog", "racecar", "car" };

            string expectedResult = "";

            string result = Program.LongestCommonPrefix(strs);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Test3()
        {
            string[] strs = new string[] { "abab", "aba", "" };

            string expectedResult = "";

            string result = Program.LongestCommonPrefix(strs);

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }


}