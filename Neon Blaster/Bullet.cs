using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neon_Blaster
{
    internal class Bullet
    {
        public int bulletLeft;
        public int bulletTop;
        private int bulletID;
        private int speed = 50, getHeightForm;
        private PictureBox bullet = new PictureBox();
        private Timer bulletTimer = new Timer();
        String path = "Image\\Laser Sprites\\";

        public void MakeBullet(Form form, bool player, int idBullet)
        {
            bulletID = idBullet;
            bullet.Size = new Size(50,50);
            bullet.SizeMode = PictureBoxSizeMode.StretchImage;
            bullet.Image = Image.FromFile(path + $"{bulletID}.png");
            if (player is true)
            {
                bullet.Tag = "bulletPlayer";
                bullet.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            }
            else
            {
                bullet.Tag = "bulletEnemy";
                bullet.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }

            bullet.Left = bulletLeft;
            bullet.Top = bulletTop; 
            bullet.Top = bulletTop; 
            bullet.BackColor = Color.Transparent; 
            bullet.ForeColor = Color.Transparent;
            getHeightForm = form.ClientSize.Height;
            bullet.BringToFront();
            form.Controls.Add(bullet);
            

            bulletTimer.Interval = 20;
            if(player)
                bulletTimer.Tick += new EventHandler(BulletPlayerTimerEvent);
            else
                bulletTimer.Tick += new EventHandler(BulletEnemyTimerEvent);
            bulletTimer.Start();

        }

        private void BulletPlayerTimerEvent(object sender, EventArgs e)
        {
            bullet.Top -= speed;
            if (bullet.Top < 65)
            {
                bulletTimer.Stop();
                bulletTimer.Dispose();
                bullet.Dispose();
                bulletTimer = null;
                bullet = null;
            }
        }

        private void BulletEnemyTimerEvent(object sender, EventArgs e)
        {
            bullet.Top += speed;
            if (bullet.Top > getHeightForm - 50)
            {
                bulletTimer.Stop();
                bulletTimer.Dispose();
                bullet.Dispose();
                bulletTimer = null;
                bullet = null;
            }
        }
    }
}
