using System.ComponentModel;

namespace EnglishPronunciator.Models
{
    public class SettingsFileModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private bool _ctrlEnabled;
        public bool CtrlEnabled { get => _ctrlEnabled; set => SetProperty(ref _ctrlEnabled, value); }

        private bool _shiftEnabled;
        public bool ShiftEnabled { get => _shiftEnabled; set => SetProperty(ref _shiftEnabled, value); }

        private bool _altEnabled;
        public bool AltEnabled { get => _altEnabled; set => SetProperty(ref _altEnabled, value); }

        private char _letter;
        public char Letter { get => _letter; set => SetProperty(ref _letter, value); }

        public SettingsFileModel()
        {
            SetDefault();
        }

        private void SetDefault()
        {
            CtrlEnabled = true;
            ShiftEnabled = false; 
            AltEnabled = false;
            Letter = 'Q';
        }

        private void SetProperty<T>(ref T propValue, T newValue)
        {
            if (!Equals(propValue, newValue))
            {
                propValue = newValue;
                OnPropertyChanged();
            }
        }

        private void OnPropertyChanged()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(string.Empty));
        }

        public void Update(SettingsFileModel newFile)
        {
            CtrlEnabled = newFile.CtrlEnabled;
            ShiftEnabled = newFile.ShiftEnabled;
            AltEnabled = newFile.AltEnabled;
            Letter = newFile.Letter;
        }
    }
}
