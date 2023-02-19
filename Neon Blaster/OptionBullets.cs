using ReadWriteIni;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neon_Blaster
{
    public partial class OptionBullets : Form
    {
        PictureBox[,] BoxBullet = new PictureBox[5,6];
        DataIni fileini = new DataIni();
        int[] bulletID = new int[31];
        public int soluong = 0;
        String path = "Image\\Laser Sprites\\";
        public SendID sender;
        public OptionBullets()
        {
            InitializeComponent();
            CreateListBullet();
        }

        public OptionBullets(SendID sender)
        {
            InitializeComponent();
            KhoiTaoListBullet();
            CreateListBullet();
            this.sender = sender;
        }

        //Truy vết đạn neon đã sở hữu
        private void KhoiTaoListBullet()
        {
            int dem = 1;
            bulletID[dem++] = 1;
            soluong++;
            while(dem != -1)
            {
                for(int i = bulletID[dem-1] +1; i <= 30; i++)
                {
                    if (int.Parse(fileini.READ("Data\\Bullet.ini", "OwnedBullet", $"Bullet{i}")) != -1)
                    {
                        //Console.WriteLine(j);
                        bulletID[dem++] = i;
                        soluong++;
                        if (i == 30)
                            dem = -1;
                        break;
                    }
                    if (i == 30)
                        dem = -1;
                }    
                
            }
            
        }

        //Khởi tạo list PictureBox
        private void CreateListBullet()
        {
            int dem = 1;
            for(int i = 0; i < BoxBullet.GetLength(0); i++)
            {
                for(int j = 0; j < BoxBullet.GetLength(1); j++)
                {
                    BoxBullet[i, j] = new PictureBox();
                    if (dem <= soluong)
                    {
                        BoxBullet[i, j].Image = Image.FromFile(path + $"{bulletID[dem]}.png");
                        BoxBullet[i, j].Tag = (bulletID[dem++]).ToString();
                        BoxBullet[i, j].Click += new EventHandler(ChooseBullets);
                    }
                    
                    BoxBullet[i, j].BackColor = Color.Transparent;
                    BoxBullet[i, j].Size = new Size(64, 60);
                    BoxBullet[i, j].Location = new Point(32 + (64+70)*j, 95 + (51+60)*i);
                    BoxBullet[i, j].SizeMode = PictureBoxSizeMode.Zoom;
                    this.Controls.Add(BoxBullet[i,j]);
                }
            }
        }

        private void ChooseBullets(object sender, EventArgs e)
        {
            foreach(Control x in this.Controls)
            {
                if(x is PictureBox && (String)x.Tag == "ChooseBullet")
                {
                    this.Controls.Remove(x);
                    ((PictureBox)x).Dispose();
                }    
            }
            PictureBox dummy = (PictureBox)sender;
            PictureBox ChooseBullet = new PictureBox();
            ChooseBullet.BackColor = Color.Transparent;
            ChooseBullet.Image = Image.FromFile("Image\\Button\\Bullet-Option\\ClickBullets.png");
            ChooseBullet.Tag = "ChooseBullet";
            ChooseBullet.Size = new Size(88, 82);
            ChooseBullet.Location = new Point(dummy.Left - 12, dummy.Top - 11);
            ChooseBullet.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(ChooseBullet);
            this.sender(int.Parse((String)dummy.Tag));
            Console.WriteLine(dummy.Tag);
        }
        private void OptionBullets_Load(object sender, EventArgs e)
        {

        }

        private void backOption_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
