
namespace PCLTestInterfaceLibrary
{
    /// <summary>
    /// Interface to functionality that should be available in all platforms
    /// </summary>
    public interface IBaseFunctionality
    {
        /// <summary>
        /// Return the platform that we are currently using.
        /// </summary>
        string PlatformString { get; }
    }
}
