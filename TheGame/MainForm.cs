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
        public MainForm()
        {
            InitializeComponent();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = GamePage;
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

        private void BackFromGame_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = MenuPage;
        }
    }
}