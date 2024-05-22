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
            buttonPronounce = new Button();
            textBoxWord = new TextBox();
            tabControl = new TabControl();
            tabPageMain = new TabPage();
            tabPageSettings = new TabPage();
            panelTabControlWrapper = new Panel();
            tabControl.SuspendLayout();
            tabPageMain.SuspendLayout();
            panelTabControlWrapper.SuspendLayout();
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
            tabControl.Size = new Size(498, 315);
            tabControl.TabIndex = 2;
            // 
            // tabPageMain
            // 
            tabPageMain.BackColor = Color.Gray;
            tabPageMain.Controls.Add(textBoxWord);
            tabPageMain.Controls.Add(buttonPronounce);
            tabPageMain.Location = new Point(4, 29);
            tabPageMain.Name = "tabPageMain";
            tabPageMain.Padding = new Padding(3);
            tabPageMain.Size = new Size(490, 282);
            tabPageMain.TabIndex = 0;
            tabPageMain.Text = "Main";
            // 
            // tabPageSettings
            // 
            tabPageSettings.BackColor = Color.Gray;
            tabPageSettings.Location = new Point(4, 29);
            tabPageSettings.Name = "tabPageSettings";
            tabPageSettings.Padding = new Padding(3);
            tabPageSettings.Size = new Size(490, 282);
            tabPageSettings.TabIndex = 1;
            tabPageSettings.Text = "Settings";
            // 
            // panelTabControlWrapper
            // 
            panelTabControlWrapper.BackColor = SystemColors.ActiveBorder;
            panelTabControlWrapper.Controls.Add(tabControl);
            panelTabControlWrapper.Dock = DockStyle.Fill;
            panelTabControlWrapper.Location = new Point(0, 0);
            panelTabControlWrapper.Name = "panelTabControlWrapper";
            panelTabControlWrapper.Size = new Size(482, 308);
            panelTabControlWrapper.TabIndex = 3;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(482, 308);
            Controls.Add(panelTabControlWrapper);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "English Pronunciator";
            tabControl.ResumeLayout(false);
            tabPageMain.ResumeLayout(false);
            tabPageMain.PerformLayout();
            panelTabControlWrapper.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button buttonPronounce;
        private TextBox textBoxWord;
        private TabControl tabControl;
        private TabPage tabPageMain;
        private TabPage tabPageSettings;
        private Panel panelTabControlWrapper;
    }
}
