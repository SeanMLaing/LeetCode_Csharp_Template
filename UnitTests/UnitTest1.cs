using Microsoft.VisualStudio.TestPlatform.TestHost;



namespace UnitTests
{

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string input = "Hello World";
            int result = LeetCodeTemplate.Problem(input);

            Assert.AreEqual(5, result);
        }






        [TestMethod]
        public void TestMethod2()
        {
            string input = "luffy is still joyboy";
            int result = LeetCodeTemplate.Problem(input);

            Assert.AreEqual(6, result);
        }




        [TestMethod]
        public void TestMethod3()
        {
            string input = "   fly me   to   the moon  ";
            int result = LeetCodeTemplate.Problem(input);

            Assert.AreEqual(4, result);
        }

    }
}