using EnglishPronunciator.Helpers;

namespace EnglishPronunciator.Services
{
    public class PlayAudioService
    {
        private readonly WMPLib.WindowsMediaPlayer _player;

        public PlayAudioService()
        {
            _player = new WMPLib.WindowsMediaPlayer();
        }

        public void PlayError()
        {
            PlayBase(FilesStructureHelper.AudioErrorPath);
        }

        public void Play(string fileName)
        {
            string filePath = $"{FilesStructureHelper.WordDirectory}/{fileName}.{FilesStructureHelper.AudioExtension}";
            PlayBase(filePath);
        }

        private void PlayBase(string url)
        {
            _player.URL = url;
            _player.controls.play();
        }
    }
}
