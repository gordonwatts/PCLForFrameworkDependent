using PCLTestInterfaceLibrary;

namespace PCLTestPhoneLibrary
{
    class PhoneBaseFunctionality : IBaseFunctionality
    {
        public string PlatformString
        {
            get { return "Phone"; }
        }
    }
}
