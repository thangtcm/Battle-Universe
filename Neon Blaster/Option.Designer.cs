namespace Neon_Blaster
{
    partial class Option
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Option));
            this.timerOption = new System.Windows.Forms.Timer(this.components);
            this.bullet0 = new System.Windows.Forms.PictureBox();
            this.bullet1 = new System.Windows.Forms.PictureBox();
            this.bullet2 = new System.Windows.Forms.PictureBox();
            this.bullet3 = new System.Windows.Forms.PictureBox();
            this.BulletChoose = new System.Windows.Forms.PictureBox();
            this.ShowBullets = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ShowCoins = new System.Windows.Forms.Label();
            this.SpaceShipMid = new System.Windows.Forms.PictureBox();
            this.SpaceShipBottom = new System.Windows.Forms.PictureBox();
            this.SpaceShipTop = new System.Windows.Forms.PictureBox();
            this.btnTop = new System.Windows.Forms.PictureBox();
            this.btnBottom = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bullet0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BulletChoose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowBullets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpaceShipMid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpaceShipBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpaceShipTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBottom)).BeginInit();
            this.SuspendLayout();
            // 
            // timerOption
            // 
            this.timerOption.Enabled = true;
            this.timerOption.Interval = 20;
            this.timerOption.Tick += new System.EventHandler(this.timerOption_Tick);
            // 
            // bullet0
            // 
            this.bullet0.BackColor = System.Drawing.Color.Transparent;
            this.bullet0.Image = ((System.Drawing.Image)(resources.GetObject("bullet0.Image")));
            this.bullet0.Location = new System.Drawing.Point(46, 592);
            this.bullet0.Name = "bullet0";
            this.bullet0.Size = new System.Drawing.Size(55, 40);
            this.bullet0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bullet0.TabIndex = 5;
            this.bullet0.TabStop = false;
            this.bullet0.Click += new System.EventHandler(this.bullet0_Click);
            // 
            // bullet1
            // 
            this.bullet1.BackColor = System.Drawing.Color.Transparent;
            this.bullet1.Image = ((System.Drawing.Image)(resources.GetObject("bullet1.Image")));
            this.bullet1.Location = new System.Drawing.Point(125, 592);
            this.bullet1.Name = "bullet1";
            this.bullet1.Size = new System.Drawing.Size(55, 40);
            this.bullet1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bullet1.TabIndex = 6;
            this.bullet1.TabStop = false;
            this.bullet1.Click += new System.EventHandler(this.bullet1_Click);
            // 
            // bullet2
            // 
            this.bullet2.BackColor = System.Drawing.Color.Transparent;
            this.bullet2.Image = ((System.Drawing.Image)(resources.GetObject("bullet2.Image")));
            this.bullet2.Location = new System.Drawing.Point(204, 592);
            this.bullet2.Name = "bullet2";
            this.bullet2.Size = new System.Drawing.Size(55, 40);
            this.bullet2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bullet2.TabIndex = 7;
            this.bullet2.TabStop = false;
            this.bullet2.Click += new System.EventHandler(this.bullet2_Click);
            // 
            // bullet3
            // 
            this.bullet3.BackColor = System.Drawing.Color.Transparent;
            this.bullet3.Image = ((System.Drawing.Image)(resources.GetObject("bullet3.Image")));
            this.bullet3.Location = new System.Drawing.Point(283, 592);
            this.bullet3.Name = "bullet3";
            this.bullet3.Size = new System.Drawing.Size(55, 40);
            this.bullet3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bullet3.TabIndex = 8;
            this.bullet3.TabStop = false;
            this.bullet3.Click += new System.EventHandler(this.bullet3_Click);
            // 
            // BulletChoose
            // 
            this.BulletChoose.BackColor = System.Drawing.Color.Transparent;
            this.BulletChoose.Image = ((System.Drawing.Image)(resources.GetObject("BulletChoose.Image")));
            this.BulletChoose.Location = new System.Drawing.Point(62, 447);
            this.BulletChoose.Name = "BulletChoose";
            this.BulletChoose.Size = new System.Drawing.Size(87, 80);
            this.BulletChoose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BulletChoose.TabIndex = 9;
            this.BulletChoose.TabStop = false;
            // 
            // ShowBullets
            // 
            this.ShowBullets.BackColor = System.Drawing.Color.Transparent;
            this.ShowBullets.Image = ((System.Drawing.Image)(resources.GetObject("ShowBullets.Image")));
            this.ShowBullets.Location = new System.Drawing.Point(356, 599);
            this.ShowBullets.Name = "ShowBullets";
            this.ShowBullets.Size = new System.Drawing.Size(27, 30);
            this.ShowBullets.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ShowBullets.TabIndex = 10;
            this.ShowBullets.TabStop = false;
            this.ShowBullets.Click += new System.EventHandler(this.ShowBullets_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ShowCoins
            // 
            this.ShowCoins.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowCoins.AutoSize = true;
            this.ShowCoins.BackColor = System.Drawing.Color.Transparent;
            this.ShowCoins.Font = new System.Drawing.Font("Big Shoulders Stencil Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowCoins.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ShowCoins.Location = new System.Drawing.Point(631, 580);
            this.ShowCoins.Name = "ShowCoins";
            this.ShowCoins.Size = new System.Drawing.Size(33, 45);
            this.ShowCoins.TabIndex = 12;
            this.ShowCoins.Text = "0";
            this.ShowCoins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SpaceShipMid
            // 
            this.SpaceShipMid.BackColor = System.Drawing.Color.Transparent;
            this.SpaceShipMid.Location = new System.Drawing.Point(284, 157);
            this.SpaceShipMid.Name = "SpaceShipMid";
            this.SpaceShipMid.Size = new System.Drawing.Size(205, 209);
            this.SpaceShipMid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SpaceShipMid.TabIndex = 13;
            this.SpaceShipMid.TabStop = false;
            // 
            // SpaceShipBottom
            // 
            this.SpaceShipBottom.BackColor = System.Drawing.Color.Transparent;
            this.SpaceShipBottom.Location = new System.Drawing.Point(596, 305);
            this.SpaceShipBottom.Name = "SpaceShipBottom";
            this.SpaceShipBottom.Size = new System.Drawing.Size(176, 215);
            this.SpaceShipBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SpaceShipBottom.TabIndex = 14;
            this.SpaceShipBottom.TabStop = false;
            this.SpaceShipBottom.Click += new System.EventHandler(this.SpaceShipBottom_Click);
            // 
            // SpaceShipTop
            // 
            this.SpaceShipTop.BackColor = System.Drawing.Color.Transparent;
            this.SpaceShipTop.Location = new System.Drawing.Point(596, 52);
            this.SpaceShipTop.Name = "SpaceShipTop";
            this.SpaceShipTop.Size = new System.Drawing.Size(176, 215);
            this.SpaceShipTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SpaceShipTop.TabIndex = 15;
            this.SpaceShipTop.TabStop = false;
            this.SpaceShipTop.Click += new System.EventHandler(this.SpaceShipTop_Click);
            // 
            // btnTop
            // 
            this.btnTop.BackColor = System.Drawing.Color.Transparent;
            this.btnTop.Image = ((System.Drawing.Image)(resources.GetObject("btnTop.Image")));
            this.btnTop.Location = new System.Drawing.Point(654, 12);
            this.btnTop.Name = "btnTop";
            this.btnTop.Size = new System.Drawing.Size(62, 34);
            this.btnTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnTop.TabIndex = 16;
            this.btnTop.TabStop = false;
            this.btnTop.Click += new System.EventHandler(this.btnTop_Click);
            // 
            // btnBottom
            // 
            this.btnBottom.BackColor = System.Drawing.Color.Transparent;
            this.btnBottom.Image = ((System.Drawing.Image)(resources.GetObject("btnBottom.Image")));
            this.btnBottom.Location = new System.Drawing.Point(654, 526);
            this.btnBottom.Name = "btnBottom";
            this.btnBottom.Size = new System.Drawing.Size(62, 34);
            this.btnBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBottom.TabIndex = 17;
            this.btnBottom.TabStop = false;
            this.btnBottom.Click += new System.EventHandler(this.btnBottom_Click);
            // 
            // Option
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.btnBottom);
            this.Controls.Add(this.btnTop);
            this.Controls.Add(this.SpaceShipTop);
            this.Controls.Add(this.SpaceShipBottom);
            this.Controls.Add(this.SpaceShipMid);
            this.Controls.Add(this.ShowCoins);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ShowBullets);
            this.Controls.Add(this.BulletChoose);
            this.Controls.Add(this.bullet3);
            this.Controls.Add(this.bullet2);
            this.Controls.Add(this.bullet1);
            this.Controls.Add(this.bullet0);
            this.DoubleBuffered = true;
            this.Name = "Option";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Option";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Option_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.bullet0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BulletChoose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowBullets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpaceShipMid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpaceShipBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpaceShipTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBottom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timerOption;
        private System.Windows.Forms.PictureBox bullet0;
        private System.Windows.Forms.PictureBox bullet1;
        private System.Windows.Forms.PictureBox bullet2;
        private System.Windows.Forms.PictureBox bullet3;
        private System.Windows.Forms.PictureBox BulletChoose;
        private System.Windows.Forms.PictureBox ShowBullets;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ShowCoins;
        private System.Windows.Forms.PictureBox SpaceShipMid;
        private System.Windows.Forms.PictureBox SpaceShipBottom;
        private System.Windows.Forms.PictureBox SpaceShipTop;
        private System.Windows.Forms.PictureBox btnTop;
        private System.Windows.Forms.PictureBox btnBottom;
    }
}