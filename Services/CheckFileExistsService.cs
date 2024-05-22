using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishPronunciator.Services
{
    public class CheckFileExistsService
    {
        SettingsService _settingsService;
        public CheckFileExistsService(SettingsService settingsService)
        {
            _settingsService = settingsService;
        }

        public bool Exists(string fileName)
        {
            string fullFilePath = $"{_settingsService.WordDirectory}/{fileName}.{_settingsService.AudioExtension}";
            return File.Exists(fullFilePath);
        }
    }
}
