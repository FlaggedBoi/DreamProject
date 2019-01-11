using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace TheGame
{
    public partial class MainForm : Form
    {
        bool GameIsActive;

        public MainForm()
        {
            InitializeComponent();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = GamePage;
            GameIsActive = true;
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = SettingsPage;
        }

        private void BackFromSettings_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = MenuPage;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_KeyDown(object Sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (tabControl1.SelectedTab != null)
                {
                    tabControl1.SelectedTab = MenuPage;
                }

                if (tabControl1.SelectedTab == MenuPage && GameIsActive == true) {
                    tabControl1.SelectedTab = GamePage;
                }
            }
        }
    }
}