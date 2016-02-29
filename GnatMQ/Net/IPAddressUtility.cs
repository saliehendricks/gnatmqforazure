namespace GnatMQForAzure.Net
{
    using System.Net;
    using System.Net.Sockets;

    /// <summary>
    /// IPAddress Utility class
    /// </summary>
    public static class IPAddressUtility
    {
        /// <summary>
        /// Return AddressFamily for the IP address
        /// </summary>
        /// <param name="ipAddress">IP address to check</param>
        /// <returns>Address family</returns>
        public static AddressFamily GetAddressFamily(this IPAddress ipAddress)
        {
#if (!MF_FRAMEWORK_VERSION_V4_2 && !MF_FRAMEWORK_VERSION_V4_3)
            return ipAddress.AddressFamily;
#else
            return (ipAddress.ToString().IndexOf(':') != -1) ? 
                AddressFamily.InterNetworkV6 : AddressFamily.InterNetwork;
#endif
        }
    }
}