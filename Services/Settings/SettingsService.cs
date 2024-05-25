using EnglishPronunciator.Models;

namespace EnglishPronunciator.Services.Settings
{
    public class SettingsService
    {
        private readonly SettingsParamsService _settingsParamsService;
        private readonly SettingsFileService _settingsFileService;

        public SettingsService(SettingsParamsService settingsParamsService, SettingsFileModel settingsFileModel)
        {
            _settingsParamsService = settingsParamsService;
            _settingsFileService = new SettingsFileService(settingsFileModel);

            _settingsParamsService.ParamChanged += settingsParamsService_ParamChanged;
        }

        private void settingsParamsService_ParamChanged(object? sender, EventArgs e)
        {
            _settingsFileService.Save();
        }
    }
}
