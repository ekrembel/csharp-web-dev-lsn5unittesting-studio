using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        

        [TestMethod]
        public void Test()
        {
            bool actualOutput = BalancedBrackets.HasBalancedBrackets("");
            Assert.AreEqual(true, actualOutput);
        }

        [TestMethod]
        public void Test1()
        {
            bool actualOutput = BalancedBrackets.HasBalancedBrackets("]");
            Assert.AreEqual(false, actualOutput);
        }

        [TestMethod]
        public void Test2()
        {
            bool actualOutput = BalancedBrackets.HasBalancedBrackets("[");
            Assert.AreEqual(false, actualOutput);
        }

        [TestMethod]
        public void Test3()
        {
            bool actualOutput = BalancedBrackets.HasBalancedBrackets("][");
            Assert.AreEqual(false, actualOutput);
        }

        [TestMethod]
        public void Test4()
        {
            bool actualOutput = BalancedBrackets.HasBalancedBrackets("[]");
            Assert.AreEqual(true, actualOutput);
        }

        [TestMethod]
        public void Test5()
        {
            bool actualOutput = BalancedBrackets.HasBalancedBrackets("[]]");
            Assert.AreEqual(false, actualOutput);
        }

        [TestMethod]
        public void Test6()
        {
            bool actualOutput = BalancedBrackets.HasBalancedBrackets("[][]");
            Assert.AreEqual(true, actualOutput);
        }

        [TestMethod]
        public void Test7()
        {
            bool actualOutput = BalancedBrackets.HasBalancedBrackets("[[]]");
            Assert.AreEqual(true, actualOutput);
        }

        [TestMethod]
        public void Test8()
        {
            bool actualOutput = BalancedBrackets.HasBalancedBrackets("]][[");
            Assert.AreEqual(false, actualOutput);
        }

        [TestMethod]
        public void Test9()
        {
            bool actualOutput = BalancedBrackets.HasBalancedBrackets("[LaunchCode");
            Assert.AreEqual(false, actualOutput);
        }

        [TestMethod]
        public void Test10()
        {
            bool actualOutput = BalancedBrackets.HasBalancedBrackets("Launch]Code[");
            Assert.AreEqual(false, actualOutput);
        }

        [TestMethod]
        public void Test11()
        {
            bool actualOutput = BalancedBrackets.HasBalancedBrackets("Launch[Code]");
            Assert.AreEqual(true, actualOutput);
        }
    }
}
