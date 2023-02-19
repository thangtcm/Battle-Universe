using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neon_Blaster
{
    internal class Enemy
    {
        private int speed = 5, getSizeForm;
        public int maxHealth = new Random().Next(1,10);
        private PictureBox enemyAI = new PictureBox();
        private Timer enemyAITimer = new Timer();
        Random rd = new Random();
        String path = "Image\\Enemy\\";
        public void MakeenemyAI(Form form)
        {
            enemyAI.Image = Image.FromFile(path + $"Spaceship_tut.png");
            enemyAI.Tag = "enemy";
            enemyAI.Size = new Size(100, 100);
            enemyAI.Top = 50;
            getSizeForm = form.ClientSize.Width;
            enemyAI.Left = rd.Next(0, getSizeForm - 100);
            enemyAI.BackColor = Color.Transparent;
            enemyAI.ForeColor = Color.Transparent;
            enemyAI.SizeMode = PictureBoxSizeMode.Zoom;
            enemyAI.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
            enemyAI.BringToFront();
            form.Controls.Add(enemyAI);


            enemyAITimer.Interval = 20;
            enemyAITimer.Tick += new EventHandler(enemyAITimerEvent);
            enemyAITimer.Start();

        }

        private void enemyAITimerEvent(object sender, EventArgs e)
        {
            enemyAI.Left -= speed;
            if (enemyAI.Left < 0 || enemyAI.Left + enemyAI.Width > getSizeForm)
                speed *= -1;
        }
    }
}
