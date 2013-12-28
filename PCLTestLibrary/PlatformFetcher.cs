using PCLTestInterfaceLibrary;
using System;

namespace PCLTestLibrary
{
    /// <summary>
    /// Interface to functionality that should be available in all platforms
    /// </summary>
    public class PlatformFetcher
    {
        /// <summary>
        /// Return the platform that we are currently using.
        /// </summary>
        public IBaseFunctionality FetchPlatformUnique
        {
            get
            {
                var r = CreatePlatformObject();
                if (r == null)
                    throw new NotImplementedException("The platform version of the PCLTest library was not linked in!");

                return r;
            }
        }

        /// <summary>
        /// Platform specific version of the creation engine.
        /// </summary>
        /// <returns></returns>
        private static IBaseFunctionality CreatePlatformObject()
        {
#if SILVERLIGHT
            return new PCLTestPhoneLibrary.PhoneBaseFunctionality();
#elif NETFX_CORE
            return new PCLTestWindowsLibrary.WinRTBaseFunctionality();
#elif FILE_SYSTEM
            return new PCLTestDesktopLibrary.DesktopBaseFunctionality();
#else
            return null;
#endif
        }

    }
}
