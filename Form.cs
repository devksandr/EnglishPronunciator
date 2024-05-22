using EnglishPronunciator.Panels;
using EnglishPronunciator.Services;

namespace EnglishPronunciator
{
    public partial class FormMain : Form
    {
        private readonly MainPanel _mainPanel;
        private readonly SettingsPanel _settingsPanel;

        private readonly SettingsService _settingsService;

        public FormMain()
        {
            InitializeComponent();

            _settingsService = new SettingsService();

            _mainPanel = new MainPanel(_settingsService, buttonPronounce, textBoxWord);
            _settingsPanel = new SettingsPanel(_settingsService);
        }
    }
}
