namespace EnglishPronunciator
{
    partial class Form1
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
            tabControl.SuspendLayout();
            tabPageMain.SuspendLayout();
            SuspendLayout();
            // 
            // buttonPronounce
            // 
            buttonPronounce.Location = new Point(145, 107);
            buttonPronounce.Name = "buttonPronounce";
            buttonPronounce.Size = new Size(94, 29);
            buttonPronounce.TabIndex = 0;
            buttonPronounce.Text = "Pronounce";
            buttonPronounce.UseVisualStyleBackColor = true;
            buttonPronounce.Click += buttonPronounce_Click;
            // 
            // textBoxWord
            // 
            textBoxWord.Location = new Point(145, 59);
            textBoxWord.Name = "textBoxWord";
            textBoxWord.Size = new Size(160, 27);
            textBoxWord.TabIndex = 1;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPageMain);
            tabControl.Controls.Add(tabPageSettings);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(777, 620);
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
            tabPageMain.Size = new Size(769, 587);
            tabPageMain.TabIndex = 0;
            tabPageMain.Text = "Main";
            // 
            // tabPageSettings
            // 
            tabPageSettings.BackColor = Color.Gray;
            tabPageSettings.Location = new Point(4, 29);
            tabPageSettings.Name = "tabPageSettings";
            tabPageSettings.Padding = new Padding(3);
            tabPageSettings.Size = new Size(769, 587);
            tabPageSettings.TabIndex = 1;
            tabPageSettings.Text = "Settings";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(777, 620);
            Controls.Add(tabControl);
            Name = "Form1";
            Text = "Form1";
            tabControl.ResumeLayout(false);
            tabPageMain.ResumeLayout(false);
            tabPageMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonPronounce;
        private TextBox textBoxWord;
        private TabControl tabControl;
        private TabPage tabPageMain;
        private TabPage tabPageSettings;
    }
}
