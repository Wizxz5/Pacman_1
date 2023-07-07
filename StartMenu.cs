using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pacman_1
{
    public partial class StartMenu : Form
    {
        public StartMenu()
        {
            InitializeComponent();
        }

        private void StartMenu_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void LoadGame(object sender, EventArgs e)
        {
            PacmanGame gameWindow = new PacmanGame();

            gameWindow.Show();
        }

        private void LoadSetting(object sender, EventArgs e)
        {
           Settingform settingWindow = new Settingform();

           settingWindow.Show();
        }

        private void LoadHelp(object sender, EventArgs e)
        {
            HelpScreen helpWindow = new HelpScreen();

            helpWindow.Show();
        }
    }
}
