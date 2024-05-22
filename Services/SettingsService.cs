using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishPronunciator.Services
{
    public class SettingsService
    {
        public string URI => "https://d1qx7pbj0dvboc.cloudfront.net";
        public string AudioErrorName => "error";
        public string AudioExtension => "mp3";
        public string AudioDirectory => "Audio";
        public string WordDirectory => Path.Combine(AudioDirectory, "Words");
        public string ExecuteCombination => "Control+Q";
    }
}
