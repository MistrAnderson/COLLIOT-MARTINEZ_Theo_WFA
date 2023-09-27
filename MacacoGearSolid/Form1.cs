using MacacoGearSolid.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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

        int foe1SpeedHoriz = 2;
        int foe1SpeedVert = 0;

        int foe2SpeedHoriz = 0;
        int foe2SpeedVert = 2;

        public Form1()
        {
            InitializeComponent();

            // Set player and enemies position
            player.Left = 86;
            player.Top = 400;

            foe1.Left = 430;
            foe1.Top = 250;

            foe2.Left = 160;
            foe2.Top = 150;

            foe3.Left = 570;
            foe3.Top = 280;
        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            txtScore.Text = "Score: " + score;

            // Inputs for Player mouvement
            if (goLeft) { player.Left -= playerSpeed; }
            if (goRight) { player.Left += playerSpeed; }
            if (goUp) { player.Top -= playerSpeed; }
            if (goDown) { player.Top += playerSpeed; }


            // Loop through all controls, check if they have the tag 'platforme'
            // then test if their bounds intersect with the player.
            // If they do, depending on the direction of the player's movement,
            // snap the player to the edge of the platform.
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
                                player.Left = x.Right;
                                goLeft = false;
                            }
                            else if (goRight && player.Left <= x.Left && player.Right >= x.Left)
                            {
                                // Prevent moving right if collision on the right side
                                player.Left = x.Left - player.Width;
                                goRight = false;
                            }
                            else if (goUp && player.Top <= x.Bottom && player.Bottom >= x.Bottom)
                            {
                                // Prevent moving up if collision on the top side
                                player.Top = x.Bottom;
                                goUp = false;
                            }
                            else if (goDown && player.Bottom >= x.Top && player.Top >= x.Top)
                            {
                                // Prevent moving down if collision on the bottom side
                                player.Top = x.Top - player.Height;
                                goDown = false;
                            }
                        }
                    }

                    // Set visibility of coins to false and add 1 to score if player Intersects with
                    // a visible coin
                    if ((string)x.Tag == "coin")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds) && x.Visible)
                        {
                            x.Visible = false;
                            score++;
                        }
                    }

                    if ((string)x.Tag == "enemy")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds))
                        {
                            gameTimer.Stop();
                            isGameOver = true;
                            txtScore.Text = "Score: " + score + Environment.NewLine + "GAME OVER";
                        }
                    }

                    if ((string)x.Name == "exit")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds))
                        {
                            gameTimer.Stop();
                            isGameOver = true;
                            txtScore.Text = "Score: " + score + Environment.NewLine + "YOU ESCAPED";
                        }
                    }

                    // Hides the path the enemies follow
                    if((string)x.Tag == "path")
                    {
                        x.Visible = false;
                    }
                }
            }
            foe1.mouvement();
            pathHandler(foe1, foe1PathVert, foe1PathHoriz);

            foe2.mouvement();
            pathHandler(foe2, foe2PathVert, foe2PathHoriz);

            foe3.mouvement();
            pathHandler(foe3, foe3PathVert, foe3PathHoriz);

            foe4.mouvement();
            pathHandler(foe4, foe4PathVert, foe4PathHoriz);

            foe5.mouvement();
            pathHandler(foe5, foe5PathVert, foe5PathHoriz);

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
            foreach (Control c in this.Controls)
            {
                if (c is PictureBox && c.Visible == false)
                {
                    c.Visible = true;
                }
            }

            // Reset player and enemies position
            player.Left = 86;
            player.Top = 400;

            foe1.Left = 430;
            foe1.Top = 250;

            foe2.Left = 160;
            foe2.Top = 150;

            foe3.Left = 570;
            foe3.Top = 280;

            gameTimer.Start();
        }

        private void pathHandler(Enemy foe, PictureBox vertPath, PictureBox horizPath)
        {
            if (foe.Top < vertPath.Top || foe.Bottom > vertPath.Bottom)
            {
                // Snap the foe to the closest end of his path
                if (vertPath.Top - foe.Top > 0)
                {
                    foe.Top = vertPath.Top + 1;
                }
                else
                {
                    foe.Top = vertPath.Bottom - foe.Height - 1;
                }
                //int r = new Random().Next(0,2);
                //Debug.WriteLine($"Random number is {r}");
                switch (new Random().Next(0, 2))
                {
                    case 0:
                        foe.vertSpeed *= -1;
                        break;
                    case 1:
                        foe.vertSpeed = 0;
                        foe.horizSpeed = 2;
                        break;

                }
            }

            if (foe.Left < horizPath.Left || foe.Right > horizPath.Right)
            {
                // Snap the foe to the closest end of his path
                if (horizPath.Left - foe.Left > 0)
                {
                    foe.Left = horizPath.Left + 1;
                }
                else
                {
                    foe.Left = horizPath.Right - foe.Width - 1;
                }

                //int r = new Random().Next(0,2);
                //Debug.WriteLine($"Random number is {r}");
                switch (new Random().Next(0, 2))
                {
                    case 0:
                        foe.horizSpeed *= -1;
                        break;
                    case 1:
                        foe.vertSpeed = 2;
                        foe.horizSpeed = 0;
                        break;

                }
            }
        }
    }
}
