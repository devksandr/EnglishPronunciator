using EnglishPronunciator.Helpers;
using EnglishPronunciator.Services;
using EnglishPronunciator.Services.Settings;

namespace EnglishPronunciator.Panels
{
    public class MainPanel
    {
        private readonly InputWordService _inputWordService;
        private readonly PlayAudioService _playAudioService;
        private readonly CatchSelectedTextService _catchSelectedTextService;
        private readonly AudioFileService _audioFileService;
        private readonly SettingsParamsService _settingsParamsService;
        private readonly ExecuteCombinationService _executeCombinationService;

        public MainPanel(SettingsParamsService settingsParamsService, ExecuteCombinationService executeCombinationService, Button buttonPronounce, TextBox textBoxWord)
        {
            _settingsParamsService = settingsParamsService;
            _executeCombinationService = executeCombinationService;
            _inputWordService = new InputWordService(textBoxWord);
            _playAudioService = new PlayAudioService();
            _catchSelectedTextService = new CatchSelectedTextService(_executeCombinationService);
            _audioFileService = new AudioFileService();

            buttonPronounce.Click += buttonPronounce_Click;
            _catchSelectedTextService.HotKeyPressed += CatchSelectedTextService_HotKeyPressed;
        }

        private async void CatchSelectedTextService_HotKeyPressed(object? sender, string e)
        {
            string word = e;
            await HandleWordToPronounce(word);
        }

        private async void buttonPronounce_Click(object? sender, EventArgs e)
        {
            string word = _inputWordService.Text;
            await HandleWordToPronounce(word);
        }

        private async Task HandleWordToPronounce(string word)
        {
            var preparedWord = AudioNameHelper.Prepare(word);
            if (!string.IsNullOrEmpty(preparedWord))
            {
                bool audioDownloaded = await _audioFileService.DownloadFileAsync(preparedWord);
                if (audioDownloaded)
                {
                    _playAudioService.Play(preparedWord);
                    return;
                }
            }

            _playAudioService.PlayError();
        }
    }
}
