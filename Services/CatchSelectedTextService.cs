using Gma.System.MouseKeyHook;

namespace EnglishPronunciator.Services
{
    public class CatchSelectedTextService
    {
        private const int COPY_DELAY_MILLISECONDS = 50;
        private const string COPY_COMMAND = "^c";

        private IKeyboardMouseEvents? _globalMouseHook;

        private readonly ExecuteCombinationService _executeCombinationService;

        public event EventHandler<string>? HotKeyPressed;

        public CatchSelectedTextService(ExecuteCombinationService executeCombinationService)
        {
            _executeCombinationService = executeCombinationService;
            
            UpdateHotKey(_executeCombinationService.Combination);
            _executeCombinationService.HotkeyChanged += executeCombinationService_HotkeyChanged;
        }

        private void executeCombinationService_HotkeyChanged(object? sender, string e)
        {
            UpdateHotKey(e);
        }

        public void UpdateHotKey(string hotKey)
        {
            _globalMouseHook = Hook.GlobalEvents();
            _globalMouseHook.OnCombination(new Dictionary<Combination, Action>
            {
                {Combination.FromString(hotKey), GetSelectedText},
            });
        }

        private async void GetSelectedText()
        {
            var tmpClipboard = Clipboard.GetDataObject();
            Clipboard.Clear();

            await Task.Delay(COPY_DELAY_MILLISECONDS);
            SendKeys.SendWait(COPY_COMMAND);
            await Task.Delay(COPY_DELAY_MILLISECONDS);

            string text = Clipboard.GetText();

            if(tmpClipboard != null)
            {
                Clipboard.SetDataObject(tmpClipboard);
            }

            HotKeyPressed?.Invoke(this, text);
        }
    }
}
