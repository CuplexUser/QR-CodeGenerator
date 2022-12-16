using System.Reflection;

namespace QR_CodeGenerator.Config;

public class EnvironmentConfigHelper
{
    public static string ApplicationName => Assembly.GetExecutingAssembly().GetName().Name;

    public static string GetApplicationUserDataPath()
    {
        return Path.Join(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), ApplicationName);
    }

}