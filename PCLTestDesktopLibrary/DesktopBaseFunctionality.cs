using PCLTestInterfaceLibrary;

namespace PCLTestDesktopLibrary
{
    class DesktopBaseFunctionality : IBaseFunctionality
    {
        public string PlatformString
        {
            get { return "Desktop"; }
        }
    }
}
