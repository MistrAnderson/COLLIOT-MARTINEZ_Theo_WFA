using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MacacoGearSolid
{
    internal class Enemy : PictureBox
    {
        public Enemy() : base()
        {
            vertSpeed = 2;
            horizSpeed = 0;
            this.Width = 16;
            this.Height = 16;
            this.Tag = "enemy";
            this.BackColor = System.Drawing.Color.Red;
        }
        public int vertSpeed { get; set; }
        public int horizSpeed { get; set; }

        public void mouvement()
        {
            this.Top -= this.vertSpeed;
            this.Left -= this.horizSpeed;
        }
    }
}
