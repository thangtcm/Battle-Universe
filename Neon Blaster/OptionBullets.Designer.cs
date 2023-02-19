namespace Neon_Blaster
{
    partial class OptionBullets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionBullets));
            this.backOption = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.backOption)).BeginInit();
            this.SuspendLayout();
            // 
            // backOption
            // 
            this.backOption.Image = ((System.Drawing.Image)(resources.GetObject("backOption.Image")));
            this.backOption.Location = new System.Drawing.Point(712, 21);
            this.backOption.Name = "backOption";
            this.backOption.Size = new System.Drawing.Size(56, 50);
            this.backOption.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backOption.TabIndex = 0;
            this.backOption.TabStop = false;
            this.backOption.Click += new System.EventHandler(this.backOption_Click);
            // 
            // OptionBullets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.backOption);
            this.DoubleBuffered = true;
            this.Name = "OptionBullets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OptionBullets";
            this.Load += new System.EventHandler(this.OptionBullets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.backOption)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox backOption;
    }
}