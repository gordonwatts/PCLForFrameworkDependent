using PCLTestInterfaceLibrary;

namespace PCLTestWindowsLibrary
{
    class WinRTBaseFunctionality : IBaseFunctionality
    {
        public string PlatformString
        {
            get { return "Windows RT"; }
        }
    }
}
