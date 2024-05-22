namespace EnglishPronunciator.Services
{
    public class InputWordService
    {
        private readonly TextBox _textBox;

        public string Text => _textBox.Text;

        public InputWordService(TextBox textBox)
        {
            _textBox = textBox;
        }
    }
}
