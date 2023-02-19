using ReadWriteIni;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neon_Blaster
{
    public delegate void SendID(int value);
    public partial class Option : Form
    {
        DataIni fileini = new DataIni();
        String pathLazer = "Image\\Laser Sprites\\", pathSpaceShip = "Image\\SpaceShip\\";
        int bulletID = -1,
            SpaceShipID = -1,
            maxSpaceShip = 0,
            spaceShipTop = 1, spaceShipBottom = 0;

        int[] ListSpaceShip = new int[12];
        public Option()
        {
            InitializeComponent();
            bulletID = int.Parse(fileini.READ("Data\\Bullet.ini", "Bullet", "ID"));
            SpaceShipID = int.Parse(fileini.READ("Data\\SpaceShip.ini", "ChooseSpaceShip", "ID"));
            maxSpaceShip = int.Parse(fileini.READ("Data\\SpaceShip.ini", "SpaceShipID", "SoLuong"));
            BulletChoose.Image = Image.FromFile(pathLazer + $"{bulletID}.png");
            ResetSpaceShip();
            ShowCoins.Text = fileini.READ("Data\\Data.ini", "DataCoins", "Coins").ToString();
            //this.Paint += new PaintEventHandler(OptionStart);
        }

        private void ResetSpaceShip()
        {
            for (int i = 0; i < ListSpaceShip.Length; i++)
            {
                ListSpaceShip[i] = -1;
            }
            //Gán ID SpaceShip vào ListSpaceShip
            for (int i = 0, ID = 0; i < ListSpaceShip.Length; i++)
            {
                if(int.Parse(fileini.READ("Data\\SpaceShip.ini", "SpaceShipID", $"SpaceShip{i}")) != -1)
                {
                    ListSpaceShip[ID++] = i;
                }    
            }

            for (int i = 0; i < ListSpaceShip.Length; i++)
            {
                Console.WriteLine(ListSpaceShip[i]);
            }

            if (ListSpaceShip[spaceShipBottom] != -1)
            {
                SpaceShipBottom.Image = Image.FromFile(pathSpaceShip + $"{ListSpaceShip[spaceShipBottom]}.png");
            }
            if (ListSpaceShip[spaceShipTop] != -1)
            {
                SpaceShipTop.Image = Image.FromFile(pathSpaceShip + $"{ListSpaceShip[spaceShipTop]}.png");
            }    
                
            SpaceShipMid.Image = Image.FromFile(pathSpaceShip + $"{SpaceShipID}.png");


            for (int i = 0; i < maxSpaceShip; i++)
                Console.WriteLine(ListSpaceShip[i]);   

        }

        private void OptionStart(Object sender, PaintEventArgs e)
        {
            String name = fileini.READ("Data\\SpaceShip.ini", "NameSpaceShip", $"Name{SpaceShipID}").ToUpper();
            Font font = new Font("Big Shoulders Stencil Text", 18.25f, FontStyle.Bold);
            Rectangle rect = new Rectangle(0, 0, 124, 38);
            LinearGradientBrush brush = new LinearGradientBrush(
                rect, Color.FromArgb(6, 151, 215),
                Color.FromArgb(196, 11, 187),LinearGradientMode.Horizontal
            );
            e.Graphics.DrawString(name, font, brush, 320, 455);
            
        }

        private void timerOption_Tick(object sender, EventArgs e)
        {
            this.Paint += new PaintEventHandler(OptionStart);
        }

        private void Option_Paint(object sender, PaintEventArgs e)
        {
            this.Paint += new PaintEventHandler(OptionStart);
        }

        private void bullet0_Click(object sender, EventArgs e)
        {
            bulletID = 1;
            BulletChoose.Image = Image.FromFile(pathLazer + $"{bulletID}.png");
            fileini.WRITE("Data\\Bullet.ini", "Bullet", "ID", bulletID.ToString());
        }

        private void bullet1_Click(object sender, EventArgs e)
        {
            bulletID = 2;
            BulletChoose.Image = Image.FromFile(pathLazer + $"{bulletID}.png");
            fileini.WRITE("Data\\Bullet.ini", "Bullet", "ID", bulletID.ToString());
        }

        private void SpaceShipTop_Click(object sender, EventArgs e)
        {
            if(SpaceShipTop.Image != null)
            {
                SpaceShipID = ListSpaceShip[spaceShipTop];
                SpaceShipMid.Image = Image.FromFile(pathSpaceShip + $"{SpaceShipID}.png");
                fileini.WRITE("Data\\SpaceShip.ini", "ChooseSpaceShip", "ID", SpaceShipID.ToString());
                this.Refresh();
            }    
        }

        private void SpaceShipBottom_Click(object sender, EventArgs e)
        {
            if (SpaceShipBottom.Image != null)
            {
                SpaceShipID = ListSpaceShip[spaceShipBottom];
                SpaceShipMid.Image = Image.FromFile(pathSpaceShip + $"{SpaceShipID}.png");
                fileini.WRITE("Data\\SpaceShip.ini", "ChooseSpaceShip", "ID", SpaceShipID.ToString());
                this.Refresh();
            }
        }

        private void btnBottom_Click(object sender, EventArgs e)
        {
            if(spaceShipBottom != 0)
            {
                
                spaceShipTop-=2;
                spaceShipBottom -= 2;
                Console.WriteLine(spaceShipBottom);
                SpaceShipTop.Image = Image.FromFile(pathSpaceShip + $"{ListSpaceShip[spaceShipTop]}.png");
                SpaceShipBottom.Image = Image.FromFile(pathSpaceShip + $"{ListSpaceShip[spaceShipBottom]}.png");
            }    
        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            if (ListSpaceShip[spaceShipTop + 1] != -1)
            {
                spaceShipTop +=2;
                spaceShipBottom +=2;
                Console.WriteLine(spaceShipBottom);
                if (ListSpaceShip[spaceShipTop] != -1)
                    SpaceShipTop.Image = Image.FromFile(pathSpaceShip + $"{ListSpaceShip[spaceShipTop]}.png");
                else
                    SpaceShipTop.Image = null;
                SpaceShipBottom.Image = Image.FromFile(pathSpaceShip + $"{ListSpaceShip[spaceShipBottom]}.png");
            }
        }

        private void bullet2_Click(object sender, EventArgs e)
        {
            bulletID = 3;
            BulletChoose.Image = Image.FromFile(pathLazer + $"{bulletID}.png");
            fileini.WRITE("Data\\Bullet.ini", "Bullet", "ID", bulletID.ToString());
        }

        private void bullet3_Click(object sender, EventArgs e)
        {
            bulletID = 4;
            BulletChoose.Image = Image.FromFile(pathLazer + $"{bulletID}.png");
            fileini.WRITE("Data\\Bullet.ini", "Bullet", "ID", bulletID.ToString());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }

        private void ShowBullets_Click(object sender, EventArgs e)
        {
            OptionBullets optionBullets = new OptionBullets(SetValue);
            this.Hide();
            optionBullets.ShowDialog();
            this.Show();
        }

        private void SetValue(int value)
        {
            this.bulletID = value;
            BulletChoose.Image = Image.FromFile(pathLazer + $"{bulletID}.png");
            fileini.WRITE("Data\\Bullet.ini", "Bullet", "ID", bulletID.ToString());
        }
    }
}
