namespace EnglishPronunciator.Services
{
    public class PlayAudioService
    {
        private readonly SettingsService _settingsService;
        private readonly WMPLib.WindowsMediaPlayer _player;

        public PlayAudioService(SettingsService settingsService)
        {
            _settingsService = settingsService;
            _player = new WMPLib.WindowsMediaPlayer();
        }

        public void PlayError()
        {
            string errorPath = $"{_settingsService.AudioDirectory}/{_settingsService.AudioErrorName}.{_settingsService.AudioExtension}";
            PlayBase(errorPath);
        }

        public void Play(string fileName)
        {
            // TODO combineWithExtension
            string filePath = $"{_settingsService.WordDirectory}/{fileName}.{_settingsService.AudioExtension}";
            PlayBase(filePath);
        }

        private void PlayBase(string url)
        {
            _player.URL = url;
            _player.controls.play();
        }
    }
}
