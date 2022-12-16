using ProtoBuf;
using QR_CodeGenerator.Config;
using QR_CodeGenerator.Models;

namespace QR_CodeGenerator.Service;

public class AppSettingsService
{
    private const string SettingsFilename = "QrCodeGenSettings.dat";

    public ApplicationSettingsModel AppSettings { get; private set; }

    public AppSettingsService()
    {
        Serializer.PrepareSerializer<ApplicationSettingsModel>();
    }

    public ApplicationSettingsModel LoadSettings()
    {
        string fullPath = Path.Join(EnvironmentConfigHelper.GetApplicationUserDataPath(), SettingsFilename);
        FileStream fs = null;
        try
        {
            if (!File.Exists(fullPath))
            {
                AppSettings = CreateDefaultSettings();
                return AppSettings;
            }

            fs = File.OpenRead(fullPath);
            var ms = new MemoryStream();
            fs.CopyTo(ms);
            ms.Position = 0;

            var settings = Serializer.Deserialize<ApplicationSettingsModel>(ms);

            if (settings == null || settings.Id == Guid.Empty)
            {
                AppSettings = CreateDefaultSettings();
                return AppSettings;
            }

            AppSettings = settings;
            return AppSettings;

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            if (fs != null)
            {
                fs.Close();
                fs.Dispose();
            }
        }
        
        AppSettings = CreateDefaultSettings();
        return AppSettings;
    }

    public void SaveSettings(ApplicationSettingsModel model)
    {
        string directoryName = EnvironmentConfigHelper.GetApplicationUserDataPath();
        string fullPath = Path.Join(directoryName, SettingsFilename);
        FileStream fs = null;

        try
        {
            if (!Directory.Exists(directoryName))
            {
                if (directoryName != null) Directory.CreateDirectory(directoryName);
            }

            if (File.Exists(fullPath))
            {
                File.Delete(fullPath);
            }

            fs = File.OpenWrite(fullPath);
            var ms = new MemoryStream();

            Serializer.Serialize(ms, model);

            ms.Position = 0;
            ms.CopyTo(fs);
            fs.Flush(true);


        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            if (fs != null)
            {
                fs.Close();
                fs.Dispose();
            }
        }
    }

    private ApplicationSettingsModel CreateDefaultSettings()
    {
        return new ApplicationSettingsModel
        {
            GenerateQRImage = true,
            RandomTextType = ApplicationSettingsModel.RandomDataType.Password,
            TextLength = 64,
            Id = Guid.NewGuid(),
            ModifiedDate = DateTime.Now
        };
    }
}