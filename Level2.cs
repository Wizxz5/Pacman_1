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
    public partial class Level2 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  
        public Level2()
        {
            InitializeComponent();
            player.SoundLocation = ''
        }

        private void Level2_Load(object sender, EventArgs e)
        {
            bool goup, godown, goleft, goright, isGameOver;
            int score, playerSpeed, Ghost3speed, Ghost2speed, GhostX, GhostY;
        }



        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void keyisdown(object sender, KeyEventArgs e)
        {

        }

        private void keyisup(object sender, KeyPressEventArgs e)
        {

        }

        ///function set graphic & Game timer
        private void MainGameTimer(object sender, EventArgs e)
        {

        }
        ///function reset game conditions
        private void resetGame()
        {

        }
        private void gameisOver()
        {

        }

    }
}
