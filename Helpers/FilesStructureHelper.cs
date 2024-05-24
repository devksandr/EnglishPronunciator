using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishPronunciator.Helpers
{
    public static class FilesStructureHelper
    {
        public static string SettingsName => "settings.xml";
        public static string AudioExtension => "mp3";
        public static string AudioDirectory => "Audio";
        public static string AudioErrorPath => $"{AudioDirectory}/error.{AudioExtension}";
        public static string WordDirectory => Path.Combine(AudioDirectory, "Words");
    }
}
