using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishPronunciator.Services
{
    public class DownloadAudioService
    {
        private readonly SettingsService _settingsService;

        public DownloadAudioService(SettingsService settingsService)
        {
            _settingsService = settingsService;
        }

        private string GetUri(string word) 
            => $"{_settingsService.URI}/{word}.{_settingsService.AudioExtension}";

        public async Task<bool> DownloadFileAsync(string word)
        {
            using (var client = new HttpClient())
            {
                string uri = GetUri(word);
                using (var response = await client.GetAsync(uri))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        using (var content = response.Content)
                        {
                            var bytes = await content.ReadAsByteArrayAsync();
                            await SaveFile(bytes, word);
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        private async Task SaveFile(byte[] bytes, string fileName)
        {
            if (!Directory.Exists(_settingsService.WordDirectory))
            {
                Directory.CreateDirectory(_settingsService.WordDirectory);
            }

            string fullFileName = $"{_settingsService.WordDirectory}/{fileName}.{_settingsService.AudioExtension}";
            await File.WriteAllBytesAsync(fullFileName, bytes);
        }
    }
}
