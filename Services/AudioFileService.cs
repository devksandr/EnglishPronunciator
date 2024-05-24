using EnglishPronunciator.Helpers;
using EnglishPronunciator.Services.Settings;

namespace EnglishPronunciator.Services
{
    public class AudioFileService
    {
        private readonly DownloadAudioService _downloadAudioService;

        public AudioFileService()
        {
            _downloadAudioService = new DownloadAudioService();
        }

        public async Task<bool> DownloadFileAsync(string word)
        {
            if (Exists(word))
            {
                return true;
            }

            bool audioDownloaded = await _downloadAudioService.DownloadFileAsync(word);
            if (audioDownloaded)
            {
                return true;
            }

            return false;
        }

        private bool Exists(string word)
        {
            string fullFilePath = $"{FilesStructureHelper.WordDirectory}/{word}.{FilesStructureHelper.AudioExtension}";
            return File.Exists(fullFilePath);
        }
    }
}
