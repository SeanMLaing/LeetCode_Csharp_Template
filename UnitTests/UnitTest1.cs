using Microsoft.VisualStudio.TestPlatform.TestHost;



namespace UnitTests
{

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int i = 0;
            int result = LeetCodeTemplate.Problem(i);

            Assert.AreEqual(i, result);
        }
    }
}