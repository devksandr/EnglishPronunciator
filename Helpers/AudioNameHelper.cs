namespace EnglishPronunciator.Helpers
{
    public static class AudioNameHelper
    {
        public static string? Prepare(string fileName) 
            => string.IsNullOrEmpty(fileName) ? null : fileName.Trim().ToLower();
    }
}
