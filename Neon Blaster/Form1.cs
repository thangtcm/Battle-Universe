using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReadWriteIni;

namespace Neon_Blaster
{
    public partial class Form1 : Form
    {
        Random rd = new Random();
        DataIni fileini = new DataIni();
        int playerHealth = 100, score = 0, coin, speed = 10, timedeplay, 
            SpaceShipID = -1;

        bool goLeft, goRight, goUp, goDown, gameOver;
        int HPBoss;
        SoundPlayer fireSound = new SoundPlayer("Sounds\\Sounds_fire.wav");
        SoundPlayer getCoins = new SoundPlayer("Sounds\\GetCoins.wav");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
            SpaceShipID = int.Parse(fileini.READ("Data\\SpaceShip.ini", "ChooseSpaceShip", "ID"));
            RestartGame();
            
        }


        private void panelY_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panelY.ClientRectangle, Color.Red, ButtonBorderStyle.Solid);
            
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.ShowDialog();
            this.Close();
        }

        private void btnMenu_MouseHover(object sender, EventArgs e)
        {
            btnMenu.Load("Image\\Button\\MenuHover.png");
        }

        private void btnMenu_MouseLeave(object sender, EventArgs e)
        {
            btnMenu.Load("Image\\Button\\Menu.png");
        }

        private void btnPlayAgain_MouseHover(object sender, EventArgs e)
        {
            btnPlayAgain.Load("Image\\Button\\PlayAgainHover.png");
        }

        private void btnPlayAgain_MouseLeave(object sender, EventArgs e)
        {
            btnPlayAgain.Load("Image\\Button\\PlayAgain.png");
        }

        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            btnExit.Load("Image\\Button\\ExitHover.png");
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.Load("Image\\Button\\Exit.png");
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ShootBullet(player);
            fireSound.Play();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (gameOver == true)
            {
                return;
            }

            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                goLeft = true;
            }

            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                goRight = true;
            }

            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                goUp = true;
            }

            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                goDown = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                goLeft = false;
            }

            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                goRight = false;
            }

            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                goUp = false;
            }

            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                goDown = false;
            }

            if (e.KeyCode == Keys.Space && gameOver == false)
            {
                ShootBullet(player);
                fireSound.Play();
            }

            if (e.KeyCode == Keys.Enter & gameOver == true)
            {
                RestartGame();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void ShootBullet(Control x)
        {
            Bullet shootBullet = new Bullet();  
            shootBullet.bulletLeft = x.Left + 25;
            shootBullet.bulletTop = x.Top + (x.Height / 2);
            
            if((String)x.Tag == "enemy")
                shootBullet.MakeBullet(this, false, rd.Next(1,10));
            else
                shootBullet.MakeBullet(this, true, int.Parse(fileini.READ("Data\\Bullet.ini", "Bullet", "ID")));
        }

        private void RestartGame()
        {
            player.Image = null;
            player.Image = Image.FromFile($"Image\\SpaceShip\\{SpaceShipID}.png");
            player.BringToFront();
            pictureGameOver.Hide();
            btnMenu.Hide();
            btnExit.Hide();
            btnPlayAgain.Hide();
            player.Location = new Point(350, 530);
            goUp = false;
            goDown = false;
            goLeft = false;
            goRight = false;
            gameOver = false;
            playerHealth = 100;
            score = 0;
            coin = 0;
            speed = 10;


            player.BackColor =  Color.Transparent;
            barhpPlayer.ForeColor = Color.Red;
            barhpPlayer.Value = playerHealth;
            timedeplay = 0;
            player.BackColor = Color.Transparent;
            spawnEnemy();
            gameTimer.Start();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            textScore.Text = "Score : " + score;
            textCoin.Text = "Coin : " + coin;
            player.BackColor = Color.Transparent;

            if (goLeft == true && player.Left > 0)
            {
                player.Left -= speed;
            }
            if (goRight == true && player.Left + player.Width + 10 < this.ClientSize.Width)
            {
                player.Left += speed;
            }
            if (goUp == true && player.Top > 45)
            {
                player.Top -= speed;
            }
            if (goDown == true && (player.Top + player.Height + 20) < this.ClientSize.Height)
            {
                player.Top += speed;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "enemy")
                {
                    if(timedeplay == 25)
                    {
                        ShootBullet(x);
                        timedeplay = 0;
                    }
                    timedeplay++;
                }
                if (x is PictureBox && (string)x.Tag == "coin")
                {
                    if (x.Top + x.Height + 20 < this.ClientSize.Height)
                        x.Top += speed;
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                        coin += rd.Next(1,10);
                        getCoins.Play();
                    }
                }
                foreach (Control j in this.Controls)
                {
                    if (x is PictureBox && (String)x.Tag == "bulletPlayer" && j is PictureBox && (String)j.Tag == "enemy")
                    {
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            score++;
                            this.Controls.Remove(x);
                            ((PictureBox)x).Dispose();
                            
                            HPBoss--;
                            if (HPBoss == 0)
                            {
                                this.Controls.Remove(j);
                                ((PictureBox)j).Dispose();
                                DropCoin();
                                spawnEnemy();
                            }
                        }
                    }
                    if (x is PictureBox && (String)x.Tag == "bulletEnemy" && j is PictureBox && (String)j.Tag == "Player")
                    {
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            playerHealth-=10;
                            this.Controls.Remove(x);
                            ((PictureBox)x).Dispose();
                            if (playerHealth < 0)
                                playerHealth = 0;
                            barhpPlayer.Value = playerHealth;
                            if (playerHealth == 0)
                            {
                                gameOver = true;
                                desTroyEnemy();
                                gameTimer.Stop();
                                int coinOld = int.Parse(fileini.READ("Data\\Data.ini", "DataCoins", "Coins"));
                                fileini.WRITE("Data\\Data.ini", "DataCoins", "Coins", (coin + coinOld).ToString());
                                player.SendToBack();
                                pictureGameOver.Show();
                                btnMenu.Show();
                                btnExit.Show();
                                btnPlayAgain.Show();
                            }
                        }
                    }
                }
            }
        }

        private void DropCoin()
        {

            PictureBox coin = new PictureBox();
            coin.Image = Image.FromFile(@"D:\Game_Group2\Neon Blaster\Neon Blaster\bin\Debug\Image\coin.png");
            coin.Size = new Size(30, 30);
            coin.SizeMode = PictureBoxSizeMode.Zoom;
            coin.Left = rd.Next(10, this.ClientSize.Width - coin.Width);
            coin.Top = 50;
            coin.Tag = "coin";
            this.Controls.Add(coin);

            coin.BringToFront();
            player.BringToFront();

        }

        private void desTroyEnemy()
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "enemy")
                {
                    this.Controls.Remove(x);
                    ((PictureBox)x).Dispose();
                }
            }
        }

        private void spawnEnemy()
        {
            Enemy enemy = new Enemy();
            HPBoss = enemy.maxHealth;
            enemy.MakeenemyAI(this);
        }
    }
}
