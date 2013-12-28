using PCLTestInterfaceLibrary;

namespace PCLTestLibrary
{
    class WinRTBaseFunctionality : IBaseFunctionality
    {
        public string PlatformString
        {
            get { return "Windows RT"; }
        }
    }
}
