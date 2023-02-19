using ReadWriteIni;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neon_Blaster
{
    public partial class Store : Form
    {
        DataIni fileini = new DataIni();
        private int SpaceShipTop = 1, SpaceShipBottom = 0, yourCoins = 0, nextBullet = 4,
            MaxSpaceShip = 0;
        public Store()
        {
            InitializeComponent();
            yourCoins = int.Parse(fileini.READ("Data\\Data.ini", "DataCoins", "Coins"));
            MaxSpaceShip = int.Parse(fileini.READ("Data\\SpaceShip.ini", "SpaceShipID", "SoLuong"));
            topSpaceShip.Image = Image.FromFile($"Image\\SpaceShip\\{SpaceShipTop}.png");
            BottomSpaceShip.Image = Image.FromFile($"Image\\SpaceShip\\{SpaceShipBottom}.png");
            buySpaceShip.Image = Image.FromFile("Image\\SpaceShip\\0.png");
            tableShowResult.Hide();
           // PriceSpaceShip.FlatAppearance.MouseDownBackColor = Color.SlateGray;
            PriceSpaceShip.FlatAppearance.MouseOverBackColor = Color.Gray;
            showCoins.Text = yourCoins.ToString("#,##0");
        }

        private void TopSpaceShip_Click(object sender, EventArgs e)
        {
            buySpaceShip.Image = Image.FromFile($"Image\\SpaceShip\\{SpaceShipTop}.png");
            if (int.Parse(fileini.READ("Data\\SpaceShip.ini", "SpaceShipID", $"SpaceShip{SpaceShipTop}")) == -1)
            {
                PriceSpaceShip.Text = fileini.READ("Data\\SpaceShip.ini", "PriceSpaceShip", $"Price{SpaceShipTop}").ToString();
                PriceSpaceShip.Tag = SpaceShipTop.ToString();
            }
            else
            {
                PriceSpaceShip.Text = "Owned";
            }
            nameSpaceShip.Text = fileini.READ("Data\\SpaceShip.ini", "NameSpaceShip", $"Name{SpaceShipTop}").ToUpper().ToString();
        }

        private void BottomSpaceShip_Click(object sender, EventArgs e)
        {
            buySpaceShip.Image = Image.FromFile($"Image\\SpaceShip\\{SpaceShipBottom}.png");
            if (int.Parse(fileini.READ("Data\\SpaceShip.ini", "SpaceShipID", $"SpaceShip{SpaceShipBottom}")) == -1)
            {
                PriceSpaceShip.Text = fileini.READ("Data\\SpaceShip.ini", "PriceSpaceShip", $"Price{SpaceShipBottom}").ToString();
                PriceSpaceShip.Tag = SpaceShipBottom.ToString();
            }
            else
            {
                PriceSpaceShip.Text = "Owned";
            }
            nameSpaceShip.Text = fileini.READ("Data\\SpaceShip.ini", "NameSpaceShip", $"Name{SpaceShipBottom}").ToUpper().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tableShowResult.Hide();
        }

        private void goTop_Click(object sender, EventArgs e)
        {
            if(SpaceShipTop == 11)
            {
                SpaceShipTop = 1;
                SpaceShipBottom = 0;
            }    
            else
            {
                SpaceShipTop += 2;
                SpaceShipBottom += 2;
            }    
            topSpaceShip.Image = Image.FromFile($"Image\\SpaceShip\\{SpaceShipTop}.png");
            BottomSpaceShip.Image = Image.FromFile($"Image\\SpaceShip\\{SpaceShipBottom}.png");
        }

        private void goBottom_Click(object sender, EventArgs e)
        {
            if (SpaceShipBottom == 0)
            {
                SpaceShipTop = 11;
                SpaceShipBottom = 10;
            }
            else
            {
                SpaceShipTop -= 2;
                SpaceShipBottom -= 2;
            }
            topSpaceShip.Image = Image.FromFile($"Image\\SpaceShip\\{SpaceShipTop}.png");
            BottomSpaceShip.Image = Image.FromFile($"Image\\SpaceShip\\{SpaceShipBottom}.png");
        }


        private void PriceBullet_Click(object sender, EventArgs e)
        {
            Button clone = (Button)sender;
            if (clone.Text != "Owned")
            {
                if (yourCoins < int.Parse(clone.Text))
                {
                    Messengerresult.Text = "You don't have enough money to buy this bullet.";
                    tableShowResult.Show();
                }
                else
                {
                    yourCoins -= int.Parse(clone.Text);
                    BuySuccess(yourCoins, $"You have successfully purchased neon bullets for {clone.Text} coins.", false, (Button)sender);
                    clone.Text = "Owned";
                }
            }
        }

        private void NextBullet_Click(object sender, EventArgs e)
        {
            if (nextBullet == 30)
                nextBullet = 0;
            //Xu li Mau dan o thu 1
            Bullet1.Image = Image.FromFile($"Image\\Laser Sprites\\{++nextBullet}.png");
            if(int.Parse(fileini.READ("Data\\Bullet.ini", "OwnedBullet", $"Bullet{nextBullet}")) != -1)
            {
                PriceBullet1.Text = "Owned";
            }
            else
            {
                PriceBullet1.Text = fileini.READ("Data\\Bullet.ini", "PriceBullet", $"Bullet{nextBullet}");
                PriceBullet1.Tag = nextBullet.ToString();
            }
            if (nextBullet == 30)
                nextBullet = 0;
            //Xu li Mau dan o thu 2
            Bullet2.Image = Image.FromFile($"Image\\Laser Sprites\\{++nextBullet}.png");
            if (int.Parse(fileini.READ("Data\\Bullet.ini", "OwnedBullet", $"Bullet{nextBullet}")) != -1)
            {
                PriceBullet2.Text = "Owned";
            }
            else
            {
                PriceBullet2.Text = fileini.READ("Data\\Bullet.ini", "PriceBullet", $"Bullet{nextBullet}");
                PriceBullet2.Tag = nextBullet.ToString();
            }

            if (nextBullet == 30)
                nextBullet = 0;
            //Xu li Mau dan o thu 3
            Bullet3.Image = Image.FromFile($"Image\\Laser Sprites\\{++nextBullet}.png");
            if (int.Parse(fileini.READ("Data\\Bullet.ini", "OwnedBullet", $"Bullet{nextBullet}")) != -1)
            {
                PriceBullet3.Text = "Owned";
            }
            else
            {
                PriceBullet3.Text = fileini.READ("Data\\Bullet.ini", "PriceBullet", $"Bullet{nextBullet}");
                PriceBullet3.Tag = nextBullet.ToString();
            }

            if (nextBullet == 30)
                nextBullet = 0;
            //Xu li Mau dan o thu 4
            Bullet4.Image = Image.FromFile($"Image\\Laser Sprites\\{++nextBullet}.png");
            if (int.Parse(fileini.READ("Data\\Bullet.ini", "OwnedBullet", $"Bullet{nextBullet}")) != -1)
            {
                PriceBullet4.Text = "Owned";
            }
            else
            {
                PriceBullet4.Text = fileini.READ("Data\\Bullet.ini", "PriceBullet", $"Bullet{nextBullet}");
                PriceBullet4.Tag = nextBullet.ToString();
            }
            Console.WriteLine(nextBullet);
        }

        private void BackMenu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }

        private void PriceSpaceShip_Click(object sender, EventArgs e)
        {
            if(PriceSpaceShip.Text != "Owned")
            {
                if (yourCoins < int.Parse(PriceSpaceShip.Text))
                {
                    Messengerresult.Text = "You don't have enough money to buy this spaceship.";
                    tableShowResult.Show();
                }
                else
                {
                    yourCoins -= int.Parse(PriceSpaceShip.Text);
                    BuySuccess(yourCoins, $"You have successfully purchased this spaceship for {PriceSpaceShip.Text} coins.", true, PriceSpaceShip);
                    PriceSpaceShip.Text = "Owned";
                }
            }
        }

        private void BuySuccess(int coins, String messenger, bool SpaceShip, Button x)
        {
            if(SpaceShip)
            {
                fileini.WRITE("Data\\SpaceShip.ini", "SpaceShipID", $"SpaceShip{(String)x.Tag}", "1");
                fileini.WRITE("Data\\SpaceShip.ini", "SpaceShipID", "SoLuong", (++MaxSpaceShip).ToString());
            }
            else
            {
                fileini.WRITE("Data\\Bullet.ini", "OwnedBullet", $"Bullet{(String)x.Tag}", "1");
            }
            Console.WriteLine(x.Tag);
            fileini.WRITE("Data\\Data.ini", "DataCoins", "Coins", (yourCoins).ToString());
            showCoins.Text = yourCoins.ToString();
            Messengerresult.Text = messenger;
            tableShowResult.Show();
        }
    }
}
