namespace Neon_Blaster
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btnExitGame = new System.Windows.Forms.PictureBox();
            this.btnStartGame = new System.Windows.Forms.PictureBox();
            this.btnHelp = new System.Windows.Forms.PictureBox();
            this.btnOption = new System.Windows.Forms.PictureBox();
            this.btnStore = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnExitGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStartGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOption)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStore)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExitGame
            // 
            this.btnExitGame.BackColor = System.Drawing.Color.Transparent;
            this.btnExitGame.Image = ((System.Drawing.Image)(resources.GetObject("btnExitGame.Image")));
            this.btnExitGame.Location = new System.Drawing.Point(271, 472);
            this.btnExitGame.Name = "btnExitGame";
            this.btnExitGame.Size = new System.Drawing.Size(270, 70);
            this.btnExitGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExitGame.TabIndex = 10;
            this.btnExitGame.TabStop = false;
            this.btnExitGame.Click += new System.EventHandler(this.BtnExitGame_Click);
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.Color.Transparent;
            this.btnStartGame.Image = ((System.Drawing.Image)(resources.GetObject("btnStartGame.Image")));
            this.btnStartGame.Location = new System.Drawing.Point(271, 365);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(270, 70);
            this.btnStartGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnStartGame.TabIndex = 11;
            this.btnStartGame.TabStop = false;
            this.btnStartGame.Click += new System.EventHandler(this.BtnStartGame_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.Transparent;
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.Location = new System.Drawing.Point(141, 584);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(130, 50);
            this.btnHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHelp.TabIndex = 12;
            this.btnHelp.TabStop = false;
            this.btnHelp.Click += new System.EventHandler(this.BtnHelp_Click);
            // 
            // btnOption
            // 
            this.btnOption.BackColor = System.Drawing.Color.Transparent;
            this.btnOption.Image = ((System.Drawing.Image)(resources.GetObject("btnOption.Image")));
            this.btnOption.Location = new System.Drawing.Point(347, 584);
            this.btnOption.Name = "btnOption";
            this.btnOption.Size = new System.Drawing.Size(130, 50);
            this.btnOption.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnOption.TabIndex = 13;
            this.btnOption.TabStop = false;
            this.btnOption.Click += new System.EventHandler(this.BtnOption_Click);
            // 
            // btnStore
            // 
            this.btnStore.BackColor = System.Drawing.Color.Transparent;
            this.btnStore.Image = ((System.Drawing.Image)(resources.GetObject("btnStore.Image")));
            this.btnStore.Location = new System.Drawing.Point(547, 584);
            this.btnStore.Name = "btnStore";
            this.btnStore.Size = new System.Drawing.Size(130, 50);
            this.btnStore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnStore.TabIndex = 14;
            this.btnStore.TabStop = false;
            this.btnStore.Click += new System.EventHandler(this.BtnStore_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.btnStore);
            this.Controls.Add(this.btnOption);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.btnExitGame);
            this.DoubleBuffered = true;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Game Battle Universe";
            ((System.ComponentModel.ISupportInitialize)(this.btnExitGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStartGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOption)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox btnExitGame;
        private System.Windows.Forms.PictureBox btnStartGame;
        private System.Windows.Forms.PictureBox btnHelp;
        private System.Windows.Forms.PictureBox btnOption;
        private System.Windows.Forms.PictureBox btnStore;
    }
}