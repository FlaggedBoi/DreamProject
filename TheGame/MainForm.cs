using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheGame
{
    public partial class MainForm : Form
    {
        bool GameIsActive; // Для реализации паузы (нужна ли она?)

        public MainForm()
        {
            InitializeComponent();
        }

        private void PlayButton_Click(object sender, EventArgs e) // Меню — кнопка перехода к игре
        {
            tabControl1.SelectedTab = GamePage;
            GameIsActive = true;
        }

        private void SettingsButton_Click(object sender, EventArgs e) // Меню — кнопка перехода в настройки
        {
            tabControl1.SelectedTab = SettingsPage;
        }

        private void BackFromSettings_Click(object sender, EventArgs e) // Настройки — кнопка возврата в меню
        {
            tabControl1.SelectedTab = MenuPage;
        }

        private void ExitButton_Click(object sender, EventArgs e) // Меню — кнопка выхода
        {
            Close();
        }

        private void MainForm_KeyDown(object Sender, KeyEventArgs e) // Пауза и возврат в игру на ESC
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (tabControl1.SelectedTab == GamePage)
                {
                    tabControl1.SelectedTab = MenuPage;
                } else if (tabControl1.SelectedTab == MenuPage && GameIsActive == true) {
                    tabControl1.SelectedTab = GamePage;
                }
            }

            switch (e.KeyCode)
            {
                case Keys.W:
                    Player.Top -= 3;
                    break;
                case Keys.A:
                    Player.Left -= 3;
                    break;
                case Keys.S:
                    Player.Top += 3;
                    break;
                case Keys.D:
                    Player.Left += 3;
                    break;
            }
        }

        private void Player_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            this.KeyDown += MainForm_KeyDown;
        }

        private void GamePage_Enter(object sender, EventArgs e)
        {
            Console.WriteLine("GamePage Enter");
            this.ActiveControl = Player;
        }
    }
}