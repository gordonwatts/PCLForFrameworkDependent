
namespace ClientPCLLibrary
{
    public class DoItNow
    {
        public static string GetThePlatform()
        {
            var tmp = new PCLTestLibrary.PlatformFetcher().FetchPlatformUnique;
            return string.Format("Returned platform string is {0}.", tmp.PlatformString);
        }
    }
}
