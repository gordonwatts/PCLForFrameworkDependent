using ClientPCLLibrary;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace ClientPCLTestPhone
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPlatformString()
        {
            Assert.AreEqual("Returned platform string is Phone.", DoItNow.GetThePlatform());
        }
    }
}
