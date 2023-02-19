namespace Neon_Blaster
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelY = new System.Windows.Forms.PictureBox();
            this.panelX = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.textScore = new System.Windows.Forms.Label();
            this.textCoin = new System.Windows.Forms.Label();
            this.barhpPlayer = new System.Windows.Forms.ProgressBar();
            this.player = new System.Windows.Forms.PictureBox();
            this.pictureGameOver = new System.Windows.Forms.PictureBox();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.btnPlayAgain = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.panelY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGameOver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlayAgain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // panelY
            // 
            this.panelY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelY.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelY.Image = ((System.Drawing.Image)(resources.GetObject("panelY.Image")));
            this.panelY.Location = new System.Drawing.Point(779, 0);
            this.panelY.Name = "panelY";
            this.panelY.Size = new System.Drawing.Size(5, 661);
            this.panelY.TabIndex = 0;
            this.panelY.TabStop = false;
            this.panelY.Paint += new System.Windows.Forms.PaintEventHandler(this.panelY_Paint);
            // 
            // panelX
            // 
            this.panelX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelX.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelX.Location = new System.Drawing.Point(0, 656);
            this.panelX.Name = "panelX";
            this.panelX.Size = new System.Drawing.Size(779, 5);
            this.panelX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.panelX.TabIndex = 1;
            this.panelX.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // textScore
            // 
            this.textScore.AutoSize = true;
            this.textScore.Dock = System.Windows.Forms.DockStyle.Left;
            this.textScore.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textScore.ForeColor = System.Drawing.Color.Transparent;
            this.textScore.Location = new System.Drawing.Point(0, 0);
            this.textScore.Name = "textScore";
            this.textScore.Size = new System.Drawing.Size(150, 45);
            this.textScore.TabIndex = 3;
            this.textScore.Text = "Score : ";
            // 
            // textCoin
            // 
            this.textCoin.AutoSize = true;
            this.textCoin.BackColor = System.Drawing.Color.Transparent;
            this.textCoin.Dock = System.Windows.Forms.DockStyle.Right;
            this.textCoin.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCoin.ForeColor = System.Drawing.Color.White;
            this.textCoin.Location = new System.Drawing.Point(654, 0);
            this.textCoin.Name = "textCoin";
            this.textCoin.Size = new System.Drawing.Size(125, 45);
            this.textCoin.TabIndex = 4;
            this.textCoin.Text = "Coin : ";
            // 
            // barhpPlayer
            // 
            this.barhpPlayer.BackColor = System.Drawing.Color.White;
            this.barhpPlayer.ForeColor = System.Drawing.Color.Red;
            this.barhpPlayer.Location = new System.Drawing.Point(0, 48);
            this.barhpPlayer.Name = "barhpPlayer";
            this.barhpPlayer.Size = new System.Drawing.Size(170, 20);
            this.barhpPlayer.TabIndex = 5;
            this.barhpPlayer.Value = 50;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.player.Location = new System.Drawing.Point(350, 530);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(120, 120);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.player.TabIndex = 2;
            this.player.TabStop = false;
            this.player.Tag = "Player";
            // 
            // pictureGameOver
            // 
            this.pictureGameOver.BackColor = System.Drawing.Color.Transparent;
            this.pictureGameOver.Image = ((System.Drawing.Image)(resources.GetObject("pictureGameOver.Image")));
            this.pictureGameOver.Location = new System.Drawing.Point(65, 0);
            this.pictureGameOver.Name = "pictureGameOver";
            this.pictureGameOver.Size = new System.Drawing.Size(689, 482);
            this.pictureGameOver.TabIndex = 6;
            this.pictureGameOver.TabStop = false;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(65, 439);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(221, 122);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMenu.TabIndex = 7;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            this.btnMenu.MouseLeave += new System.EventHandler(this.btnMenu_MouseLeave);
            this.btnMenu.MouseHover += new System.EventHandler(this.btnMenu_MouseHover);
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.BackColor = System.Drawing.Color.Transparent;
            this.btnPlayAgain.Image = ((System.Drawing.Image)(resources.GetObject("btnPlayAgain.Image")));
            this.btnPlayAgain.Location = new System.Drawing.Point(292, 439);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(221, 122);
            this.btnPlayAgain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPlayAgain.TabIndex = 8;
            this.btnPlayAgain.TabStop = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            this.btnPlayAgain.MouseLeave += new System.EventHandler(this.btnPlayAgain_MouseLeave);
            this.btnPlayAgain.MouseHover += new System.EventHandler(this.btnPlayAgain_MouseHover);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(519, 439);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(221, 122);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExit.TabIndex = 9;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            this.btnExit.MouseHover += new System.EventHandler(this.btnExit_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.barhpPlayer);
            this.Controls.Add(this.textCoin);
            this.Controls.Add(this.textScore);
            this.Controls.Add(this.player);
            this.Controls.Add(this.panelX);
            this.Controls.Add(this.panelY);
            this.Controls.Add(this.pictureGameOver);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Battle Universe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.panelY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGameOver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlayAgain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox panelY;
        private System.Windows.Forms.PictureBox panelX;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label textScore;
        private System.Windows.Forms.Label textCoin;
        private System.Windows.Forms.ProgressBar barhpPlayer;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox pictureGameOver;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.PictureBox btnPlayAgain;
        private System.Windows.Forms.PictureBox btnExit;
    }
}

