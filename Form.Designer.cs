namespace EnglishPronunciator
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            buttonPronounce = new Button();
            textBoxWord = new TextBox();
            tabControl = new TabControl();
            tabPageMain = new TabPage();
            tabPageSettings = new TabPage();
            panelExecuteCombination = new Panel();
            checkBoxCtrl = new CheckBox();
            label2 = new Label();
            checkBoxShift = new CheckBox();
            checkBoxAlt = new CheckBox();
            label1 = new Label();
            textBoxLetter = new TextBox();
            panelTabControlWrapper = new Panel();
            contextMenuStripTray = new ContextMenuStrip(components);
            exitToolStripMenuItemTray = new ToolStripMenuItem();
            notifyIconTray = new NotifyIcon(components);
            tabControl.SuspendLayout();
            tabPageMain.SuspendLayout();
            tabPageSettings.SuspendLayout();
            panelExecuteCombination.SuspendLayout();
            panelTabControlWrapper.SuspendLayout();
            contextMenuStripTray.SuspendLayout();
            SuspendLayout();
            // 
            // buttonPronounce
            // 
            buttonPronounce.Location = new Point(376, 36);
            buttonPronounce.Name = "buttonPronounce";
            buttonPronounce.Size = new Size(94, 32);
            buttonPronounce.TabIndex = 0;
            buttonPronounce.Text = "Pronounce";
            buttonPronounce.UseVisualStyleBackColor = true;
            // 
            // textBoxWord
            // 
            textBoxWord.Location = new Point(10, 36);
            textBoxWord.Margin = new Padding(10);
            textBoxWord.MinimumSize = new Size(0, 30);
            textBoxWord.Name = "textBoxWord";
            textBoxWord.Size = new Size(353, 30);
            textBoxWord.TabIndex = 1;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPageMain);
            tabControl.Controls.Add(tabPageSettings);
            tabControl.Location = new Point(-4, 2);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(498, 156);
            tabControl.TabIndex = 2;
            // 
            // tabPageMain
            // 
            tabPageMain.BackColor = Color.Transparent;
            tabPageMain.Controls.Add(textBoxWord);
            tabPageMain.Controls.Add(buttonPronounce);
            tabPageMain.Location = new Point(4, 29);
            tabPageMain.Name = "tabPageMain";
            tabPageMain.Padding = new Padding(3);
            tabPageMain.Size = new Size(490, 123);
            tabPageMain.TabIndex = 0;
            tabPageMain.Text = "Main";
            // 
            // tabPageSettings
            // 
            tabPageSettings.BackColor = Color.Transparent;
            tabPageSettings.Controls.Add(panelExecuteCombination);
            tabPageSettings.Location = new Point(4, 29);
            tabPageSettings.Name = "tabPageSettings";
            tabPageSettings.Padding = new Padding(3);
            tabPageSettings.Size = new Size(490, 123);
            tabPageSettings.TabIndex = 1;
            tabPageSettings.Text = "Settings";
            // 
            // panelExecuteCombination
            // 
            panelExecuteCombination.BorderStyle = BorderStyle.FixedSingle;
            panelExecuteCombination.Controls.Add(checkBoxCtrl);
            panelExecuteCombination.Controls.Add(label2);
            panelExecuteCombination.Controls.Add(checkBoxShift);
            panelExecuteCombination.Controls.Add(checkBoxAlt);
            panelExecuteCombination.Controls.Add(label1);
            panelExecuteCombination.Controls.Add(textBoxLetter);
            panelExecuteCombination.Location = new Point(12, 9);
            panelExecuteCombination.Name = "panelExecuteCombination";
            panelExecuteCombination.Size = new Size(458, 76);
            panelExecuteCombination.TabIndex = 7;
            // 
            // checkBoxCtrl
            // 
            checkBoxCtrl.AutoSize = true;
            checkBoxCtrl.Location = new Point(81, 39);
            checkBoxCtrl.Name = "checkBoxCtrl";
            checkBoxCtrl.Size = new Size(54, 24);
            checkBoxCtrl.TabIndex = 0;
            checkBoxCtrl.Text = "Ctrl";
            checkBoxCtrl.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(167, 8);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 5;
            label2.Text = "Pronounce hotkey";
            // 
            // checkBoxShift
            // 
            checkBoxShift.AutoSize = true;
            checkBoxShift.Location = new Point(139, 39);
            checkBoxShift.Name = "checkBoxShift";
            checkBoxShift.Size = new Size(61, 24);
            checkBoxShift.TabIndex = 1;
            checkBoxShift.Text = "Shift";
            checkBoxShift.UseVisualStyleBackColor = true;
            // 
            // checkBoxAlt
            // 
            checkBoxAlt.AutoSize = true;
            checkBoxAlt.Location = new Point(206, 39);
            checkBoxAlt.Name = "checkBoxAlt";
            checkBoxAlt.Size = new Size(50, 24);
            checkBoxAlt.TabIndex = 2;
            checkBoxAlt.Text = "Alt";
            checkBoxAlt.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(274, 39);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 4;
            label1.Text = "Letter:";
            // 
            // textBoxLetter
            // 
            textBoxLetter.Location = new Point(330, 36);
            textBoxLetter.MaxLength = 1;
            textBoxLetter.Name = "textBoxLetter";
            textBoxLetter.ReadOnly = true;
            textBoxLetter.Size = new Size(33, 27);
            textBoxLetter.TabIndex = 3;
            // 
            // panelTabControlWrapper
            // 
            panelTabControlWrapper.BackColor = SystemColors.Control;
            panelTabControlWrapper.Controls.Add(tabControl);
            panelTabControlWrapper.Dock = DockStyle.Fill;
            panelTabControlWrapper.Location = new Point(0, 0);
            panelTabControlWrapper.Name = "panelTabControlWrapper";
            panelTabControlWrapper.Size = new Size(482, 119);
            panelTabControlWrapper.TabIndex = 3;
            // 
            // contextMenuStripTray
            // 
            contextMenuStripTray.ImageScalingSize = new Size(20, 20);
            contextMenuStripTray.Items.AddRange(new ToolStripItem[] { exitToolStripMenuItemTray });
            contextMenuStripTray.Name = "contextMenuStripTray";
            contextMenuStripTray.Size = new Size(103, 28);
            // 
            // exitToolStripMenuItemTray
            // 
            exitToolStripMenuItemTray.Name = "exitToolStripMenuItemTray";
            exitToolStripMenuItemTray.Size = new Size(102, 24);
            exitToolStripMenuItemTray.Text = "Exit";
            // 
            // notifyIconTray
            // 
            notifyIconTray.ContextMenuStrip = contextMenuStripTray;
            notifyIconTray.Icon = (Icon)resources.GetObject("notifyIconTray.Icon");
            notifyIconTray.Text = "English Pronunciator";
            notifyIconTray.Visible = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(482, 119);
            Controls.Add(panelTabControlWrapper);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "English Pronunciator";
            tabControl.ResumeLayout(false);
            tabPageMain.ResumeLayout(false);
            tabPageMain.PerformLayout();
            tabPageSettings.ResumeLayout(false);
            panelExecuteCombination.ResumeLayout(false);
            panelExecuteCombination.PerformLayout();
            panelTabControlWrapper.ResumeLayout(false);
            contextMenuStripTray.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button buttonPronounce;
        private TextBox textBoxWord;
        private TabControl tabControl;
        private TabPage tabPageMain;
        private TabPage tabPageSettings;
        private Panel panelTabControlWrapper;
        private ContextMenuStrip contextMenuStripTray;
        private ToolStripMenuItem exitToolStripMenuItemTray;
        private NotifyIcon notifyIconTray;
        private CheckBox checkBoxShift;
        private CheckBox checkBoxCtrl;
        private Panel panelExecuteCombination;
        private Label label2;
        private CheckBox checkBoxAlt;
        private Label label1;
        private TextBox textBoxLetter;
    }
}
