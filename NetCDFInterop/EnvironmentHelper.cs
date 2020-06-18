using System.IO;
using System.Reflection;

namespace NetCDFInterop
{
    public static class EnvironmentHelper
    {
        public static string CurrentLocation => Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
    }
}