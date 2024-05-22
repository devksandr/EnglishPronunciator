using EnglishPronunciator.Services;

namespace EnglishPronunciator.Panels
{
    public class MainPanel
    {
        private readonly InputWordService _inputWordService;
        private readonly DownloadAudioService _downloadAudioService;
        private readonly PlayAudioService _playAudioService;
        private readonly CheckFileExistsService _checkFileExistsService;
        private readonly SettingsService _settingsService;

        public MainPanel(SettingsService settingsService, Button buttonPronounce, TextBox textBoxWord)
        {
            _settingsService = settingsService;

            _inputWordService = new InputWordService(textBoxWord);
            _downloadAudioService = new DownloadAudioService(_settingsService);
            _playAudioService = new PlayAudioService(_settingsService);
            _checkFileExistsService = new CheckFileExistsService(_settingsService);

            buttonPronounce.Click += buttonPronounce_Click;
        }

        private async void buttonPronounce_Click(object sender, EventArgs e)
        {
            string word = _inputWordService.Text.Trim();
            if (string.IsNullOrEmpty(word))
            {
                _playAudioService.PlayError();
                return;
            }

            if(_checkFileExistsService.Exists(word))
            {
                _playAudioService.Play(word);
                return;
            }

            bool audioDownloaded = await _downloadAudioService.DownloadFileAsync(word);
            if (audioDownloaded)
            {
                _playAudioService.Play(word);
                return;
            }

            _playAudioService.PlayError();
        }

    }
}
