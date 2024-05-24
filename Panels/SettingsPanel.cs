using EnglishPronunciator.Services;
using EnglishPronunciator.Services.Settings;

namespace EnglishPronunciator.Panels
{
    public class SettingsPanel
    {
        private readonly SettingsService _settingsService;
        private readonly ExecuteCombinationService _executeCombinationService;

        public SettingsPanel(SettingsService settingsService, ExecuteCombinationService executeCombinationService)
        {
            _settingsService = settingsService;
            _executeCombinationService = executeCombinationService;
        }
    }
}
