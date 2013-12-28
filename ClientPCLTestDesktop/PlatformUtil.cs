using ClientPCLLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClientPCLTestWindows
{
    [TestClass]
    public class PlatformUtil
    {
        [TestMethod]
        public void TestPlatformString()
        {
            Assert.AreEqual("Returned platform string is Desktop.", DoItNow.GetThePlatform());
        }
    }
}
