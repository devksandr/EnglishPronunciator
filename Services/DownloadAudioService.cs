using EnglishPronunciator.Helpers;

namespace EnglishPronunciator.Services
{
    public class DownloadAudioService
    {
        private const string URL = "https://d1qx7pbj0dvboc.cloudfront.net";

        private string GetUri(string word) 
            => $"{URL}/{word}.{FilesStructureHelper.AudioExtension}";

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
            if (!Directory.Exists(FilesStructureHelper.WordDirectory))
            {
                Directory.CreateDirectory(FilesStructureHelper.WordDirectory);
            }

            string fullFileName = $"{FilesStructureHelper.WordDirectory}/{fileName}.{FilesStructureHelper.AudioExtension}";
            await File.WriteAllBytesAsync(fullFileName, bytes);
        }
    }
}
