using System;
using System.Drawing;
using System.Windows.Forms;

namespace Neon_Blaster
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void BtnExitGame_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            this.Hide();
            help.ShowDialog();
            this.Show();
        }

        private void BtnStore_Click(object sender, EventArgs e)
        {
            Store store = new Store();
            this.Hide();
            store.ShowDialog();
            this.Close();
        }

        private void BtnOption_Click(object sender, EventArgs e)
        {
            Option option = new Option();
            this.Hide();
            option.ShowDialog();
            this.Close();
        }

        private void BtnStartGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 rungame = new Form1();
            rungame.ShowDialog();
            this.Close();
        }
    }
}
