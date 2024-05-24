using EnglishPronunciator.Helpers;
using EnglishPronunciator.Models;
using System.Xml;
using System.Xml.Serialization;

namespace EnglishPronunciator.Services.Settings
{
    public class SettingsFileService
    {
        private SettingsFileModel _settingsFileModel;

        public SettingsFileService(SettingsFileModel settingsFileModel)
        {
            _settingsFileModel = settingsFileModel;
            InitializeSettings();
        }

        private void InitializeSettings()
        {
            PrepareFile();
            var settings = ReadFile();
            if (settings is null)
            {
                throw new ArgumentNullException("Error when read settings file");
            }

            _settingsFileModel.Update(settings);
        }

        private void PrepareFile()
        {
            if (!File.Exists(FilesStructureHelper.SettingsName))
            {
                CreateFile();
            }
        }

        private void CreateFile()
        {
            XmlSerializer xs = new XmlSerializer(typeof(SettingsFileModel));
            using (var tw = new StreamWriter(FilesStructureHelper.SettingsName))
            {
                xs.Serialize(tw, _settingsFileModel);
            }
        }

        private SettingsFileModel? ReadFile()
        {
            XmlSerializer xs = new XmlSerializer(typeof(SettingsFileModel));
            using (XmlReader reader = XmlReader.Create(FilesStructureHelper.SettingsName))
            {
                var settingsObject = xs.Deserialize(reader);
                return settingsObject is null ? null : (SettingsFileModel)settingsObject;
            }
        }

        public void Save() 
            => CreateFile();
    }
}
