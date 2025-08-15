using System;
using System.IO;
using System.Xml.Serialization;

namespace MyCVToolkit
{
    public class Settings
    {
        // Folder and file path
        private static readonly string FolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "MyCVToolkit");
        private static readonly string FilePath = Path.Combine(FolderPath, "settings.xml");

        // User settings that are saved
        public class UserSettings
        {
            // Reporting Database
            public string Server { get; set; }
            public string Database { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }

            // Directories
            public string UserFiles { get; set; }
            public string ReviewerFiles { get; set; }
        }

        // Save user settings to an XML file
        public static void SaveUserSettingsToXml(UserSettings settings)
        {
            // Create directory if it doesn't exist
            Directory.CreateDirectory(FolderPath);

            // Create an XML serializer for the UserSettings class
            var serializer = new XmlSerializer(typeof(UserSettings));
            using (var writer = new StreamWriter(FilePath))
            {
                serializer.Serialize(writer, settings);
            }
        }

        // Load the user settings XML file
        public static UserSettings LoadUserSettingsFromXml()
        {
            if (File.Exists(FilePath))
            {
                try
                {
                    var serializer = new XmlSerializer(typeof(UserSettings));
                    using (var reader = new StreamReader(FilePath))
                    {
                        return (UserSettings)serializer.Deserialize(reader);
                    }
                }
                catch (Exception)
                {
                    // If deserialization fails, return default settings
                    return new UserSettings();
                }
            }

            // Return default settings if file doesn't exist
            return new UserSettings();
        }
    }
}
