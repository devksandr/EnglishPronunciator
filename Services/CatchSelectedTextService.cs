using Gma.System.MouseKeyHook;

namespace EnglishPronunciator.Services
{
    public class CatchSelectedTextService
    {
        private IKeyboardMouseEvents _globalMouseHook;

        private readonly SettingsService _settingsService;

        public event EventHandler<string>? HotKeyPressed;

        public CatchSelectedTextService(SettingsService settingsService)
        {
            _settingsService = settingsService;

            _globalMouseHook = Hook.GlobalEvents();
            Hook.GlobalEvents().OnCombination(new Dictionary<Combination, Action>
            {
                {Combination.FromString(_settingsService.ExecuteCombination), GetSelectedText},
            });
        }

        private async void GetSelectedText()
        {
            var tmpClipboard = Clipboard.GetDataObject();
            Clipboard.Clear();

            await Task.Delay(50);
            SendKeys.SendWait("^c");
            await Task.Delay(50);

            string text = Clipboard.GetText();

            if(tmpClipboard != null)
            {
                Clipboard.SetDataObject(tmpClipboard);
            }

            HotKeyPressed?.Invoke(this, text);
        }
    }
}
