using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        int playerSpeed = 5;

        int enemySPeed = 5;

        public Form1()
        {
            InitializeComponent();
        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            txtScore.Text = "Score: " + score;

            // Inputs for Player mouvement
            if (goLeft) { player.Left -= playerSpeed; }
            if (goRight) { player.Left += playerSpeed; }
            if (goUp) { player.Top -= playerSpeed; }
            if (goDown) { player.Top += playerSpeed; }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    if ((string)x.Tag == "plateforme")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds))
                        {
                            // Collision detected, prevent player movement in the direction of the collision
                            if (goLeft && player.Right >= x.Right && player.Left <= x.Right)
                            {
                                // Prevent moving left if collision on the left side
                                Debug.WriteLine("Can't go left");
                                Debug.WriteLine($"{player.Left} < {x.Right}");
                                player.Left = x.Right;
                                goLeft = false;
                                // TODO TP player to wall
                            }
                            else if (goRight && player.Left <= x.Left && player.Right >= x.Left)
                            {
                                // Prevent moving right if collision on the right side
                                Debug.WriteLine("ruef");
                                player.Left = x.Left - player.Width;
                                goRight = false;
                            }
                            else if (goUp && player.Top <= x.Bottom && player.Bottom >= x.Bottom)
                            {
                                // Prevent moving up if collision on the top side
                                Debug.WriteLine("HAHA");
                                player.Top = x.Bottom;
                                goUp = false;
                            }
                            else if (goDown && player.Bottom >= x.Top && player.Top >= x.Top)
                            {
                                // Prevent moving down if collision on the bottom side
                                Debug.WriteLine("AHAH");
                                player.Top = x.Top - player.Height;
                                goDown = false;
                            }
                        }
                    }
                }
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {

            // Save the current position of the player
            int playerX = player.Left;
            int playerY = player.Top;

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
            switch (e.KeyCode)
            {
                case Keys.Left:
                    goLeft = false;
                    break;
                case Keys.Right:
                    goRight = false;
                    break;
                case Keys.Up:
                    goUp = false;
                    break;
                case Keys.Down:
                    goDown = false;
                    break;
            }

            if (e.KeyCode == Keys.Enter && isGameOver)
            {
                RestartGame();
            }
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
