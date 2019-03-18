using System.Configuration;

namespace Tests.UserCredentials
{
    public static class Credentials
    {
        public static string adminUserName = ConfigurationManager.AppSettings.Get("adminUserName");
        public static string adminPassword = ConfigurationManager.AppSettings.Get("adminPassword");
    }

    
}
