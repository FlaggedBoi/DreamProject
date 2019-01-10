namespace TheGame
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.GameView = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.MenuPage = new System.Windows.Forms.TabPage();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.PlayButton = new System.Windows.Forms.Button();
            this.SettingsPage = new System.Windows.Forms.TabPage();
            this.BackFromSettings = new System.Windows.Forms.Button();
            this.SettingsMusicOn = new System.Windows.Forms.CheckBox();
            this.GamePage = new System.Windows.Forms.TabPage();
            this.BackFromGame = new System.Windows.Forms.Button();
            this.ExitPage = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.GameView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.MenuPage.SuspendLayout();
            this.SettingsPage.SuspendLayout();
            this.GamePage.SuspendLayout();
            this.SuspendLayout();
            // 
            // GameView
            // 
            this.GameView.Location = new System.Drawing.Point(0, 0);
            this.GameView.Name = "GameView";
            this.GameView.Size = new System.Drawing.Size(640, 480);
            this.GameView.TabIndex = 0;
            this.GameView.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.MenuPage);
            this.tabControl1.Controls.Add(this.SettingsPage);
            this.tabControl1.Controls.Add(this.GamePage);
            this.tabControl1.Controls.Add(this.ExitPage);
            this.tabControl1.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(640, 480);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 1;
            // 
            // MenuPage
            // 
            this.MenuPage.Controls.Add(this.ExitButton);
            this.MenuPage.Controls.Add(this.SettingsButton);
            this.MenuPage.Controls.Add(this.PlayButton);
            this.MenuPage.Location = new System.Drawing.Point(4, 5);
            this.MenuPage.Name = "MenuPage";
            this.MenuPage.Padding = new System.Windows.Forms.Padding(3);
            this.MenuPage.Size = new System.Drawing.Size(632, 471);
            this.MenuPage.TabIndex = 0;
            this.MenuPage.Text = "MenuPage";
            this.MenuPage.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(175, 241);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(255, 42);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Location = new System.Drawing.Point(175, 178);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(255, 42);
            this.SettingsButton.TabIndex = 0;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.Location = new System.Drawing.Point(175, 113);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(255, 42);
            this.PlayButton.TabIndex = 0;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // SettingsPage
            // 
            this.SettingsPage.Controls.Add(this.BackFromSettings);
            this.SettingsPage.Controls.Add(this.SettingsMusicOn);
            this.SettingsPage.Location = new System.Drawing.Point(4, 5);
            this.SettingsPage.Name = "SettingsPage";
            this.SettingsPage.Size = new System.Drawing.Size(632, 471);
            this.SettingsPage.TabIndex = 3;
            this.SettingsPage.Text = "SettingsPage";
            this.SettingsPage.UseVisualStyleBackColor = true;
            // 
            // BackFromSettings
            // 
            this.BackFromSettings.Location = new System.Drawing.Point(211, 189);
            this.BackFromSettings.Name = "BackFromSettings";
            this.BackFromSettings.Size = new System.Drawing.Size(154, 48);
            this.BackFromSettings.TabIndex = 1;
            this.BackFromSettings.Text = "Back";
            this.BackFromSettings.UseVisualStyleBackColor = true;
            this.BackFromSettings.Click += new System.EventHandler(this.BackFromSettings_Click);
            // 
            // SettingsMusicOn
            // 
            this.SettingsMusicOn.AutoSize = true;
            this.SettingsMusicOn.Location = new System.Drawing.Point(73, 46);
            this.SettingsMusicOn.Name = "SettingsMusicOn";
            this.SettingsMusicOn.Size = new System.Drawing.Size(102, 17);
            this.SettingsMusicOn.TabIndex = 0;
            this.SettingsMusicOn.Text = "Example Setting";
            this.SettingsMusicOn.UseVisualStyleBackColor = true;
            // 
            // GamePage
            // 
            this.GamePage.Controls.Add(this.BackFromGame);
            this.GamePage.Location = new System.Drawing.Point(4, 5);
            this.GamePage.Name = "GamePage";
            this.GamePage.Padding = new System.Windows.Forms.Padding(3);
            this.GamePage.Size = new System.Drawing.Size(632, 471);
            this.GamePage.TabIndex = 1;
            this.GamePage.Text = "GamePage";
            this.GamePage.UseVisualStyleBackColor = true;
            // 
            // BackFromGame
            // 
            this.BackFromGame.Location = new System.Drawing.Point(228, 430);
            this.BackFromGame.Name = "BackFromGame";
            this.BackFromGame.Size = new System.Drawing.Size(146, 33);
            this.BackFromGame.TabIndex = 0;
            this.BackFromGame.Text = "Back to menu";
            this.BackFromGame.Click += new System.EventHandler(this.BackFromGame_Click);
            // 
            // ExitPage
            // 
            this.ExitPage.Location = new System.Drawing.Point(4, 5);
            this.ExitPage.Name = "ExitPage";
            this.ExitPage.Size = new System.Drawing.Size(632, 471);
            this.ExitPage.TabIndex = 2;
            this.ExitPage.Text = "ExitPage";
            this.ExitPage.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.GameView);
            this.Name = "MainForm";
            this.Text = "DreamProject";
            ((System.ComponentModel.ISupportInitialize)(this.GameView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.MenuPage.ResumeLayout(false);
            this.SettingsPage.ResumeLayout(false);
            this.SettingsPage.PerformLayout();
            this.GamePage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox GameView;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage MenuPage;
        private System.Windows.Forms.TabPage GamePage;
        private System.Windows.Forms.TabPage ExitPage;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.TabPage SettingsPage;
        private System.Windows.Forms.Button BackFromSettings;
        private System.Windows.Forms.CheckBox SettingsMusicOn;
        private System.Windows.Forms.Button BackFromGame;
    }
}

