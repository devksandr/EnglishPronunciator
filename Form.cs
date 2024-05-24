using EnglishPronunciator.Models;
using EnglishPronunciator.Panels;
using EnglishPronunciator.Services;
using EnglishPronunciator.Services.Settings;

namespace EnglishPronunciator
{
    public partial class FormMain : Form
    {
        private readonly MainPanel _mainPanel;
        private readonly SettingsPanel _settingsPanel;

        private readonly ExecuteCombinationService _executeCombinationService;
        private readonly TrayService _trayService;

        private readonly SettingsService _settingsService;
        private readonly SettingsParamsService _settingsParamsService;

        public FormMain()
        {
            InitializeComponent();

            var settingsFileModel = new SettingsFileModel();
            _settingsParamsService = new SettingsParamsService(settingsFileModel);
            _settingsService = new SettingsService(_settingsParamsService, settingsFileModel);

            var executeCombinationModel = new ExecuteCombinationModel(checkBoxCtrl, checkBoxShift, checkBoxAlt, textBoxLetter);
            _executeCombinationService = new ExecuteCombinationService(executeCombinationModel, _settingsParamsService);
            _trayService = new TrayService(exitToolStripMenuItemTray, notifyIconTray, this);

            _mainPanel = new MainPanel(_settingsParamsService, _executeCombinationService, buttonPronounce, textBoxWord);
            _settingsPanel = new SettingsPanel(_settingsService, _executeCombinationService);
        }
    }
}
