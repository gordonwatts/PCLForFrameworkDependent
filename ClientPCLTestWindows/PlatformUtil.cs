using ClientPCLLibrary;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace ClientPCLTestDesktop
{
    [TestClass]
    public class PlatformUtil
    {
        [TestMethod]
        public void TestFetch()
        {
            Assert.AreEqual("Returned platform string is Windows RT.", DoItNow.GetThePlatform());
        }
    }
}
