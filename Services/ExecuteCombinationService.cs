using EnglishPronunciator.Models;
using EnglishPronunciator.Services.Settings;

namespace EnglishPronunciator.Services
{
    public class ExecuteCombinationService
    {
        private const char COMBINATION_SEPARATOR = '+';

        public event EventHandler<string>? HotkeyChanged;

        private readonly ExecuteCombinationModel _controls;
        private readonly SettingsParamsService _settingsParamsService;
        private readonly Dictionary<CheckBox, string> _checkBoxNames;

        public string Combination 
        { 
            get
            {
                var combinationControls = _checkBoxNames
                    .Where(cbp => cbp.Key.Checked)
                    .Select(cbp => cbp.Value)
                    .ToList();
                combinationControls.Add(_controls.LetterTextBox.Text);
                return string.Join(COMBINATION_SEPARATOR, combinationControls);
            }
        }

        public ExecuteCombinationService(
            ExecuteCombinationModel executeCombinationModel, 
            SettingsParamsService settingsParamsService)
        {
            _controls = executeCombinationModel;
            _settingsParamsService = settingsParamsService;

            _checkBoxNames = new Dictionary<CheckBox, string>
            {
                [_controls.CtrlCheckBox] = "Control",
                [_controls.ShiftCheckBox] = "Shift",
                [_controls.AltCheckBox] = "Alt",
            };

            InitializeControlValues();
            _controls.CtrlCheckBox.CheckedChanged += CtrlCheckBox_CheckedChanged;
            _controls.ShiftCheckBox.CheckedChanged += ShiftCheckBox_CheckedChanged;
            _controls.AltCheckBox.CheckedChanged += AltCheckBox_CheckedChanged;
            _controls.LetterTextBox.KeyPress += textBoxLetter_KeyPress;
        }

        private void InitializeControlValues()
        {
            var param = _settingsParamsService.Params;
            _controls.CtrlCheckBox.Checked = param.CtrlEnabled;
            _controls.ShiftCheckBox.Checked = param.ShiftEnabled;
            _controls.AltCheckBox.Checked = param.AltEnabled;
            _controls.LetterTextBox.Text = param.Letter.ToString();
        }

        private void CtrlCheckBox_CheckedChanged(object? sender, EventArgs e)
        {
            _settingsParamsService.Params.CtrlEnabled = _controls.CtrlCheckBox.Checked;
            HotkeyChanged?.Invoke(this, Combination);
        }
        private void ShiftCheckBox_CheckedChanged(object? sender, EventArgs e)
        {
            _settingsParamsService.Params.ShiftEnabled = _controls.ShiftCheckBox.Checked;
            HotkeyChanged?.Invoke(this, Combination);
        }
        private void AltCheckBox_CheckedChanged(object? sender, EventArgs e)
        {
            _settingsParamsService.Params.AltEnabled = _controls.AltCheckBox.Checked;
            HotkeyChanged?.Invoke(this, Combination);
        }

        private void textBoxLetter_KeyPress(object? sender, KeyPressEventArgs e)
        {
            char letter = e.KeyChar;
            if (char.IsLetter(letter))
            {
                char upperLetter = char.ToUpper(letter);
                _controls.LetterTextBox.Text = upperLetter.ToString();
                _settingsParamsService.Params.Letter = upperLetter;
                HotkeyChanged?.Invoke(this, Combination);
            }
        }
    }
}