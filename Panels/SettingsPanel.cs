using EnglishPronunciator.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishPronunciator.Panels
{
    public class SettingsPanel
    {
        private readonly SettingsService _settingsService;

        public SettingsPanel(SettingsService settingsService)
        {
            _settingsService = settingsService;
        }
    }
}
