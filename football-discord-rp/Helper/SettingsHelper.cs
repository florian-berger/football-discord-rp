using System.IO;
using Newtonsoft.Json;

namespace football_discord_rp.Helper
{
    public class SettingsHelper<T> where T : notnull
    {
        #region Private variables
        
        // ReSharper disable once StaticMemberInGenericType
        private static readonly string SettingsFilePath;

        #endregion Private variables

        #region Constructor

        static SettingsHelper()
        {
            SettingsFilePath = BuildFilePath("config.json");
        }

        #endregion Constructor

        #region Private methods

        private static string BuildFilePath(string fileName)
        {
            var appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var configPath = Path.Combine(appData, "Florian Berger", "Football-Discord-RP");
            if (!Directory.Exists(configPath))
            {
                Directory.CreateDirectory(configPath);
            }
            
            return Path.Combine(configPath, fileName);
        }

        #endregion Private methods

        #region Public methods

        public static T LoadSettings()
        {
            if (File.Exists(SettingsFilePath))
            {
                var fileContent = File.ReadAllText(SettingsFilePath);
                return JsonConvert.DeserializeObject<T>(fileContent) ?? default!;
            }

            var defaultSettings = Activator.CreateInstance<T>();
            SaveSettings(defaultSettings);
            
            return defaultSettings;
        }

        public static void SaveSettings(T settings)
        {
            var defaultJson = JsonConvert.SerializeObject(settings);
            File.WriteAllText(SettingsFilePath, defaultJson);
        }

        #endregion Public methods
    }
}
