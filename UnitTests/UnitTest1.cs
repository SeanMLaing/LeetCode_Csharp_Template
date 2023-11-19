using Microsoft.VisualStudio.TestPlatform.TestHost;



namespace UnitTests
{

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string input = "Hello";
            string result = LeetCodeTemplate.Problem(input);

            Assert.AreEqual("hello", result);
        }



        [TestMethod]
        public void TestMethod2()
        {
            string input = "here";
            string result = LeetCodeTemplate.Problem(input);

            Assert.AreEqual("here", result);
        }




        [TestMethod]
        public void TestMethod3()
        {
            string input = "LOVELY";
            string result = LeetCodeTemplate.Problem(input);

            Assert.AreEqual("lovely", result);
        }




    }
}