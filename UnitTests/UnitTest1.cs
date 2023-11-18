using Microsoft.VisualStudio.TestPlatform.TestHost;



namespace UnitTests
{

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1(string[] args)
        {
            string word1 = args[1], word2 = args[2];

            Assert.IsTrue(string.Equals(LeetCodeTemplate.Problem(word1, word2), "apbqcr"));

        }


        [TestMethod]
        public void TestMethod2()
        {
            string word1 = "ab", word2 = "pqrs";

            Assert.IsTrue(string.Equals(LeetCodeTemplate.Problem(word1, word2), "apbqrs"));

        }


        [TestMethod]
        public void TestMethod3()
        {
            string word1 = "abcd", word2 = "pq";

            Assert.IsTrue(string.Equals(LeetCodeTemplate.Problem(word1, word2), "apbqcd"));

        }


    }
}