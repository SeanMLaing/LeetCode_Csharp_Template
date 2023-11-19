using Microsoft.VisualStudio.TestPlatform.TestHost;



namespace UnitTests
{

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] i = { 5, 1, 3 };
            int result = LeetCodeTemplate.Problem(i);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] i = { 1, 1, 2, 2, 3 };
            int result = LeetCodeTemplate.Problem(i);

            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int[] i = { 1, 1, 1 };
            int result = LeetCodeTemplate.Problem(i);

            Assert.AreEqual(0, result);
        }



        [TestMethod]
        public void TestMethod4()
        {
            int[] i = { 27664, 47570, 27664, 27664, 27664, 27664, 27664, 27664, 27664, 27664};

            int result = LeetCodeTemplate.Problem(i);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestMethod5()
        {
            int[] i = { 10832, 43690, (int)Math.Round((5 * Math.Pow(10, 4)) + 1)};
            int result = LeetCodeTemplate.Problem(i);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestMethod6()
        {
            int[] i = { 49995, 49999, 49993, 49997, 49996, 50000, 49991, 49998, 49992, 49994 };
            int result = LeetCodeTemplate.Problem(i);

            Assert.AreEqual(45, result);
        }
        




    } // EOC




}