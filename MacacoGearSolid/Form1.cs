using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MacacoGearSolid
{
    public partial class Form1 : Form
    {
        bool goLeft, goRight, goUp, goDown, isGameOver;

        int score;
        int playerSpeed = 7;

        int enemySPeed = 5;

        public Form1()
        {
            InitializeComponent();
        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {

        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    goLeft = true;
                    break;
                case Keys.Right:
                    goRight = true;
                    break;
                case Keys.Up:
                    goUp = true;
                    break;
                case Keys.Down:
                    goDown = true;
                    break;

            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {

        }

        private void RestartGame()
        {
            // Reset state of player
            goDown = false;
            goLeft = false;
            goUp = false;
            goRight = false;
            score = 0;
            isGameOver = false;

            txtScore.Text = "Score: " + score;

            // Reset visibility of entities
            foreach(Control c in this.Controls)
            {
                if (c is PictureBox && c.Visible == false)
                {
                    c.Visible = true;
                }
            }

            // Reset player and enemies position
            player.Left = 560;
            player.Top = 86;

            foe1.Left = 570;
            foe1.Top = 280;

            foe2.Left = 210;
            foe2.Top = 160;

            foe3.Left = 740;
            foe3.Top = 310;


            gameTimer.Start();

        }
    }
}
