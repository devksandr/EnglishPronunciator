namespace EnglishPronunciator.Services
{
    public class TrayService
    {
        private readonly ToolStripMenuItem _exitMenu;
        private readonly NotifyIcon _notifyIcon;
        private readonly Form _mainForm;

        public TrayService(ToolStripMenuItem exitMenu, NotifyIcon notifyIcon, Form mainForm)
        {
            (_exitMenu, _notifyIcon, _mainForm) = (exitMenu, notifyIcon, mainForm);
            _exitMenu.Click += exitToolStripMenuItemTray_Click;
            _notifyIcon.MouseClick += notifyIconTray_MouseClick;
            _mainForm.FormClosing += FormMain_FormClosing;
        }

        private void exitToolStripMenuItemTray_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void notifyIconTray_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _mainForm.Show();
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                _mainForm.Hide();
            }
        }
    }
}
