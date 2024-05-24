using EnglishPronunciator.Models;

namespace EnglishPronunciator.Services.Settings
{
    public class SettingsParamsService
    {
        public event EventHandler? ParamChanged;
        public SettingsFileModel Params { get; }

        public SettingsParamsService(SettingsFileModel settingsFileModel)
        {
            Params = settingsFileModel;
            Params.PropertyChanged += SettingsFileModel_PropertyChanged;
        }

        private void SettingsFileModel_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            ParamChanged?.Invoke(this, new EventArgs());
        }
    }
}
